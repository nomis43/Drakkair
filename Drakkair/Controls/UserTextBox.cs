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
	public partial class UserTextBox : TextBox
	{
		public UserTextBox()
		{
			InitializeComponent();

			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ForeColor = System.Drawing.Color.White;
		}
	}
}
