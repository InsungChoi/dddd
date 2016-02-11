using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Diagnostics;

namespace DataPlotter
{
	/// <summary>
	/// The Plotter calss is a control to display 2D data
	/// in an X/Y coordinate system.
	/// For both axis a linear or logarithmic view can be used.
	/// </summary>
	public class Plotter : System.Windows.Forms.UserControl
	{
		private System.ComponentModel.Container components = null;

		public Plotter()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// Plotter
			// 
			this.Name = "Plotter";
			this.Size = new System.Drawing.Size(272, 216);
			this.Resize += new System.EventHandler(this.Plotter_Resize);

		}
		#endregion

		private Color colorDraw = Color.DarkBlue;
		[Category("Plotter")]
		[Description("The color of the data line")]
		public Color  ColorDraw
		{
			get {return colorDraw;}
			set {colorDraw = value;}
		}

		private Color colorGrid = Color.LightGray;
		[Category("Plotter")]
		[Description("The color of the gird lines")]
		public Color  ColorGrid
		{
			get {return colorGrid;}
			set {colorGrid = value;}
		}

		private Color colorBg = Color.White;
		[Category("Plotter")]
		[Description("The background color")]
		public Color  ColorBg
		{
			get {return colorBg;}
			set {colorBg = value;}
		}

		private Color colorAxis = Color.Black;
		[Category("Plotter")]
		[Description("The color of the axis and text")]
		public Color  ColorAxis
		{
			get {return colorAxis;}
			set {colorAxis = value;}
		}

		private Font fontAxis = new Font("Arial", 8);
		[Category("Plotter")]
		[Description("The font for the text")]
		public Font  FontAxis
		{
			get {return fontAxis;}
			set {fontAxis = value;}
		}

		private int penWidth = 2;
		[Category("Plotter")]
		[Description("The width of the data line")]
		public int  PenWidth
		{
			get {return penWidth;}
			set {penWidth = value;}
		}

		public enum DrawModeType { Line = 1, Dot, Bar };
		private DrawModeType drawMode = DrawModeType.Line;
		[Category("Plotter")]
		[Description("Draw mode for the data points")]
		public DrawModeType  DrawMode
		{
			get {return drawMode;}
			set {drawMode = value;}
		}

		private int borderTop = 30;
		[Category("Plotter")]
		[Description("The internal border at the top")]
		public int  BorderTop
		{
			get {return borderTop;}
			set {borderTop = value;}
		}

		private int borderLeft = 50;
		[Category("Plotter")]
		[Description("The internal border at the left")]
		public int  BorderLeft
		{
			get {return borderLeft;}
			set {borderLeft = value;}
		}

		private int borderBottom = 50;
		[Category("Plotter")]
		[Description("The internal border at the bottom")]
		public int  BorderBottom
		{
			get {return borderBottom;}
			set {borderBottom = value;}
		}

		private int borderRight = 30;
		[Category("Plotter")]
		[Description("The internal border at the right")]
		public int  BorderRight
		{
			get {return borderRight;}
			set {borderRight = value;}
		}

		private double xRangeStart = 0;
		[Category("Plotter")]
		[Description("The start of the data range on the x axis")]
		public double  XRangeStart
		{
			get {return xRangeStart;}
			set {xRangeStart = value;}
		}

		private double xRangeEnd = 100;
		[Category("Plotter")]
		[Description("The end of the data range on the x axis")]
		public double  XRangeEnd
		{
			get {return xRangeEnd;}
			set {xRangeEnd = value;}
		}

		private double yRangeStart = 0;
		[Category("Plotter")]
		[Description("The start of the data range on the y axis")]
		public double  YRangeStart
		{
			get {return yRangeStart;}
			set {yRangeStart = value;}
		}

		private double yRangeEnd = 100;
		[Category("Plotter")]
		[Description("The end of the data range on the y axis")]
		public double  YRangeEnd
		{
			get {return yRangeEnd;}
			set {yRangeEnd = value;}
		}

		private double xGrid = 10;
		[Category("Plotter")]
		[Description("The spacing for the linear grid in x direction. Ingnored for log. views")]
		public double  XGrid
		{
			get {return xGrid;}
			set {xGrid = value;}
		}
		
