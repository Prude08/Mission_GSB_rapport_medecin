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
    public partial class gererNmPre : Form
    {
        private medecin m;
        private gsbm2Entities ord;
        private int nbDepartement;
        public gererNmPre(gsbm2Entities ord, string dep)
        {
            InitializeComponent();
            this.m = new medecin();
            this.ord = new gsbm2Entities();
            this.nbDepartement = Convert.ToInt32(dep);
            
        }

        private void supMed_Load(object sender, EventArgs e)
        {
            var query = from medecin in ord.medecin where medecin.departement == this.nbDepartement select medecin.nom;
            var allName = query.ToList();

            foreach (var medecin in allName)
            {
                this.combo_nom.Items.Add(medecin);
            }
        }

        private void annul_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            

            modifierMed modif = new modifierMed(this.ord, this.combo_nom.Text, this.combo_pre.Text);
            modif.Show();
        }

        private void supp_Click(object sender, EventArgs e)
        {
            try
            {
                string nm = this.combo_nom.SelectedItem.ToString();
                string pr = this.combo_pre.SelectedItem.ToString();

                var query1 = from medecin in this.ord.medecin
                             where medecin.nom == nm && medecin.prenom == pr
                             select medecin;
                /* on peut prendre l'id avec medecin.id */

                bool beuhh = false;
                int id = 0;
                foreach (medecin m in query1.ToList())
                {
                    id = m.id;

                    var query = from rapport in this.ord.rapport
                                where rapport.idMedecin == id
                                select rapport;
                    foreach (rapport r in query.ToList())
                    {
                        if (id == r.idMedecin)
                        {
                            beuhh = true;
                        }
                    }
                }
                if (beuhh==false)
                {
                    MessageBox.Show("Médecin supprimé avec succès");
                    var query = from medecin in this.ord.medecin
                                where id == medecin.id
                                select medecin;

                    foreach (medecin m in query.ToList())
                    {
                        if (id == m.id)
                        {
                            this.ord.medecin.Remove(m);
                            this.ord.SaveChanges();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Le médecin est concerné par des rapports ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combo_nom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.combo_pre.Items.Clear();
            var query1 = from medecin in ord.medecin where medecin.nom == this.combo_nom.SelectedItem.ToString() select medecin.prenom;
            var allPrenom = query1.ToList();

            foreach (string medecin in allPrenom)
            {
                this.combo_pre.Items.Add(medecin);
            }
        }
    }
}
