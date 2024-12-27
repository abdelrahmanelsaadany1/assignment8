using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Binding
{
    internal class FullTimeEmp:Employee
    {
        public decimal Salary {  get; set; }
        public FullTimeEmp(int _Id,string _Name,int _Age, int _Salary ) :base(_Id,_Name,_Age)
        { 
        Salary = _Salary;
        
        }
        public new void Fun01()
        {
            Console.WriteLine("iam full time employee");
        }
        public override void Fun02()
        {
            Console.WriteLine($"id is :{Id},name is :{Name} age is :{Age} salary is {Salary}");
        }
    }
}
