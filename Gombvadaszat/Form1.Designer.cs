﻿namespace Gombvadaszat
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
            this.components = new System.ComponentModel.Container();
            this.myButton1 = new Gombvadaszat.MyButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.ClickCount = 0;
            this.myButton1.Location = new System.Drawing.Point(653, 388);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(119, 61);
            this.myButton1.TabIndex = 1;
            this.myButton1.Text = "0";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Gombvadászat";
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton myButton1;
        public System.Windows.Forms.Timer timer1;
    }
}