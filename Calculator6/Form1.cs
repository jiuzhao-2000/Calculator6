using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator6
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private int ans=0;//结果该次保存
        private bool mate = false;//符号，判断是否输入符号
        private Point mouseMove;
        Operation oper;//计算
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.D5)
            {
                MessageBox.Show("aaa");
                return;
            }
            //键盘按下按键
            switch (e.KeyCode)
            {
                case Keys.D0:
                    Btn_0_Click(this, EventArgs.Empty);
                    break;
                case Keys.D1:
                    Btn_1_Click(this, EventArgs.Empty);
                    break;
                case Keys.D2:
                    Btn_2_Click(this, EventArgs.Empty);
                    break;
                case Keys.D3:
                    Btn_3_Click(this, EventArgs.Empty);
                    break;
                case Keys.D4:
                    Btn_4_Click(this, EventArgs.Empty);
                    break;
                case Keys.D5:
                    Btn_5_Click(this, EventArgs.Empty);
                    break;
                case Keys.D6:
                    Btn_6_Click(this, EventArgs.Empty);
                    break;
                case Keys.D7:
                    Btn_7_Click(this, EventArgs.Empty);
                    break;
                case Keys.D8:
                    Btn_8_Click(this, EventArgs.Empty);
                    break;
                case Keys.D9:
                    Btn_9_Click(this, EventArgs.Empty);
                    break;
                case Keys.A:
                    Btn_A_Click(this, EventArgs.Empty);
                    break;
                case Keys.B:
                    Btn_B_Click(this, EventArgs.Empty);
                    break;
                case Keys.C:
                    Btn_C_Click(this, EventArgs.Empty);
                    break;
                case Keys.D:
                    Btn_D_Click(this, EventArgs.Empty);
                    break;
                case Keys.E:
                    Btn_E_Click(this, EventArgs.Empty);
                    break;
                case Keys.F:
                    Btn_F_Click(this, EventArgs.Empty);
                    break;
                case Keys.X:

                    break;
                case Keys.Y:
                    break;
                case Keys.Z:
                    break;
                case Keys.Add:
                    break;
                case Keys.Divide:
                    break;
                case Keys.Multiply:
                    break;
                case Keys.Subtract:
                    break;
                case Keys.Decimal:
                    MessageBox.Show("aaa");
                    break;
                default:
                    break;
            }
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 各个按钮输入情况
        /// 若输入过符号，在输入符号时，清空结果框
        /// </summary>
        private void Btn_A_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "A";
        }

        private void Btn_B_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "B";
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "C";
        }

        private void Btn_D_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "D";
        }

        private void Btn_E_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "E";
        }

        private void Btn_F_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "F";
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (mate) {Txt_Result.Clear();mate = false;}
            Txt_Result.Text += "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "9";
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            if (mate) { Txt_Result.Clear(); mate = false; }
            Txt_Result.Text += "0";
        }
        /// <summary>
        /// 鼠标拖动窗体，窗体跟随移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            //左键拖动窗体
            if (e.Button == MouseButtons.Left)
            {
                mouseMove.X = e.X;
                mouseMove.Y = e.Y;
            }
        }

        private void Calculator_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Top = MousePosition.Y - mouseMove.Y;
                Left = MousePosition.X - mouseMove.X;
            }
        }
        //创建加法运算
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //判断输入字符是否为空
            if (Txt_Result.Text == string.Empty) return;
            oper = OperationFactory.CreateOperation("+");
            //判断数字正确性
            oper.NumberA = Convert.ToInt32(Txt_Result.Text);
            //将算式输入到计算框，并清空结果文本
            Txt_Calc.Text = Txt_Result.Text + "+";
            mate = true;
        }
        //创键减法运算
        private void Btn_Sub_Click(object sender, EventArgs e)
        {
            //判断输入字符是否为空
            if (Txt_Result.Text == string.Empty) return;
            oper = OperationFactory.CreateOperation("-");
            //判断数字正确性
            oper.NumberA = Convert.ToInt32(Txt_Result.Text);
            //将算式输入到计算框，并清空结果文本
            Txt_Calc.Text = Txt_Result.Text + "-";
            mate = true;
        }
        //创建乘法运算
        private void Btn_Mul_Click(object sender, EventArgs e)
        {
            //判断输入字符是否为空
            if (Txt_Result.Text == string.Empty) return;
            oper = OperationFactory.CreateOperation("*");
            //判断数字正确性
            oper.NumberA = Convert.ToInt32(Txt_Result.Text);
            //将算式输入到计算框，并清空结果文本
            Txt_Calc.Text = Txt_Result.Text + "*";
            mate = true;
        }
        //创建取商运算
        private void Btn_Divide_Click(object sender, EventArgs e)
        {
            //判断输入字符是否为空
            if (Txt_Result.Text == string.Empty) return;
            oper = OperationFactory.CreateOperation("/");
            //判断数字正确性
            oper.NumberA = Convert.ToInt32(Txt_Result.Text);
            //将算式输入到计算框，并清空结果文本
            Txt_Calc.Text = Txt_Result.Text + "/";
            mate = true;
        }
        //创建取余运算
        private void Btn_Remainder_Click(object sender, EventArgs e)
        {
            //判断输入字符是否为空
            if (Txt_Result.Text == string.Empty) return;
            oper = OperationFactory.CreateOperation("%");
            //判断数字正确性
            oper.NumberA = Convert.ToInt32(Txt_Result.Text);
            //将算式输入到计算框，并清空结果文本
            Txt_Calc.Text = Txt_Result.Text + "%";
            mate = true;
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            //判断输入字符是否为空
            if (Txt_Result.Text == string.Empty) return;
            oper.NumberB = Convert.ToInt32(Txt_Result.Text);
            Txt_Calc.Text += Txt_Result.Text+"=";
            Txt_Result.Clear();
            ans = oper.GetResult();
            Txt_Result.Text = ans.ToString();
            mate = true;
        }
        //读取上个计算结果值
        private void Btn_Ans_Click(object sender, EventArgs e)
        {
            Txt_Result.Clear();
            Txt_Result.Text = ans.ToString();
        }
    }
}
