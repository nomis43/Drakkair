namespace Drakkair
{
	using System.Drawing;

    partial class FormPanelAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tabAjoutVoyage = new System.Windows.Forms.TabPage();
			this.labelVignette = new System.Windows.Forms.Label();
			this.labelPhoto = new System.Windows.Forms.Label();
			this.buttonVignette = new Drakkair.Controls.UserButton();
			this.buttonPhoto = new Drakkair.Controls.UserButton();
			this.checkboxPromotion = new System.Windows.Forms.CheckBox();
			this.buttonValider = new Drakkair.Controls.UserButton();
			this.lblNbJours = new System.Windows.Forms.Label();
			this.lblPrix = new System.Windows.Forms.Label();
			this.textPrix = new Drakkair.Controls.UserTextBox();
			this.textNbJours = new Drakkair.Controls.UserTextBox();
			this.textDescr = new Drakkair.Controls.UserTextBox();
			this.textDest = new Drakkair.Controls.UserTextBox();
			this.textCode = new Drakkair.Controls.UserTextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblDestination = new System.Windows.Forms.Label();
			this.lblCode = new System.Windows.Forms.Label();
			this.lblHebergement = new System.Windows.Forms.Label();
			this.lblThematique = new System.Windows.Forms.Label();
			this.comboHebergement = new System.Windows.Forms.ComboBox();
			this.comboThematique = new System.Windows.Forms.ComboBox();
			this.tabBox = new System.Windows.Forms.TabControl();
			this.tabAjoutReservations = new System.Windows.Forms.TabPage();
			this.buttonAnnulerTransaction = new Drakkair.Controls.UserButton();
			this.buttonValiderTransaction = new Drakkair.Controls.UserButton();
			this.buttonRecap = new Drakkair.Controls.UserButton();
			this.grpReservation1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textboxNbPers1 = new Drakkair.Controls.UserTextBox();
			this.comboSelClient1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grpReservation2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.textboxNbPers2 = new Drakkair.Controls.UserTextBox();
			this.comboSelClient2 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.grpReservation3 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.textboxNbPers3 = new Drakkair.Controls.UserTextBox();
			this.comboSelClient3 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tabModif = new System.Windows.Forms.TabPage();
			this.buttonSupprimer = new Drakkair.Controls.UserButton();
			this.comboModCode = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.buttonModVignette = new Drakkair.Controls.UserButton();
			this.buttonModPhoto = new Drakkair.Controls.UserButton();
			this.checkboxModPromo = new System.Windows.Forms.CheckBox();
			this.buttonModifier = new Drakkair.Controls.UserButton();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textModPrix = new Drakkair.Controls.UserTextBox();
			this.textModDuree = new Drakkair.Controls.UserTextBox();
			this.textModDescr = new Drakkair.Controls.UserTextBox();
			this.textModDest = new Drakkair.Controls.UserTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.comboModHebergt = new System.Windows.Forms.ComboBox();
			this.comboModThemq = new System.Windows.Forms.ComboBox();
			this.tabAjoutVoyage.SuspendLayout();
			this.tabBox.SuspendLayout();
			this.tabAjoutReservations.SuspendLayout();
			this.grpReservation1.SuspendLayout();
			this.grpReservation2.SuspendLayout();
			this.grpReservation3.SuspendLayout();
			this.tabModif.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabAjoutVoyage
			// 
			this.tabAjoutVoyage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tabAjoutVoyage.Controls.Add(this.labelVignette);
			this.tabAjoutVoyage.Controls.Add(this.labelPhoto);
			this.tabAjoutVoyage.Controls.Add(this.buttonVignette);
			this.tabAjoutVoyage.Controls.Add(this.buttonPhoto);
			this.tabAjoutVoyage.Controls.Add(this.checkboxPromotion);
			this.tabAjoutVoyage.Controls.Add(this.buttonValider);
			this.tabAjoutVoyage.Controls.Add(this.lblNbJours);
			this.tabAjoutVoyage.Controls.Add(this.lblPrix);
			this.tabAjoutVoyage.Controls.Add(this.textPrix);
			this.tabAjoutVoyage.Controls.Add(this.textNbJours);
			this.tabAjoutVoyage.Controls.Add(this.textDescr);
			this.tabAjoutVoyage.Controls.Add(this.textDest);
			this.tabAjoutVoyage.Controls.Add(this.textCode);
			this.tabAjoutVoyage.Controls.Add(this.lblDescription);
			this.tabAjoutVoyage.Controls.Add(this.lblDestination);
			this.tabAjoutVoyage.Controls.Add(this.lblCode);
			this.tabAjoutVoyage.Controls.Add(this.lblHebergement);
			this.tabAjoutVoyage.Controls.Add(this.lblThematique);
			this.tabAjoutVoyage.Controls.Add(this.comboHebergement);
			this.tabAjoutVoyage.Controls.Add(this.comboThematique);
			this.tabAjoutVoyage.Location = new System.Drawing.Point(4, 28);
			this.tabAjoutVoyage.Margin = new System.Windows.Forms.Padding(4);
			this.tabAjoutVoyage.Name = "tabAjoutVoyage";
			this.tabAjoutVoyage.Padding = new System.Windows.Forms.Padding(4);
			this.tabAjoutVoyage.Size = new System.Drawing.Size(849, 542);
			this.tabAjoutVoyage.TabIndex = 0;
			this.tabAjoutVoyage.Text = "Ajout voyage";
			// 
			// labelVignette
			// 
			this.labelVignette.AutoSize = true;
			this.labelVignette.Location = new System.Drawing.Point(139, 171);
			this.labelVignette.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelVignette.Name = "labelVignette";
			this.labelVignette.Size = new System.Drawing.Size(21, 20);
			this.labelVignette.TabIndex = 19;
			this.labelVignette.Text = "...";
			// 
			// labelPhoto
			// 
			this.labelPhoto.AutoSize = true;
			this.labelPhoto.Location = new System.Drawing.Point(139, 129);
			this.labelPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPhoto.Name = "labelPhoto";
			this.labelPhoto.Size = new System.Drawing.Size(21, 20);
			this.labelPhoto.TabIndex = 18;
			this.labelPhoto.Text = "...";
			// 
			// buttonVignette
			// 
			this.buttonVignette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonVignette.AutoSize = true;
			this.buttonVignette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonVignette.FlatAppearance.BorderSize = 0;
			this.buttonVignette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVignette.Location = new System.Drawing.Point(18, 164);
			this.buttonVignette.Margin = new System.Windows.Forms.Padding(4);
			this.buttonVignette.Name = "buttonVignette";
			this.buttonVignette.Size = new System.Drawing.Size(117, 34);
			this.buttonVignette.TabIndex = 17;
			this.buttonVignette.Text = "Ajout Vignette";
			this.buttonVignette.UseVisualStyleBackColor = true;
			this.buttonVignette.Click += new System.EventHandler(this.buttonVignette_Click);
			// 
			// buttonPhoto
			// 
			this.buttonPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPhoto.AutoSize = true;
			this.buttonPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonPhoto.FlatAppearance.BorderSize = 0;
			this.buttonPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPhoto.Location = new System.Drawing.Point(23, 121);
			this.buttonPhoto.Margin = new System.Windows.Forms.Padding(4);
			this.buttonPhoto.Name = "buttonPhoto";
			this.buttonPhoto.Size = new System.Drawing.Size(112, 34);
			this.buttonPhoto.TabIndex = 16;
			this.buttonPhoto.Text = "Ajout Photo";
			this.buttonPhoto.UseVisualStyleBackColor = true;
			this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
			// 
			// checkboxPromotion
			// 
			this.checkboxPromotion.AutoSize = true;
			this.checkboxPromotion.Location = new System.Drawing.Point(143, 487);
			this.checkboxPromotion.Margin = new System.Windows.Forms.Padding(4);
			this.checkboxPromotion.Name = "checkboxPromotion";
			this.checkboxPromotion.Size = new System.Drawing.Size(102, 24);
			this.checkboxPromotion.TabIndex = 15;
			this.checkboxPromotion.Text = "Promotion";
			this.checkboxPromotion.UseVisualStyleBackColor = true;
			// 
			// buttonValider
			// 
			this.buttonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonValider.AutoSize = true;
			this.buttonValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonValider.FlatAppearance.BorderSize = 0;
			this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonValider.Location = new System.Drawing.Point(708, 481);
			this.buttonValider.Margin = new System.Windows.Forms.Padding(4);
			this.buttonValider.Name = "buttonValider";
			this.buttonValider.Size = new System.Drawing.Size(100, 34);
			this.buttonValider.TabIndex = 14;
			this.buttonValider.Text = "Valider";
			this.buttonValider.UseVisualStyleBackColor = true;
			this.buttonValider.Click += new System.EventHandler(this.btnAjouter_Click);
			// 
			// lblNbJours
			// 
			this.lblNbJours.AutoSize = true;
			this.lblNbJours.Location = new System.Drawing.Point(19, 438);
			this.lblNbJours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNbJours.Name = "lblNbJours";
			this.lblNbJours.Size = new System.Drawing.Size(126, 20);
			this.lblNbJours.TabIndex = 13;
			this.lblNbJours.Text = "Nombre de jours";
			// 
			// lblPrix
			// 
			this.lblPrix.AutoSize = true;
			this.lblPrix.Location = new System.Drawing.Point(627, 438);
			this.lblPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrix.Name = "lblPrix";
			this.lblPrix.Size = new System.Drawing.Size(36, 20);
			this.lblPrix.TabIndex = 12;
			this.lblPrix.Text = "Prix";
			// 
			// textPrix
			// 
			this.textPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrix.ForeColor = System.Drawing.Color.White;
			this.textPrix.Location = new System.Drawing.Point(675, 434);
			this.textPrix.Margin = new System.Windows.Forms.Padding(4);
			this.textPrix.Name = "textPrix";
			this.textPrix.Size = new System.Drawing.Size(132, 27);
			this.textPrix.TabIndex = 11;
			// 
			// textNbJours
			// 
			this.textNbJours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textNbJours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNbJours.ForeColor = System.Drawing.Color.White;
			this.textNbJours.Location = new System.Drawing.Point(153, 434);
			this.textNbJours.Margin = new System.Windows.Forms.Padding(4);
			this.textNbJours.Name = "textNbJours";
			this.textNbJours.Size = new System.Drawing.Size(132, 27);
			this.textNbJours.TabIndex = 10;
			// 
			// textDescr
			// 
			this.textDescr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDescr.ForeColor = System.Drawing.Color.White;
			this.textDescr.Location = new System.Drawing.Point(143, 219);
			this.textDescr.Margin = new System.Windows.Forms.Padding(4);
			this.textDescr.Multiline = true;
			this.textDescr.Name = "textDescr";
			this.textDescr.Size = new System.Drawing.Size(664, 188);
			this.textDescr.TabIndex = 8;
			// 
			// textDest
			// 
			this.textDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDest.ForeColor = System.Drawing.Color.White;
			this.textDest.Location = new System.Drawing.Point(143, 76);
			this.textDest.Margin = new System.Windows.Forms.Padding(4);
			this.textDest.Name = "textDest";
			this.textDest.Size = new System.Drawing.Size(193, 27);
			this.textDest.TabIndex = 7;
			// 
			// textCode
			// 
			this.textCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCode.ForeColor = System.Drawing.Color.White;
			this.textCode.Location = new System.Drawing.Point(143, 22);
			this.textCode.Margin = new System.Windows.Forms.Padding(4);
			this.textCode.Name = "textCode";
			this.textCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textCode.Size = new System.Drawing.Size(193, 27);
			this.textCode.TabIndex = 5;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(31, 224);
			this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(88, 20);
			this.lblDescription.TabIndex = 9;
			this.lblDescription.Text = "Description";
			// 
			// lblDestination
			// 
			this.lblDestination.AutoSize = true;
			this.lblDestination.Location = new System.Drawing.Point(31, 80);
			this.lblDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDestination.Name = "lblDestination";
			this.lblDestination.Size = new System.Drawing.Size(88, 20);
			this.lblDestination.TabIndex = 6;
			this.lblDestination.Text = "Destination";
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(31, 26);
			this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(109, 20);
			this.lblCode.TabIndex = 4;
			this.lblCode.Text = "Code de l\'offre";
			// 
			// lblHebergement
			// 
			this.lblHebergement.AutoSize = true;
			this.lblHebergement.Location = new System.Drawing.Point(493, 80);
			this.lblHebergement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHebergement.Name = "lblHebergement";
			this.lblHebergement.Size = new System.Drawing.Size(103, 20);
			this.lblHebergement.TabIndex = 3;
			this.lblHebergement.Text = "Hébergement";
			// 
			// lblThematique
			// 
			this.lblThematique.AutoSize = true;
			this.lblThematique.Location = new System.Drawing.Point(504, 26);
			this.lblThematique.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblThematique.Name = "lblThematique";
			this.lblThematique.Size = new System.Drawing.Size(91, 20);
			this.lblThematique.TabIndex = 2;
			this.lblThematique.Text = "Thématique";
			// 
			// comboHebergement
			// 
			this.comboHebergement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboHebergement.FormattingEnabled = true;
			this.comboHebergement.Location = new System.Drawing.Point(612, 76);
			this.comboHebergement.Margin = new System.Windows.Forms.Padding(4);
			this.comboHebergement.Name = "comboHebergement";
			this.comboHebergement.Size = new System.Drawing.Size(195, 27);
			this.comboHebergement.TabIndex = 1;
			// 
			// comboThematique
			// 
			this.comboThematique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboThematique.FormattingEnabled = true;
			this.comboThematique.Location = new System.Drawing.Point(612, 22);
			this.comboThematique.Margin = new System.Windows.Forms.Padding(4);
			this.comboThematique.Name = "comboThematique";
			this.comboThematique.Size = new System.Drawing.Size(195, 27);
			this.comboThematique.TabIndex = 0;
			// 
			// tabBox
			// 
			this.tabBox.Controls.Add(this.tabAjoutVoyage);
			this.tabBox.Controls.Add(this.tabAjoutReservations);
			this.tabBox.Controls.Add(this.tabModif);
			this.tabBox.Location = new System.Drawing.Point(17, 18);
			this.tabBox.Margin = new System.Windows.Forms.Padding(4);
			this.tabBox.Name = "tabBox";
			this.tabBox.SelectedIndex = 0;
			this.tabBox.Size = new System.Drawing.Size(857, 574);
			this.tabBox.TabIndex = 0;
			// 
			// tabAjoutReservations
			// 
			this.tabAjoutReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tabAjoutReservations.Controls.Add(this.buttonAnnulerTransaction);
			this.tabAjoutReservations.Controls.Add(this.buttonValiderTransaction);
			this.tabAjoutReservations.Controls.Add(this.buttonRecap);
			this.tabAjoutReservations.Controls.Add(this.grpReservation1);
			this.tabAjoutReservations.Controls.Add(this.grpReservation2);
			this.tabAjoutReservations.Controls.Add(this.grpReservation3);
			this.tabAjoutReservations.Location = new System.Drawing.Point(4, 28);
			this.tabAjoutReservations.Margin = new System.Windows.Forms.Padding(4);
			this.tabAjoutReservations.Name = "tabAjoutReservations";
			this.tabAjoutReservations.Padding = new System.Windows.Forms.Padding(4);
			this.tabAjoutReservations.Size = new System.Drawing.Size(849, 542);
			this.tabAjoutReservations.TabIndex = 1;
			this.tabAjoutReservations.Text = "Réservations";
			// 
			// buttonAnnulerTransaction
			// 
			this.buttonAnnulerTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAnnulerTransaction.AutoSize = true;
			this.buttonAnnulerTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonAnnulerTransaction.Enabled = false;
			this.buttonAnnulerTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.buttonAnnulerTransaction.FlatAppearance.BorderSize = 0;
			this.buttonAnnulerTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAnnulerTransaction.Location = new System.Drawing.Point(538, 490);
			this.buttonAnnulerTransaction.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAnnulerTransaction.Name = "buttonAnnulerTransaction";
			this.buttonAnnulerTransaction.Size = new System.Drawing.Size(166, 35);
			this.buttonAnnulerTransaction.TabIndex = 8;
			this.buttonAnnulerTransaction.Text = "Annuler transaction";
			this.buttonAnnulerTransaction.UseVisualStyleBackColor = true;
			this.buttonAnnulerTransaction.Click += new System.EventHandler(this.buttonAnnulerTransaction_Click);
			// 
			// buttonValiderTransaction
			// 
			this.buttonValiderTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonValiderTransaction.AutoSize = true;
			this.buttonValiderTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonValiderTransaction.Enabled = false;
			this.buttonValiderTransaction.FlatAppearance.BorderSize = 0;
			this.buttonValiderTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonValiderTransaction.Location = new System.Drawing.Point(359, 491);
			this.buttonValiderTransaction.Margin = new System.Windows.Forms.Padding(4);
			this.buttonValiderTransaction.Name = "buttonValiderTransaction";
			this.buttonValiderTransaction.Size = new System.Drawing.Size(152, 34);
			this.buttonValiderTransaction.TabIndex = 9;
			this.buttonValiderTransaction.Text = "Valider transaction";
			this.buttonValiderTransaction.UseVisualStyleBackColor = true;
			this.buttonValiderTransaction.Click += new System.EventHandler(this.buttonValiderTransaction_Click);
			// 
			// buttonRecap
			// 
			this.buttonRecap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRecap.AutoSize = true;
			this.buttonRecap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonRecap.Enabled = false;
			this.buttonRecap.FlatAppearance.BorderSize = 0;
			this.buttonRecap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRecap.Location = new System.Drawing.Point(167, 491);
			this.buttonRecap.Margin = new System.Windows.Forms.Padding(4);
			this.buttonRecap.Name = "buttonRecap";
			this.buttonRecap.Size = new System.Drawing.Size(149, 34);
			this.buttonRecap.TabIndex = 10;
			this.buttonRecap.Text = "Récapitulatif";
			this.buttonRecap.UseVisualStyleBackColor = true;
			this.buttonRecap.Click += new System.EventHandler(this.buttonRecap_Click);
			// 
			// grpReservation1
			// 
			this.grpReservation1.Controls.Add(this.label3);
			this.grpReservation1.Controls.Add(this.dateTimePicker1);
			this.grpReservation1.Controls.Add(this.textboxNbPers1);
			this.grpReservation1.Controls.Add(this.comboSelClient1);
			this.grpReservation1.Controls.Add(this.label2);
			this.grpReservation1.Controls.Add(this.label1);
			this.grpReservation1.Enabled = false;
			this.grpReservation1.ForeColor = System.Drawing.Color.White;
			this.grpReservation1.Location = new System.Drawing.Point(8, 9);
			this.grpReservation1.Margin = new System.Windows.Forms.Padding(4);
			this.grpReservation1.Name = "grpReservation1";
			this.grpReservation1.Padding = new System.Windows.Forms.Padding(4);
			this.grpReservation1.Size = new System.Drawing.Size(827, 152);
			this.grpReservation1.TabIndex = 0;
			this.grpReservation1.TabStop = false;
			this.grpReservation1.Text = "Réservation n°1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(504, 91);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Date de réservation";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "ddMMyyyy";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(659, 91);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(133, 27);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// textboxNbPers1
			// 
			this.textboxNbPers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textboxNbPers1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textboxNbPers1.ForeColor = System.Drawing.Color.White;
			this.textboxNbPers1.Location = new System.Drawing.Point(192, 93);
			this.textboxNbPers1.Margin = new System.Windows.Forms.Padding(4);
			this.textboxNbPers1.Name = "textboxNbPers1";
			this.textboxNbPers1.Size = new System.Drawing.Size(111, 27);
			this.textboxNbPers1.TabIndex = 3;
			// 
			// comboSelClient1
			// 
			this.comboSelClient1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSelClient1.FormattingEnabled = true;
			this.comboSelClient1.Location = new System.Drawing.Point(177, 44);
			this.comboSelClient1.Margin = new System.Windows.Forms.Padding(4);
			this.comboSelClient1.Name = "comboSelClient1";
			this.comboSelClient1.Size = new System.Drawing.Size(309, 27);
			this.comboSelClient1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre de personnes";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 48);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sélectionner client";
			// 
			// grpReservation2
			// 
			this.grpReservation2.Controls.Add(this.label4);
			this.grpReservation2.Controls.Add(this.dateTimePicker2);
			this.grpReservation2.Controls.Add(this.textboxNbPers2);
			this.grpReservation2.Controls.Add(this.comboSelClient2);
			this.grpReservation2.Controls.Add(this.label5);
			this.grpReservation2.Controls.Add(this.label6);
			this.grpReservation2.Enabled = false;
			this.grpReservation2.ForeColor = System.Drawing.Color.White;
			this.grpReservation2.Location = new System.Drawing.Point(8, 170);
			this.grpReservation2.Margin = new System.Windows.Forms.Padding(4);
			this.grpReservation2.Name = "grpReservation2";
			this.grpReservation2.Padding = new System.Windows.Forms.Padding(4);
			this.grpReservation2.Size = new System.Drawing.Size(827, 152);
			this.grpReservation2.TabIndex = 6;
			this.grpReservation2.TabStop = false;
			this.grpReservation2.Text = "Réservation n°2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(504, 91);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Date de réservation";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "ddMMyyyy";
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(659, 91);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(133, 27);
			this.dateTimePicker2.TabIndex = 4;
			// 
			// textboxNbPers2
			// 
			this.textboxNbPers2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textboxNbPers2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textboxNbPers2.ForeColor = System.Drawing.Color.White;
			this.textboxNbPers2.Location = new System.Drawing.Point(192, 91);
			this.textboxNbPers2.Margin = new System.Windows.Forms.Padding(4);
			this.textboxNbPers2.Name = "textboxNbPers2";
			this.textboxNbPers2.Size = new System.Drawing.Size(111, 27);
			this.textboxNbPers2.TabIndex = 3;
			// 
			// comboSelClient2
			// 
			this.comboSelClient2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSelClient2.FormattingEnabled = true;
			this.comboSelClient2.Location = new System.Drawing.Point(177, 44);
			this.comboSelClient2.Margin = new System.Windows.Forms.Padding(4);
			this.comboSelClient2.Name = "comboSelClient2";
			this.comboSelClient2.Size = new System.Drawing.Size(309, 27);
			this.comboSelClient2.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 95);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Nombre de personnes";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 48);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Sélectionner client";
			// 
			// grpReservation3
			// 
			this.grpReservation3.Controls.Add(this.label7);
			this.grpReservation3.Controls.Add(this.dateTimePicker3);
			this.grpReservation3.Controls.Add(this.textboxNbPers3);
			this.grpReservation3.Controls.Add(this.comboSelClient3);
			this.grpReservation3.Controls.Add(this.label8);
			this.grpReservation3.Controls.Add(this.label9);
			this.grpReservation3.Enabled = false;
			this.grpReservation3.ForeColor = System.Drawing.Color.White;
			this.grpReservation3.Location = new System.Drawing.Point(8, 330);
			this.grpReservation3.Margin = new System.Windows.Forms.Padding(4);
			this.grpReservation3.Name = "grpReservation3";
			this.grpReservation3.Padding = new System.Windows.Forms.Padding(4);
			this.grpReservation3.Size = new System.Drawing.Size(827, 152);
			this.grpReservation3.TabIndex = 7;
			this.grpReservation3.TabStop = false;
			this.grpReservation3.Text = "Réservation n°3";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(504, 91);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 20);
			this.label7.TabIndex = 5;
			this.label7.Text = "Date de réservation";
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.CustomFormat = "ddMMyyyy";
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker3.Location = new System.Drawing.Point(659, 91);
			this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(133, 27);
			this.dateTimePicker3.TabIndex = 4;
			// 
			// textboxNbPers3
			// 
			this.textboxNbPers3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textboxNbPers3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textboxNbPers3.ForeColor = System.Drawing.Color.White;
			this.textboxNbPers3.Location = new System.Drawing.Point(192, 89);
			this.textboxNbPers3.Margin = new System.Windows.Forms.Padding(4);
			this.textboxNbPers3.Name = "textboxNbPers3";
			this.textboxNbPers3.Size = new System.Drawing.Size(111, 27);
			this.textboxNbPers3.TabIndex = 3;
			// 
			// comboSelClient3
			// 
			this.comboSelClient3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSelClient3.FormattingEnabled = true;
			this.comboSelClient3.Location = new System.Drawing.Point(177, 44);
			this.comboSelClient3.Margin = new System.Windows.Forms.Padding(4);
			this.comboSelClient3.Name = "comboSelClient3";
			this.comboSelClient3.Size = new System.Drawing.Size(309, 27);
			this.comboSelClient3.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 95);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(163, 20);
			this.label8.TabIndex = 1;
			this.label8.Text = "Nombre de personnes";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(21, 48);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(135, 20);
			this.label9.TabIndex = 0;
			this.label9.Text = "Sélectionner client";
			// 
			// tabModif
			// 
			this.tabModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tabModif.Controls.Add(this.buttonSupprimer);
			this.tabModif.Controls.Add(this.comboModCode);
			this.tabModif.Controls.Add(this.label10);
			this.tabModif.Controls.Add(this.label11);
			this.tabModif.Controls.Add(this.buttonModVignette);
			this.tabModif.Controls.Add(this.buttonModPhoto);
			this.tabModif.Controls.Add(this.checkboxModPromo);
			this.tabModif.Controls.Add(this.buttonModifier);
			this.tabModif.Controls.Add(this.label12);
			this.tabModif.Controls.Add(this.label13);
			this.tabModif.Controls.Add(this.textModPrix);
			this.tabModif.Controls.Add(this.textModDuree);
			this.tabModif.Controls.Add(this.textModDescr);
			this.tabModif.Controls.Add(this.textModDest);
			this.tabModif.Controls.Add(this.label14);
			this.tabModif.Controls.Add(this.label15);
			this.tabModif.Controls.Add(this.label16);
			this.tabModif.Controls.Add(this.label17);
			this.tabModif.Controls.Add(this.label18);
			this.tabModif.Controls.Add(this.comboModHebergt);
			this.tabModif.Controls.Add(this.comboModThemq);
			this.tabModif.Location = new System.Drawing.Point(4, 28);
			this.tabModif.Margin = new System.Windows.Forms.Padding(4);
			this.tabModif.Name = "tabModif";
			this.tabModif.Padding = new System.Windows.Forms.Padding(4);
			this.tabModif.Size = new System.Drawing.Size(849, 542);
			this.tabModif.TabIndex = 2;
			this.tabModif.Text = "Modifier voyage";
			// 
			// buttonSupprimer
			// 
			this.buttonSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSupprimer.AutoSize = true;
			this.buttonSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonSupprimer.FlatAppearance.BorderSize = 0;
			this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSupprimer.Location = new System.Drawing.Point(581, 481);
			this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSupprimer.Name = "buttonSupprimer";
			this.buttonSupprimer.Size = new System.Drawing.Size(100, 34);
			this.buttonSupprimer.TabIndex = 41;
			this.buttonSupprimer.Text = "Supprimer";
			this.buttonSupprimer.UseVisualStyleBackColor = true;
			this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
			// 
			// comboModCode
			// 
			this.comboModCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModCode.FormattingEnabled = true;
			this.comboModCode.Location = new System.Drawing.Point(149, 20);
			this.comboModCode.Margin = new System.Windows.Forms.Padding(4);
			this.comboModCode.Name = "comboModCode";
			this.comboModCode.Size = new System.Drawing.Size(193, 27);
			this.comboModCode.TabIndex = 40;
			this.comboModCode.SelectedIndexChanged += new System.EventHandler(this.comboModCode_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(145, 171);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(21, 20);
			this.label10.TabIndex = 39;
			this.label10.Text = "...";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(145, 129);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(21, 20);
			this.label11.TabIndex = 38;
			this.label11.Text = "...";
			// 
			// buttonModVignette
			// 
			this.buttonModVignette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonModVignette.AutoSize = true;
			this.buttonModVignette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonModVignette.FlatAppearance.BorderSize = 0;
			this.buttonModVignette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModVignette.Location = new System.Drawing.Point(24, 164);
			this.buttonModVignette.Margin = new System.Windows.Forms.Padding(4);
			this.buttonModVignette.Name = "buttonModVignette";
			this.buttonModVignette.Size = new System.Drawing.Size(117, 34);
			this.buttonModVignette.TabIndex = 37;
			this.buttonModVignette.Text = "Ajout Vignette";
			this.buttonModVignette.UseVisualStyleBackColor = true;
			// 
			// buttonModPhoto
			// 
			this.buttonModPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonModPhoto.AutoSize = true;
			this.buttonModPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonModPhoto.FlatAppearance.BorderSize = 0;
			this.buttonModPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModPhoto.Location = new System.Drawing.Point(29, 121);
			this.buttonModPhoto.Margin = new System.Windows.Forms.Padding(4);
			this.buttonModPhoto.Name = "buttonModPhoto";
			this.buttonModPhoto.Size = new System.Drawing.Size(112, 34);
			this.buttonModPhoto.TabIndex = 36;
			this.buttonModPhoto.Text = "Ajout Photo";
			this.buttonModPhoto.UseVisualStyleBackColor = true;
			// 
			// checkboxModPromo
			// 
			this.checkboxModPromo.AutoSize = true;
			this.checkboxModPromo.Location = new System.Drawing.Point(149, 487);
			this.checkboxModPromo.Margin = new System.Windows.Forms.Padding(4);
			this.checkboxModPromo.Name = "checkboxModPromo";
			this.checkboxModPromo.Size = new System.Drawing.Size(102, 24);
			this.checkboxModPromo.TabIndex = 35;
			this.checkboxModPromo.Text = "Promotion";
			this.checkboxModPromo.UseVisualStyleBackColor = true;
			// 
			// buttonModifier
			// 
			this.buttonModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonModifier.AutoSize = true;
			this.buttonModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonModifier.FlatAppearance.BorderSize = 0;
			this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModifier.Location = new System.Drawing.Point(715, 481);
			this.buttonModifier.Margin = new System.Windows.Forms.Padding(4);
			this.buttonModifier.Name = "buttonModifier";
			this.buttonModifier.Size = new System.Drawing.Size(100, 34);
			this.buttonModifier.TabIndex = 34;
			this.buttonModifier.Text = "Modifier";
			this.buttonModifier.UseVisualStyleBackColor = true;
			this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(25, 438);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(126, 20);
			this.label12.TabIndex = 33;
			this.label12.Text = "Nombre de jours";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(633, 438);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(36, 20);
			this.label13.TabIndex = 32;
			this.label13.Text = "Prix";
			// 
			// textModPrix
			// 
			this.textModPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textModPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textModPrix.ForeColor = System.Drawing.Color.White;
			this.textModPrix.Location = new System.Drawing.Point(677, 436);
			this.textModPrix.Margin = new System.Windows.Forms.Padding(4);
			this.textModPrix.Name = "textModPrix";
			this.textModPrix.Size = new System.Drawing.Size(132, 27);
			this.textModPrix.TabIndex = 31;
			// 
			// textModDuree
			// 
			this.textModDuree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textModDuree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textModDuree.ForeColor = System.Drawing.Color.White;
			this.textModDuree.Location = new System.Drawing.Point(159, 434);
			this.textModDuree.Margin = new System.Windows.Forms.Padding(4);
			this.textModDuree.Name = "textModDuree";
			this.textModDuree.Size = new System.Drawing.Size(132, 27);
			this.textModDuree.TabIndex = 30;
			// 
			// textModDescr
			// 
			this.textModDescr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textModDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textModDescr.ForeColor = System.Drawing.Color.White;
			this.textModDescr.Location = new System.Drawing.Point(149, 219);
			this.textModDescr.Margin = new System.Windows.Forms.Padding(4);
			this.textModDescr.Multiline = true;
			this.textModDescr.Name = "textModDescr";
			this.textModDescr.Size = new System.Drawing.Size(664, 188);
			this.textModDescr.TabIndex = 28;
			// 
			// textModDest
			// 
			this.textModDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textModDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textModDest.ForeColor = System.Drawing.Color.White;
			this.textModDest.Location = new System.Drawing.Point(149, 76);
			this.textModDest.Margin = new System.Windows.Forms.Padding(4);
			this.textModDest.Name = "textModDest";
			this.textModDest.Size = new System.Drawing.Size(193, 27);
			this.textModDest.TabIndex = 27;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(37, 224);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(88, 20);
			this.label14.TabIndex = 29;
			this.label14.Text = "Description";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(37, 80);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(88, 20);
			this.label15.TabIndex = 26;
			this.label15.Text = "Destination";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(37, 26);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(109, 20);
			this.label16.TabIndex = 24;
			this.label16.Text = "Code de l\'offre";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(500, 80);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(103, 20);
			this.label17.TabIndex = 23;
			this.label17.Text = "Hébergement";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(511, 26);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(91, 20);
			this.label18.TabIndex = 22;
			this.label18.Text = "Thématique";
			// 
			// comboModHebergt
			// 
			this.comboModHebergt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModHebergt.FormattingEnabled = true;
			this.comboModHebergt.Location = new System.Drawing.Point(619, 76);
			this.comboModHebergt.Margin = new System.Windows.Forms.Padding(4);
			this.comboModHebergt.Name = "comboModHebergt";
			this.comboModHebergt.Size = new System.Drawing.Size(195, 27);
			this.comboModHebergt.TabIndex = 21;
			// 
			// comboModThemq
			// 
			this.comboModThemq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModThemq.FormattingEnabled = true;
			this.comboModThemq.Location = new System.Drawing.Point(619, 22);
			this.comboModThemq.Margin = new System.Windows.Forms.Padding(4);
			this.comboModThemq.Name = "comboModThemq";
			this.comboModThemq.Size = new System.Drawing.Size(195, 27);
			this.comboModThemq.TabIndex = 20;
			// 
			// FormPanelAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(885, 601);
			this.Controls.Add(this.tabBox);
			this.Font = new System.Drawing.Font("Open Sans", 10.8F);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(901, 639);
			this.MinimumSize = new System.Drawing.Size(901, 639);
			this.Name = "FormPanelAdmin";
			this.Text = "Ajout d\'un voyage";
			this.Load += new System.EventHandler(this.FormAjoutVoyage_Load);
			this.tabAjoutVoyage.ResumeLayout(false);
			this.tabAjoutVoyage.PerformLayout();
			this.tabBox.ResumeLayout(false);
			this.tabAjoutReservations.ResumeLayout(false);
			this.tabAjoutReservations.PerformLayout();
			this.grpReservation1.ResumeLayout(false);
			this.grpReservation1.PerformLayout();
			this.grpReservation2.ResumeLayout(false);
			this.grpReservation2.PerformLayout();
			this.grpReservation3.ResumeLayout(false);
			this.grpReservation3.PerformLayout();
			this.tabModif.ResumeLayout(false);
			this.tabModif.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAjoutVoyage;
        private System.Windows.Forms.Label labelVignette;
        private System.Windows.Forms.Label labelPhoto;
        private Controls.UserButton buttonVignette;
        private Controls.UserButton buttonPhoto;
        private System.Windows.Forms.CheckBox checkboxPromotion;
        private Controls.UserButton buttonValider;
        private System.Windows.Forms.Label lblNbJours;
        private System.Windows.Forms.Label lblPrix;
        private Controls.UserTextBox textPrix;
        private Controls.UserTextBox textNbJours;
        private Controls.UserTextBox textDescr;
        private Controls.UserTextBox textDest;
        private Controls.UserTextBox textCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblHebergement;
        private System.Windows.Forms.Label lblThematique;
        private System.Windows.Forms.ComboBox comboHebergement;
        private System.Windows.Forms.ComboBox comboThematique;
        private System.Windows.Forms.TabControl tabBox;
        private System.Windows.Forms.TabPage tabAjoutReservations;
        private Controls.UserButton buttonAnnulerTransaction;
        private Controls.UserButton buttonValiderTransaction;
        private Controls.UserButton buttonRecap;
        private System.Windows.Forms.GroupBox grpReservation1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Controls.UserTextBox textboxNbPers1;
        private System.Windows.Forms.ComboBox comboSelClient1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpReservation2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Controls.UserTextBox textboxNbPers2;
        private System.Windows.Forms.ComboBox comboSelClient2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpReservation3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private Controls.UserTextBox textboxNbPers3;
        private System.Windows.Forms.ComboBox comboSelClient3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabModif;
        private System.Windows.Forms.ComboBox comboModCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Controls.UserButton buttonModVignette;
        private Controls.UserButton buttonModPhoto;
        private System.Windows.Forms.CheckBox checkboxModPromo;
        private Controls.UserButton buttonModifier;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Controls.UserTextBox textModPrix;
        private Controls.UserTextBox textModDuree;
        private Controls.UserTextBox textModDescr;
        private Controls.UserTextBox textModDest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboModHebergt;
        private System.Windows.Forms.ComboBox comboModThemq;
        private Controls.UserButton buttonSupprimer;
    }
}