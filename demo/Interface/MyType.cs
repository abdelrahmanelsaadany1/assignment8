using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Interface
{
    internal class MyType : IMyType
    {
        public int Id { get ; set ; }

        public void MyFun()
        {
            Console.WriteLine("hello world");
        }
    }
}
