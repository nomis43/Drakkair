using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drakkair
{
    public partial class FormAjoutVoyage : Form
    {
        DataSet ds = new DataSet();
        OleDbConnection co = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Drakkair.mdb");

        bool AdminMode;

        public FormAjoutVoyage()
        {
            InitializeComponent();
        }

        public FormAjoutVoyage(bool AdminMode) : this()
        {
            this.AdminMode = AdminMode;
        }

        private void FormAjoutVoyage_Load(object sender, EventArgs e)
        {
            this.ChargerCombos();
        }

        private void ChargerBDD(string req, string table)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(req, this.co);
            da.Fill(this.ds, table);
        }

        private void ChargerCombos()
        {
            string reqHebergt = @"SELECT * FROM tblHebergement";
            string reqThematique = @"SELECT * FROM tblThematique";

            ChargerBDD(reqHebergt, "Hebergement");
            ChargerBDD(reqThematique, "Thematique");

            this.comboHebergement.DataSource = ds.Tables["Hebergement"];
            this.comboHebergement.DisplayMember = "NomCategorie";
            this.comboHebergement.ValueMember = "NumCategorie";

            this.comboThematique.DataSource = ds.Tables["Thematique"];
            this.comboThematique.DisplayMember = "libThem";
            this.comboThematique.ValueMember = "codeThem";
        }

        private void CheckInput()
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string code = (string)textCode.Text;
            string destination = (string)textDest.Text;
            string description = (string)textDescr.Text;
            int thematique = (int)comboThematique.SelectedValue;
            int hebergement = (int)comboHebergement.SelectedValue;
            int nbJours = Convert.ToInt32(textNbJours.Text);
            int prix = Convert.ToInt32(textPrix.Text);

            string req = "INSERT INTO tblVoyages VALUES (CodeVoyage, Destination, Duree, TypeThematique, Description, Prix) VALUES (\"" + code + "\",\"" + destination + "\"," + nbJours + "," + thematique + ",\"" + description + "\"," + prix + ")";
            MessageBox.Show(req);
        }


    }
}
