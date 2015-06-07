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
        OleDbConnection co = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Documents\IUT\modules\A21\A21_Projet\Drakkair\Drakkair.mdb");

        List<string> listeTransaction = new List<string>();

        public FormPanelAdmin()
        {
            InitializeComponent();
        }

        private void FormAjoutVoyage_Load(object sender, EventArgs e)
        {
            this.ChargerCombos();


            this.textboxNbPers1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            this.textboxNbPers2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            this.textboxNbPers3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            this.textNbJours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            this.textPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);

            this.comboModCode.DataSource = ds.Tables["Voyages"];
            this.comboModCode.DisplayMember = "CodeVoyage";
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
            string reqModifier = @"SELECT tblVoyages.*, tblHebergement.*, tblThematique.*
FROM ((tblVoyages INNER JOIN tblHebergement ON tblVoyages.TypeHebergement = tblHebergement.NumCategorie) INNER JOIN tblThematique ON tblVoyages.TypeThematique = tblThematique.codeThem)";

            ChargerBDD(reqHebergt, "Hebergement");
            ChargerBDD(reqThematique, "Thematique");
            ChargerBDD(reqClients, "Clients");
            ChargerBDD(reqModifier, "Voyages");

            this.comboModHebergt.DataSource = ds.Tables["Hebergement"].Copy();
            this.comboModHebergt.DisplayMember = "NomCategorie";
            this.comboModHebergt.ValueMember = "NumCategorie";

            this.comboModThemq.DataSource = ds.Tables["Thematique"].Copy();
            this.comboModThemq.DisplayMember = "libThem";
            this.comboModThemq.ValueMember = "codeThem";

            this.comboHebergement.DataSource = ds.Tables["Hebergement"];
            this.comboHebergement.DisplayMember = "NomCategorie";
            this.comboHebergement.ValueMember = "NumCategorie";
          
            this.comboThematique.DataSource = ds.Tables["Thematique"];
            this.comboThematique.DisplayMember = "libThem";
            this.comboThematique.ValueMember = "codeThem";


            foreach (ComboBox combo in new ComboBox[] { this.comboSelClient1, this.comboSelClient2, this.comboSelClient3 })
            {
                combo.DataSource = ds.Tables["Clients"].Copy();
                combo.DisplayMember = "Nom";
                combo.ValueMember = "NumClient";
                combo.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Verifie que la touche pressée est bien un chiffre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckInput(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (!Char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
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
                string req = "INSERT INTO tblVoyages (CodeVoyage, Destination, Duree, TypeThematique, Description, Prix, TypeHebergement) VALUES ('" + code + "','" + destination + "'," + nbJours + "," + thematique + ",'" + description + "'," + prix + ",'" +hebergement+"')";

                listeTransaction.Add(req);
                this.activerTabReservation();
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

        private void construireReqReservation(ComboBox clientId, TextBox nbPers, DateTime date)
        {
            string req;
            try
            {
                if (!String.IsNullOrEmpty(clientId.SelectedValue.ToString()) || !String.IsNullOrEmpty(nbPers.Text.ToString()))
                {
                    string formatDate = "#" + date.ToString("MM/dd/yyyy") + "#";

                    req = "INSERT INTO tblReservations (NumClient, CodeVoyage, NombrePersonnes, DateReservation) VALUES (" 
                        + clientId.SelectedValue + ",'" + textCode.Text.ToString() 
                        + "'," + nbPers.Text.ToString() + "," + formatDate + ")";
                    listeTransaction.Add(req);
                }
            }
            catch (NullReferenceException) { };
        }

        private void buttonValiderTransaction_Click(object sender, EventArgs e)
        {
            
            OleDbTransaction transaction;

            construireReqReservation(comboSelClient1, textboxNbPers1, dateTimePicker1.Value);
            construireReqReservation(comboSelClient2, textboxNbPers2, dateTimePicker2.Value);
            construireReqReservation(comboSelClient3, textboxNbPers3, dateTimePicker3.Value);

            MessageBox.Show(listeTransaction[0]);
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
                listeTransaction.Clear();
                this.tabAjoutVoyage.Select();
                this.resetTabVoyage();
            }
            catch (OleDbException ex)
            {
                transaction.Rollback();
                MessageBox.Show("ERREUR: Impossible d'effectuer la transaction!\n"+ex.Message);
            } 
            co.Close(); 
             
            /*co.Open();
            new OleDbCommand("INSERT INTO tblVoyage VALUES (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)", co).ExecuteNonQuery();
            co.Close();*/
            
        }

        private void resetTabVoyage()
        {
            resetControls(this.tabAjoutVoyage.Controls);
            resetControls(this.grpReservation1.Controls);
            resetControls(this.grpReservation2.Controls);
            resetControls(this.grpReservation3.Controls);

            this.checkboxPromotion.Checked = false;
            this.buttonValiderTransaction.Enabled = false;
            this.buttonRecap.Enabled = false;
            this.buttonAnnulerTransaction.Enabled = false;
            this.buttonValider.Enabled = true;

            this.grpReservation1.Enabled = false;
            this.grpReservation2.Enabled = false;
            this.grpReservation3.Enabled = false;
        }

        private void resetControls(Control.ControlCollection listControls)
        {
            foreach (Control c in listControls)
            {
                if (c.GetType() != typeof(Button) && c.GetType() != typeof(Label) && c.GetType() != typeof(CheckBox))
                {
                    c.ResetText();
                }
            }

        }

        private void activerTabReservation()
        {
            buttonValiderTransaction.Enabled = true;
            buttonRecap.Enabled = true;
            buttonAnnulerTransaction.Enabled = true;

            grpReservation1.Enabled = true;
            grpReservation2.Enabled = true;
            grpReservation3.Enabled = true;
        }

        private void comboModCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboModThemq.SelectedValue = Convert.ToInt32(ds.Tables["Voyages"].Rows[this.comboModCode.SelectedIndex][3].ToString());
            this.comboModHebergt.SelectedValue = Convert.ToInt32(ds.Tables["Voyages"].Rows[this.comboModCode.SelectedIndex][9].ToString());

            this.textModDest.Text = ds.Tables["Voyages"].Rows[this.comboModCode.SelectedIndex][1].ToString();
            this.textModDuree.Text = ds.Tables["Voyages"].Rows[this.comboModCode.SelectedIndex][2].ToString();
            this.textModDescr.Text = ds.Tables["Voyages"].Rows[this.comboModCode.SelectedIndex][4].ToString();
            this.textModPrix.Text = ds.Tables["Voyages"].Rows[this.comboModCode.SelectedIndex][5].ToString();
            this.checkboxModPromo.Checked = Convert.ToBoolean(ds.Tables["Voyages"].Rows[this.comboModCode.SelectedIndex][6].ToString());
        }


        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            string req1 = "DELETE * FROM tblReservations WHERE CodeVoyage = '" + this.comboModCode.Text + "'";
            string req2 = "DELETE * FROM tblVoyages WHERE CodeVoyage = '" + this.comboModCode.Text + "'";
            OleDbCommand cmd = new OleDbCommand(req1, co);
            MessageBox.Show(req1 + "\n" + req2);
            try
            {
                co.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = req2;
                cmd.ExecuteScalar();
                co.Close();
                ds.Tables["Voyages"].Rows[comboModCode.SelectedIndex].Delete();
            }
            catch (OleDbException)
            {
                MessageBox.Show("ERREUR: Suppression echouée!");
            }
        }
    }
}