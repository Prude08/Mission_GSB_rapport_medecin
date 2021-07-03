namespace gsbRapportMed
{
    partial class dernierRap
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
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.p = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(425, 79);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(42, 20);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(425, 164);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(64, 20);
            this.Prenom.TabIndex = 1;
            this.Prenom.Text = "Prenom";
            // 
            // n
            // 
            this.n.FormattingEnabled = true;
            this.n.Location = new System.Drawing.Point(579, 79);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(440, 28);
            this.n.TabIndex = 2;
            this.n.SelectedIndexChanged += new System.EventHandler(this.n_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(812, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // p
            // 
            this.p.FormattingEnabled = true;
            this.p.Location = new System.Drawing.Point(579, 164);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(440, 28);
            this.p.TabIndex = 6;
            // 
            // dernierRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 450);
            this.Controls.Add(this.p);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Name = "dernierRap";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.ComboBox n;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox p;
    }
}