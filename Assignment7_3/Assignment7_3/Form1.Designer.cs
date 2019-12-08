namespace Assignment7_3
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
            this.blue = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click on a button to change the forms color.";
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(111, 60);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(75, 23);
            this.blue.TabIndex = 1;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = true;
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(111, 89);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(75, 23);
            this.green.TabIndex = 2;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(111, 118);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(75, 23);
            this.red.TabIndex = 3;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            // 
            // yellow
            // 
            this.yellow.Location = new System.Drawing.Point(111, 147);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(75, 23);
            this.yellow.TabIndex = 4;
            this.yellow.Text = "Yellow";
            this.yellow.UseVisualStyleBackColor = true;
            // 
            // orange
            // 
            this.orange.Location = new System.Drawing.Point(111, 176);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(75, 23);
            this.orange.TabIndex = 5;
            this.orange.Text = "Orange";
            this.orange.UseVisualStyleBackColor = true;
            this.orange.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 226);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.red);
            this.Controls.Add(this.green);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button orange;
    }
}

