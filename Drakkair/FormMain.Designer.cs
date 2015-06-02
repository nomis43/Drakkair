namespace Drakkair
{
	using System.Drawing;
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panelTopBar = new System.Windows.Forms.Panel();
			this.buttonAdmin = new System.Windows.Forms.Button();
			this.pictureLogo = new System.Windows.Forms.PictureBox();
			this.panelSideBar = new System.Windows.Forms.FlowLayoutPanel();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panelTopBar, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureLogo, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelSideBar, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 743);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panelTopBar
			// 
			this.panelTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.panelTopBar.Controls.Add(this.buttonAdmin);
			this.panelTopBar.Location = new System.Drawing.Point(350, 0);
			this.panelTopBar.Margin = new System.Windows.Forms.Padding(0);
			this.panelTopBar.Name = "panelTopBar";
			this.panelTopBar.Size = new System.Drawing.Size(801, 150);
			this.panelTopBar.TabIndex = 1;
			// 
			// buttonAdmin
			// 
			this.buttonAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(53)))));
			this.buttonAdmin.FlatAppearance.BorderSize = 0;
			this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdmin.Location = new System.Drawing.Point(674, 84);
			this.buttonAdmin.Margin = new System.Windows.Forms.Padding(20, 20, 20, 30);
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.Size = new System.Drawing.Size(94, 36);
			this.buttonAdmin.TabIndex = 1;
			this.buttonAdmin.Text = "ADMIN";
			this.buttonAdmin.UseVisualStyleBackColor = false;
			// 
			// pictureLogo
			// 
			this.pictureLogo.Image = global::Drakkair.Properties.Resources.logo;
			this.pictureLogo.Location = new System.Drawing.Point(0, 0);
			this.pictureLogo.Margin = new System.Windows.Forms.Padding(0);
			this.pictureLogo.Name = "pictureLogo";
			this.pictureLogo.Size = new System.Drawing.Size(350, 150);
			this.pictureLogo.TabIndex = 3;
			this.pictureLogo.TabStop = false;
			// 
			// panelSideBar
			// 
			this.panelSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.panelSideBar.Location = new System.Drawing.Point(0, 150);
			this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
			this.panelSideBar.Name = "panelSideBar";
			this.panelSideBar.Size = new System.Drawing.Size(350, 593);
			this.panelSideBar.TabIndex = 5;
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(350, 150);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(801, 593);
			this.dataGridView.TabIndex = 4;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1147, 742);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panelTopBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopBar;
		private System.Windows.Forms.Button buttonAdmin;
		private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.FlowLayoutPanel panelSideBar;
	}
}