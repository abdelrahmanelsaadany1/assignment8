using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class TypeA
    {
        public int A {  get; set; }
        public TypeA( int _A) {
            A = _A;
        }
        public void Fun01() {

            Console.WriteLine( "iam base parent");
        
        }
        public virtual void Fun02()
        {

            Console.WriteLine($"A={A}");

        }
    }
}
