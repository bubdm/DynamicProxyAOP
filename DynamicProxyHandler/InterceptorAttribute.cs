using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProxyHandler
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class InterceptorAttribute : InterceptorBaseAttribute
    {
        public override object Invoke(object @object, string method, object[] parameters)
        {
            Console.WriteLine($"Interceptor does something before invoke {method}.");

            object obj = null;

            try
            {
                obj = base.Invoke(@object, method, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine($"Interceptor does something after invoke {method}.");

            return obj;
        }
    }
}
