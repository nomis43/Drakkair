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
	public partial class FormHotels : Form
	{
		/// <summary>
		/// Initialisation de la connexion à la BDD.
		/// </summary>
		private OleDbConnection DB;// = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Drakkair.mdb");
		// ----------------------------------------------------------------

		private DataSet DATA = new DataSet();
		// ----------------------------------------------------------------

		public FormHotels(OleDbConnection db)
		{
			InitializeComponent();
			this.DB = db;
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
		/// <exception cref="IndexOutOfRangeException">Emise automatiquement si le tableau n'a pas les bonnes dimensions.</exception>
		private void AddRowToTable(string tableName, object[,] config)
		{
			var row = DATA.Tables[tableName].NewRow();

			for(int i = 0, c = config.GetLength(0); i < c; i++)
				row[(string)config[i, 0]] = config[i, 1];

			DATA.Tables[tableName].Rows.Add(row);
		}
		// ----------------------------------------------------------------

		/// <summary>
		/// Crée une table d'hôtels et une table d'appréciation.
		/// Fait les contraintes.
		/// </summary>
		private void RetrieveData()
		{
			// table Hotels
			var hotels = new DataTable("Hotels");

			hotels.Columns.AddRange(new[]{
				new DataColumn("code"),
				new DataColumn("nom"),
				new DataColumn("adresse"),
				new DataColumn("telephone"),
				new DataColumn("etoiles")
			});

			DATA.Tables.Add(hotels);

			// table Appreciations
			var appreciations = new DataTable("Appreciations");

			appreciations.Columns.AddRange(new[]{
				new DataColumn("auteur_nom"),
				new DataColumn("auteur_prenom"),
				new DataColumn("hotel_code"),
				new DataColumn("titre"),
				new DataColumn("commentaire"),
				new DataColumn("note"),
				new DataColumn("date")
			});

			DATA.Tables.Add(appreciations);

			// contraintes
			hotels.Constraints.Add("PK_hotel_code", hotels.Columns["code"], true);

			appreciations.Constraints.Add("FK_appreciation_hotel",
				primaryKeyColumn: hotels.Columns["code"],
				foreignKeyColumn: appreciations.Columns["hotel_code"]
			);
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
		/// Initialise une liste d'hôtels.
		/// </summary>
		private void FormHotels_Load(object sender, EventArgs e)
		{
			RetrieveData();

			// ajout de quelques hotels
			AddRowToTable("Hotels", new object[,]{
				{"code",      2014},
				{"nom",       "Le Sarkory"},
				{"adresse",   "360 rue du Diamant"},
				{"telephone", "08 74 12 40 33"},
				{"etoiles",   5}
			});

			AddRowToTable("Hotels", new object[,]{
				{"code",      2015},
				{"nom",       "Olaf Budget"},
				{"adresse",   "Pas au 11, au 10, ducon..."},
				{"telephone", "03 88 41 52 68"},
				{"etoiles",   0}
			});

			AddRowToTable("Hotels", new object[,]{
				{"code",      2016},
				{"nom",       "Chambre d'hôte le Père Noël"},
				{"adresse",   "7 boulevard du Cadeau, Laponie"},
				{"telephone", "8 12 12 12 12 12 12 12 12 ..."},
				{"etoiles",   2}
			});

			AddRowToTable("Hotels", new object[,]{
				{"code",      2017},
				{"nom",       "Le Hollandais"},
				{"adresse",   "2017 année de l'Election, Paris"},
				{"telephone", "5€CR€T"},
				{"etoiles",   3}
			});

			AddRowToTable("Hotels", new object[,]{
				{"code",      2018},
				{"nom",       "Le Salut"},
				{"adresse",   "95 avenue du port"},
				{"telephone", "06 78 99 30 12"},
				{"etoiles",   2}
			});

			// liaison dataGridListHotels - Table "Hotels"
			dataGridListHotels.DataSource = DATA.Tables["Hotels"];

			dataGridListHotels.Columns["code"].HeaderText      = "CODE";
			dataGridListHotels.Columns["nom"].HeaderText       = "HOTEL";
			dataGridListHotels.Columns["adresse"].HeaderText   = "ADRESSE";
			dataGridListHotels.Columns["telephone"].HeaderText = "TELEPHONE";
			dataGridListHotels.Columns["etoiles"].HeaderText   = "ETOILES";

			dataGridListHotels.AutoSize = true;
			dataGridListHotels.Columns["code"].Frozen = true;

			// liaison dataGridAppreciationsHotel - Table "Appreciations"
			dataGridAppreciationsHotel.DataSource = new DataView(DATA.Tables["Appreciations"]);

			// liaison comboAppreciationHotel - Table "Hotels"
			ComboDataLink(comboAppreciationHotel, "Hotels", "code", "nom");

			// liaison comboChoixHotel - Table "Hotels"
			ComboDataLink(comboChoixHotel, "Hotels", "code", "nom");
		}
		// ----------------------------------------------------------------
		
		/// <summary>
		/// Met à jour la liste des appréciation en fonction de l'hôtel choisi.
		/// </summary>
		private void comboAppreciationHotel_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridAppreciationsHotel.DataSource = new DataView(DATA.Tables["Appreciations"]) {
				RowFilter = "hotel_code = " + (int)comboAppreciationHotel.SelectedValue
			};
		}
		// ----------------------------------------------------------------
		
		/// <summary>
		/// Ajoute une nouvelle appréciation sur un hôtel.
		/// </summary>
		private void buttonValiderAppreciation_Click(object sender, EventArgs e)
		{
			AddRowToTable("Appreciations", new object[,]{
				{"auteur_nom",    textNom.Text},
				{"auteur_prenom", textPrenom.Text},
				{"hotel_code",    (int)comboAppreciationHotel.SelectedValue},
				{"titre",         textTitre.Text},
				{"commentaire",   textCommentaire.Text},
				{"note",          trackNote.Value},
				{"date",          DateTime.Now}
			});
		}
		// ----------------------------------------------------------------

		/// <summary>
		/// Insert un hôtel dans la table des hotels.
		/// </summary>
		private void buttonValiderHotel_Click(object sender, EventArgs e)
		{
			AddRowToTable("Hotels", new object[,]{
				{"code",      int.Parse(textCode.Text)},
				{"nom",       textNomHotel.Text},
				{"adresse",   textAdresse.Text},
				{"telephone", textTelephone.Text},
				{"etoiles",   trackEtoiles.Value}
			});
		}
		// ----------------------------------------------------------------

		/// <summary>
		/// Met à jour le pitite label à côté du slider.
		/// </summary>
		private void trackEtoiles_Scroll(object sender, EventArgs e)
		{
			labelEtoiles.Text = "" + trackEtoiles.Value;
		}
		// ----------------------------------------------------------------

		/// <summary>
		/// Met à jour le pitite label à côté du slider.
		/// </summary>
		private void trackNote_Scroll(object sender, EventArgs e)
		{
			labelNote.Text = "" + trackNote.Value;
		}
		// ----------------------------------------------------------------
	}
}
