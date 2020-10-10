using System;

namespace DynamicProxyHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            IBusinessClass instance =DynamicProxy.CreateProxyOfRealize<IBusinessClass, BusinessClass>();

            instance.ArgumentVoid(1,"2");
            instance.GetString("abc");
            instance.NoArgument();
            instance.Test();
        }
    }
}
