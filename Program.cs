using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ClearScript;

namespace ConsoleProxyScript
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var engine = new Microsoft.ClearScript.V8.V8ScriptEngine();

            // add the math library
            //engine.Execute("var math = require('math');");
            engine.Execute("var Math = host.import('Math');");
            Console.WriteLine("Hello World!");
        }
    }
}
