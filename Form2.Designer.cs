namespace osama_hashed2
{
    partial class Form2
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
            this.buyllow = new System.Windows.Forms.Button();
            this.bugreen = new System.Windows.Forms.Button();
            this.bured = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buyllow
            // 
            this.buyllow.Location = new System.Drawing.Point(217, 64);
            this.buyllow.Name = "buyllow";
            this.buyllow.Size = new System.Drawing.Size(75, 23);
            this.buyllow.TabIndex = 0;
            this.buyllow.Text = "اصفر";
            this.buyllow.UseVisualStyleBackColor = true;
            this.buyllow.Click += new System.EventHandler(this.buyllow_Click);
            // 
            // bugreen
            // 
            this.bugreen.Location = new System.Drawing.Point(110, 64);
            this.bugreen.Name = "bugreen";
            this.bugreen.Size = new System.Drawing.Size(75, 23);
            this.bugreen.TabIndex = 1;
            this.bugreen.Text = "اخضر";
            this.bugreen.UseVisualStyleBackColor = true;
            this.bugreen.Click += new System.EventHandler(this.bugreen_Click);
            // 
            // bured
            // 
            this.bured.Location = new System.Drawing.Point(8, 64);
            this.bured.Name = "bured";
            this.bured.Size = new System.Drawing.Size(75, 23);
            this.bured.TabIndex = 2;
            this.bured.Text = "احمر";
            this.bured.UseVisualStyleBackColor = true;
            this.bured.Click += new System.EventHandler(this.bured_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "جهاز 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "جهاز 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bured);
            this.Controls.Add(this.bugreen);
            this.Controls.Add(this.buyllow);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buyllow;
        private System.Windows.Forms.Button bugreen;
        private System.Windows.Forms.Button bured;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}