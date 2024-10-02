namespace osama_hashed2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labnum = new System.Windows.Forms.Label();
            this.busum = new System.Windows.Forms.Button();
            this.bufact = new System.Windows.Forms.Button();
            this.busqrt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labnum
            // 
            this.labnum.AutoSize = true;
            this.labnum.Location = new System.Drawing.Point(113, 27);
            this.labnum.Name = "labnum";
            this.labnum.Size = new System.Drawing.Size(56, 13);
            this.labnum.TabIndex = 1;
            this.labnum.Text = "ادخل العدد";
            this.labnum.Click += new System.EventHandler(this.labnum_Click);
            // 
            // busum
            // 
            this.busum.Location = new System.Drawing.Point(166, 91);
            this.busum.Name = "busum";
            this.busum.Size = new System.Drawing.Size(75, 23);
            this.busum.TabIndex = 2;
            this.busum.Text = "المجموع";
            this.busum.UseVisualStyleBackColor = true;
            this.busum.Click += new System.EventHandler(this.busum_Click);
            // 
            // bufact
            // 
            this.bufact.Location = new System.Drawing.Point(166, 136);
            this.bufact.Name = "bufact";
            this.bufact.Size = new System.Drawing.Size(75, 23);
            this.bufact.TabIndex = 3;
            this.bufact.Text = "المضروب";
            this.bufact.UseVisualStyleBackColor = true;
            this.bufact.Click += new System.EventHandler(this.bufact_Click);
            // 
            // busqrt
            // 
            this.busqrt.Location = new System.Drawing.Point(166, 182);
            this.busqrt.Name = "busqrt";
            this.busqrt.Size = new System.Drawing.Size(75, 23);
            this.busqrt.TabIndex = 4;
            this.busqrt.Text = "الجذر";
            this.busqrt.UseVisualStyleBackColor = true;
            this.busqrt.Click += new System.EventHandler(this.busqrt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.busqrt);
            this.Controls.Add(this.bufact);
            this.Controls.Add(this.busum);
            this.Controls.Add(this.labnum);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labnum;
        private System.Windows.Forms.Button busum;
        private System.Windows.Forms.Button bufact;
        private System.Windows.Forms.Button busqrt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

