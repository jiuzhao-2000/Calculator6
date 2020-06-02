using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator6
{
    public class OperationFactory
    {
        public static Operation CreateOperation(string mate)
        {
            Operation oper;
            switch (mate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                case "%":
                    oper = new OperationDiv();
                    break;
                default:
                    MessageBox.Show("您还没有输入符号！");
                    return null;
            }
            return oper;
        }
    }
}
