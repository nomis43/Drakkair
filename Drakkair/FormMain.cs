using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

using Drakkair.Controls;

namespace Drakkair
{
	public partial class FormMain : Form
	{
		/// <summary>
		/// Initialisation de la connexion à la BDD.
		/// </summary>
		private OleDbConnection DB = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Drakkair.mdb");
		// ----------------------------------------------------------------

		private DataSet DATA = new DataSet();
		// ----------------------------------------------------------------

		private ComboBox comboDepart = new ComboBox();
		private ComboBox comboTheme = new ComboBox();
		private ComboBox comboPension = new ComboBox();
		// ----------------------------------------------------------------

		private UserTextBox textPrixMin = new UserTextBox();
		private UserTextBox textPrixMax = new UserTextBox();
		// ----------------------------------------------------------------

		/// <summary>
		/// Génère automatiquement des boutons vers les catégories de voyage.
		/// </summary>
		private void InitSideBarCategoryButtons()
		{
			LinkButton buttonTmp;
			foreach(DataRow line in DATA.Tables["Thematiques"].Rows)
			{
				buttonTmp = new LinkButton();

				buttonTmp.Size = new System.Drawing.Size(350, 36);
				buttonTmp.Tag  = line["id"];
				buttonTmp.Text = (string)line["name"];
				buttonTmp.TextAlign = ContentAlignment.MiddleRight;

				panelSideBar.Controls.Add(buttonTmp);
			}
		}
		// ----------------------------------------------------------------

		/// <summary>
		/// Initialise la barre latérale avec tous ses composants :
		/// - les labels de légende
		/// - les textbox de prix
		/// - les combos départ, theme et pension
		/// - les boutons des catégories d'offres
		/// </summary>
		private void InitSideBar()
		{
			Label labelTmp;

			// titre catégories
			labelTmp = new Label();
			labelTmp.Text = "Catégories d'offres";
			labelTmp.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelTmp.Margin = new System.Windows.Forms.Padding(6);
			labelTmp.Size = new System.Drawing.Size(338, 36);
			panelSideBar.Controls.Add(labelTmp);

			// génération des boutons des catégories
			InitSideBarCategoryButtons();

			// titre recherche
			labelTmp = new Label();
			labelTmp.Text = "Critères de recherche";
			labelTmp.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelTmp.Margin = new System.Windows.Forms.Padding(6);
			labelTmp.Size = new System.Drawing.Size(338, 36);
			panelSideBar.Controls.Add(labelTmp);

			// label départ
			labelTmp = new Label();
			labelTmp.Text = "Départ";
			labelTmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			labelTmp.AutoSize = true;
			labelTmp.Margin = new System.Windows.Forms.Padding(6);
			panelSideBar.Controls.Add(labelTmp);

			// comboDepart
			this.comboDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboDepart.BackColor = System.Drawing.Color.White;
			this.comboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDepart.ForeColor = System.Drawing.Color.Black;
			this.comboDepart.FormattingEnabled = true;
			this.comboDepart.Margin = new System.Windows.Forms.Padding(6);
			this.comboDepart.Size = new System.Drawing.Size(248, 32);
			panelSideBar.Controls.Add(this.comboDepart);

			// label theme
			labelTmp = new Label();
			labelTmp.Text = "Theme";
			labelTmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			labelTmp.AutoSize = true;
			labelTmp.Margin = new System.Windows.Forms.Padding(6);
			panelSideBar.Controls.Add(labelTmp);

			// comboTheme
			this.comboTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboTheme.BackColor = System.Drawing.Color.White;
			this.comboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboTheme.ForeColor = System.Drawing.Color.Black;
			this.comboTheme.FormattingEnabled = true;
			this.comboTheme.Location = new System.Drawing.Point(93, 145);
			this.comboTheme.Margin = new System.Windows.Forms.Padding(6);
			this.comboTheme.Size = new System.Drawing.Size(248, 32);
			panelSideBar.Controls.Add(this.comboTheme);

			// label pension
			labelTmp = new Label();
			labelTmp.Text = "Pension";
			labelTmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			labelTmp.AutoSize = true;
			labelTmp.Location = new System.Drawing.Point(6, 192);
			labelTmp.Margin = new System.Windows.Forms.Padding(6);
			labelTmp.Size = new System.Drawing.Size(83, 26);
			panelSideBar.Controls.Add(labelTmp);

			// comboPension
			this.comboPension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboPension.BackColor = System.Drawing.Color.White;
			this.comboPension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPension.ForeColor = System.Drawing.Color.Black;
			this.comboPension.FormattingEnabled = true;
			this.comboPension.Location = new System.Drawing.Point(101, 189);
			this.comboPension.Margin = new System.Windows.Forms.Padding(6);
			this.comboPension.Size = new System.Drawing.Size(240, 32);
			panelSideBar.Controls.Add(this.comboPension);

			// label gamme de prix
			labelTmp = new Label();
			labelTmp.Text = "Gamme de prix";
			labelTmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			labelTmp.Margin = new System.Windows.Forms.Padding(6);
			labelTmp.Size = new System.Drawing.Size(338, 26);
			panelSideBar.Controls.Add(labelTmp);

			// sous label gamme de prix
			labelTmp = new Label();
			labelTmp.Text = "De";
			labelTmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			labelTmp.AutoSize = true;
			labelTmp.Margin = new System.Windows.Forms.Padding(6);
			panelSideBar.Controls.Add(labelTmp);

			// textPrixMin
			this.textPrixMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textPrixMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textPrixMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrixMin.ForeColor = System.Drawing.Color.White;
			this.textPrixMin.Size = new System.Drawing.Size(86, 32);
			panelSideBar.Controls.Add(this.textPrixMin);

			// sous label gamme de prix
			labelTmp = new Label();
			labelTmp.Text = "à";
			labelTmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			labelTmp.AutoSize = true;
			labelTmp.Margin = new System.Windows.Forms.Padding(6);
			panelSideBar.Controls.Add(labelTmp);

			// textPrixMax
			this.textPrixMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textPrixMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.textPrixMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrixMax.ForeColor = System.Drawing.Color.White;
			this.textPrixMax.Size = new System.Drawing.Size(118, 32);
			panelSideBar.Controls.Add(this.textPrixMax);

			// sous label gamme de prix
			labelTmp = new Label();
			labelTmp.Text = "€";
			labelTmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			labelTmp.AutoSize = true;
			labelTmp.Margin = new System.Windows.Forms.Padding(6);
			panelSideBar.Controls.Add(labelTmp);
		}
		// ----------------------------------------------------------------

