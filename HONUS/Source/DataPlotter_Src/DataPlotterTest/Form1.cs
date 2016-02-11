using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataPlotterTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private DataPlotter.Plotter pl;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.pl = new DataPlotter.Plotter();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(10, 405);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 26);
			this.button1.TabIndex = 3;
			this.button1.Text = "Xlin/Ylin";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.Location = new System.Drawing.Point(106, 405);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 26);
			this.button2.TabIndex = 4;
			this.button2.Text = "Xlin/Ylog";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.Location = new System.Drawing.Point(202, 405);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(86, 26);
			this.button3.TabIndex = 5;
			this.button3.Text = "Xlog/Ylin";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button4.Location = new System.Drawing.Point(298, 405);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(86, 26);
			this.button4.TabIndex = 6;
			this.button4.Text = "Xlog/Ylog";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(432, 9);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.SelectedObject = this.pl;
			this.propertyGrid1.Size = new System.Drawing.Size(269, 422);
			this.propertyGrid1.TabIndex = 7;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.propertyGrid1.Click += new System.EventHandler(this.propertyGrid1_Click);
			this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
			// 
			// pl
			// 
			this.pl.BorderBottom = 50;
			this.pl.BorderLeft = 50;
			this.pl.BorderRight = 30;
			this.pl.BorderTop = 30;
			this.pl.ColorAxis = System.Drawing.Color.Black;
			this.pl.ColorBg = System.Drawing.Color.White;
			this.pl.ColorDraw = System.Drawing.Color.DarkBlue;
			this.pl.ColorGrid = System.Drawing.Color.LightGray;
			this.pl.DrawMode = DataPlotter.Plotter.DrawModeType.Line;
			this.pl.FontAxis = new System.Drawing.Font("Arial", 8F);
			this.pl.Location = new System.Drawing.Point(8, 8);
			this.pl.Name = "pl";
			this.pl.PenWidth = 2;
			this.pl.Size = new System.Drawing.Size(416, 392);
			this.pl.TabIndex = 8;
			this.pl.XData = null;
			this.pl.XGrid = 10;
			this.pl.XLogBase = 0;
			this.pl.XRangeEnd = 100;
			this.pl.XRangeStart = 0;
			this.pl.YData = null;
			this.pl.YGrid = 10;
			this.pl.YLogBase = 0;
			this.pl.YRangeEnd = 100;
			this.pl.YRangeStart = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(710, 436);
			this.Controls.Add(this.pl);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			pl.ColorBg = Color.LightYellow;
			pl.ColorGrid = Color.LightGray;
			pl.XLogBase = 0;
			pl.XRangeStart = -100;
			pl.XRangeEnd = 1000;
			pl.XGrid = 100;
			pl.YLogBase = 0;
			pl.YRangeStart = -10;
			pl.YRangeEnd = 10;
			pl.YGrid = 2;
			pl.XData = new Double[] { -10, 10, 200, 250, 700 } ;
			pl.YData = new Double[] { 5, -2, -3, 1, 7 } ;
			pl.Refresh();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			pl.YLogBase = 10;
			pl.YRangeStart = 1;
			pl.YRangeEnd = 100000;
			pl.XLogBase = 0;
			pl.XRangeStart = 0;
			pl.XRangeEnd = 100;
			pl.XGrid = 10;
			pl.YData = new Double[] { 1.1, 10, 100, 1000, 10000 } ;
			pl.XData = new Double[] { 0, 10, 30, 50, 80 } ;
			pl.Refresh();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			pl.XLogBase = 10;
			pl.XRangeStart = 1;
			pl.XRangeEnd = 100000;
			pl.YLogBase = 0;
			pl.YRangeStart = 0;
			pl.YRangeEnd = 100;
			pl.YGrid = 10;
			pl.XData = new Double[] { 1.1, 10, 100, 1000, 10000 } ;
			pl.YData = new Double[] { 0, 10, 30, 50, 80 } ;
			pl.Refresh();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			pl.ColorBg = Color.White;
			pl.ColorGrid = Color.FromArgb(255, 200,200);
			pl.XLogBase = 10;
			pl.XRangeStart = 1;
			pl.XRangeEnd = 100000;
			pl.YLogBase = 10;
			pl.YRangeStart = 1;
			pl.YRangeEnd = 100000;
			pl.XData = new Double[] { 1.1, 10, 100, 1000, 10000 } ;
			pl.YData = new Double[] { 1.1, 10, 100, 1000, 10000 } ;
			pl.Refresh();
		}

		private void propertyGrid1_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			pl.Refresh();
		}

		private void propertyGrid1_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}
