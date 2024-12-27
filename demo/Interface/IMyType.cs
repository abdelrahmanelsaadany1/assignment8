using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Interface
{
    internal interface IMyType
    {
        //default access modifier is public 
        // what you can write : 
        //1-signature for property 
        public int Id { get; set; }
        public void MyFun();
        public void print()
        {

            Console.WriteLine("default implemented method");
        }
    }
}
