using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ClearScript;
using Microsoft.ClearScript.V8;

namespace ConsoleProxyScript
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var engine = new Microsoft.ClearScript.V8.V8ScriptEngine();
            engine.AddHostObject("host", new HostFunctions());
            //var math = engine.Evaluate("Math");
            var math = engine.Script.Math;
            var sinResult = math.sin(Math.PI / 6);
            var sqrtResult = math.sqrt(9);

            Console.WriteLine("Hello World!");


        }
    }
}
