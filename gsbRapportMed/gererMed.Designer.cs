﻿namespace gsbRapportMed
{
    partial class gererMed
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
            this.dep = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Location = new System.Drawing.Point(320, 107);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(103, 20);
            this.dep.TabIndex = 0;
            this.dep.Text = "Département";
            // 
            // dept
            // 
            this.dept.FormattingEnabled = true;
            this.dept.Location = new System.Drawing.Point(166, 172);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(404, 28);
            this.dept.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gererMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.dep);
            this.Name = "gererMed";
            this.Text = "gererMed";
            this.Load += new System.EventHandler(this.gererMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dep;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}