using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator6
{
    public class Operation
    {
        private int _numberA = 0;
        private int _numberB = 0;
        public int NumberA 
        {
            get { return _numberA; }
            set { _numberA = value; } 
        }
        public int NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }
        public virtual int GetResult()
        {
            return 0;
        }
    }
}
