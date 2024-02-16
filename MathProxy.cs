using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxyScript
{
    public class MathProxy : RealProxy, IMath
    {
        private readonly dynamic _math;

        public MathProxy(): base(typeof(IMath))
        {
            var engine = new Microsoft.ClearScript.V8.V8ScriptEngine();
            engine.Execute("var Math = host.import('Math');");
            _math = engine.Script.Math;
        }

        public override IMessage Invoke(IMessage msg)
        {
            var methodCall = (IMethodCallMessage)msg;
            var methodName = methodCall.MethodName;
            var args = methodCall.Args;
            var result = _math[methodName](args);

            Console.WriteLine($"{methodName}({string.Join(", ", args)}) = {result}");
            return new ReturnMessage(result, null, 0, methodCall.LogicalCallContext, methodCall);
        }
    }
}
