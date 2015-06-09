namespace Drakkair
{
	partial class FormHotels
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
			if(disposing && (components != null))
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridListHotels = new System.Windows.Forms.DataGridView();
			this.tabPanel = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.comboAppreciationHotel = new System.Windows.Forms.ComboBox();
			this.dataGridAppreciationsHotel = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.labelEtoiles = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.trackEtoiles = new System.Windows.Forms.TrackBar();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.labelNote = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.comboChoixHotel = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.trackNote = new System.Windows.Forms.TrackBar();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.buttonValiderHotel = new Drakkair.Controls.UserButton();
			this.textTelephone = new Drakkair.Controls.UserTextBox();
			this.textAdresse = new Drakkair.Controls.UserTextBox();
			this.textNomHotel = new Drakkair.Controls.UserTextBox();
			this.textCode = new Drakkair.Controls.UserTextBox();
			this.textNom = new Drakkair.Controls.UserTextBox();
			this.textPrenom = new Drakkair.Controls.UserTextBox();
			this.textTitre = new Drakkair.Controls.UserTextBox();
			this.textCommentaire = new Drakkair.Controls.UserTextBox();
			this.buttonValiderAppreciation = new Drakkair.Controls.UserButton();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridListHotels)).BeginInit();
			this.tabPanel.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAppreciationsHotel)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackEtoiles)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackNote)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tabPage1.Controls.Add(this.dataGridListHotels);
			this.tabPage1.Location = new System.Drawing.Point(4, 33);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(934, 618);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Liste des hôtels";
			// 
			// dataGridListHotels
			// 
			this.dataGridListHotels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridListHotels.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.dataGridListHotels.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridListHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridListHotels.Location = new System.Drawing.Point(0, 0);
			this.dataGridListHotels.Margin = new System.Windows.Forms.Padding(0);
			this.dataGridListHotels.Name = "dataGridListHotels";
			this.dataGridListHotels.RowTemplate.Height = 24;
			this.dataGridListHotels.Size = new System.Drawing.Size(908, 534);
			this.dataGridListHotels.TabIndex = 0;
			// 
			// tabPanel
			// 
			this.tabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabPanel.Controls.Add(this.tabPage1);
			this.tabPanel.Controls.Add(this.tabPage2);
			this.tabPanel.Controls.Add(this.tabPage3);
			this.tabPanel.Controls.Add(this.tabPage4);
			this.tabPanel.Location = new System.Drawing.Point(9, 9);
			this.tabPanel.Margin = new System.Windows.Forms.Padding(0);
			this.tabPanel.Name = "tabPanel";
			this.tabPanel.SelectedIndex = 0;
			this.tabPanel.Size = new System.Drawing.Size(942, 655);
			this.tabPanel.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Controls.Add(this.dataGridAppreciationsHotel);
			this.tabPage2.Location = new System.Drawing.Point(4, 33);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(934, 618);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Appréciations sur un hôtel";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboAppreciationHotel);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(978, 84);
			this.panel1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hôtel";
			// 
			// comboAppreciationHotel
			// 
			this.comboAppreciationHotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboAppreciationHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboAppreciationHotel.FormattingEnabled = true;
			this.comboAppreciationHotel.Location = new System.Drawing.Point(90, 25);
			this.comboAppreciationHotel.Name = "comboAppreciationHotel";
			this.comboAppreciationHotel.Size = new System.Drawing.Size(816, 32);
			this.comboAppreciationHotel.TabIndex = 0;
			this.comboAppreciationHotel.SelectedIndexChanged += new System.EventHandler(this.comboAppreciationHotel_SelectedIndexChanged);
			// 
			// dataGridAppreciationsHotel
			// 
			this.dataGridAppreciationsHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridAppreciationsHotel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.dataGridAppreciationsHotel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridAppreciationsHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridAppreciationsHotel.Location = new System.Drawing.Point(0, 84);
			this.dataGridAppreciationsHotel.Margin = new System.Windows.Forms.Padding(0);
			this.dataGridAppreciationsHotel.Name = "dataGridAppreciationsHotel";
			this.dataGridAppreciationsHotel.RowTemplate.Height = 24;
			this.dataGridAppreciationsHotel.Size = new System.Drawing.Size(938, 538);
			this.dataGridAppreciationsHotel.TabIndex = 2;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tabPage3.Controls.Add(this.labelEtoiles);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.trackEtoiles);
			this.tabPage3.Controls.Add(this.buttonValiderHotel);
			this.tabPage3.Controls.Add(this.textTelephone);
			this.tabPage3.Controls.Add(this.textAdresse);
			this.tabPage3.Controls.Add(this.textNomHotel);
			this.tabPage3.Controls.Add(this.textCode);
			this.tabPage3.Location = new System.Drawing.Point(4, 33);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(934, 618);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Ajouter un hôtel";
			// 
			// labelEtoiles
			// 
			this.labelEtoiles.AutoSize = true;
			this.labelEtoiles.Location = new System.Drawing.Point(187, 321);
			this.labelEtoiles.Name = "labelEtoiles";
			this.labelEtoiles.Size = new System.Drawing.Size(23, 26);
			this.labelEtoiles.TabIndex = 11;
			this.labelEtoiles.Text = "0";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(27, 294);
			this.label13.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(71, 26);
			this.label13.TabIndex = 10;
			this.label13.Text = "Etoiles";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(27, 26);
			this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 26);
			this.label7.TabIndex = 9;
			this.label7.Text = "Code";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 93);
			this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 26);
			this.label6.TabIndex = 8;
			this.label6.Text = "Nom";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 160);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 26);
			this.label5.TabIndex = 7;
			this.label5.Text = "Adresse";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 227);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 26);
			this.label4.TabIndex = 6;
			this.label4.Text = "Téléphone";
			// 
			// trackEtoiles
			// 
			this.trackEtoiles.Location = new System.Drawing.Point(26, 321);
			this.trackEtoiles.Maximum = 5;
			this.trackEtoiles.Name = "trackEtoiles";
			this.trackEtoiles.Size = new System.Drawing.Size(155, 56);
			this.trackEtoiles.TabIndex = 4;
			this.trackEtoiles.Scroll += new System.EventHandler(this.trackEtoiles_Scroll);
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tabPage4.Controls.Add(this.labelNote);
			this.tabPage4.Controls.Add(this.panel2);
			this.tabPage4.Controls.Add(this.label12);
			this.tabPage4.Controls.Add(this.trackNote);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Controls.Add(this.label10);
			this.tabPage4.Controls.Add(this.label9);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Controls.Add(this.textNom);
			this.tabPage4.Controls.Add(this.textPrenom);
			this.tabPage4.Controls.Add(this.textTitre);
			this.tabPage4.Controls.Add(this.textCommentaire);
			this.tabPage4.Controls.Add(this.buttonValiderAppreciation);
			this.tabPage4.Location = new System.Drawing.Point(4, 33);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(934, 618);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Donner son appréciation";
			// 
			// labelNote
			// 
			this.labelNote.AutoSize = true;
			this.labelNote.Location = new System.Drawing.Point(167, 511);
			this.labelNote.Name = "labelNote";
			this.labelNote.Size = new System.Drawing.Size(23, 26);
			this.labelNote.TabIndex = 14;
			this.labelNote.Text = "0";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.panel2.Controls.Add(this.comboChoixHotel);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(10);
			this.panel2.Size = new System.Drawing.Size(948, 84);
			this.panel2.TabIndex = 13;
			// 
			// comboChoixHotel
			// 
			this.comboChoixHotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboChoixHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboChoixHotel.FormattingEnabled = true;
			this.comboChoixHotel.Location = new System.Drawing.Point(95, 27);
			this.comboChoixHotel.Name = "comboChoixHotel";
			this.comboChoixHotel.Size = new System.Drawing.Size(785, 32);
			this.comboChoixHotel.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 26);
			this.label3.TabIndex = 1;
			this.label3.Text = "Hôtel";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(35, 484);
			this.label12.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(55, 26);
			this.label12.TabIndex = 7;
			this.label12.Text = "Note";
			// 
			// trackNote
			// 
			this.trackNote.Location = new System.Drawing.Point(34, 511);
			this.trackNote.Maximum = 5;
			this.trackNote.Name = "trackNote";
			this.trackNote.Size = new System.Drawing.Size(127, 56);
			this.trackNote.TabIndex = 6;
			this.trackNote.Scroll += new System.EventHandler(this.trackNote_Scroll);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(31, 306);
			this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(136, 26);
			this.label11.TabIndex = 5;
			this.label11.Text = "Commentaire";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(31, 239);
			this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 26);
			this.label10.TabIndex = 4;
			this.label10.Text = "Titre";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(31, 172);
			this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 26);
			this.label9.TabIndex = 3;
			this.label9.Text = "Prenom";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(31, 105);
			this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 26);
			this.label8.TabIndex = 2;
			this.label8.Text = "Nom";
			// 
			// buttonValiderHotel
			// 
			this.buttonValiderHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonValiderHotel.AutoSize = true;
			this.buttonValiderHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonValiderHotel.FlatAppearance.BorderSize = 0;
			this.buttonValiderHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonValiderHotel.Location = new System.Drawing.Point(810, 561);
			this.buttonValiderHotel.Margin = new System.Windows.Forms.Padding(20, 20, 20, 30);
			this.buttonValiderHotel.Name = "buttonValiderHotel";
			this.buttonValiderHotel.Size = new System.Drawing.Size(101, 36);
			this.buttonValiderHotel.TabIndex = 5;
			this.buttonValiderHotel.Text = "VALIDER";
			this.buttonValiderHotel.UseVisualStyleBackColor = false;
			this.buttonValiderHotel.Click += new System.EventHandler(this.buttonValiderHotel_Click);
			// 
			// textTelephone
			// 
			this.textTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTelephone.ForeColor = System.Drawing.Color.White;
			this.textTelephone.Location = new System.Drawing.Point(26, 254);
			this.textTelephone.Name = "textTelephone";
			this.textTelephone.Size = new System.Drawing.Size(885, 32);
			this.textTelephone.TabIndex = 3;
			// 
			// textAdresse
			// 
			this.textAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textAdresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textAdresse.ForeColor = System.Drawing.Color.White;
			this.textAdresse.Location = new System.Drawing.Point(26, 187);
			this.textAdresse.Name = "textAdresse";
			this.textAdresse.Size = new System.Drawing.Size(885, 32);
			this.textAdresse.TabIndex = 2;
			// 
			// textNomHotel
			// 
			this.textNomHotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textNomHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textNomHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNomHotel.ForeColor = System.Drawing.Color.White;
			this.textNomHotel.Location = new System.Drawing.Point(26, 120);
			this.textNomHotel.Name = "textNomHotel";
			this.textNomHotel.Size = new System.Drawing.Size(885, 32);
			this.textNomHotel.TabIndex = 1;
			// 
			// textCode
			// 
			this.textCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCode.ForeColor = System.Drawing.Color.White;
			this.textCode.Location = new System.Drawing.Point(26, 53);
			this.textCode.Name = "textCode";
			this.textCode.Size = new System.Drawing.Size(885, 32);
			this.textCode.TabIndex = 0;
			// 
			// textNom
			// 
			this.textNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNom.ForeColor = System.Drawing.Color.White;
			this.textNom.Location = new System.Drawing.Point(30, 132);
			this.textNom.Name = "textNom";
			this.textNom.Size = new System.Drawing.Size(886, 32);
			this.textNom.TabIndex = 12;
			// 
			// textPrenom
			// 
			this.textPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrenom.ForeColor = System.Drawing.Color.White;
			this.textPrenom.Location = new System.Drawing.Point(30, 199);
			this.textPrenom.Name = "textPrenom";
			this.textPrenom.Size = new System.Drawing.Size(886, 32);
			this.textPrenom.TabIndex = 11;
			// 
			// textTitre
			// 
			this.textTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTitre.ForeColor = System.Drawing.Color.White;
			this.textTitre.Location = new System.Drawing.Point(30, 266);
			this.textTitre.Name = "textTitre";
			this.textTitre.Size = new System.Drawing.Size(886, 32);
			this.textTitre.TabIndex = 10;
			// 
			// textCommentaire
			// 
			this.textCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textCommentaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCommentaire.ForeColor = System.Drawing.Color.White;
			this.textCommentaire.Location = new System.Drawing.Point(30, 333);
			this.textCommentaire.Multiline = true;
			this.textCommentaire.Name = "textCommentaire";
			this.textCommentaire.Size = new System.Drawing.Size(886, 138);
			this.textCommentaire.TabIndex = 9;
			// 
			// buttonValiderAppreciation
			// 
			this.buttonValiderAppreciation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonValiderAppreciation.AutoSize = true;
			this.buttonValiderAppreciation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonValiderAppreciation.FlatAppearance.BorderSize = 0;
			this.buttonValiderAppreciation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonValiderAppreciation.Location = new System.Drawing.Point(803, 561);
			this.buttonValiderAppreciation.Margin = new System.Windows.Forms.Padding(20, 20, 20, 30);
			this.buttonValiderAppreciation.Name = "buttonValiderAppreciation";
			this.buttonValiderAppreciation.Size = new System.Drawing.Size(108, 36);
			this.buttonValiderAppreciation.TabIndex = 8;
			this.buttonValiderAppreciation.Text = "VALIDER";
			this.buttonValiderAppreciation.UseVisualStyleBackColor = false;
			this.buttonValiderAppreciation.Click += new System.EventHandler(this.buttonValiderAppreciation_Click);
			// 
			// FormHotels
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(960, 673);
			this.Controls.Add(this.tabPanel);
			this.Font = new System.Drawing.Font("Open Sans", 10.8F);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormHotels";
			this.Load += new System.EventHandler(this.FormHotels_Load);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridListHotels)).EndInit();
			this.tabPanel.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAppreciationsHotel)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackEtoiles)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackNote)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabPanel;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataGridView dataGridListHotels;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridAppreciationsHotel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboAppreciationHotel;
		private System.Windows.Forms.ComboBox comboChoixHotel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private Controls.UserButton buttonValiderHotel;
		private System.Windows.Forms.TrackBar trackEtoiles;
		private Controls.UserTextBox textTelephone;
		private Controls.UserTextBox textAdresse;
		private Controls.UserTextBox textNomHotel;
		private Controls.UserTextBox textCode;
		private Controls.UserTextBox textNom;
		private Controls.UserTextBox textPrenom;
		private Controls.UserTextBox textTitre;
		private Controls.UserTextBox textCommentaire;
		private Controls.UserButton buttonValiderAppreciation;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TrackBar trackNote;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelNote;
		private System.Windows.Forms.Label labelEtoiles;
	}
}
