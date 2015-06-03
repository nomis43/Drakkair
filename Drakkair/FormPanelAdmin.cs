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
    public partial class FormPanelAdmin : Form
    {
        DataSet ds = new DataSet();   // DataSet global utilisé pour stocker les résultats de requetes sur ce form
        OleDbConnection co = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Drakkair.mdb");

        List<string> listeTransaction = new List<string>();

        public FormPanelAdmin()
        {
            InitializeComponent();
        }

        private void FormAjoutVoyage_Load(object sender, EventArgs e)
        {
            this.ChargerCombos();
        }

        /// <summary>
        ///     Fonction utilisée pour charger un resultat de requête SQL dans le DataSet global ds.
        /// </summary>
        /// <param name="req">Requête SQL</param>
        /// <param name="table">Nom de la table de ds dans laquelle va être stocké le resultat de la requête.</param>
        private void ChargerBDD(string req, string table)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(req, this.co);
            da.Fill(this.ds, table);
        }

        /// <summary>
        /// Procédure utilisée pour charger les ComboBox du form.
        /// </summary>
        private void ChargerCombos()
        {
            string reqHebergt = @"SELECT * FROM tblHebergement";
            string reqThematique = @"SELECT * FROM tblThematique";
            string reqClients = @"SELECT NumClient, NomClient+' '+Prenom AS Nom FROM tblClients";

            ChargerBDD(reqHebergt, "Hebergement");
            ChargerBDD(reqThematique, "Thematique");
            ChargerBDD(reqClients, "Clients");

            this.comboHebergement.DataSource = ds.Tables["Hebergement"];
            this.comboHebergement.DisplayMember = "NomCategorie";
            this.comboHebergement.ValueMember = "NumCategorie";

            this.comboThematique.DataSource = ds.Tables["Thematique"];
            this.comboThematique.DisplayMember = "libThem";
            this.comboThematique.ValueMember = "codeThem";

            foreach (ComboBox combo in new ComboBox[] { this.comboSelClient1, this.comboSelClient2, this.comboSelClient3 })
            {
                combo.DataSource = ds.Tables["Clients"];
                combo.DisplayMember = "Nom";
                combo.ValueMember = "NumClient";
                combo.SelectedIndex = -1;
            }


        }

        private void CheckInput(TextBox t, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string code = (string)textCode.Text;
                string destination = (string)textDest.Text;
                string description = (string)textDescr.Text;
                int thematique = (int)comboThematique.SelectedValue;
                int hebergement = (int)comboHebergement.SelectedValue;
                int nbJours = Convert.ToInt32(textNbJours.Text);
                int prix = Convert.ToInt32(textPrix.Text);
                string req = "INSERT INTO tblVoyages (CodeVoyage, Destination, Duree, TypeThematique, Description, Prix) VALUES (\"" + code + "\",\"" + destination + "\"," + nbJours + "," + thematique + ",\"" + description + "\"," + prix + ")";

                listeTransaction.Add(req);
                this.buttonValider.Enabled = false;
                this.tabBox.SelectedIndex = 1;
            }
            catch (FormatException)
            {
                MessageBox.Show("Attention, un champ est vide!");
            }
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            labelPhoto.Text = SelectFichier();
        }

        private void buttonVignette_Click(object sender, EventArgs e)
        {
            labelVignette.Text = SelectFichier();
        }

        /// <summary>
        /// Procédure qui ouvre un OpenFileDialog et retourne le fichier selectionné.
        /// </summary>
        /// <returns></returns>
        private string SelectFichier()
        {
            //TODO : Autoriser la selection d'images uniquement
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.ShowDialog();
            return ofd.FileName;
        }

        private void buttonRecap_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (string req in listeTransaction)
            {
                str += req + "\n";
            }
            MessageBox.Show(str);
        }

        private void construireReqReservation(string clientId, string nbPers, DateTime date)
        {
            string req;
            string formatDate = "#" + date.ToString("MM/dd/yyyy") + "#";

            req = "INSERT INTO tblReservations (NumClient, CodeVoyage, NombrePersonnes, DateReservation) VALUES (\"" + clientId + "\",\"" + textCode.Text + "\"," + nbPers + "\"," + formatDate + "\"";
            listeTransaction.Add(req);
        }

        private void buttonValiderTransaction_Click(object sender, EventArgs e)
        {
            OleDbTransaction transaction;

            construireReqReservation(comboSelClient1.SelectedValue.ToString(), textboxNbPers1.Text, dateTimePicker1.Value);
            construireReqReservation(comboSelClient2.SelectedValue.ToString(), textboxNbPers2.Text, dateTimePicker2.Value);
            construireReqReservation(comboSelClient3.SelectedValue.ToString(), textboxNbPers3.Text, dateTimePicker3.Value);

            co.Open();
            transaction = co.BeginTransaction();

            try
            {
                if (listeTransaction.Count > 1)
                {
                    foreach (string req in listeTransaction)
                    {
                        new OleDbCommand(req, co, transaction).ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
            catch (OleDbException)
            {
                transaction.Rollback();
            } 
            co.Close(); 
        }
    }
}