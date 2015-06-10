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

        public FormPanelAdmin(OleDbConnection co) : this()
        {
            this.co = co;
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
            /*string reqModifier = @"SELECT tblVoyages.*, tblHebergement.*, tblThematique.*
FROM ((tblVoyages INNER JOIN tblHebergement ON tblVoyages.TypeHebergement = tblHebergement.NumCategorie) INNER JOIN tblThematique ON tblVoyages.TypeThematique = tblThematique.codeThem)";*/
            string reqModifier = "SELECT * FROM tblVoyages";

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

        /// <summary>
        /// Execute la requête permettant d'ajouter un voyage, et remet les contrôles à 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                this.construireReqVoyage();
                this.activerTabReservation();
                this.buttonValider.Enabled = false;
                this.tabBox.SelectedIndex = 1;
            }
            catch (FormatException)
            {
                MessageBox.Show("Attention, un champ est vide!");
            }
        }

        /// <summary>
        /// Construit une requête permettant d'ajouter un voyage à partir des valeurs entrées dans l'onglet Ajout voyage
        /// </summary>
        private void construireReqVoyage()
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

        /// <summary>
        /// Affiche un récapitulatif de la transaction avant validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecap_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> recap = new Dictionary<string, string>();
            recap.Add("code", this.textCode.Text);
            recap.Add("dest", this.textDest.Text);
            recap.Add("prix", this.textPrix.Text);
            recap.Add("duree", this.textNbJours.Text);
            recap.Add("descr", this.textDescr.Text);
            recap.Add("themq", this.comboThematique.Text);
            recap.Add("hebergt", this.comboHebergement.Text);

            recap.Add("grp1Nom", this.comboSelClient1.Text);
            recap.Add("grp2Nom", this.comboSelClient2.Text);
            recap.Add("grp3Nom", this.comboSelClient3.Text);

            recap.Add("grp1nb", this.textboxNbPers1.Text);
            recap.Add("grp2nb", this.textboxNbPers2.Text);
            recap.Add("grp3nb", this.textboxNbPers3.Text);

            recap.Add("grp1date", this.dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            recap.Add("grp2date", this.dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            recap.Add("grp3date", this.dateTimePicker3.Value.ToString("dd/MM/yyyy"));

            new FormRecapTransaction(recap).Show();
        }

        /// <summary>
        /// Construit une requête permettant d'insérer une transaction à partir des valeurs passées en paramètre
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="nbPers"></param>
        /// <param name="date"></param>
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

        /// <summary>
        /// Fonction qui permet d'effectuer une transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValiderTransaction_Click(object sender, EventArgs e)
        {
            
            OleDbTransaction transaction;

            construireReqReservation(comboSelClient1, textboxNbPers1, dateTimePicker1.Value);
            construireReqReservation(comboSelClient2, textboxNbPers2, dateTimePicker2.Value);
            construireReqReservation(comboSelClient3, textboxNbPers3, dateTimePicker3.Value);

            DialogResult confirmation = MessageBox.Show("Etes-vous certain de vouloir ajouter ce voyage et ces réservations?","Comfirmez", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
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
                    this.Close();
                }
                catch (OleDbException ex)
                {
                    transaction.Rollback();
                    listeTransaction.Clear();
                    MessageBox.Show("ERREUR: Impossible d'effectuer la transaction!\n" + ex.Message);
                    foreach (string req in listeTransaction)
                    {
                        MessageBox.Show(req);
                    }
                }
                co.Close();
            }
        }

        /// <summary>
        /// Permet une remise à zero des onglets réservation et ajout voyage après une transaction
        /// </summary>
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

        /// <summary>
        /// Supprime le texte de tous les contrôles passés en paramètre 
        /// </summary>
        /// <param name="listControls"></param>
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

        /// <summary>
        /// Active l'onglet réservation
        /// </summary>
        private void activerTabReservation()
        {
            buttonValiderTransaction.Enabled = true;
            buttonRecap.Enabled = true;
            buttonAnnulerTransaction.Enabled = true;

            grpReservation1.Enabled = true;
            grpReservation2.Enabled = true;
            grpReservation3.Enabled = true;
        }

        /// <summary>
        /// Procédure chargant tous les contrôles de l'onglet modifier à chaque changement de la combobox ID 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// S'exécute après un clic sur le bouton supprimer une offre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
             DialogResult confirmation = MessageBox.Show("Etes-vous certain de vouloir supprimer ce voyage? ","Comfirmez", MessageBoxButtons.YesNo);
             if (confirmation == DialogResult.Yes)
             {
                 string req1 = "DELETE * FROM tblReservations WHERE CodeVoyage = '" + this.comboModCode.Text + "'";
                 string req2 = "DELETE * FROM tblVoyages WHERE CodeVoyage = '" + this.comboModCode.Text + "'";
                 OleDbCommand cmd = new OleDbCommand(req1, co);
                 // MessageBox.Show(req1 + "\n" + req2);
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

        /// <summary>
        /// evenement permettant de supprimer une offre sélectionnée dans l'interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Etes-vous certain de vouloir ajouter ce voyage et ces réservations?","Comfirmez", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                string req = "UPDATE tblVoyages SET Destination = '" + this.textModDest.Text + "',"
                                                 + "Duree = " + this.textModDuree.Text + ","
                                                 + "TypeThematique = " + this.comboModThemq.SelectedValue + ","
                                                 + "Description = '" + this.textModDescr.Text.Replace("'", " ") + "',"
                                                 + "Prix = " + this.textModPrix.Text + ","
                                                 + "Promotion = " + this.checkboxModPromo.Checked.ToString() + ","
                                                 + "TypeHebergement = '" + this.comboModHebergt.SelectedValue + "'";

                string finReq = " WHERE CodeVoyage='" + this.comboModCode.Text + "'";
                req += finReq;

                OleDbCommand cmd = new OleDbCommand(req, this.co);
                try
                {
                    this.co.Open();
                    MessageBox.Show(req);
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException)
                {
                    MessageBox.Show("ERREUR: Modification impossible!");
                }
                finally
                {
                    this.co.Close();
                }
            } 
        }
    }
}