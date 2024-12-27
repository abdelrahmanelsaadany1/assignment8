using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _B,int _A):base(_A) 
        {
            B = _B;
         
        }
        public new void Fun01()
        {

            Console.WriteLine("iam  the child ");

        }
        public override void Fun02()
        {

            Console.WriteLine($"B={B} A={A}");

        }
    }
}
