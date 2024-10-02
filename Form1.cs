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
    //كود المضروب والمجموع والجذر
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labnum_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            busum.Enabled = busqrt.Enabled = bufact.Enabled = (textBox1.Text.Trim() != "");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bufact.Enabled = busum.Enabled = busqrt.Enabled = false;
        }

        private void bufact_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            long f = 1;
            for (int i = 2; i <= n; i++) {
                f *= i;
            }
            label3.Text = f.ToString();
            
            textBox1.Clear();
        }

        private void busqrt_Click(object sender, EventArgs e)
        {
            label4.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void busum_Click(object sender, EventArgs e)
        {
            
            int sum=0;
            for(int i=0 ; i<=Convert.ToInt32(textBox1.Text) ;i++){
            sum+=i;    
            }

            label2.Text = sum.ToString();
           

        }
    }
}
