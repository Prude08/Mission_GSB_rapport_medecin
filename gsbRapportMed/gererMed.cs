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
    public partial class gererMed : Form
    {
        private gsbm2Entities ord;
        private medecin m;
        public gererMed(gsbm2Entities ord)
        {
            InitializeComponent();
            this.m = new medecin();
            this.ord = new gsbm2Entities();
        }

        private void gererMed_Load(object sender, EventArgs e)
        {
            var query = from medecin in ord.medecin 
                        select medecin.departement;

            var allName = query.ToList().Distinct();

            foreach (var medecin in allName)
            {
                this.dept.Items.Add(medecin);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gererNmPre supM = new gererNmPre(this.ord, this.dept.SelectedItem.ToString());
            supM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
