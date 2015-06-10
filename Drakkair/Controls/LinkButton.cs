using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drakkair.Controls
{
	public partial class LinkButton : Button
	{
		/// <summary>
		/// var lk = new LinkButton();
		///
		/// lk.Size = new System.Drawing.Size(350, 0);
		/// lk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		/// lk.Text = "Nous sommes fous";
		///
		/// panelSideBar.Controls.Add(lk);
		/// </summary>
		public LinkButton()
		{
			InitializeComponent();

			this.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));

			this.Location = new System.Drawing.Point(0, 0);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.AutoSize = true;
			this.Text = "A link button";

			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.FlatAppearance.BorderSize = 0;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UseVisualStyleBackColor = false;
		}
	}
}
