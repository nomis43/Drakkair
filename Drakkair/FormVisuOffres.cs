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

        private OleDbConnection co ;

		private DataSet ds = new DataSet();

        private BindingSource bindingsource = new BindingSource();

		public FormVisuOffres()
		{
			InitializeComponent();
		}

        public FormVisuOffres(OleDbConnection co) : this()
        {
            this.co = co;
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

          

           bindingsource.DataSource = ds.Tables["offres"];

           bindingNavigator1.BindingSource = bindingsource;

         

            textBoxCode.DataBindings.Add(new Binding("Text", bindingsource, "Code"));
            textBoxDescription.DataBindings.Add(new Binding("Text", bindingsource, "Description"));
            textBoxdestination.DataBindings.Add(new Binding("Text", bindingsource, "Destination"));
            textBoxHebergement.DataBindings.Add(new Binding("Text", bindingsource, "Hebergement"));
            textBoxPrix.DataBindings.Add(new Binding("Text", bindingsource, "Prix"));
            textBoxJours.DataBindings.Add(new Binding("Text", bindingsource, "Duree"));
            textBoxThematique.DataBindings.Add(new Binding("Text", bindingsource, "Thematique"));
            checkBoxPromo.DataBindings.Add(new Binding("Checked", bindingsource, "Promotion"));

            DisplayPosition();

			co.Close();
            

        }
        private void DisplayPosition()
        {
            lbl_pos.Text = (this.bindingsource.Position + 1).ToString() + "/" + bindingsource.Count;
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            bindingsource.MoveFirst();
            DisplayPosition();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
       
            bindingsource.MovePrevious();
            DisplayPosition();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            
            bindingsource.MoveNext();
            DisplayPosition();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            bindingsource.MoveLast();
            DisplayPosition();
           
        }

        private void textBoxPrix_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
