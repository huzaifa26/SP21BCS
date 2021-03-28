
namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ibFirst = new System.Windows.Forms.TextBox();
            this.ibSecond = new System.Windows.Forms.TextBox();
            this.ibResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ibFirst
            // 
            this.ibFirst.Location = new System.Drawing.Point(12, 66);
            this.ibFirst.Name = "ibFirst";
            this.ibFirst.Size = new System.Drawing.Size(100, 23);
            this.ibFirst.TabIndex = 0;
            this.ibFirst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ibSecond
            // 
            this.ibSecond.Location = new System.Drawing.Point(118, 66);
            this.ibSecond.Name = "ibSecond";
            this.ibSecond.Size = new System.Drawing.Size(100, 23);
            this.ibSecond.TabIndex = 1;
            this.ibSecond.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ibResult
            // 
            this.ibResult.Location = new System.Drawing.Point(118, 125);
            this.ibResult.Name = "ibResult";
            this.ibResult.Size = new System.Drawing.Size(100, 23);
            this.ibResult.TabIndex = 2;
            this.ibResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(21, 124);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.ibResult);
            this.Controls.Add(this.ibSecond);
            this.Controls.Add(this.ibFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ibFirst;
        private System.Windows.Forms.TextBox ibSecond;
        private System.Windows.Forms.TextBox ibResult;
        private System.Windows.Forms.Button btnCalculate;
    }
}

