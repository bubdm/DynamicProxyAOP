using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProxyHandler
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class ActionAttribute : ActionBaseAttribute
    {
        public override void Before(string method, object[] parameters)
        {
            Console.WriteLine($"Action Before 111111, method:{method}, params:{parameters}");
        }

        public override object After(string method, object result)
        {
            Console.WriteLine($"Action After 222222, method: {method}, result: {result}");
            return base.After(method, result);
        }
    }
}
