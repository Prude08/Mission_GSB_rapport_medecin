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
    public partial class dernierRap : Form
    {
        private gsbm2Entities ord;
        private medecin m;
        public dernierRap(gsbm2Entities ord)
        {
            InitializeComponent();
            this.m = new medecin();
            this.ord = new gsbm2Entities();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.m = new medecin();
            var prenom = this.Prenom.Text;
            m.prenom = prenom;

            var query = from medecin in ord.medecin select medecin.nom;
            var allName = query.ToList();

            foreach(var medecin in allName)
            {
                this.n.Items.Add(medecin);
            } 
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getIdMedecin(string nom, string prenom)
        {
            var query = (from medecin in ord.medecin where medecin.nom == nom && medecin.prenom == prenom select medecin.id);
            return query.First();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int idMedecin = getIdMedecin(this.n.SelectedItem.ToString(), this.p.SelectedItem.ToString());
            rapportMed telech = new rapportMed(this.ord, idMedecin);
            telech.Show();
        }

        private void n_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.p.Items.Clear();
            var query1 = from medecin in ord.medecin where medecin.nom == this.n.SelectedItem.ToString() select medecin.prenom;
            var allPrenom = query1.ToList();

            foreach(string medecin in allPrenom)
            {
                this.p.Items.Add(medecin);
            }
        }
    }
}
