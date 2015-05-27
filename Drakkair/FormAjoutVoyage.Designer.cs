namespace Drakkair
{
    partial class FormAjoutVoyage
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
            this.tabBox = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.lblNbJours = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.textNbJours = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textDescr = new System.Windows.Forms.TextBox();
            this.textDest = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblHebergement = new System.Windows.Forms.Label();
            this.lblThematique = new System.Windows.Forms.Label();
            this.comboHebergement = new System.Windows.Forms.ComboBox();
            this.comboThematique = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tabBox.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBox
            // 
            this.tabBox.Controls.Add(this.tabPage);
            this.tabBox.Controls.Add(this.tabPage2);
            this.tabBox.Location = new System.Drawing.Point(13, 13);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(643, 392);
            this.tabBox.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.btnAjouter);
            this.tabPage.Controls.Add(this.lblNbJours);
            this.tabPage.Controls.Add(this.lblPrix);
            this.tabPage.Controls.Add(this.textPrix);
            this.tabPage.Controls.Add(this.textNbJours);
            this.tabPage.Controls.Add(this.lblDescription);
            this.tabPage.Controls.Add(this.textDescr);
            this.tabPage.Controls.Add(this.textDest);
            this.tabPage.Controls.Add(this.lblDestination);
            this.tabPage.Controls.Add(this.textCode);
            this.tabPage.Controls.Add(this.lblCode);
            this.tabPage.Controls.Add(this.lblHebergement);
            this.tabPage.Controls.Add(this.lblThematique);
            this.tabPage.Controls.Add(this.comboHebergement);
            this.tabPage.Controls.Add(this.comboThematique);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(635, 366);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Ajout d\'un voyage";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // lblNbJours
            // 
            this.lblNbJours.AutoSize = true;
            this.lblNbJours.Location = new System.Drawing.Point(14, 281);
            this.lblNbJours.Name = "lblNbJours";
            this.lblNbJours.Size = new System.Drawing.Size(84, 13);
            this.lblNbJours.TabIndex = 13;
            this.lblNbJours.Text = "Nombre de jours";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(470, 281);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(24, 13);
            this.lblPrix.TabIndex = 12;
            this.lblPrix.Text = "Prix";
            // 
            // textPrix
            // 
            this.textPrix.Location = new System.Drawing.Point(506, 278);
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(100, 20);
            this.textPrix.TabIndex = 11;
            // 
            // textNbJours
            // 
            this.textNbJours.Location = new System.Drawing.Point(107, 278);
            this.textNbJours.Name = "textNbJours";
            this.textNbJours.Size = new System.Drawing.Size(100, 20);
            this.textNbJours.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // textDescr
            // 
            this.textDescr.Location = new System.Drawing.Point(107, 118);
            this.textDescr.Multiline = true;
            this.textDescr.Name = "textDescr";
            this.textDescr.Size = new System.Drawing.Size(499, 130);
            this.textDescr.TabIndex = 8;
            // 
            // textDest
            // 
            this.textDest.Location = new System.Drawing.Point(107, 60);
            this.textDest.Name = "textDest";
            this.textDest.Size = new System.Drawing.Size(146, 20);
            this.textDest.TabIndex = 7;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(23, 63);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 6;
            this.lblDestination.Text = "Destination";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(107, 23);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(146, 20);
            this.textCode.TabIndex = 5;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(23, 26);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(75, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code de l\'offre";
            // 
            // lblHebergement
            // 
            this.lblHebergement.AutoSize = true;
            this.lblHebergement.Location = new System.Drawing.Point(370, 63);
            this.lblHebergement.Name = "lblHebergement";
            this.lblHebergement.Size = new System.Drawing.Size(71, 13);
            this.lblHebergement.TabIndex = 3;
            this.lblHebergement.Text = "Hébergement";
            // 
            // lblThematique
            // 
            this.lblThematique.AutoSize = true;
            this.lblThematique.Location = new System.Drawing.Point(378, 26);
            this.lblThematique.Name = "lblThematique";
            this.lblThematique.Size = new System.Drawing.Size(63, 13);
            this.lblThematique.TabIndex = 2;
            this.lblThematique.Text = "Thématique";
            // 
            // comboHebergement
            // 
            this.comboHebergement.FormattingEnabled = true;
            this.comboHebergement.Location = new System.Drawing.Point(459, 60);
            this.comboHebergement.Name = "comboHebergement";
            this.comboHebergement.Size = new System.Drawing.Size(147, 21);
            this.comboHebergement.TabIndex = 1;
            // 
            // comboThematique
            // 
            this.comboThematique.FormattingEnabled = true;
            this.comboThematique.Location = new System.Drawing.Point(459, 23);
            this.comboThematique.Name = "comboThematique";
            this.comboThematique.Size = new System.Drawing.Size(147, 21);
            this.comboThematique.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(531, 327);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter Offre";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjoutVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 417);
            this.Controls.Add(this.tabBox);
            this.Name = "FormAjoutVoyage";
            this.Text = "Ajout d\'un voyage";
            this.Load += new System.EventHandler(this.FormAjoutVoyage_Load);
            this.tabBox.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBox;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textDescr;
        private System.Windows.Forms.TextBox textDest;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblHebergement;
        private System.Windows.Forms.Label lblThematique;
        private System.Windows.Forms.ComboBox comboHebergement;
        private System.Windows.Forms.ComboBox comboThematique;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.TextBox textNbJours;
        private System.Windows.Forms.Label lblNbJours;
        private System.Windows.Forms.Button btnAjouter;
    }
}