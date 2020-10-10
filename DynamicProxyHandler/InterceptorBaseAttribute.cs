using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProxyHandler
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class InterceptorBaseAttribute : Attribute
    {
        public virtual object Invoke(object obj, string method, object[] parameters)
        {
            return obj.GetType().GetMethod(method).Invoke(obj, parameters);
        }
    }
}