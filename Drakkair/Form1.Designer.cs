namespace Drakkair
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.pictureLogo = new System.Windows.Forms.PictureBox();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.buttonAdmin = new System.Windows.Forms.Button();
			this.panelSidebar = new System.Windows.Forms.Panel();
			this.comboPension = new System.Windows.Forms.ComboBox();
			this.comboTheme = new System.Windows.Forms.ComboBox();
			this.comboDepart = new System.Windows.Forms.ComboBox();
			this.textPrixMax = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textPrixMin = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonDetailOffres = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.gridViewVoyages = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
			this.panelMenu.SuspendLayout();
			this.panelSidebar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridViewVoyages)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureLogo
			// 
			this.pictureLogo.Image = global::Drakkair.Properties.Resources.logo;
			this.pictureLogo.Location = new System.Drawing.Point(0, 0);
			this.pictureLogo.Margin = new System.Windows.Forms.Padding(0);
			this.pictureLogo.Name = "pictureLogo";
			this.pictureLogo.Size = new System.Drawing.Size(350, 150);
			this.pictureLogo.TabIndex = 1;
			this.pictureLogo.TabStop = false;
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.panelMenu.Controls.Add(this.buttonAdmin);
			this.panelMenu.Location = new System.Drawing.Point(350, 0);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(789, 150);
			this.panelMenu.TabIndex = 2;
			// 
			// buttonAdmin
			// 
			this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAdmin.FlatAppearance.BorderSize = 0;
			this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdmin.Location = new System.Drawing.Point(654, 84);
			this.buttonAdmin.Margin = new System.Windows.Forms.Padding(33);
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.Size = new System.Drawing.Size(90, 33);
			this.buttonAdmin.TabIndex = 0;
			this.buttonAdmin.Text = "ADMIN";
			this.buttonAdmin.UseVisualStyleBackColor = false;
			// 
			// panelSidebar
			// 
			this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.panelSidebar.Controls.Add(this.comboPension);
			this.panelSidebar.Controls.Add(this.comboTheme);
			this.panelSidebar.Controls.Add(this.comboDepart);
			this.panelSidebar.Controls.Add(this.textPrixMax);
			this.panelSidebar.Controls.Add(this.label2);
			this.panelSidebar.Controls.Add(this.textPrixMin);
			this.panelSidebar.Controls.Add(this.button3);
			this.panelSidebar.Controls.Add(this.label9);
			this.panelSidebar.Controls.Add(this.label1);
			this.panelSidebar.Controls.Add(this.label8);
			this.panelSidebar.Controls.Add(this.button2);
			this.panelSidebar.Controls.Add(this.label7);
			this.panelSidebar.Controls.Add(this.button1);
			this.panelSidebar.Controls.Add(this.label6);
			this.panelSidebar.Controls.Add(this.label5);
			this.panelSidebar.Controls.Add(this.buttonDetailOffres);
			this.panelSidebar.Controls.Add(this.label4);
			this.panelSidebar.Controls.Add(this.label3);
			this.panelSidebar.Location = new System.Drawing.Point(0, 150);
			this.panelSidebar.Margin = new System.Windows.Forms.Padding(0);
			this.panelSidebar.Name = "panelSidebar";
			this.panelSidebar.Size = new System.Drawing.Size(350, 592);
			this.panelSidebar.TabIndex = 3;
			// 
			// comboPension
			// 
			this.comboPension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.comboPension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboPension.ForeColor = System.Drawing.Color.White;
			this.comboPension.FormattingEnabled = true;
			this.comboPension.Location = new System.Drawing.Point(115, 398);
			this.comboPension.Name = "comboPension";
			this.comboPension.Size = new System.Drawing.Size(212, 32);
			this.comboPension.TabIndex = 14;
			// 
			// comboTheme
			// 
			this.comboTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.comboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboTheme.ForeColor = System.Drawing.Color.White;
			this.comboTheme.FormattingEnabled = true;
			this.comboTheme.Location = new System.Drawing.Point(115, 353);
			this.comboTheme.Name = "comboTheme";
			this.comboTheme.Size = new System.Drawing.Size(212, 32);
			this.comboTheme.TabIndex = 13;
			// 
			// comboDepart
			// 
			this.comboDepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.comboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboDepart.ForeColor = System.Drawing.Color.White;
			this.comboDepart.FormattingEnabled = true;
			this.comboDepart.Location = new System.Drawing.Point(115, 308);
			this.comboDepart.Name = "comboDepart";
			this.comboDepart.Size = new System.Drawing.Size(212, 32);
			this.comboDepart.TabIndex = 4;
			// 
			// textPrixMax
			// 
			this.textPrixMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textPrixMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrixMax.ForeColor = System.Drawing.Color.White;
			this.textPrixMax.Location = new System.Drawing.Point(188, 482);
			this.textPrixMax.Name = "textPrixMax";
			this.textPrixMax.Size = new System.Drawing.Size(107, 32);
			this.textPrixMax.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 255);
			this.label2.Margin = new System.Windows.Forms.Padding(12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(296, 38);
			this.label2.TabIndex = 6;
			this.label2.Text = "Critères de recherche";
			// 
			// textPrixMin
			// 
			this.textPrixMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textPrixMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrixMin.ForeColor = System.Drawing.Color.White;
			this.textPrixMin.Location = new System.Drawing.Point(69, 482);
			this.textPrixMin.Name = "textPrixMin";
			this.textPrixMin.Size = new System.Drawing.Size(78, 32);
			this.textPrixMin.TabIndex = 11;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(0, 129);
			this.button3.Margin = new System.Windows.Forms.Padding(0);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button3.Size = new System.Drawing.Size(350, 33);
			this.button3.TabIndex = 4;
			this.button3.Text = "La dernière";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(304, 485);
			this.label9.Margin = new System.Windows.Forms.Padding(6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 26);
			this.label9.TabIndex = 10;
			this.label9.Text = "€";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 38);
			this.label1.TabIndex = 5;
			this.label1.Text = "Catégories d\'offres";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(156, 485);
			this.label8.Margin = new System.Windows.Forms.Padding(6);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 26);
			this.label8.TabIndex = 9;
			this.label8.Text = "à";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(0, 96);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button2.Size = new System.Drawing.Size(350, 33);
			this.button2.TabIndex = 3;
			this.button2.Text = "Une seconde";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 485);
			this.label7.Margin = new System.Windows.Forms.Padding(6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 26);
			this.label7.TabIndex = 8;
			this.label7.Text = "De";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(0, 63);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button1.Size = new System.Drawing.Size(350, 33);
			this.button1.TabIndex = 2;
			this.button1.Text = "Première catégorie";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 447);
			this.label6.Margin = new System.Windows.Forms.Padding(6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 26);
			this.label6.TabIndex = 7;
			this.label6.Text = "Gamme de prix";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 401);
			this.label5.Margin = new System.Windows.Forms.Padding(6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 26);
			this.label5.TabIndex = 6;
			this.label5.Text = "Pension";
			// 
			// buttonDetailOffres
			// 
			this.buttonDetailOffres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonDetailOffres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonDetailOffres.FlatAppearance.BorderSize = 0;
			this.buttonDetailOffres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDetailOffres.Location = new System.Drawing.Point(42, 177);
			this.buttonDetailOffres.Margin = new System.Windows.Forms.Padding(33, 15, 33, 33);
			this.buttonDetailOffres.Name = "buttonDetailOffres";
			this.buttonDetailOffres.Size = new System.Drawing.Size(179, 33);
			this.buttonDetailOffres.TabIndex = 1;
			this.buttonDetailOffres.Text = "Toutes les offres";
			this.buttonDetailOffres.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 359);
			this.label4.Margin = new System.Windows.Forms.Padding(6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 26);
			this.label4.TabIndex = 5;
			this.label4.Text = "Thème";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 311);
			this.label3.Margin = new System.Windows.Forms.Padding(6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Départ";
			// 
			// gridViewVoyages
			// 
			this.gridViewVoyages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.gridViewVoyages.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridViewVoyages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridViewVoyages.Location = new System.Drawing.Point(350, 150);
			this.gridViewVoyages.Name = "gridViewVoyages";
			this.gridViewVoyages.RowTemplate.Height = 24;
			this.gridViewVoyages.Size = new System.Drawing.Size(789, 595);
			this.gridViewVoyages.TabIndex = 4;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1136, 740);
			this.Controls.Add(this.gridViewVoyages);
			this.Controls.Add(this.panelSidebar);
			this.Controls.Add(this.panelMenu);
			this.Controls.Add(this.pictureLogo);
			this.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMain";
			this.Text = "Drake Airlines";
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
			this.panelMenu.ResumeLayout(false);
			this.panelSidebar.ResumeLayout(false);
			this.panelSidebar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridViewVoyages)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.PictureBox pictureLogo;
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelSidebar;
		private System.Windows.Forms.Button buttonAdmin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonDetailOffres;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textPrixMax;
		private System.Windows.Forms.TextBox textPrixMin;
		private System.Windows.Forms.ComboBox comboPension;
		private System.Windows.Forms.ComboBox comboTheme;
		private System.Windows.Forms.ComboBox comboDepart;
		private System.Windows.Forms.DataGridView gridViewVoyages;

	}
}

