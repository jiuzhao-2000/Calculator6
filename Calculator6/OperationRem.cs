﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator6
{
    class OperationRem:Operation
    {
        //取余计算，返回result
        public override int GetResult()
        {
            int result = NumberA % NumberB;
            return result;
        }
    }
}
