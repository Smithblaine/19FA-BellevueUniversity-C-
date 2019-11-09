namespace EggsInteractiveGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chic1 = new System.Windows.Forms.TextBox();
            this.chic2 = new System.Windows.Forms.TextBox();
            this.chic4 = new System.Windows.Forms.TextBox();
            this.chic5 = new System.Windows.Forms.TextBox();
            this.chic3 = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chicken 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chicken 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chicken 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chicken 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chicken 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter the number of eggs produced for each chicken";
            // 
            // chic1
            // 
            this.chic1.Location = new System.Drawing.Point(119, 76);
            this.chic1.Name = "chic1";
            this.chic1.Size = new System.Drawing.Size(58, 22);
            this.chic1.TabIndex = 6;
            // 
            // chic2
            // 
            this.chic2.Location = new System.Drawing.Point(119, 108);
            this.chic2.Name = "chic2";
            this.chic2.Size = new System.Drawing.Size(58, 22);
            this.chic2.TabIndex = 7;
            // 
            // chic4
            // 
            this.chic4.Location = new System.Drawing.Point(119, 168);
            this.chic4.Name = "chic4";
            this.chic4.Size = new System.Drawing.Size(58, 22);
            this.chic4.TabIndex = 8;
            this.chic4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // chic5
            // 
            this.chic5.Location = new System.Drawing.Point(119, 196);
            this.chic5.Name = "chic5";
            this.chic5.Size = new System.Drawing.Size(58, 22);
            this.chic5.TabIndex = 9;
            // 
            // chic3
            // 
            this.chic3.Location = new System.Drawing.Point(119, 139);
            this.chic3.Name = "chic3";
            this.chic3.Size = new System.Drawing.Size(58, 22);
            this.chic3.TabIndex = 10;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(292, 193);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(93, 23);
            this.calc.TabIndex = 11;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(29, 240);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 17);
            this.output.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 305);
            this.Controls.Add(this.output);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.chic3);
            this.Controls.Add(this.chic5);
            this.Controls.Add(this.chic4);
            this.Controls.Add(this.chic2);
            this.Controls.Add(this.chic1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox chic1;
        private System.Windows.Forms.TextBox chic2;
        private System.Windows.Forms.TextBox chic4;
        private System.Windows.Forms.TextBox chic5;
        private System.Windows.Forms.TextBox chic3;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label output;
    }
}

