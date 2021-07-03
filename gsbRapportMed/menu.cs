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
    public partial class Form1 : Form
    {
        private readonly gsbm2Entities ord;
        public Form1()
        {
            InitializeComponent();
           this.ord = new gsbm2Entities();
        }

        private void AjoutMed_Click_1(object sender, EventArgs e)
        {
            ajoutMed ajoutMed = new ajoutMed(this.ord);
            ajoutMed.Show();
        }

        private void dernierRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dernierRap dernierRap = new dernierRap(this.ord);
            dernierRap.Show();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gererMed gerer = new gererMed(this.ord);
            gerer.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
