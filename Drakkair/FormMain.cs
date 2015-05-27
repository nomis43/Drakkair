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

namespace Drakkair
{
	public partial class MainForm : Form
    {
		/// <summary>
		/// Connexion à la BDD.
		/// </summary>
		private OleDbConnection DB = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\Drakkair.mdb");
		// ----------------------------------------------------------------

        public MainForm()
        {
            InitializeComponent();
        }
		// ----------------------------------------------------------------
    }
}
