﻿namespace DesignPatterns
{
    partial class LogForm
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
            this.simple = new System.Windows.Forms.RadioButton();
            this.detailed = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simple
            // 
            this.simple.AutoSize = true;
            this.simple.Location = new System.Drawing.Point(80, 63);
            this.simple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simple.Name = "simple";
            this.simple.Size = new System.Drawing.Size(94, 21);
            this.simple.TabIndex = 0;
            this.simple.TabStop = true;
            this.simple.Text = "Simple log";
            this.simple.UseVisualStyleBackColor = true;
            // 
            // detailed
            // 
            this.detailed.AutoSize = true;
            this.detailed.Location = new System.Drawing.Point(80, 130);
            this.detailed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailed.Name = "detailed";
            this.detailed.Size = new System.Drawing.Size(104, 21);
            this.detailed.TabIndex = 1;
            this.detailed.TabStop = true;
            this.detailed.Text = "Detailed log";
            this.detailed.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log all tasks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detailed);
            this.Controls.Add(this.simple);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton simple;
        private System.Windows.Forms.RadioButton detailed;
        private System.Windows.Forms.Button button1;
    }
}