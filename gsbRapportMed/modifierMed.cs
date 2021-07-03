using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapportMed
{
    public partial class modifierMed : Form
    {
        private gsbm2Entities ord;
        private string nom;
        private string prenom;
        public modifierMed(gsbm2Entities ord, string n, string p)
        {
            InitializeComponent();
            this.ord = new gsbm2Entities();
            this.nom = n;
            this.prenom = p;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifierMed_Load(object sender, EventArgs e)
        {
            var query = from medecin in ord.medecin where medecin.nom == nom && medecin.prenom == prenom select medecin;
             
            foreach(medecin m in query)
            {
                this.label_nom.Text = m.nom;
                this.label_pre.Text = m.prenom;
                this.label_id.Text = Convert.ToString(m.id);
            }
                var query1= from medecin in ord.medecin select medecin.departement;
                var allName = query1.ToList().Distinct();

                foreach (var medecin in allName)
                {
                    this.combo_dep.Items.Add(medecin);
                }
            var querey = from medecin in ord.medecin where medecin.specialiteComplementaire != null select medecin.specialiteComplementaire;
            var specialite = querey.ToList().Distinct();

            foreach(var medecin in specialite)
            {
                this.combo_spe.Items.Add(medecin);
            }
            
        }

        private void modif_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.text_adr == null || this.text_tel.TextLength <= 5)
                {
                    MessageBox.Show("Veillez remplir tous les champs");
                }
                else
                {
                    var adresse = this.text_adr.Text;
                    var tel = this.text_tel.Text;
                    var spe = Convert.ToString(this.combo_spe.SelectedItem);
                    var dep = Convert.ToInt32(this.combo_dep.SelectedItem);

                    int id = Convert.ToInt32(this.Id);

                    var query3 = from medecin in ord.medecin where medecin.id == id select medecin;
                    var allmed = query3.ToList();


                    foreach (medecin m in allmed)
                    {
                        m.adresse = adresse;
                        m.tel = tel;
                        m.specialiteComplementaire = spe;
                        m.departement = dep;

                        this.ord.SaveChanges();
                        this.Close();
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
