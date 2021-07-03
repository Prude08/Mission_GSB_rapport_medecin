using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace gsbRapportMed
{
    public partial class rapportMed : Form
    {
        private gsbm2Entities ord;
        private rapport rap;
        private int idMedecin;
        public rapportMed(gsbm2Entities ord, int id)
        {
            InitializeComponent();
            this.rap = new rapport();
            this.ord = new gsbm2Entities();
            this.idMedecin = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var idMax = (from rap in ord.rapport 
                         where rap.idMedecin == this.idMedecin 
                         select rap).Max(rap => rap.id);

            var query = (from rapport in ord.rapport 
                         where rapport.id == idMax 
                         select rapport);
            var leRapport = query.ToList();
            this.dgv.DataSource = new BindingSource(new BindingList<rapport>(leRapport), null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            XElement xml = new XElement("Rapports",
                new XElement("id", dgv.CurrentRow.Cells[0].Value),
                new XElement("date", dgv.CurrentRow.Cells[1].Value),
                new XElement("motif", dgv.CurrentRow.Cells[2].Value),
                new XElement("bilan", dgv.CurrentRow.Cells[3].Value),
                new XElement("idVisiteur", dgv.CurrentRow.Cells[4].Value),
                new XElement("idMedecin", dgv.CurrentRow.Cells[5].Value));

            xml.Save("abn.xml");

            MessageBox.Show("Fichier enregistré avec succès");
            this.Close();
        }

    }
}