using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProxyHandler
{
    [Interceptor]
    public class BusinessClass : IBusinessClass
    {
        public void ArgumentVoid(int a, string b)
        {
            
        }

        public string GetString(string str)
        {
            return str;
        }

        public int NoArgument()
        {
            return 1;
        }

        [Action]
        public void Test()
        {
            
        }
    }
}
