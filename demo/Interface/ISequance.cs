using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Interface
{
    internal interface ISequance
    {
        public int Current {  get; set; }
        public void GetNext();
        public void Reset();
        
        

    }
}
