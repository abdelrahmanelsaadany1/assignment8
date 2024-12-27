using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demo.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

      
        public Employee(int _Id,string _Name, int _Age) {
            Id = _Id;
            Name = _Name;
            Age = _Age;
        
        }
        public void Fun01() {

            Console.WriteLine("iam employee");
        
        }
       
        public virtual void Fun02()
        {

            Console.WriteLine($"id is :{ Id},name is :{Name } age is :{Age }");

        }
    }
}
