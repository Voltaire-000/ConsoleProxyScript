using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript.V8;

namespace ConsoleProxyScript
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var engine = new Microsoft.ClearScript.V8.V8ScriptEngine();
            //engine.AddHostObject("host", new HostFunctions());
            //var math = engine.Evaluate("Math");
            var math = engine.Script.Math;

            // expose a host type

            engine.AddHostType("Console", typeof(Console));

            engine.Execute("Console.WriteLine('{0} is an interesting number.', Math.PI)");
            // expose a host object

            engine.AddHostObject("random", new Random());

            engine.Execute("Console.WriteLine(random.NextDouble())");
            // expose entire assemblies

            engine.AddHostObject("lib", new HostTypeCollection("mscorlib", "System.Core"));

            engine.Execute("Console.WriteLine(lib.System.DateTime.Now)");

            var sinResult = math.sin(Math.PI / 6);
            var sqrtResult = math.sqrt(9);

            Console.WriteLine("Hello World!");


        }
    }
}
