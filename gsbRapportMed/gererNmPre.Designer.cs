namespace gsbRapportMed
{
    partial class gererNmPre
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NomPrenom = new System.Windows.Forms.Label();
            this.combo_nom = new System.Windows.Forms.ComboBox();
            this.modifier = new System.Windows.Forms.Button();
            this.supp = new System.Windows.Forms.Button();
            this.annul = new System.Windows.Forms.Button();
            this.departement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_pre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NomPrenom
            // 
            this.NomPrenom.AutoSize = true;
            this.NomPrenom.Location = new System.Drawing.Point(116, 145);
            this.NomPrenom.Name = "NomPrenom";
            this.NomPrenom.Size = new System.Drawing.Size(54, 20);
            this.NomPrenom.TabIndex = 1;
            this.NomPrenom.Text = "Nom   ";
            // 
            // combo_nom
            // 
            this.combo_nom.FormattingEnabled = true;
            this.combo_nom.Location = new System.Drawing.Point(296, 145);
            this.combo_nom.Name = "combo_nom";
            this.combo_nom.Size = new System.Drawing.Size(375, 28);
            this.combo_nom.TabIndex = 2;
            this.combo_nom.SelectedIndexChanged += new System.EventHandler(this.combo_nom_SelectedIndexChanged);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(93, 339);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(106, 49);
            this.modifier.TabIndex = 3;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supp
            // 
            this.supp.Location = new System.Drawing.Point(337, 339);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(110, 49);
            this.supp.TabIndex = 4;
            this.supp.Text = "Supprimer";
            this.supp.UseVisualStyleBackColor = true;
            this.supp.Click += new System.EventHandler(this.supp_Click);
            // 
            // annul
            // 
            this.annul.Location = new System.Drawing.Point(589, 339);
            this.annul.Name = "annul";
            this.annul.Size = new System.Drawing.Size(99, 49);
            this.annul.TabIndex = 5;
            this.annul.Text = "Annuler";
            this.annul.UseVisualStyleBackColor = true;
            this.annul.Click += new System.EventHandler(this.annul_Click);
            // 
            // departement
            // 
            this.departement.AutoSize = true;
            this.departement.Location = new System.Drawing.Point(243, 51);
            this.departement.Name = "departement";
            this.departement.Size = new System.Drawing.Size(0, 20);
            this.departement.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prénom";
            // 
            // combo_pre
            // 
            this.combo_pre.FormattingEnabled = true;
            this.combo_pre.Location = new System.Drawing.Point(296, 204);
            this.combo_pre.Name = "combo_pre";
            this.combo_pre.Size = new System.Drawing.Size(375, 28);
            this.combo_pre.TabIndex = 8;
            // 
            // gererNmPre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combo_pre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departement);
            this.Controls.Add(this.annul);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.combo_nom);
            this.Controls.Add(this.NomPrenom);
            this.Name = "gererNmPre";
            this.Text = "gererNmPre";
            this.Load += new System.EventHandler(this.supMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label NomPrenom;
        private System.Windows.Forms.ComboBox combo_nom;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supp;
        private System.Windows.Forms.Button annul;
        private System.Windows.Forms.Label departement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_pre;
    }
}