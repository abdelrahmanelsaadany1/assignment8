using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demo.Binding
{
    internal class PartTime:Employee
    {
        public decimal HourRate { get; set; }
        public PartTime(int _Id, string _Name, int _Age, int _HourRate) : base(_Id, _Name, _Age)
        {
            HourRate = _HourRate;

        }
        public new void Fun01()
        {
            Console.WriteLine("iam part time employee");
        }
        public override void Fun02()
        {
            Console.WriteLine($"id is :{Id},name is :{Name} age is :{Age} hour rate is {HourRate}");
        }
    }
}
