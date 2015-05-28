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

		/// <summary>
		/// Initialise les composants.
		/// Va chercher les données dans la BDD.
		/// </summary>
		public FormMain()
		{
			InitializeComponent();
		}
		// ----------------------------------------------------------------
	}
}
