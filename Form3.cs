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
    public partial class Form3 : Form {
        double a,b,c;
        string []op={"+","-","*","/"};
    
        public Form3()
        {
            InitializeComponent();
            this.listBox1.Items.AddRange(op);
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            res.ReadOnly=true;
            num1.Focus();
        }
          private void col_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void del_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            res.Clear();
            num1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool val=true;
            bool oper=true;
            if (num1.Text.Trim()!=""&&num2.Text.Trim()!="")
            {
            
                try
                {
                a=Convert.ToDouble(num1.Text);
                }
                catch(Exception)
                {
                MessageBox.Show("العدد الاول غير صالح ","تحذير",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                   num1.Clear();
                    num1.Focus();
                    val=false;
                }
                try
                {
                b=Convert.ToDouble(num2.Text);

                }
                catch(Exception){
                MessageBox.Show("العدد الثاني غير صالح ","تحذير",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                   num2.Clear();
                    num2.Focus();
                    val=false;
                }
                if(val)
                {
                switch(listBox1.SelectedIndex)
                {
                    case 0:c=a+b;break;
                    case 1:c=a-b;break;
                    case 2:c=a*b;break;
                    case 3:
                        if(b!=0)
                        {      
                         c=a/b;
                        }
                        else
                        {
                        MessageBox.Show("لايمكن القسمة على صفر","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            oper=false;
                        }
                        break;
                    default:
                        MessageBox.Show("يرجى اختيار عملية حسابيه","تحذير",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        oper=false;
                        break;
                }
                    if(oper)
                    {
                    res.Text=c.ToString();
                    }
                    else
                    {
                    res.Clear();
                    }
                }
            }
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) {
                e.Handled = true;
            }
            }

        private void num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) {
                e.Handled = true;
            }
        }


            
        }
    }

        

      
 

