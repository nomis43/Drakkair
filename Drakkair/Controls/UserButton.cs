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
	public partial class UserButton : Button
	{
		public UserButton()
		{
			InitializeComponent();

			this.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			
			this.Location = new System.Drawing.Point(0, 0);
			this.Margin = new System.Windows.Forms.Padding(20, 20, 20, 30);
			this.Name = "buttonAdmin";
			this.AutoSize = true;
			this.Text = "CLICK ME";
			
			this.FlatAppearance.BorderSize = 0;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.UseVisualStyleBackColor = false;
		}
	}
}
