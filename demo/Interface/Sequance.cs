using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Interface
{
    internal class Sequance : ISequance
        //By two
    {
        public int Current { get; set; } = 10;

        public void GetNext()
        {
            Current+=2;
        }
        public void Reset() {
            Current = 0;
        }
    }
}
