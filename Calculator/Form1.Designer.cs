namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sum = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(12, 78);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(75, 23);
            this.Sum.TabIndex = 0;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(102, 78);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(75, 23);
            this.Min.TabIndex = 1;
            this.Min.Text = "-";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(12, 107);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(75, 23);
            this.Mult.TabIndex = 2;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(102, 107);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 3;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Location = new System.Drawing.Point(102, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.Location = new System.Drawing.Point(12, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 144);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Sum);
            this.Name = "Form1";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

