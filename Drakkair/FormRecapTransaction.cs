using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drakkair
{
    public partial class FormRecapTransaction : Form
    {
        Dictionary<string, string> recap;
        public FormRecapTransaction()
        {
            InitializeComponent();
        }

        public FormRecapTransaction(Dictionary<string, string> recap) : this()
        {
            this.recap = recap;
        }

        private void FormRecapTransaction_Load(object sender, EventArgs e)
        {
            this.lblCode.Text = recap["code"];
            this.lblDestination.Text = recap["dest"];
            this.lblPrix.Text = recap["prix"];
            this.lblDuree.Text = recap["duree"];
            this.txtDescr.Text = recap["descr"];
            this.lblHebgt.Text = recap["hebergt"];
            this.lblThemq.Text = recap["themq"];

            this.lblReserv1.Text += String.Format("  {0:-25} - {1:-4} Jours - Départ le {2:8}", recap["grp1Nom"], recap["grp1nb"], recap["grp1date"]);
            this.lblReserv2.Text += String.Format("  {0:-25} - {1:-4} Jours - Départ le {2:8}", recap["grp2Nom"], recap["grp2nb"], recap["grp2date"]);
            this.lblReserv3.Text += String.Format("  {0:-25} - {1:-4} Jours - Départ le {2:8}", recap["grp3Nom"], recap["grp3nb"], recap["grp3date"]);
                
        }
    }
}
