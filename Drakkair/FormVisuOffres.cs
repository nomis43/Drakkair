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
    public partial class FormVisuOffres : Form
    {
        OleDbConnection co = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Drakkair.mdb");
        
        DataSet ds = new DataSet();

        BindingNavigator customersBindingNavigator = new BindingNavigator(true);

        BindingSource customersBindingSource = new BindingSource();
        TextBox companyNameTextBox = new TextBox();

        public FormVisuOffres()
        {
            InitializeComponent();

            this.customersBindingNavigator.BindingSource = customersBindingSource;
            this.customersBindingNavigator.Dock = DockStyle.Bottom;
            this.Controls.Add(customersBindingNavigator);


            this.companyNameTextBox.Dock = DockStyle.Bottom;
            this.Controls.Add(this.companyNameTextBox);
        }

        private void FormVisuOffres_Load(object sender, EventArgs e)
        {
            co.Open();
            string req = @"SELECT v.CodeVoyage as Code, v.Destination, th.libThem as Thematique, h.NomCategorie as Hebergement, v.Description, v.Duree, v.Prix, v.Promotion 
                            FROM tblVoyages v, tblThematique th, tblHebergement h 
                            WHERE v.TypeThematique=th.codeThem 
                            AND v.TypeHebergement=h.NumCategorie";

            
           OleDbDataAdapter da = new OleDbDataAdapter(req, this.co);

           ds.Tables.Add("offres");
           da.Fill(ds.Tables["offres"]);

          // companyNameTextBox.DataBindings.Add(new Binding("Text", ds, "offres.Code"));


           this.customersBindingSource.DataSource = ds.Tables["offres"];


           dataGridView1.DataSource = ds.Tables["offres"];




           companyNameTextBox.DataBindings.Add(new Binding("Text", this.customersBindingSource, "Code", true));

        }
    }
}
