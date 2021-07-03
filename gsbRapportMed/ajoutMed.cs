using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gsbRapportMed
{
    public partial class ajoutMed : Form
    {
        private  gsbm2Entities ord;
        private medecin m;
        public ajoutMed(gsbm2Entities ord)
        {
            
            InitializeComponent();
            this.m = new medecin();
            this.ord = new gsbm2Entities();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.m = new medecin();

            var nom = this.nom.Text;
            var prenom = this.prenom.Text;
            var adresse = this.adresse.Text;
            var tel = this.tel.Text;

            m.nom = nom;
            m.prenom = prenom;
            m.adresse = adresse;
            m.tel = tel;

            try
            {
                var query = from medecin in ord.medecin where medecin.specialiteComplementaire != null select medecin.specialiteComplementaire;
                
                var allspecialite = query.ToList().Distinct();

                foreach (var medecin in allspecialite)
                {
                    this.specialite.Items.Add(medecin);
                }

                var query1 = from medecin in ord.medecin select medecin.departement;

                var allMedecins = query1.ToList().Distinct();
                foreach (var medecin in allMedecins)
                {
                    this.dep.Items.Add(medecin);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.m = new medecin();
            try
            {
                string nom = Convert.ToString( this.nom.Text);
                string prenom = Convert.ToString(this.prenom.Text);
                string adresse = Convert.ToString(this.adresse.Text);
                string tel = Convert.ToString(this.tel.Text);
                string specialite = Convert.ToString(this.specialite.SelectedItem);
                int dep = Convert.ToInt32(this.dep.SelectedItem);

                this.m.nom = nom;
                this.m.prenom = prenom;
                this.m.adresse = adresse;
                this.m.tel = tel;
                this.m.specialiteComplementaire = specialite;
                this.m.departement = dep;

                if (nom == "" || prenom == "" || adresse == "" || tel == "" || specialite == null || dep == 0)
                {
                    if (nom == m.nom || prenom == m.prenom)
                    {
                        MessageBox.Show("Veillez remplir tous les champs \n ou le medecin existe déjà");
                    }
                }
                else
                {
                    medecin med = new medecin { nom = nom, prenom = prenom, adresse = adresse, tel = tel, specialiteComplementaire = specialite, departement = dep };
                    ord.medecin.Add(this.m);
                    ord.SaveChanges();
                    MessageBox.Show("Le medecin a bien été enregistré");
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
        }
    }
}