		/// <summary>
		/// Rmplit le dataset this.DATA avec les données souhaitées.
		/// </summary>
		private void RetrieveData()
		{
			new OleDbDataAdapter(@"
				SELECT codeVille AS id, nomVille AS name
				FROM tblVilles
			", DB).Fill(DATA, "Departs");

			new OleDbDataAdapter(@"
				SELECT codeThem AS id, libThem AS name
				FROM tblThematique
			", DB).Fill(DATA, "Thematiques");

			new OleDbDataAdapter(@"
				SELECT NumCategorie AS id, NomCategorie AS name
				FROM tblHebergement
			", DB).Fill(DATA, "Pensions");
		}
		// ----------------------------------------------------------------

		public FormMain()
		{
			InitializeComponent();
		}
		// ----------------------------------------------------------------

		/// <summary>
		/// Fait une liason de données sur une combobox avec une table de this.DATA.
		/// </summary>
		/// <param name="combo">La combocob à lier.</param>
		/// <param name="tableName">Le nom de la table dans laquelle aller chercher les données.</param>
		/// <param name="valueMember">Valeur pour la propriété combo.ValueMember.</param>
		/// <param name="displayMemeber">Valeur pour la propriété combo.DisplayMember.</param>
		private void ComboDataLink(ComboBox combo, string tableName, string valueMember, string displayMemeber)
		{
			combo.DataSource = DATA.Tables[tableName];
			combo.ValueMember = valueMember;
			combo.DisplayMember = displayMemeber;
		}
		// ----------------------------------------------------------------

		/// <summary>
		/// Ajoute une ligne dans une table de this.DATA.
		/// </summary>
		/// <param name="tableName">Le nom de la table à modifier.</param>
		/// <param name="config">
		/// Tableau de configuration pour la ligne à rajouter.
		/// Chaque sous tableau a deux dimensions :
		/// - la première case est une string qui sert de nom de colonne
		/// - la seconde sert de valeur dans la nouvelle ligne.
		/// </param>
		/// <example>
		/// AddRowToTable("Dogs", new object[,]{
		///		{"id", 12},
		///		{"name", "Olaf"},
		///		{"nickname", "Ducon"}
		///	});
		/// </example>
		/// <exception cref="IndexOutOfRangeException">Emit automatiquement si le tableau n'a pas les bonnes dimensions.</exception>
		private void AddRowToTable(string tableName, object[,] config)
		{
			var r = DATA.Tables[tableName].NewRow();

			for(int i = 0, c = config.GetLength(0); i < c; i++)
				r[(string)config[i, 0]] = config[i, 1];

			DATA.Tables[tableName].Rows.Add(r);
		}
		// ----------------------------------------------------------------

		/// <summary>
		/// - rapatrie les données dans le dataset
		/// - Initialise les composants de la sidebar
		/// - lie les données à ces composants
		/// - lie les évènements à ces composants
		/// </summary>
		private void FormMain_Load(object sender, EventArgs e)
		{
			// par ici les données !
			RetrieveData();

			// placement des composants
			InitSideBar();

			// liaison des données avec les composants
			ComboDataLink(comboDepart, "Departs", "id", "name");
			ComboDataLink(comboTheme, "Thematiques", "id", "name");
			ComboDataLink(comboPension, "Pensions", "id", "name");

			// création de lignes fictives dans les tables pour simuler la sélection de toutes les options.
			AddRowToTable("Departs", new object[,]{
				{"id", -1},
				{"name", "Tous les départs"}
			});
			comboDepart.SelectedValue = -1;

			AddRowToTable("Thematiques", new object[,]{
				{"id", -1},
				{"name", "Tous les thèmes"}
			});
			comboTheme.SelectedValue = -1;

			AddRowToTable("Pensions", new object[,]{
				{"id", -1},
				{"name", "Tout type de pension"}
			});
			comboPension.SelectedValue = -1;
		}
		// ----------------------------------------------------------------
	}
}
