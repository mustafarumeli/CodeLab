using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CodeLab.Classes
{
    public class CodeRunner
    {

        private readonly string _code;

        public CodeRunner(string code)
        {

            _code = code;
            var compilation = CreateCompilerContext();
            using (var ms = new MemoryStream())
            {
                var result = compilation.Emit(ms);
                Result = result.Success ? (ExecuteCompiledCode(ms),true) : (GetErrorText(result),false);
            }

        }

        public (object result,bool succes) Result { get; }

        private IEnumerable<string> GetAssemblyFiles(Assembly assembly)
        {
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assemblyName in assembly.GetReferencedAssemblies())
                yield return loadedAssemblies.SingleOrDefault(a => a.FullName == assemblyName.FullName)?.Location;
        }

        /**************************************************************************************************
        * Creates compiler context.
        *
        * @return The new compiler context.
        **************************************************************************************************/

        public CSharpCompilation CreateCompilerContext()
        {
            SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(_code);
            var assemblyName = Path.GetRandomFileName();
            Assembly a = typeof(CodeRunner).Assembly;
            var refs = GetMetadataReferencesInAssembly(a);

            var compilation = CSharpCompilation.Create(
                                                       assemblyName,
                                                       new[] { syntaxTree },
                                                       refs.ToArray(),
                                                       new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            return compilation;
        }

        private string GetErrorText(EmitResult result)
        {
            var failures = result.Diagnostics.Where(CodeHasError);
            return failures.Aggregate("", (current, diagnostic) => current + ($"{diagnostic.Id}: {diagnostic.GetMessage()}" + Environment.NewLine));
        }

        /**************************************************************************************************
        * Executes the compiled code operation.
        *
        * @param ms The milliseconds.
        **************************************************************************************************/

        private object ExecuteCompiledCode(MemoryStream ms)
        {
            ms.Seek(0, SeekOrigin.Begin);
            var assembly = Assembly.Load(ms.ToArray());

            var type = assembly.GetType("Test.testClass");
            var obj = Activator.CreateInstance(type);
            object result = type.InvokeMember("Run",
                              BindingFlags.Default | BindingFlags.InvokeMethod,
                              null,
                              obj,
                              new object[] { });
            return result;
        }

        /**************************************************************************************************
        * Gets metadata references in assembly.
        *
        * @param assembly The assembly.
        *
        * @return The metadata references in assembly.
        **************************************************************************************************/

        private List<MetadataReference> GetMetadataReferencesInAssembly(Assembly assembly)
        {


            var assemblyFiles = GetAssemblyFiles(assembly);

            Console.WriteLine(assemblyFiles);

            List<MetadataReference> refs = new List<MetadataReference>();
            foreach (var assemblyname in assemblyFiles)
                refs.Add(MetadataReference.CreateFromFile(assemblyname));

            return refs;
        }



        /**************************************************************************************************
        * Code has error.
        *
        * @param diagnostic The diagnostic.
        *
        * @return True if it succeeds, false if it fails.
        **************************************************************************************************/

        private bool CodeHasError(Diagnostic diagnostic)
        {
            return diagnostic.IsWarningAsError || diagnostic.Severity == DiagnosticSeverity.Error;
        }

       


    }

}
