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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buyllow_Click(object sender, EventArgs e)
        {
           
            if (sender == buyllow)
            {
                button4.BackColor = Color.Yellow;
            }
           
            
        }

        private void bugreen_Click(object sender, EventArgs e)
        {
            if (sender == bugreen) 
            {
                button4.BackColor = Color.Green;
            }
        }

        private void bured_Click(object sender, EventArgs e)
        {
            if (sender == bured) 
            {
                button4.BackColor = Color.Red;
            }
        }
    }
}