		private double yGrid = 10;
		[Category("Plotter")]
		[Description("The spacing for the linear grid in y direction. Ingnored for log. views")]
		public double  YGrid
		{
			get {return yGrid;}
			set {yGrid = value;}
		}

		private int xLogBase = 0;
		[Category("Plotter")]
		[Description("The base for log. views in x direction. If < 2 then a linear view is displayed")]
		public int  XLogBase
		{
			get {return xLogBase;}
			set {xLogBase = value;}
		}

		private int yLogBase = 0;
		[Category("Plotter")]
		[Description("The base for log. views in y direction. If < 2 then a linear view is displayed")]
		public int  YLogBase
		{
			get {return yLogBase;}
			set {yLogBase = value;}
		}
		
		private double[] xData;
		[Category("Plotter")]
		[Description("The data to be displayed for x.")]
		public double[] XData
		{
			get {return xData;}
			set {xData = value;}
		}
		
		private double[] yData;
		[Category("Plotter")]
		[Description("The data to be displayed for y.")]
		public double[] YData
		{
			get {return yData;}
			set {yData = value;}
		}
		
		protected override void OnPaint(PaintEventArgs e) 
		{
			int x0, y0, x1, y1, w0, h0, w1, h1;
			int i, j, x, y, n, d, d1;
			string s;

			try	// overall exception handling to avoid crashes
			{
				// check properties
				if (xRangeEnd <= xRangeStart) return;
				if (yRangeEnd <= yRangeStart) return;
				if (xLogBase < 2) 
				{
					if (xGrid <= 0) return;
				}
				else
				{
					if (xRangeStart <= 0) return;
				}
				if (yLogBase < 2) 
				{
					if (yGrid <= 0) return;
				}
				else
				{
					if (yRangeStart <= 0) return;
				}

				// prepare the tools
				Graphics g = e.Graphics;
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				g.FillRectangle(new SolidBrush(colorBg), ClientRectangle);
				Pen penDraw = new Pen(colorDraw, penWidth);
				Pen penGrid = new Pen(colorGrid, 1);
				Pen penAxis = new Pen(colorAxis, 1);
				SolidBrush brushAxis = new SolidBrush(colorAxis);

				// calculate coordinates, width and hight inside
				x0 = ClientRectangle.Left + borderLeft;
				y0 = ClientRectangle.Top + borderTop;
				w0 = ClientRectangle.Width - borderLeft - borderRight;
				h0 = ClientRectangle.Height - borderTop - borderBottom;
				x1 = ClientRectangle.Right - borderRight;
				y1 = ClientRectangle.Bottom - borderBottom;

				// draw grid
				if (xLogBase < 2)		// linear
				{
					n = Convert.ToInt32((xRangeEnd - xRangeStart) / xGrid);
					if (n == 0) n = 1;
					d = w0 / n;
					for (i = 0; i <= n; i++)
					{
						x = x0 + i * d;
						g.DrawLine(penGrid, x, y0, x, y1);
						s = Convert.ToString(xRangeStart + (xRangeEnd - xRangeStart) * i / n);
						SizeF sf = g.MeasureString(s, fontAxis);
						g.DrawString(s, fontAxis, brushAxis, 
							x - sf.Width / 2, y1 + sf.Height / 2);
					}
				}
				else					// logarithmic
				{
					n = Convert.ToInt32(
						Math.Log(xRangeEnd, xLogBase) - Math.Log(xRangeStart, xLogBase));
					if (n == 0) n = 1;
					d = w0 / n;
					for (i = 0; i <= n; i++)
					{
						x = x0 + i * d;
						if (i < n)
						{
							for (j = 1; j < xLogBase; j++)
							{
								d1 = Convert.ToInt32(Math.Log(j, xLogBase) * d);
								g.DrawLine(penGrid, x + d1, y0, x + d1, y1);
							}
						}
						s = Convert.ToString(
							Math.Pow(xLogBase, Math.Log(xRangeStart, xLogBase) + i));
						SizeF sf = g.MeasureString(s, fontAxis);
						g.DrawString(s, fontAxis, brushAxis, 
							x - sf.Width / 2, y1 + sf.Height / 2);
					}
				}
				w1 = d * n;

				if (yLogBase < 2)		// linear
				{
					n = Convert.ToInt32((yRangeEnd - yRangeStart) / yGrid);
					if (n == 0) n = 1;
					d = h0 / n;
					for (i = 0; i <= n; i++)
					{
						y = y1 - i * d;
						g.DrawLine(penGrid, x0, y, x1, y);
						s = Convert.ToString(yRangeStart + (yRangeEnd - yRangeStart) * i / n);
						SizeF sf = g.MeasureString(s, fontAxis);
						g.DrawString(s, fontAxis, brushAxis, 
							x0 - sf.Width - sf.Height / 4, y - sf.Height / 2);
					}
				}
				else					// logarithmic
				{
					n = Convert.ToInt32(
						Math.Log(yRangeEnd, yLogBase) - Math.Log(yRangeStart, yLogBase));
					if (n == 0) n = 1;
					d = h0 / n;
					for (i = 0; i <= n; i++)
					{
						y = y1 - i * d;
						if (i < n)
						{
							for (j = 1; j < yLogBase; j++)
							{
								d1 = Convert.ToInt32(Math.Log(j, yLogBase) * d);
								g.DrawLine(penGrid, x0, y - d1, x1, y - d1);
							}
						}
						s = Convert.ToString(
							Math.Pow(yLogBase, Math.Log(yRangeStart, yLogBase) + i));
						SizeF sf = g.MeasureString(s, fontAxis);
						g.DrawString(s, fontAxis, brushAxis, 
							x0 - sf.Width - sf.Height / 4, y - sf.Height / 2);
					}
				}
				h1 = d * n;

				// draw axis
				g.DrawRectangle(penAxis, x0, y0, w0, h0);

				// Correct internal width and height.
				// This is necessary because equidistant grid lines may not fit into
				// the axis rectangle without rounding errors
				h0 = h1;
				w0 = w1;

				// draw data if available

				if (xData == null || yData == null) return;
				if (xData.Length != yData.Length) return;

				// first convert the data arrays into points inside the axis rectangle
				Point[] pt = new Point[xData.Length];
				Point lastValidPt = new Point(x0, y1);
				for (i = 0; i < pt.Length; i++)
				{
					try	// catch invalid data points 
					{
						if (xLogBase < 2)
						{
							pt[i].X = Convert.ToInt32(x0 + 
								(xData[i] - xRangeStart) / (xRangeEnd - xRangeStart) * w0);
						}
						else
						{
							pt[i].X = Convert.ToInt32(x0 + 
								(Math.Log(xData[i], xLogBase) - Math.Log(xRangeStart, xLogBase)) / 
								(Math.Log(xRangeEnd, xLogBase) - Math.Log(xRangeStart, xLogBase)) * w0);
						}

						if (yLogBase < 2)
						{
							pt[i].Y = Convert.ToInt32(y1 - 
								(yData[i] - yRangeStart) / (yRangeEnd - yRangeStart) * h0);
						}
						else
						{
							pt[i].Y = Convert.ToInt32(y1 - 
								(Math.Log(yData[i], yLogBase) - Math.Log(yRangeStart, yLogBase)) / 
								(Math.Log(yRangeEnd, yLogBase) - Math.Log(yRangeStart, yLogBase)) * h0);
						}
						lastValidPt = pt[i];
					}
					catch(System.Exception )
					{ 
						pt[i] = lastValidPt;	// redraw last valid point on error
					}

				}

				// now draw the points
				for (i = 0; i < pt.Length; i++)
				{
					switch(drawMode)
					{
						case DrawModeType.Dot:
							Debug.WriteLine("Dot");
							g.DrawEllipse(penDraw, 
								pt[i].X - penWidth / 2, pt[i].Y - penWidth / 2, 
								penWidth, penWidth);
							break;

						case DrawModeType.Bar:
							Debug.WriteLine("Bar");
							g.DrawLine(penDraw, new Point(pt[i].X, y1), pt[i]);
							break;

						default:
							if (i > 0) g.DrawLine(penDraw, pt[i - 1], pt[i]);
							break;
					}
				}
			}
			catch(System.Exception )
			{ }
		}

		private void Plotter_Resize(object sender, System.EventArgs e)
		{
			this.Refresh();
		}
	}
}
