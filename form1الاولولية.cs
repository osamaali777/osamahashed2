using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osama_hashed2
{
    public partial class form1الاولولية : Form
    {
        public form1الاولولية()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num11, num22, num33;
            string operation1 = op1.Text;
            string operation2 = op2.Text;
            string intermediateresult = "";
            string finalresult = "";

            if (double.TryParse(num1.Text, out num11) &&
                double.TryParse(num2.Text, out num22) &&
                double.TryParse(num3.Text, out num33))
            {

                if (HasHigherpriority(operation1, operation2))
                {
                    intermediateresult =performoperation(num11, num22, operation2).ToString();
                    if (intermediateresult == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية الاولى غير صحيحة", "تحذير ");
                        op1.Text = "";
                        op1.Focus();
                        return;
                    }

                    finalresult = performoperation(Convert.ToDouble(intermediateresult), num33, operation2).ToString();
                    if (finalresult == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية غير صحيحة", "تحذير");
                        op2.Text = "";
                        op2.Focus();
                        return;
                    }
                }
                else
                {
                    intermediateresult = performoperation(num22, num33, operation2).ToString();
                    if (intermediateresult == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية الاولى غير صحيحة", "تحذير ");
                        op2.Text = "";
                        op2.Focus();
                        return;
                    }

                    finalresult = performoperation(num11, Convert.ToDouble(intermediateresult), operation1).ToString();
                    if (finalresult == double.NaN.ToString())
                    {
                        MessageBox.Show("العملية غير صحيحة", "تحذير");
                        op1.Text = "";
                        op1.Focus();
                        return;
                    }
                }
                rus.Text = finalresult.ToString();
            }
            else
            {
                MessageBox.Show("العملية الاولى غير صحيحة", "تحذير ");
            }
        }
        private double performoperation(double n1, double n2, string oper)
        {

            switch (oper)
            {

                case "+":
                    return n1 + n2;
                case "-":
                    return n1 - n2;
                case "*":
                    return n1 * n2;
                case "/":
                    return n2 != 0 ? n1 / n1 : double.NaN;
                default:
                    return double.NaN;
            }
        }
        private bool HasHigherpriority(string op1, string op2) { 
        if((op1=="*"||op1=="/") && (op2=="+" || op2=="-"))
            return true ;
            else
            return false ;
        }

        private void form1الاولولية_Load(object sender, EventArgs e)
        {

        }
    }
}
