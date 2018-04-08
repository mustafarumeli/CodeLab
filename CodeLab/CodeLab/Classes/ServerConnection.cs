using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes
{
    class CodeCompile : DbObject
    {
        public string CodeText { get; set; }
        public string Language { get; set; }
    }
    class ServerConnection
    {
        #region Properties
        public string IpAddress { get; private set; }
        public int Port { get; private set; }
        #endregion
        #region Public
        /// <summary>
        /// If servers sends a message to the client this delegate will trigger all of its subscribers. You can register your method to receive the message to server sended. Message is given as the parameter.
        /// </summary>
        public event Action<string> OnReceived;
        #endregion
        #region private
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private IMongoCollection<BsonDocument> _codeCompileTable;
        private byte[] _dataBuffer = new byte[1024];
        #endregion
        /// <summary>
        /// Basis for server and database conneciton. You have to enter server ip and the port for the server part and the IMongoDatabase type of variable for the database connection.
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="port"></param>
        /// <param name="dataConnection"></param>
        public ServerConnection(string ipAddress, int port, IMongoDatabase dataConnection)
        {
            IpAddress = ipAddress;
            Port = port;
            _codeCompileTable = dataConnection.GetCollection<BsonDocument>(typeof(CodeCompile).Name);
        }
       /// <summary>
       /// Starts to trying to connect to the server. Every failed attempt and successfull connection will Invoke the given method with a paramater giving the current status of connection.
       /// </summary>
       /// <param name="ConnectionStatus"></param>
        public async void StartConnecting(Action<string> ConnectionStatus)
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    await Task.Run(() => _clientSocket.Connect(IPAddress.Parse(IpAddress), Port));
                }
                catch (SocketException)
                {
                    Console.Clear();
                    ConnectionStatus("Conntection Attempts :" + attempts);
                    //Console.WriteLine("Conntection Attempts :" + attempts);
                }
            }
            Console.Clear();
            ConnectionStatus("Conntected");
            //Console.WriteLine("Connected");
        }
        /// <summary>
        /// Sends code to the database and id of the code to the server for processing.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public bool SendCode(string code, string language)
        {
            var id = SendToDatabase(code, language);
            SendToServer(id);
            return true;
        }
        /// <summary>
        /// Sends the code and language to Mongodb database given. Under table CodeCompile
        /// </summary>
        /// <param name="code"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        private string SendToDatabase(string code, string language)
        {
            var cComp = new CodeCompile { CodeText = code, Language = language };
            _codeCompileTable.InsertOne(cComp.ToBsonDocument());
            return cComp._id;
        }
        /// <summary>
        /// Sends message to the given server.
        /// </summary>
        /// <param name="message"></param>
        private void SendToServer(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            _clientSocket.Send(buffer);

            _clientSocket.BeginReceive(_dataBuffer,0, _dataBuffer.Length, SocketFlags.None, OnReceive, null);

            //int rec = _clientSocket.Receive(receivedBuffer);
            //byte[] data = new byte[rec];
            //Array.Copy(receivedBuffer, data, rec);
            //Console.WriteLine("Received: " + Encoding.ASCII.GetString(data));
        }

        private void OnReceive(IAsyncResult ar)
        {
            int receiveSize = _clientSocket.EndReceive(ar);
            if (receiveSize>0)
            {
                byte[] receivedData = new byte[receiveSize];
                Array.Copy(_dataBuffer, receivedData, receiveSize);
                OnReceived(Encoding.UTF8.GetString(receivedData));
            }

        }
    }
}
