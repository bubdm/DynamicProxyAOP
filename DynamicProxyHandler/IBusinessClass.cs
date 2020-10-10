using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProxyHandler
{
    public interface IBusinessClass
    {
        void Test();
        int NoArgument();
        void ArgumentVoid(int a, string b);
        string GetString(string str);
    }
}
