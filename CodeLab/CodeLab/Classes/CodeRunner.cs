using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes
{
    public class CodeRunner
    {
        #region Properties
        
        #endregion
        #region Public
        /// <summary>
        /// If servers sends a message to the client this delegate will trigger all of its subscribers. You can register your method to receive the message to server sended. Message is given as the parameter.
        /// </summary>
        public event Action<string> OnReceived;
        public event Action<string> ConnectionStatus;
        #endregion
        #region private
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private byte[] _dataBuffer = new byte[1024];
        //string _ipAddress = Properties.Settings.Default.DebugServerIp;
        //int _port = Properties.Settings.Default.DebugServerPort;
        string _ipAddress = "172.31.134.251";
        int _port = 4242;
        /// Starts to trying to connect to the server. Every failed attempt and successfull connection will Invoke the given method with a paramater giving the current status of connection.
        /// </summary>
        /// <param name="ConnectionStatus"></param>
       #endregion
        private async Task StartConnecting()
        {
            ConnectionStatus("Trying to Connect To Server..");
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    await Task.Run(() => _clientSocket.Connect(IPAddress.Parse(_ipAddress), _port));
                }
                catch (SocketException)
                {
                    ConnectionStatus("Conntection Attempts :" + attempts);
                }
            }
            ConnectionStatus("Conntected");
        }
        /// <summary>
        /// _id is the id of the debug object in database we sent it to debug server so it can operate with it
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public  async Task<bool> SendCode(string _id)
        {
           await StartConnecting();
            SendToServer(_id);
            return true;
        }
        /// <summary>
        /// Sends message to the given server.
        /// </summary>
        /// <param name="message"></param>
        private void SendToServer(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            _clientSocket.Send(buffer);
            _clientSocket.BeginReceive(_dataBuffer, 0, _dataBuffer.Length, SocketFlags.None, OnReceive, null);
        }
        private void OnReceive(IAsyncResult ar)
        {
            int receiveSize = 0;
            try
            {
                receiveSize = _clientSocket.EndReceive(ar);
            }catch(SocketException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (receiveSize > 0)
            {
                byte[] receivedData = new byte[receiveSize];
                Array.Copy(_dataBuffer, receivedData, receiveSize);
                OnReceived(Encoding.UTF8.GetString(receivedData));
            }
            _clientSocket.Disconnect(true);
        }
    }
    /// <summary>
    /// deprecated
    /// </summary>
    //    private readonly string _code;

    //    public CodeRunner(string code)
    //    {

    //        _code = code;
    //        var compilation = CreateCompilerContext();
    //        using (var ms = new MemoryStream())
    //        {
    //            var result = compilation.Emit(ms);
    //            Result = result.Success ? (ExecuteCompiledCode(ms),true) : (GetErrorText(result),false);
    //        }

    //    }

    //    public (object result,bool succes) Result { get; }

    //    private IEnumerable<string> GetAssemblyFiles(Assembly assembly)
    //    {
    //        var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
    //        foreach (var assemblyName in assembly.GetReferencedAssemblies())
    //            yield return loadedAssemblies.SingleOrDefault(a => a.FullName == assemblyName.FullName)?.Location;
    //    }

    //    /**************************************************************************************************
    //    * Creates compiler context.
    //    *
    //    * @return The new compiler context.
    //    **************************************************************************************************/

    //    public CSharpCompilation CreateCompilerContext()
    //    {
    //        SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(_code);
    //        var assemblyName = Path.GetRandomFileName();
    //        Assembly a = typeof(CodeRunner).Assembly;
    //        var refs = GetMetadataReferencesInAssembly(a);

    //        var compilation = CSharpCompilation.Create(
    //                                                   assemblyName,
    //                                                   new[] { syntaxTree },
    //                                                   refs.ToArray(),
    //                                                   new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
    //        return compilation;
    //    }

    //    private string GetErrorText(EmitResult result)
    //    {
    //        var failures = result.Diagnostics.Where(CodeHasError);
    //        return failures.Aggregate("", (current, diagnostic) => current + ($"{diagnostic.Id}: {diagnostic.GetMessage()}" + Environment.NewLine));
    //    }

    //    /**************************************************************************************************
    //    * Executes the compiled code operation.
    //    *
    //    * @param ms The milliseconds.
    //    **************************************************************************************************/

    //    private object ExecuteCompiledCode(MemoryStream ms)
    //    {
    //        ms.Seek(0, SeekOrigin.Begin);
    //        var assembly = Assembly.Load(ms.ToArray());

    //        var type = assembly.GetType("Test.testClass");
    //        var obj = Activator.CreateInstance(type);
    //        object result = type.InvokeMember("Run",
    //                          BindingFlags.Default | BindingFlags.InvokeMethod,
    //                          null,
    //                          obj,
    //                          new object[] { });
    //        return result;
    //    }

    //    /**************************************************************************************************
    //    * Gets metadata references in assembly.
    //    *
    //    * @param assembly The assembly.
    //    *
    //    * @return The metadata references in assembly.
    //    **************************************************************************************************/

    //    private List<MetadataReference> GetMetadataReferencesInAssembly(Assembly assembly)
    //    {


    //        var assemblyFiles = GetAssemblyFiles(assembly);

    //        Console.WriteLine(assemblyFiles);

    //        List<MetadataReference> refs = new List<MetadataReference>();
    //        foreach (var assemblyname in assemblyFiles)
    //            refs.Add(MetadataReference.CreateFromFile(assemblyname));

    //        return refs;
    //    }



    //    /**************************************************************************************************
    //    * Code has error.
    //    *
    //    * @param diagnostic The diagnostic.
    //    *
    //    * @return True if it succeeds, false if it fails.
    //    **************************************************************************************************/

    //    private bool CodeHasError(Diagnostic diagnostic)
    //    {
    //        return diagnostic.IsWarningAsError || diagnostic.Severity == DiagnosticSeverity.Error;
    //    }




    //}
}