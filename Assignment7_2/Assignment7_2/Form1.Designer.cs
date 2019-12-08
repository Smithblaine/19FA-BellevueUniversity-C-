namespace Assignment7_2
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
            this.yes1 = new System.Windows.Forms.CheckBox();
            this.no1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cox Communication Internet Access";
            // 
            // yes1
            // 
            this.yes1.AutoSize = true;
            this.yes1.Location = new System.Drawing.Point(125, 144);
            this.yes1.Name = "yes1";
            this.yes1.Size = new System.Drawing.Size(54, 21);
            this.yes1.TabIndex = 1;
            this.yes1.Text = "Yes";
            this.yes1.UseVisualStyleBackColor = true;
            // 
            // no1
            // 
            this.no1.AutoSize = true;
            this.no1.Location = new System.Drawing.Point(224, 144);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(48, 21);
            this.no1.TabIndex = 2;
            this.no1.Text = "No";
            this.no1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Would your household be interested in internet access";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.no1);
            this.Controls.Add(this.yes1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox yes1;
        private System.Windows.Forms.CheckBox no1;
        private System.Windows.Forms.Label label2;
    }
}

