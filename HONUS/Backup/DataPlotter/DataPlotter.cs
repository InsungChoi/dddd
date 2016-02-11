/*
 *    DataPlotter.Plotter Component.
 * 
 *    Now one Series. Soon Extended in multiple series.
 * 
 *    Original Writer : unknown.
 * 
 *    2005-03-07 last updated by mortalpain of infinik.
 * 
 *    Extended in multiple series.
 * 
*/
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

		public bool bIsColorMap = false;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem miXRangeEnd;
		private System.Windows.Forms.MenuItem miXGrid;
		private System.Windows.Forms.MenuItem miYRangeStart;
		private System.Windows.Forms.MenuItem miRangeEnd;
		private System.Windows.Forms.MenuItem miYGrid;
		private System.Windows.Forms.MenuItem miColorGrid;
		private System.Windows.Forms.MenuItem miColorBackGround;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.MenuItem miXLabel;
		private System.Windows.Forms.MenuItem miLabel;
		private System.Windows.Forms.MenuItem miTitle;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem miAxisFont;
		private System.Windows.Forms.MenuItem miLabelFont;
		private System.Windows.Forms.MenuItem miTitleFont;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem miNone;
		private System.Windows.Forms.MenuItem miCircle;
		private System.Windows.Forms.MenuItem miSquare;
		private System.Windows.Forms.MenuItem miCross;
		private System.Windows.Forms.MenuItem miPlus;
		private System.Windows.Forms.MenuItem miTriangle;
		private System.Windows.Forms.MenuItem miDiamond;
		private System.Windows.Forms.MenuItem miAsterik;
		private System.Windows.Forms.MenuItem miLeft;
		private System.Windows.Forms.MenuItem miRight;
		private System.Windows.Forms.MenuItem miDown;
		private System.Windows.Forms.MenuItem miPenwidth;
		private System.Windows.Forms.MenuItem miShowGrid;
		private System.Windows.Forms.MenuItem miShowLegend;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem miAxisMode_Linear;
		private System.Windows.Forms.MenuItem miAxisMode_Log10;
		private int ColorBarGap = 30;

		bool bShowGrid = true;
		private System.Windows.Forms.MenuItem miMakerSize;
		private System.Windows.Forms.MenuItem mi_Title;
		private System.Windows.Forms.MenuItem miColorXLabel;
		private System.Windows.Forms.MenuItem miColorYLabel;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem miLinear;
		private System.Windows.Forms.MenuItem miLog10;
		private System.Windows.Forms.MenuItem miDB;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem miLegendPosition_LeftTop;
		private System.Windows.Forms.MenuItem miLegendPosition_LeftRight;
		private System.Windows.Forms.MenuItem miLegendPosition_RightTop;
		private System.Windows.Forms.MenuItem miLegendPosition_RightDown;
		private System.Windows.Forms.MenuItem miGraphSave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.MenuItem miDataSeries;
		bool bShowLegend = false;

		public Plotter()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			series = new ArrayList();
		}

		public Plotter(int SeriesCount)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			series = new ArrayList(SeriesCount);
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
				{
					series.Clear();
					components.Dispose();
				}

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
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.miXRangeEnd = new System.Windows.Forms.MenuItem();
			this.miXGrid = new System.Windows.Forms.MenuItem();
			this.miXLabel = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.miAxisMode_Linear = new System.Windows.Forms.MenuItem();
			this.miAxisMode_Log10 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.miYRangeStart = new System.Windows.Forms.MenuItem();
			this.miRangeEnd = new System.Windows.Forms.MenuItem();
			this.miYGrid = new System.Windows.Forms.MenuItem();
			this.miLabel = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.miLinear = new System.Windows.Forms.MenuItem();
			this.miLog10 = new System.Windows.Forms.MenuItem();
			this.miDB = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.miColorGrid = new System.Windows.Forms.MenuItem();
			this.miColorBackGround = new System.Windows.Forms.MenuItem();
			this.mi_Title = new System.Windows.Forms.MenuItem();
			this.miColorXLabel = new System.Windows.Forms.MenuItem();
			this.miColorYLabel = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.miAxisFont = new System.Windows.Forms.MenuItem();
			this.miLabelFont = new System.Windows.Forms.MenuItem();
			this.miTitleFont = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.miNone = new System.Windows.Forms.MenuItem();
			this.miCircle = new System.Windows.Forms.MenuItem();
			this.miSquare = new System.Windows.Forms.MenuItem();
			this.miCross = new System.Windows.Forms.MenuItem();
			this.miPlus = new System.Windows.Forms.MenuItem();
			this.miTriangle = new System.Windows.Forms.MenuItem();
			this.miDiamond = new System.Windows.Forms.MenuItem();
			this.miAsterik = new System.Windows.Forms.MenuItem();
			this.miLeft = new System.Windows.Forms.MenuItem();
			this.miRight = new System.Windows.Forms.MenuItem();
			this.miDown = new System.Windows.Forms.MenuItem();
			this.miMakerSize = new System.Windows.Forms.MenuItem();
			this.miTitle = new System.Windows.Forms.MenuItem();
			this.miPenwidth = new System.Windows.Forms.MenuItem();
			this.miShowGrid = new System.Windows.Forms.MenuItem();
			this.miShowLegend = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.miLegendPosition_LeftTop = new System.Windows.Forms.MenuItem();
			this.miLegendPosition_LeftRight = new System.Windows.Forms.MenuItem();
			this.miLegendPosition_RightTop = new System.Windows.Forms.MenuItem();
			this.miLegendPosition_RightDown = new System.Windows.Forms.MenuItem();
			this.miGraphSave = new System.Windows.Forms.MenuItem();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.miDataSeries = new System.Windows.Forms.MenuItem();
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1,
																						 this.menuItem10,
																						 this.menuItem5,
																						 this.menuItem6,
																						 this.miMakerSize,
																						 this.miTitle,
																						 this.miPenwidth,
																						 this.miShowGrid,
																						 this.miShowLegend,
																						 this.menuItem9,
																						 this.miGraphSave,
																						 this.miDataSeries});
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "Axis";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.miXRangeEnd,
																					  this.miXGrid,
																					  this.miXLabel,
																					  this.menuItem7});
			this.menuItem2.Text = "X";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "RangeStart";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// miXRangeEnd
			// 
			this.miXRangeEnd.Index = 1;
			this.miXRangeEnd.Text = "RangeEnd";
			this.miXRangeEnd.Click += new System.EventHandler(this.miXRangeEnd_Click);
			// 
			// miXGrid
			// 
			this.miXGrid.Index = 2;
			this.miXGrid.Text = "Grid";
			this.miXGrid.Click += new System.EventHandler(this.miXGrid_Click);
			// 
			// miXLabel
			// 
			this.miXLabel.Index = 3;
			this.miXLabel.Text = "Label";
			this.miXLabel.Click += new System.EventHandler(this.miXLabel_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 4;
			this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miAxisMode_Linear,
																					  this.miAxisMode_Log10});
			this.menuItem7.Text = "Axis Mode";
			// 
			// miAxisMode_Linear
			// 
			this.miAxisMode_Linear.Index = 0;
			this.miAxisMode_Linear.Text = "Linear";
			this.miAxisMode_Linear.Click += new System.EventHandler(this.miAxisMode_Linear_Click);
			// 
			// miAxisMode_Log10
			// 
			this.miAxisMode_Log10.Index = 1;
			this.miAxisMode_Log10.Text = "Log10";
			this.miAxisMode_Log10.Click += new System.EventHandler(this.miAxisMode_Log10_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miYRangeStart,
																					  this.miRangeEnd,
																					  this.miYGrid,
																					  this.miLabel,
																					  this.menuItem8});
			this.menuItem3.Text = "Y";
			// 
			// miYRangeStart
			// 
			this.miYRangeStart.Index = 0;
			this.miYRangeStart.Text = "RangeStart";
			this.miYRangeStart.Click += new System.EventHandler(this.miYRangeStart_Click);
			// 
			// miRangeEnd
			// 
			this.miRangeEnd.Index = 1;
			this.miRangeEnd.Text = "RangeEnd";
			this.miRangeEnd.Click += new System.EventHandler(this.miRangeEnd_Click);
			// 
			// miYGrid
			// 
			this.miYGrid.Index = 2;
			this.miYGrid.Text = "Grid";
			this.miYGrid.Click += new System.EventHandler(this.miYGrid_Click);
			// 
			// miLabel
			// 
			this.miLabel.Index = 3;
			this.miLabel.Text = "Label";
			this.miLabel.Click += new System.EventHandler(this.miLabel_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 4;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miLinear,
																					  this.miLog10,
																					  this.miDB});
			this.menuItem8.Text = "Axis Mode";
			// 
			// miLinear
			// 
			this.miLinear.Index = 0;
			this.miLinear.Text = "Linear";
			this.miLinear.Click += new System.EventHandler(this.miLinear_Click);
			// 
			// miLog10
			// 
			this.miLog10.Index = 1;
			this.miLog10.Text = "Log10";
			this.miLog10.Click += new System.EventHandler(this.miLog10_Click);
			// 
			// miDB
			// 
			this.miDB.Index = 2;
			this.miDB.Text = "dB";
			this.miDB.Click += new System.EventHandler(this.miDB_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 1;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.miColorGrid,
																					   this.miColorBackGround,
																					   this.mi_Title,
																					   this.miColorXLabel,
																					   this.miColorYLabel});
			this.menuItem10.Text = "Color";
			// 
			// miColorGrid
			// 
			this.miColorGrid.Index = 0;
			this.miColorGrid.Text = "Grid";
			this.miColorGrid.Click += new System.EventHandler(this.miColorGrid_Click);
			// 
			// miColorBackGround
			// 
			this.miColorBackGround.Index = 1;
			this.miColorBackGround.Text = "BackGround";
			this.miColorBackGround.Click += new System.EventHandler(this.miColorBackGround_Click);
			// 
			// mi_Title
			// 
			this.mi_Title.Index = 2;
			this.mi_Title.Text = "Title";
			this.mi_Title.Click += new System.EventHandler(this.mi_Title_Click);
			// 
			// miColorXLabel
			// 
			this.miColorXLabel.Index = 3;
			this.miColorXLabel.Text = "X Label";
			this.miColorXLabel.Click += new System.EventHandler(this.miColorXLabel_Click);
			// 
			// miColorYLabel
			// 
			this.miColorYLabel.Index = 4;
			this.miColorYLabel.Text = "Y Label";
			this.miColorYLabel.Click += new System.EventHandler(this.miColorYLabel_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miAxisFont,
																					  this.miLabelFont,
																					  this.miTitleFont});
			this.menuItem5.Text = "Font";
			// 
			// miAxisFont
			// 
			this.miAxisFont.Index = 0;
			this.miAxisFont.Text = "Axis Font";
			this.miAxisFont.Click += new System.EventHandler(this.miAxisFont_Click);
			// 
			// miLabelFont
			// 
			this.miLabelFont.Index = 1;
			this.miLabelFont.Text = "Label Font";
			this.miLabelFont.Click += new System.EventHandler(this.miLabelFont_Click);
			// 
			// miTitleFont
			// 
			this.miTitleFont.Index = 2;
			this.miTitleFont.Text = "Title Font";
			this.miTitleFont.Click += new System.EventHandler(this.miTitleFont_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 3;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miNone,
																					  this.miCircle,
																					  this.miSquare,
																					  this.miCross,
																					  this.miPlus,
																					  this.miTriangle,
																					  this.miDiamond,
																					  this.miAsterik,
																					  this.miLeft,
																					  this.miRight,
																					  this.miDown});
			this.menuItem6.Text = "Mark Type";
			// 
			// miNone
			// 
			this.miNone.Index = 0;
			this.miNone.Text = "None";
			this.miNone.Click += new System.EventHandler(this.miNone_Click);
			// 
			// miCircle
			// 
			this.miCircle.Index = 1;
			this.miCircle.Text = "Circle";
			this.miCircle.Click += new System.EventHandler(this.miCircle_Click);
			// 
			// miSquare
			// 
			this.miSquare.Index = 2;
			this.miSquare.Text = "Square";
			this.miSquare.Click += new System.EventHandler(this.miSquare_Click);
			// 
			// miCross
			// 
			this.miCross.Index = 3;
			this.miCross.Text = "Cross";
			this.miCross.Click += new System.EventHandler(this.miCross_Click);
			// 
			// miPlus
			// 
			this.miPlus.Index = 4;
			this.miPlus.Text = "Plus";
			this.miPlus.Click += new System.EventHandler(this.miPlus_Click);
			// 
			// miTriangle
			// 
			this.miTriangle.Index = 5;
			this.miTriangle.Text = "Triangle";
			this.miTriangle.Click += new System.EventHandler(this.miTriangle_Click);
			// 
			// miDiamond
			// 
			this.miDiamond.Index = 6;
			this.miDiamond.Text = "Diamond";
			this.miDiamond.Click += new System.EventHandler(this.miDiamond_Click);
			// 
			// miAsterik
			// 
			this.miAsterik.Index = 7;
			this.miAsterik.Text = "Asterik";
			this.miAsterik.Click += new System.EventHandler(this.miAsterik_Click);
			// 
			// miLeft
			// 
			this.miLeft.Index = 8;
			this.miLeft.Text = "Left";
			this.miLeft.Click += new System.EventHandler(this.miLeft_Click);
			// 
			// miRight
			// 
			this.miRight.Index = 9;
			this.miRight.Text = "Right";
			this.miRight.Click += new System.EventHandler(this.miRight_Click);
			// 
			// miDown
			// 
			this.miDown.Index = 10;
			this.miDown.Text = "Down";
			this.miDown.Click += new System.EventHandler(this.miDown_Click);
			// 
			// miMakerSize
			// 
			this.miMakerSize.Index = 4;
			this.miMakerSize.Text = "Maker Size";
			this.miMakerSize.Click += new System.EventHandler(this.miMakerSize_Click);
			// 
			// miTitle
			// 
			this.miTitle.Index = 5;
			this.miTitle.Text = "Title";
			this.miTitle.Click += new System.EventHandler(this.miTitle_Click);
			// 
			// miPenwidth
			// 
			this.miPenwidth.Index = 6;
			this.miPenwidth.Text = "PenWidth";
			this.miPenwidth.Click += new System.EventHandler(this.miPenwidth_Click);
			// 
			// miShowGrid
			// 
			this.miShowGrid.Index = 7;
			this.miShowGrid.Text = "Show Grid";
			this.miShowGrid.Click += new System.EventHandler(this.miShowGrid_Click);
			// 
			// miShowLegend
			// 
			this.miShowLegend.Index = 8;
			this.miShowLegend.Text = "Show Legend";
			this.miShowLegend.Click += new System.EventHandler(this.miShowLegend_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 9;
			this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miLegendPosition_LeftTop,
																					  this.miLegendPosition_LeftRight,
																					  this.miLegendPosition_RightTop,
																					  this.miLegendPosition_RightDown});
			this.menuItem9.Text = "Legend Position";
			// 
			// miLegendPosition_LeftTop
			// 
			this.miLegendPosition_LeftTop.Index = 0;
			this.miLegendPosition_LeftTop.Text = "LEFT TOP";
			this.miLegendPosition_LeftTop.Click += new System.EventHandler(this.miLegendPosition_LeftTop_Click);
			// 
			// miLegendPosition_LeftRight
			// 
			this.miLegendPosition_LeftRight.Index = 1;
			this.miLegendPosition_LeftRight.Text = "LEFT DOWN";
			this.miLegendPosition_LeftRight.Click += new System.EventHandler(this.miLegendPosition_LeftRight_Click);
			// 
			// miLegendPosition_RightTop
			// 
			this.miLegendPosition_RightTop.Index = 2;
			this.miLegendPosition_RightTop.Text = "RIGHT TOP";
			this.miLegendPosition_RightTop.Click += new System.EventHandler(this.miLegendPosition_RightTop_Click);
			// 
			// miLegendPosition_RightDown
			// 
			this.miLegendPosition_RightDown.Index = 3;
			this.miLegendPosition_RightDown.Text = "RIGHT DOWN";
			this.miLegendPosition_RightDown.Click += new System.EventHandler(this.miLegendPosition_RightDown_Click);
			// 
			// miGraphSave
			// 
			this.miGraphSave.Index = 10;
			this.miGraphSave.Text = "Graph Save";
			this.miGraphSave.Click += new System.EventHandler(this.miGraphSave_Click);
			// 
			// miDataSeries
			// 
			this.miDataSeries.Index = 11;
			this.miDataSeries.Text = "Data Series";
			// 
			// Plotter
			// 
			this.ContextMenu = this.contextMenu1;
			this.Name = "Plotter";
			this.Size = new System.Drawing.Size(272, 216);
			this.Resize += new System.EventHandler(this.Plotter_Resize);
			this.Load += new System.EventHandler(this.Plotter_Load);

		}
		#endregion

		private String title = "Plotter Example";
		[Category("Plotter")]
		[Description("The title of the Plotter")]
		public String  Title
		{
			get {return title;}
			set {title = value;}
		}

		private String xlabel = "X Axis";
		[Category("Plotter")]
		[Description("The labeling of x Axis of the Plotter")]
		public String  XLabel
		{
			get {return xlabel;}
			set {xlabel = value;}
		}

		private String ylabel = "Y Axis";
		[Category("Plotter")]
		[Description("The title of the Plotter")]
		public String  YLabel
		{
			get {return ylabel;}
			set {ylabel = value;}
		}

		private String zlabel = "Z Axis";
		[Category("Plotter")]
		[Description("The title of the Plotter")]
		public String  ZLabel
		{
			get {return zlabel;}
			set {zlabel = value;}
		}

		private Color titlecolor = Color.Black;
		[Category("Plotter")]
		[Description("The color of the title color")]
		public Color  TitleColor
		{
			get {return titlecolor;}
			set {titlecolor = value;}
		}

		private Color xlabelcolor = Color.DarkBlue;
		[Category("Plotter")]
		[Description("The color of label color of X Axis")]
		public Color XLabelColor
		{
			get {return xlabelcolor;}
			set {xlabelcolor = value;}
		}

		private Color ylabelcolor = Color.DarkBlue;
		[Category("Plotter")]
		[Description("The color of label color of Y Axis")]
		public Color YLabelColor
		{
			get {return ylabelcolor;}
			set {ylabelcolor = value;}
		}

		private Color zlabelcolor = Color.DarkBlue;
		[Category("Plotter")]
		[Description("The color of label color of Z Axis")]
		public Color ZLabelColor
		{
			get {return zlabelcolor;}
			set {zlabelcolor = value;}
		}

		private Font fontTitle = new Font("굴림", 9);
		[Category("Plotter")]
		[Description("The font for title")]
		public Font  FontTitle
		{
			get {return fontTitle;}
			set {fontTitle = value;}
		}

		private Font fontLabel = new Font("굴림", 9);
		[Category("Plotter")]
		[Description("The font for the label")]
		public Font  FontLabel
		{
			get {return fontLabel;}
			set {fontLabel = value;}
		}

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

		private bool grid = true;
		[Category("Plotter")]
		[Description("whether grid of plotter shows or not")]
		public  bool ShowGrid
		{
			get {return grid;}
			set {grid = value;}
		}

		private int penWidth = 1;
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

		public enum MarkerModeType { None = 1, Circle, Square, Cross, Plus, Triangle, Diamond, Asterik, Left, Right, Down };
		private MarkerModeType markerType = MarkerModeType.None;
		[Category("Plotter")]
		[Description("Marker type for the data points")]
		public MarkerModeType MarkerType
		{
			get {return markerType;}
			set {markerType = value;}
		}

		public enum LegendPosition_Enum { LEFT_TOP = 1, LEFT_DOWN , RIGHT_TOP , RIGHT_DOWN };
		private LegendPosition_Enum LegendPosition_ = LegendPosition_Enum.LEFT_TOP;
		[Category("Plotter")]
		[Description("Legend Position")]
		public LegendPosition_Enum LegendPosition_Proferty
		{
			get {return LegendPosition_;}
			set {LegendPosition_ = value;}
		}

		private int markerSize = 4;
		[Category("Plotter")]
		[Description("Marker Size for the data points")]
		public int MarkerSize 
		{
			get { return ( markerSize >= 2 || markerSize <= 48 ) ? markerSize : 6 ;}
			set {markerSize = value;}
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

		private double zRangeStart = 0;
		[Category("Plotter")]
		[Description("The start of the data range on the z axis")]
		public double  ZRangeStart
		{
			get {return zRangeStart;}
			set {zRangeStart = value;}
		}

		private double zRangeEnd = 100;
		[Category("Plotter")]
		[Description("The end of the data range on the z axis")]
		public double  ZRangeEnd
		{
			get {return zRangeEnd;}
			set {zRangeEnd = value;}
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

		public enum XAxisModeType { Linear = 0, Log10 };
		private XAxisModeType FXAxisMode = XAxisModeType.Linear;
		[Category("Plotter")]
		[Description("X Axis Mode for the data points")]
		public XAxisModeType XAxisMode
		{
			get {return FXAxisMode;}
			set 
			{
				FXAxisMode = value;
				/*
				 * 반드시 돌아온다.... =ㅅ=;;
				XAxisModeType prev = FXAxisMode ;
				if ( value == XAxisModeType.Log10 && xRangeStart <= 0 ) 
				{
					MessageBox.Show("Wrong Condition !");
					FXAxisMode = prev; 
				}
				else	
				*/
				// 모드변경 가능하려면 주석제거. FXAxisMode = value;
			}
		}

		public enum YAxisModeType { Linear = 0, Log10, dB };
		private YAxisModeType FYAxisMode = YAxisModeType.Linear;
		[Category("Plotter")]
		[Description("Y Axis Mode for the data points")]
		public YAxisModeType YAxisMode
		{
			get {return FYAxisMode;}
			set 
			{
				FYAxisMode = value;
				// 모드변경 가능하려면 주석제거. 험난하다 인생아.... =ㅅ=;;
				/*
				 * 조건은 가능한대로 첨가하자.
				 * 
				YAxisModeType prev = FYAxisMode ;
				if ( value == YAxisModeType.dB && yRangeStart <= 0 ) 
				{
					MessageBox.Show("Wrong Condition !");
					FYAxisMode = prev; 
				}
				else if ( value == YAxisModeType.Log10 && yRangeStart <=0 ) 
				{
					MessageBox.Show("Wrong Condition !");
					FYAxisMode = prev; 
				}
				else if ( prev == YAxisModeType.Log10 && value == YAxisModeType.dB )
				{
					FYAxisMode = prev; 
				}
				else if ( prev == YAxisModeType.dB && value == YAxisModeType.Log10 )
				{
					FYAxisMode = prev; 
				}
				else
				{
					FYAxisMode = value;
				}
				*/
			}
		}

		public enum ZAxisModeType { Linear = 0};
		private ZAxisModeType FZAxisMode = ZAxisModeType.Linear;
		[Category("Plotter")]
		[Description("Z Axis Mode for the data points")]
		public ZAxisModeType ZAxisMode
		{
			get {return FZAxisMode;}
			set 
			{ 
				// 모드변경 가능하려면 주석제거. 험난하다 인생아.... =ㅅ=;;
				/*
				 * 조건은 가능한대로 첨가하자.
				 * 
				YAxisModeType prev = FYAxisMode ;
				if ( value == YAxisModeType.dB && yRangeStart <= 0 ) 
				{
					MessageBox.Show("Wrong Condition !");
					FYAxisMode = prev; 
				}
				else if ( value == YAxisModeType.Log10 && yRangeStart <=0 ) 
				{
					MessageBox.Show("Wrong Condition !");
					FYAxisMode = prev; 
				}
				else if ( prev == YAxisModeType.Log10 && value == YAxisModeType.dB )
				{
					FYAxisMode = prev; 
				}
				else if ( prev == YAxisModeType.dB && value == YAxisModeType.Log10 )
				{
					FYAxisMode = prev; 
				}
				else
				{
					FYAxisMode = value;
				}
				*/
			}
		}

		public bool XAxisModeChanged = false;
		public bool YAxisModeChanged = false;

		private bool showlegend = false;
		[Category("Plotter")]
		[Description("whether grid of plotter shows or not")]
		public  bool ShowLegend
		{
			get {return showlegend;}
			set {showlegend = value;}
		}

		// 2005-03-07 multiple series added by DataSeries Class.
		
		private ArrayList series ;
		[Category("Plotter")]
		[Description("Series of Plotter.")]
		public ArrayList Series
		{
			get { return series; }
			set { series = value ; }
		}

		private DataSeries FData = new DataSeries();
		[Category("Plotter")]
		[Description("Series Data Test of Plotter.")]
		public DataSeries Data
		{
			get { return FData ; }
			set { FData = value; }
		}

		private bool IsOctave_ = false;
		[Category("Plotter")]
		[Description("")]
		public bool IsOctave
		{
			get { return IsOctave_ ; }
			set { IsOctave_ = value; }
		}

		private int Interval_ = 0;
		[Category("Plotter")]
		[Description("")]
		public int Interval
		{
			get { return Interval_ ; }
			set { Interval_ = value; }
		}
		
		// 2005-03-08 Cursor Option Added.
		/*
		private bool FCursorMode = false ;
		[Category("Plotter")]
		[Description("The cursor mode of plotter.")]
		public bool CursorMode 
		{
			get { return FCursorMode ; }
			set { if ( ! grid && ! ShowLegend ) FCursorMode = value; }
		}
		*/
		
		protected override void OnPaint(PaintEventArgs e) 
		{
			if(bIsColorMap == false)
			{
				int x0, y0, x1, y1, w0, h0, w1=0, h1=0;
				int i, j, x, y, n, d, d1;
				string s;

//				try	// overall exception handling to avoid crashes
//				{
					// check properties
					if (xRangeEnd <= xRangeStart) return;
					if (yRangeEnd <= yRangeStart) return;
					if ( FXAxisMode == XAxisModeType.Linear )   // linear.
					{
						if (xGrid <= 0) return;
					}
					else                // logarithmic
					{
						if (xRangeStart <= 0) return;
					}
				
					switch ( FYAxisMode )
					{
						case YAxisModeType.Linear :  // linear.
							if (yGrid <= 0) return;
							break;		
						case YAxisModeType.Log10 :   // logarithmic.
							if (yRangeStart <= 0) return;
							break;
						case YAxisModeType.dB : 
							if (yRangeStart <= 0) return;     // dB Mode.
							break;
					}

					// prepare the tools
					Graphics g = e.Graphics;
					e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
					g.FillRectangle(new SolidBrush(colorBg), ClientRectangle);
					Pen penDraw = new Pen(colorDraw, penWidth);
					Pen penGrid = new Pen(colorGrid, 1);
					Pen penAxis = new Pen(colorAxis, 1);
					Pen penTitle = new Pen(titlecolor, 3);
					Pen penLabel = new Pen(xlabelcolor, 2);
					SolidBrush brushAxis = new SolidBrush(colorAxis);
					SolidBrush brushTitle = new SolidBrush(titlecolor);
					SolidBrush xBrushLabel = new SolidBrush(xlabelcolor);
					SolidBrush yBrushLabel = new SolidBrush(ylabelcolor);

					// calculate coordinates, width and hight inside
					x0 = ClientRectangle.Left + borderLeft;
					y0 = ClientRectangle.Top + borderTop;
					w0 = ClientRectangle.Width - borderLeft - borderRight;
					h0 = ClientRectangle.Height - borderTop - borderBottom;
					x1 = ClientRectangle.Right - borderRight;
					y1 = ClientRectangle.Bottom - borderBottom;

					// draw title and label

					s = title ;
					SizeF tp = g.MeasureString(s, fontTitle);
					//				g.DrawString(s, fontTitle, brushTitle, ClientRectangle.Left + w0/2-tp.Width/2, ClientRectangle.Top + 5);
					// 정기리가 수정한 부분
					g.DrawString(s, fontTitle, brushTitle, ((ClientRectangle.Left + ClientRectangle.Right) / 2) - (tp.Width / 2), ClientRectangle.Top + 5);
					// 여기까지

					s = xlabel ;
					tp = g.MeasureString(s, fontLabel);
					g.DrawString(s, fontLabel, xBrushLabel, ((ClientRectangle.Left + ClientRectangle.Right) / 2) - (tp.Width / 2), ClientRectangle.Bottom - 20);

					s = ylabel;
					tp = g.MeasureString(s, fontLabel);
					StringFormat drawFormat = new StringFormat();
					//drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
				drawFormat.FormatFlags = StringFormatFlags.FitBlackBox;
					//				g.DrawString(s, fontLabel, yBrushLabel, ClientRectangle.Left + 5, ClientRectangle.Top + tp.Width + 10, drawFormat);
					// 정기리가 수정한 부분
				g.RotateTransform(-90,System.Drawing.Drawing2D.MatrixOrder.Append);
				g.DrawString(s, fontLabel, yBrushLabel, ((ClientRectangle.Top - ClientRectangle.Bottom) / 2) - (tp.Width / 2),ClientRectangle.Left + 10, drawFormat);
				//g.DrawString(s, fontLabel, yBrushLabel, ClientRectangle.Left - 200, ((ClientRectangle.Top + ClientRectangle.Bottom) / 2) - 180, drawFormat);
				//	g.DrawString(s, fontLabel, yBrushLabel, ClientRectangle.Left + 10, ((ClientRectangle.Top + ClientRectangle.Bottom) / 2) - (tp.Width / 2), drawFormat);
				g.RotateTransform(90,System.Drawing.Drawing2D.MatrixOrder.Append);
				// 여기까지
					drawFormat.Dispose();

					// draw grid
					switch ( FXAxisMode )
					{
						case XAxisModeType.Linear :  // linear.
							if(IsOctave == false)
							{
								n = Convert.ToInt32(Math.Floor((xRangeEnd - xRangeStart) / xGrid));
								if (n == 0) n = 1;
								d = (int)(w0 * xGrid / (xRangeEnd - xRangeStart));
								for (i = 0; i <= n; i++)
								{
									x = x0 + i * d;

									// grid 기능이 있으면 그리드를 그린다.
							
									if ( grid ) g.DrawLine(penGrid, x, y0, x, y1); 
							
									// 데이터가 있다면 축을 그리는 펜으로 tick marker 를 그리자.
							
									//							if ( series.Count > 0 ) // 기존의것 ( xData != null && yData != null)
									//							{	
									g.DrawLine(penAxis, x, y1, x, y1-5);           
									g.DrawLine(penAxis, x, y0, x, y0+5);
									//							}

									// Tick Label
									s = Convert.ToString(xRangeStart + xGrid * i);
									SizeF sf = g.MeasureString(s, fontAxis);
									g.DrawString(s, fontAxis, brushAxis, x - sf.Width / 2, y1 + sf.Height / 2);
								}

								w1 = d * n;
							}
							else
							{
								n = Convert.ToInt32(((DataSeries)this.series[0]).XData.Length);

								float w0_Temp = w0;
								float n_Temp = n;
								float fTemp_d = w0_Temp / n_Temp ;
								float xd = 0;
								int count = Interval;
								for (i = 0; i < n; i++)
								{
									if(i == 0.0)
									{
										xd = fTemp_d / 2;
									}
									else
									{
										xd = fTemp_d + xd ;
									}

									x = (int)(x0 + xd);

									// grid 기능이 있으면 그리드를 그린다.
							
									if ( grid ) g.DrawLine(penGrid, x, y0, x, y1);
							
									if(Interval > 0)
									{
										if(Interval == count)
										{
											// 축을 그리는 펜으로 tick marker 를 그리자.
											g.DrawLine(penAxis, x, y1, x, y1-5);           
											g.DrawLine(penAxis, x, y0, x, y0+5);

											s = Convert.ToString(((DataSeries)series[0]).XData[(int)i]);
											SizeF sf = g.MeasureString(s, fontAxis);
											g.DrawString(s, fontAxis, brushAxis, x - sf.Width / 2, y1 + sf.Height / 2);

											count = 0;
										}
									}
									else
									{
										// 축을 그리는 펜으로 tick marker 를 그리자.
										g.DrawLine(penAxis, x, y1, x, y1-5);           
										g.DrawLine(penAxis, x, y0, x, y0+5);

										s = Convert.ToString(((DataSeries)series[0]).XData[(int)i]);
										SizeF sf = g.MeasureString(s, fontAxis);
										g.DrawString(s, fontAxis, brushAxis, x - sf.Width / 2, y1 + sf.Height / 2);
									}

									count++;
								}

								w1 = (int)(fTemp_d * n);
							}
							break;

						case XAxisModeType.Log10 :					// logarithmic
							//if ( xRangeStart > 0 )
							n = Convert.ToInt32(Math.Log10(xRangeEnd) - Math.Log10(xRangeStart));
							//else
							//n = Convert.ToInt32(Math.Log10(xRangeEnd));
							if (n == 0) n = 1;
							d = w0 / n;
							for (i = 0; i <= n; i++)
							{
								x = x0 + i * d;
								if (i < n)
								{
									for (j = 1; j < 10 /* log base */ ; j++)
									{
										d1 = Convert.ToInt32(Math.Log10(j) * d);
									
										// grid 기능이 있으면 그리드를 그린다.
									
										if ( grid ) g.DrawLine(penGrid, x + d1, y0, x + d1, y1);
									}
								}

								// 데이터가 있다면 축을 그리는 펜으로 tick marker 를 그리자.
							
								//							if ( series.Count > 0 ) // 기존의것 ( xData != null && yData != null)
								//							{	
								g.DrawLine(penAxis, x, y1, x, y1-5);           
								g.DrawLine(penAxis, x, y0, x, y0+5);
								//							}
							
								if ( xRangeStart > 0 )
									s = Convert.ToString(Math.Pow(10, Math.Log10(xRangeStart) + i));
								else
								{
									if ( i == 0 ) s = "0";
									if ( i != 0 ) s = Convert.ToString(Math.Pow(10, 0 + i));
								}
//								int Temp_ss = (int)double.Parse(s);
//								s = Temp_ss.ToString();
								SizeF sf = g.MeasureString(s, fontAxis);
								g.DrawString(s, fontAxis, brushAxis, x - sf.Width / 2, y1 + sf.Height / 2);
							}

							w1 = d * n;
							break;
					}

					switch ( FYAxisMode )
					{
						case YAxisModeType.Linear :  // linear.

							n = Convert.ToInt32(Math.Floor((yRangeEnd - yRangeStart) / yGrid));
							if (n == 0) n = 1;
							d = (int)(h0 * yGrid / (yRangeEnd - yRangeStart));
							for (i = 0; i <= n; i++)
							{
								y = y1 - i * d;

								// grid 기능이 있으면 그리드를 그린다.

								if ( grid ) g.DrawLine(penGrid, x0, y, x1, y);
							
								// 데이터가 있다면 축을 그리는 펜으로 tick marker 를 그리자.
							
								//							if ( series.Count > 0 ) // 기존의것 ( xData != null && yData != null)
								//							{	
								g.DrawLine(penAxis, x0, y, x0+5, y);           
								g.DrawLine(penAxis, x1, y, x1-5, y);
								//							}
							
								s = Convert.ToString(yRangeStart + yGrid * i);
								SizeF sf = g.MeasureString(s, fontAxis);
								g.DrawString(s, fontAxis, brushAxis, x0 - sf.Width - sf.Height / 4, y - sf.Height / 2);
							}

							h1 = d * n;
							break;	

						case YAxisModeType.Log10 :   // logarithmic.
						
							n = Convert.ToInt32(Math.Log10(yRangeEnd) - Math.Log10(yRangeStart));
							if (n == 0) n = 1;
							d = h0 / n;
							for (i = 0; i <= n; i++)
							{
								y = y1 - i * d;
								if (i < n)
								{
									for (j = 1; j < 10 ; j++)
									{									
										d1 = Convert.ToInt32(Math.Log10(j) * d);
								
										// grid 기능이 있으면 그리드를 그린다.
								
										if (grid ) g.DrawLine(penGrid, x0, y - d1, x1, y - d1);
									}
								}
						
								// 데이터가 있다면 축을 그리는 펜으로 tick marker 를 그리자.
						
								//							if ( series.Count > 0 ) // 기존의것 ( xData != null && yData != null)
								//							{	
								g.DrawLine(penAxis, x0, y, x0+5, y);           
								g.DrawLine(penAxis, x1, y, x1-5, y);
								//							}
						
								s = Convert.ToString(Math.Pow(10, Math.Log10(yRangeStart) + i));
//								int Temp_ss = (int)double.Parse(s);
//								s = Temp_ss.ToString();
								SizeF sf = g.MeasureString(s, fontAxis);
								g.DrawString(s, fontAxis, brushAxis, x0 - sf.Width - sf.Height / 4, y - sf.Height / 2);
							}

							h1 = d * n;
							break;
					
					
						case YAxisModeType.dB :  // dB Mode.
						
							n = Convert.ToInt32((yRangeEnd - yRangeStart) / yGrid);
							if (n == 0) n = 1;
							d = h0 / n;
							for (i = 0; i <= n; i++)
							{
								y = y1 - i * d;

								// grid 기능이 있으면 그리드를 그린다.

								if ( grid ) g.DrawLine(penGrid, x0, y, x1, y);
							
								// 데이터가 있다면 축을 그리는 펜으로 tick marker 를 그리자.
							
								//							if ( series.Count > 0 ) // 기존의것 ( xData != null && yData != null)
								//							{	
								g.DrawLine(penAxis, x0, y, x0+5, y);           
								g.DrawLine(penAxis, x1, y, x1-5, y);
								//							}
							
								s = Convert.ToString(yRangeStart + (yRangeEnd - yRangeStart) * i / n);
//								int Temp_ss = (int)double.Parse(s);
//								s = Temp_ss.ToString();
								SizeF sf = g.MeasureString(s, fontAxis);
								g.DrawString(s, fontAxis, brushAxis, x0 - sf.Width - sf.Height / 4, y - sf.Height / 2);
							}

							h1 = d * n;
							break;
					}

					// draw axis
					g.DrawRectangle(penAxis, x0, y0, w0, h0);

					// Correct internal width and height.
					// This is necessary because equidistant grid lines may not fit into
					// the axis rectangle without rounding errors
					//h0 = h1;
					//w0 = w1;

					// draw data if available

					if ( series.Count == 0 ) return;				

					for ( int ppp = 0 ; ppp < series.Count ; ++ ppp )
					{
						DataSeries tSeries = new DataSeries() ;
						tSeries = (DataSeries)series[ppp];
						if ( tSeries.XData.Length != tSeries.YData.Length ) return ;
					}

					// draw legend - 문단 위치 중요. 
					// 위 두 if 문 없거나 위에 존재 하려면 조건에 && (xData != null && yData != null) 추가.

					if ( showlegend )
					{
						int lb_w = 0, lb_h = 0, ln_w = 0, ln_h = 0, lx0, ly0, max_CapW = 0;
						// lb_w : legend box width.     lb_h : legend box height.
						// ln_w : legend name width.    ln_w : legend name height.
						// lx0  : legend box x position ly0 : legend box y position.
						// max_CapW : 제일 긴 레전드 네임 길이 .

						DataSeries tSeries = new DataSeries();

						float[] ln_hs = new float[series.Count]; // 레전드 문자들 높이의 배열이당.

						for ( int ppp = 0; ppp < series.Count ; ++ ppp )
						{
							tSeries = (DataSeries)series[ppp];
						
							s = tSeries.Name ;  // 기존 s  = legendname ;
							tp = g.MeasureString(s, tSeries.Font); // 기존 fontLegend);
							ln_w = Convert.ToInt32(tp.Width);						
							ln_h += Convert.ToInt32(tp.Height);
							ln_hs[ppp] = tp.Height ;
							if( max_CapW < ln_w )
							{
								max_CapW = ln_w;
							}
							else
							{
								max_CapW = max_CapW ;
							}
							
							/* 마지막 레전드가 아니면 간격도 포함시킨다. */
							if ( ppp + 1 != series.Count ) ln_h += 2 ; // 시리즈들의 줄 간격은 2로하자.						
						}

						ln_w = max_CapW;

						lb_w = 30+2+ln_w+10*2;
						lb_h = ln_h+3*2;
						lx0 = 0;
						ly0 = 0;
						if(LegendPosition_ == LegendPosition_Enum.RIGHT_TOP)
						{
							lx0  = x0+w0-lb_w-4;
							ly0 = y0+10;
						}
						else if(LegendPosition_ == LegendPosition_Enum.LEFT_TOP)
						{
							lx0  = x0 + 4;
							ly0 = y0+10;
						}

						if(LegendPosition_ == LegendPosition_Enum.RIGHT_DOWN)
						{
							lx0  = x0+w0-lb_w-4;
							ly0 = y1 - lb_h - 10;
						}
						else if(LegendPosition_ == LegendPosition_Enum.LEFT_DOWN)
						{
							lx0  = x0 + 4;
							ly0 = y1 - lb_h - 10;
						}
						
						// 레전드 박스를 그린다.
						g.DrawRectangle(penAxis, lx0, ly0, lb_w, lb_h);

						PointF[] lp = new PointF[2];
					
						float Lcyp = ly0+3;  // legend caption Y position. 
						// 이제 레전드를 그려보자.

						for ( int ppp = 0; ppp < series.Count ; ++ ppp )
						{
							tSeries = (DataSeries)series[ppp];								
							s = tSeries.Name ;						
							Pen tpen = new Pen(tSeries.Color);
							lp[0].X = lx0+10; lp[1].X = lp[0].X+30;
							lp[0].Y = Lcyp+ln_hs[ppp]/2;
							lp[1].Y = lp[0].Y ;
							g.DrawLine(tpen, lp[0], lp[1]);                        
							g.DrawString(s, tSeries.Font, xBrushLabel, lp[1].X + 2, Lcyp);
							Lcyp = Lcyp + ln_hs[ppp] + 2 ;
						}
					}

					// first convert the data arrays into points inside the axis rectangle

					DataSeries pSeries = new DataSeries();

					for ( int ppp = 0 ; ppp < series.Count ; ++ ppp )
					{
						pSeries = (DataSeries)series[ppp];

						Pen ppen = new Pen(pSeries.Color, pSeries.PenWidth);

						Point[] pt = new Point[pSeries.XData.Length];
						Point lastValidPt = new Point(x0, y1);

						n = Convert.ToInt32(((DataSeries)this.series[0]).XData.Length);

						float w0_Temp = w0;
						float n_Temp = n;
						float fTemp_d = w0_Temp / n_Temp ;
						float xd = 0;

						for (i = 0; i < pt.Length; i++)
						{
//							try	// catch invalid data points 
//							{
								switch ( FXAxisMode )
								{
									case XAxisModeType.Linear :  // linear.
										if(this.IsOctave == true)
										{
											if(i == 0)
											{
												xd = fTemp_d / 2;
											}
											else
											{
												xd = fTemp_d + xd ;
											}

											x = (int)(x0 + xd);

											pt[i].X = x;
										}
										else
										{
											pt[i].X = (int)(x0 + (pSeries.XData[i] - xRangeStart) / (xRangeEnd - xRangeStart) * w0);
										}
										break;
									case XAxisModeType.Log10 :   // logarithmic
										pt[i].X = (int)(x0 + (Math.Log10(pSeries.XData[i]) - Math.Log10(xRangeStart)) / (Math.Log10(xRangeEnd) - Math.Log10(xRangeStart)) * w0);
										break;
								}
							
								switch ( FYAxisMode )
								{
									case YAxisModeType.Linear :  // linear.
										pt[i].Y = (int)(y1 - (pSeries.YData[i] - yRangeStart) / (yRangeEnd - yRangeStart) * h0);
										break;
									case YAxisModeType.Log10 :   // logarithmic
										pt[i].Y = (int)(y1 - (Math.Log10(pSeries.YData[i]) - Math.Log10(yRangeStart)) / (Math.Log10(yRangeEnd) - Math.Log10(yRangeStart)) * h0);
										break;
								
									case YAxisModeType.dB    :   // dB
										pt[i].Y = (int)(y1 - (pSeries.YData[i] - yRangeStart) / (yRangeEnd - yRangeStart) * h0);
										break;								
								}

								lastValidPt = pt[i];
//							}
//							catch(System.Exception )
//							{ 
								pt[i] = lastValidPt;	// redraw last valid point on error
//							}

						}

						// now draw the points
						g.Clip = new Region(new Rectangle(new Point(x0, y0), new Size(w0, h0)));

						for (i = 0; i < pt.Length; i++)
						{
							if ( ( pt[i].X >= x0 && pt[i].X <= x0 + w0 ) && ( pt[i].Y >= y0 && pt[i].Y <= y0 + h0 ) )  // 그래프 영역에만 그림을 그리자.
							{						
								switch(drawMode)
								{
									case DrawModeType.Dot:
										Debug.WriteLine("Dot");
										g.DrawEllipse(ppen, pt[i].X - penWidth / 2, pt[i].Y - penWidth / 2, penWidth, penWidth);
										break;

									case DrawModeType.Bar:
										Debug.WriteLine("Bar");
										g.DrawLine(ppen, new Point(pt[i].X, y1), pt[i]);
										break;

									default:
										// Draw mode 가 dot나 bar일 경우 데이터 자체가 이산적이므로 Line Mode 시에만 Marker 를 표시한다.
										// 라인으로 데이터가 Continuous 되기전에 Marker를 그리자.
									
									switch ( markerType )
									{
										case MarkerModeType.None :
											Debug.WriteLine("None");										
											break;
										case MarkerModeType.Circle :
											Debug.WriteLine("Circle");
											g.DrawEllipse(ppen, pt[i].X - markerSize/2, pt[i].Y - markerSize/2, markerSize, markerSize);
											break;
										case MarkerModeType.Square :
											Debug.WriteLine("Square");
											g.DrawRectangle(ppen, pt[i].X - markerSize/2, pt[i].Y - markerSize/2, markerSize, markerSize);
											break;
										case MarkerModeType.Cross :
											Debug.WriteLine("Cross");
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y - markerSize/2, pt[i].X + markerSize/2, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X + markerSize/2, pt[i].Y - markerSize/2, pt[i].X - markerSize/2, pt[i].Y + markerSize/2);
											break;
										case MarkerModeType.Plus :
											Debug.WriteLine("Plus");
											g.DrawLine(ppen, pt[i].X, pt[i].Y - markerSize/2, pt[i].X, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y, pt[i].X + markerSize/2, pt[i].Y);
											break;
										case MarkerModeType.Triangle :
											Debug.WriteLine("Triangle");
											g.DrawLine(ppen, pt[i].X, pt[i].Y - markerSize/2, pt[i].X - markerSize/2, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y + markerSize/2, pt[i].X + markerSize/2, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X + markerSize/2, pt[i].Y + markerSize/2, pt[i].X, pt[i].Y - markerSize/2);
											break;
										case MarkerModeType.Diamond :
											Debug.WriteLine("Diamond");
											g.DrawLine(ppen, pt[i].X, pt[i].Y - markerSize/2, pt[i].X - markerSize/2, pt[i].Y);
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y, pt[i].X, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X, pt[i].Y + markerSize/2, pt[i].X + markerSize/2, pt[i].Y);
											g.DrawLine(ppen, pt[i].X + markerSize/2, pt[i].Y, pt[i].X, pt[i].Y - markerSize/2);																				
											break;
										case MarkerModeType.Asterik :
											Debug.WriteLine("Asterik");
											g.DrawLine(ppen, pt[i].X, pt[i].Y - markerSize/2, pt[i].X, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y, pt[i].X + markerSize/2, pt[i].Y);
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y - markerSize/2, pt[i].X + markerSize/2, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X + markerSize/2, pt[i].Y - markerSize/2, pt[i].X - markerSize/2, pt[i].Y + markerSize/2);
											break;
										case MarkerModeType.Right :
											Debug.WriteLine("Right");
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y - markerSize/2, pt[i].X - markerSize/2, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y + markerSize/2, pt[i].X + markerSize/2, pt[i].Y);
											g.DrawLine(ppen, pt[i].X + markerSize/2, pt[i].Y, pt[i].X - markerSize/2, pt[i].Y - markerSize/2);
											break;
										case MarkerModeType.Left :
											Debug.WriteLine("Left");
											g.DrawLine(ppen, pt[i].X + markerSize/2, pt[i].Y - markerSize/2, pt[i].X + markerSize/2, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X + markerSize/2, pt[i].Y + markerSize/2, pt[i].X - markerSize/2, pt[i].Y);
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y, pt[i].X + markerSize/2, pt[i].Y - markerSize/2);
											break;
										case MarkerModeType.Down :
											Debug.WriteLine("Down");
											g.DrawLine(ppen, pt[i].X - markerSize/2, pt[i].Y - markerSize/2, pt[i].X + markerSize/2, pt[i].Y - markerSize/2);
											g.DrawLine(ppen, pt[i].X + markerSize/2, pt[i].Y - markerSize/2, pt[i].X, pt[i].Y + markerSize/2);
											g.DrawLine(ppen, pt[i].X, pt[i].Y + markerSize/2, pt[i].X - markerSize/2, pt[i].Y - markerSize/2);
											break;
									}
									
										// 라인 모드이므로 선으로 이어 준다. 라인이 필요 없을시 플랙으로 분리.... =ㅅ=;;
										if (i > 0) g.DrawLine(ppen, pt[i - 1], pt[i]);

										/* 
										 * 삐친 선 처리..... =ㅅ=;;
										if ( pt[i-1].X <= x0 ) 
										{
											g.DrawLine(ppen, pt[i - 1], pt[i]);
										}
										*/
										break;
								}
						
							}
						}
						g.Flush();
					}

//				}
//				catch( System.Exception )
//				{ }
			}
			else // Color Map
			{
				ColorMapDraw();
			}
		  
		}

		// Color Map
		private void ColorMapDraw()
		{
//			try	// overall exception handling to avoid crashes
//			{
				// 유효 하다면
				if(Exception_Check() == true)
				{
					Graphics g = this.CreateGraphics();

					// Label 그리기
					Label_Draw(g);

					// Grid 그리기
					Grid_Draw(g);

					// Legend 그리기
					Legend_Draw(g);

					// Data 그리기
					Data_Draw(g);

					//Color Bar 그리기
					ColorBar_Draw(g);
				}
//			}
//			catch( System.Exception )
//			{ }
		}

		/// <summary>
		/// 유효성 체크
		/// </summary>
		/// <returns></returns>
		private bool Exception_Check()
		{
			bool bResult = true;

			// check properties
			if (xRangeEnd <= xRangeStart)
			{
				bResult = false;
			}

			if (yRangeEnd <= yRangeStart)
			{
				bResult = false;
			}

			if ( FXAxisMode == XAxisModeType.Linear )   // linear.
			{
				if (xGrid <= 0)
				{
					bResult = false;
				}
			}
			else                // logarithmic
			{
				if (xRangeStart <= 0)
				{
					bResult = false;
				}
			}
				
			switch ( FYAxisMode )
			{
				case YAxisModeType.Linear :  // linear.
					if (yGrid <= 0)
					{
						bResult = false;
					}
					break;		
				case YAxisModeType.Log10 :   // logarithmic.
					if (yRangeStart <= 0)
					{
						bResult = false;
					}
					break;
				case YAxisModeType.dB : 
					if (yRangeStart <= 0)
					{
						bResult = false;
					}
					break;
			}

			// draw data if available

			if ( series.Count == 0 )
			{
				bResult = false;
			}

			for ( int ppp = 0 ; ppp < series.Count ; ++ ppp )
			{
				DataSeries tSeries = new DataSeries() ;
				tSeries = (DataSeries)series[ppp];
				if ( tSeries.XData.Length != tSeries.YData.Length )
				{
					bResult = false;
				}
			}

			return bResult;
		}


		/// <summary>
		/// Label 그리기
		/// </summary>
		/// <param name="g"></param>
		private void Label_Draw(Graphics g)
		{
			// draw title and label

			SolidBrush brushTitle = new SolidBrush(titlecolor);
			SolidBrush xBrushLabel = new SolidBrush(xlabelcolor);
			SolidBrush yBrushLabel = new SolidBrush(ylabelcolor);

			string s = title ;
			SizeF tp = g.MeasureString(s, fontTitle);
			g.DrawString(s, fontTitle, brushTitle, ((ClientRectangle.Left + ClientRectangle.Right) / 2) - (tp.Width / 2), ClientRectangle.Top + 5);

			s = xlabel ;
			tp = g.MeasureString(s, fontLabel);
			g.DrawString(s, fontLabel, xBrushLabel, ((ClientRectangle.Left + ClientRectangle.Right) / 2) - (tp.Width / 2), ClientRectangle.Bottom - 20);

			s = ylabel;
			tp = g.MeasureString(s, fontLabel);
			StringFormat drawFormat = new StringFormat();
			drawFormat.FormatFlags = StringFormatFlags.FitBlackBox;
			g.RotateTransform(-90,System.Drawing.Drawing2D.MatrixOrder.Append);
			g.DrawString(s, fontLabel, yBrushLabel, ((ClientRectangle.Top - ClientRectangle.Bottom) / 2) - (tp.Width / 2),ClientRectangle.Left + 10, drawFormat);
			g.RotateTransform(90,System.Drawing.Drawing2D.MatrixOrder.Append);
			//drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
			//g.DrawString(s, fontLabel, yBrushLabel, ClientRectangle.Left + 5, ((ClientRectangle.Top + ClientRectangle.Bottom) / 2) - (tp.Width / 2), drawFormat);
			drawFormat.Dispose();
		}


		/// <summary>
		/// Grid 그리기
		/// </summary>
		private void Grid_Draw(Graphics g)
		{
			float x0, y0, x1, y1, w0, h0;
			float n, xd, d,x=0,y;

			// calculate coordinates, width and hight inside
			x0 = ClientRectangle.Left + borderLeft;
			y0 = ClientRectangle.Top + borderTop;
			w0 = ClientRectangle.Width - borderLeft - borderRight;
			h0 = ClientRectangle.Height - borderTop - borderBottom;
			x1 = ClientRectangle.Right - borderRight;
			y1 = ClientRectangle.Bottom - borderBottom;

			// prepare the tools
			Pen penGrid = new Pen(colorGrid, 1);
			Pen penAxis = new Pen(colorAxis, 1);
			SolidBrush brushAxis = new SolidBrush(colorAxis);

			// draw grid

			string s = "";

			switch ( FXAxisMode )
			{
				case XAxisModeType.Linear :  // linear.
					n = Convert.ToInt32((xRangeEnd - xRangeStart) / xGrid);

					float fTemp_d = (w0 - this.ColorBarGap) / n;
					for (float i = 0.0F; i <= n; i = i + 1)
					{
						if(i == 0.0)
						{
							x = x0;
						}
						else
						{
							x = fTemp_d + x;
						}
							
						// 축을 그리는 펜으로 tick marker 를 그리자.
						g.DrawLine(penAxis, x, y1, x, y1-5);           
						g.DrawLine(penAxis, x, y0, x, y0+5);
						//							}

						// Tick Label
						s = Convert.ToString(xRangeStart + (xRangeEnd - xRangeStart) * i / n);
						SizeF sf = g.MeasureString(s, fontAxis);
						g.DrawString(s, fontAxis, brushAxis, x - sf.Width / 2, y1 + sf.Height / 2);
					}

					//w1 = d * n;
					break;
//
					#region Log10
////				case XAxisModeType.Log10 :					// logarithmic
////					//if ( xRangeStart > 0 )
////					n = Convert.ToInt32(Math.Log10(xRangeEnd) - Math.Log10(xRangeStart));
////					//else
////					//n = Convert.ToInt32(Math.Log10(xRangeEnd));
////					if (n == 0) n = 1;
////					d = w0 / n;
////					for (i = 0; i <= n; i++)
////					{
////						x = x0 + i * d;
////						if (i < n)
////						{
////							for (j = 1; j < 10 /* log base */ ; j++)
////							{
////								d1 = Convert.ToInt32(Math.Log10(j) * d);
////									
////								// grid 기능이 있으면 그리드를 그린다.
////									
////								if ( grid ) g.DrawLine(penGrid, x + d1, y0, x + d1, y1);
////							}
////						}
////
////						// 데이터가 있다면 축을 그리는 펜으로 tick marker 를 그리자.
////							
////						//							if ( series.Count > 0 ) // 기존의것 ( xData != null && yData != null)
////						//							{	
////						g.DrawLine(penAxis, x, y1, x, y1-5);           
////						g.DrawLine(penAxis, x, y0, x, y0+5);
////						//							}
////							
////						if ( xRangeStart > 0 )
////							s = Convert.ToString(Math.Pow(10, Math.Log10(xRangeStart) + i));
////						else
////						{
////							if ( i == 0 ) s = "0";
////							if ( i != 0 ) s = Convert.ToString(Math.Pow(10, 0 + i));
////						}
////						SizeF sf = g.MeasureString(s, fontAxis);
////						g.DrawString(s, fontAxis, brushAxis, x - sf.Width / 2, y1 + sf.Height / 2);
////					}
////
////					w1 = d * n;
////					break;
					#endregion
			}

			s = "";

			switch ( FXAxisMode )
			{
				case XAxisModeType.Linear :  // linear.
					if(IsOctave == false)
					{
						n = Convert.ToInt32((xRangeEnd - xRangeStart) / xGrid);
						if (n == 0) n = 1;
						d = (w0 - this.ColorBarGap) / n;
						for (float i = 0; i <= n; i++)
						{
							x = x0 + i * d;

							// grid 기능이 있으면 그리드를 그린다.
							
							if ( grid ) g.DrawLine(penGrid, x, y0, x, y1); 
							
							// 데이터가 있다면 축을 그리는 펜으로 tick marker 를 그리자.
							
							//							if ( series.Count > 0 ) // 기존의것 ( xData != null && yData != null)
							//							{	
							g.DrawLine(penAxis, x, y1, x, y1-5);           
							g.DrawLine(penAxis, x, y0, x, y0+5);
							//							}

							// Tick Label
							s = Convert.ToString(xRangeStart + (xRangeEnd - xRangeStart) * i / n);
							//									int Temp_ss = (int)double.Parse(s);
							//									s = Temp_ss.ToString();
							SizeF sf = g.MeasureString(s, fontAxis);
							if(i % 200 == 0)
							{
								g.DrawString(s, fontAxis, brushAxis, x - sf.Width / 2, y1 + sf.Height / 2);
							}
						}
					}
					else
					{
						n = Convert.ToInt32(((DataSeries)this.series[0]).XData.Length);

						//float fTemp_d = w0 / n;
						float fTemp_d = (w0 - this.ColorBarGap) / n; // Color Bar 를 그리기 위한 여백
						xd = 0.0F;
						int count = Interval;
						for (float i = 0.0F; i < n; i++)
						{
							if(i == 0.0)
							{
								xd = fTemp_d / 2;
							}
							else
							{
								xd = fTemp_d + xd ;
							}

							x = x0 + xd;

							//y = y1 - (i + 1) * d;
							
							if(Interval > 0)
							{
								if(Interval == count)
								{
									// 축을 그리는 펜으로 tick marker 를 그리자.
									g.DrawLine(penAxis, x, y1, x, y1-5);           
									g.DrawLine(penAxis, x, y0, x, y0+5);

									s = Convert.ToString(((DataSeries)series[0]).XData[(int)i]);
									SizeF sf = g.MeasureString(s, fontAxis);
									if(i % 200 == 0)
									{
										g.DrawString(s, fontAxis, brushAxis, x - sf.Width / 2, y1 + sf.Height / 2);
									}
									count = 0;
								}
							}
							else
							{
								// 축을 그리는 펜으로 tick marker 를 그리자.
								g.DrawLine(penAxis, x, y1, x, y1-5);           
								g.DrawLine(penAxis, x, y0, x, y0+5);

								s = Convert.ToString(((DataSeries)series[0]).XData[(int)i]);
								SizeF sf = g.MeasureString(s, fontAxis);
								if(i % 200 == 0)
								{
									g.DrawString(s, fontAxis, brushAxis, x - sf.Width / 2, y1 + sf.Height / 2);
								}
							}

							count++;
						}
					}
					break;
			}
			switch ( FZAxisMode )
			{
				case ZAxisModeType.Linear :  // linear.
					
					n = Convert.ToInt32(this.series.Count);

					float fTemp_d = h0 / n;
					d = 0.0F;
					int count = 0;
					for (float i = 0.0F; i < n; i++)
					{
						if(i == 0.0)
						{
							d = fTemp_d / 2;
						}
						else
						{
							d = fTemp_d + d;
						}

						y = y1 - d;

						//y = y1 - (i + 1) * d;
							
						// 축을 그리는 펜으로 tick marker 를 그리자.
						g.DrawLine(penAxis, x0, y, x0+5, y);           
						g.DrawLine(penAxis, x1 - this.ColorBarGap, y, x1-5 - this.ColorBarGap, y);
						//							}
						s = Convert.ToString(((DataSeries)series[count]).ZData[0]);
						SizeF sf = g.MeasureString(s, fontAxis);
						g.DrawString(s, fontAxis, brushAxis, x0 - sf.Width - sf.Height / 4, y - sf.Height / 2);

						count++;
					}

					//h1 = d * n;
					break;


					#region Log10
					//				case YAxisModeType.Log10 :   // logarithmic.
					//						
					//					n = Convert.ToInt32(Math.Log10(yRangeEnd) - Math.Log10(yRangeStart));
					//					if (n == 0) n = 1;
					//					d = h0 / n;
					//					for (i = 0; i <= n; i++)
					//					{
					//						y = y1 - i * d;
					//						if (i < n)
					//						{
					//							for (j = 1; j < 10 ; j++)
					//							{									
					//								d1 = Convert.ToInt32(Math.Log10(j) * d);
					//								
					//								// grid 기능이 있으면 그리드를 그린다.
					//								
					//								if (grid ) g.DrawLine(penGrid, x0, y - d1, x1, y - d1);
					//							}
					//						}
					//						
					//						// 데이터가 있다면 축을 그리는 펜으로 tick marker 를 그리자.
					//						
					//						//							if ( series.Count > 0 ) // 기존의것 ( xData != null && yData != null)
					//						//							{	
					//						g.DrawLine(penAxis, x0, y, x0+5, y);           
					//						g.DrawLine(penAxis, x1, y, x1-5, y);
					//						//							}
					//						
					//						s = Convert.ToString(Math.Pow(10, Math.Log10(yRangeStart) + i));
					//						SizeF sf = g.MeasureString(s, fontAxis);
					//						g.DrawString(s, fontAxis, brushAxis, x0 - sf.Width - sf.Height / 4, y - sf.Height / 2);
					//					}
					//
					//					h1 = d * n;
					//					break;
					#endregion
					
					#region DB
					//				case YAxisModeType.dB :  // dB Mode.
					//						
					//					n = Convert.ToInt32((yRangeEnd - yRangeStart) / yGrid);
					//					if (n == 0) n = 1;
					//					d = h0 / n;
					//					for (float i = 0; i <= n; i++)
					//					{
					//						y = y1 - i * d;
					//
					//						// grid 기능이 있으면 그리드를 그린다.
					//
					//						if ( grid ) g.DrawLine(penGrid, x0, y, x1, y);
					//							
					//						// 데이터가 있다면 축을 그리는 펜으로 tick marker 를 그리자.
					//							
					//						//							if ( series.Count > 0 ) // 기존의것 ( xData != null && yData != null)
					//						//							{	
					//						g.DrawLine(penAxis, x0, y, x0+5, y);           
					//						g.DrawLine(penAxis, x1, y, x1-5, y);
					//						//							}
					//							
					//						string s = Convert.ToString(yRangeStart + (yRangeEnd - yRangeStart) * i / n);
					//						SizeF sf = g.MeasureString(s, fontAxis);
					//						g.DrawString(s, fontAxis, brushAxis, x0 - sf.Width - sf.Height / 4, y - sf.Height / 2);
					//					}
					//
					//					h1 = d * n;
					//					break;
					#endregion
			}

			// draw axis
			g.DrawRectangle(penAxis, x0, y0, w0 - this.ColorBarGap, h0);
		}


		/// <summary>
		/// Legend 그리기
		/// </summary>
		/// <param name="g"></param>
		private void Legend_Draw(Graphics g)
		{
			// draw legend - 문단 위치 중요. 
			int x0 = ClientRectangle.Left + borderLeft;
			int y0 = ClientRectangle.Top + borderTop;
			int w0 = ClientRectangle.Width - borderLeft - borderRight;

			Pen penAxis = new Pen(colorAxis, 1);

			SolidBrush xBrushLabel = new SolidBrush(xlabelcolor);

			if ( showlegend )
			{
				int lb_w = 0, lb_h = 0, ln_w = 0, ln_h = 0, lx0, ly0, max_CapW = 0;
				// lb_w : legend box width.     lb_h : legend box height.
				// ln_w : legend name width.    ln_w : legend name height.
				// lx0  : legend box x position ly0 : legend box y position.
				// max_CapW : 제일 긴 레전드 네임 길이 .

				DataSeries tSeries = new DataSeries();

				float[] ln_hs = new float[series.Count]; // 레전드 문자들 높이의 배열이당.

				for ( int ppp = 0; ppp < series.Count ; ++ ppp )
				{
					tSeries = (DataSeries)series[ppp];
						
					string s = tSeries.Name ;  // 기존 s  = legendname ;
					SizeF tp = g.MeasureString(s, tSeries.Font); // 기존 fontLegend);
					ln_w = Convert.ToInt32(tp.Width);						
					ln_h += Convert.ToInt32(tp.Height);
					ln_hs[ppp] = tp.Height ;
					ln_w = ( max_CapW < ln_w ) ? ln_w : max_CapW ;
					/* 마지막 레전드가 아니면 간격도 포함시킨다. */
					if ( ppp + 1 != series.Count ) ln_h += 2 ; // 시리즈들의 줄 간격은 2로하자.						
				}

				lb_w = 30+2+ln_w+10*2; lb_h = ln_h+3*2;
				lx0  = x0+w0-lb_w-4;  ly0 = y0+10;
				// 레전드 박스를 그린다.
				g.DrawRectangle(penAxis, lx0, ly0, lb_w, lb_h);

				PointF[] lp = new PointF[2];
					
				float Lcyp = ly0+3;  // legend caption Y position. 
				// 이제 레전드를 그려보자.

				for ( int ppp = 0; ppp < series.Count ; ++ ppp )
				{
					tSeries = (DataSeries)series[ppp];								
					string s = tSeries.Name ;						
					Pen tpen = new Pen(tSeries.Color);
					lp[0].X = lx0+10; lp[1].X = lp[0].X+30;
					lp[0].Y = Lcyp+ln_hs[ppp]/2;
					lp[1].Y = lp[0].Y ;
					g.DrawLine(tpen, lp[0], lp[1]);                        
					g.DrawString(s, tSeries.Font, xBrushLabel, lp[1].X + 2, Lcyp);
					Lcyp = Lcyp + ln_hs[ppp]/2 + 2 ;
				}
			}
		}


		/// <summary>
		/// Data 그리기
		/// </summary>
		/// <param name="g"></param>
		private void Data_Draw(Graphics g)
		{
			float y1 = ClientRectangle.Bottom - borderBottom;
			float h0 = ClientRectangle.Height - borderTop - borderBottom;
			float x0 = ClientRectangle.Left + borderLeft;
			float w0 = ClientRectangle.Width - borderLeft - borderRight;
			float y0 = ClientRectangle.Top + borderTop;

			float d = h0 / Convert.ToInt32(this.series.Count);
			//float xd = w0 / Convert.ToInt32(((DataSeries)this.series[0]).XData.Length);
			float xd = (w0 - this.ColorBarGap) / Convert.ToInt32(((DataSeries)this.series[0]).XData.Length);

			Pen penAxis = new Pen(colorAxis, 1);			

			// first convert the data arrays into points inside the axis rectangle
			DataSeries pSeries = new DataSeries();

			for ( int ppp = 0 ; ppp < series.Count ; ++ ppp )
			{
				pSeries = (DataSeries)series[ppp];

				Pen ppen = new Pen(pSeries.Color, pSeries.PenWidth);

				Point_Data [] pt = new Point_Data[pSeries.XData.Length];
				for (int iii = 0;iii<pSeries.XData.Length;iii++)
				{
					pt[iii] = new Point_Data();
				}
				Point_Data lastValidPt = new Point_Data(x0, y1);

				Color [] dimColor = new Color[pt.Length];
				for(int jjj = 0 ; jjj < pt.Length ; jjj++)
				{
					dimColor[jjj] = new Color();
				}

				for (int i = 0; i < pt.Length; i++)
				{
//					try	// catch invalid data points 
//					{	
						switch ( FXAxisMode )
						{
							case XAxisModeType.Linear :  // linear.
								//pt[i].x_Data = (double)(x0 + (pSeries.XData[i] - xRangeStart) / (xRangeEnd - xRangeStart) * w0);
								pt[i].x_Data = x0 + (i + 1) * xd;
								break;
						}

						switch ( FYAxisMode )
						{
							case YAxisModeType.Linear :  // linear.
								// RGB 생삭을 구해낸다
								pt[i].y_Data = y1 - (pSeries.YData[i] - yRangeStart) / (yRangeEnd - yRangeStart) * h0;
								dimColor[i] = GetRGB(pSeries.YData[i]);
								break;

								#region Log10
//							case YAxisModeType.Log10 :   // logarithmic
//								pt[i].Y = Convert.ToInt32(y1 - (Math.Log10(pSeries.YData[i]) - Math.Log10(yRangeStart)) / (Math.Log10(yRangeEnd) - Math.Log10(yRangeStart)) * h0);
//								break;
								#endregion
								
								#region DB
//							case YAxisModeType.dB    :   // dB
//								pt[i].Y = Convert.ToInt32(y1 - (pSeries.YData[i] - yRangeStart) / (yRangeEnd - yRangeStart) * h0);
//								break;								
								#endregion
						}

						switch ( FZAxisMode )
						{
							case ZAxisModeType.Linear :  // linear.
								pt[i].y_Data = y1 - (ppp + 1) * d;
								break;		
						}

						lastValidPt = pt[i];
//					}
//					catch(System.Exception )
//					{ 
////					}
				}
				
				for (int i = 0; i < pt.Length; i++)
				{
					float X1, XW, Y1, YH;
					// Color Map 의 한칸 한칸 네모를 그린다.
					SolidBrush brushColor = new SolidBrush(dimColor[i]);
//					if(i == 0)
//					{
//						X1 = x0;
//						XW = (float)(pt[1].x_Data/2 + pt[0].x_Data - x0);
//					} 
//					else if(i == pt.Length-1)
//					{
//						X1 = (float)(pt[i].x_Data/2 + pt[i-1].x_Data/2);
//						XW = x0 + w0;
//					} 
//					else
//					{
//						X1 = (float)(pt[i].x_Data/2 + pt[i-1].x_Data/2);
//						XW = (float)(pt[i+1].x_Data/2 - pt[i-1].x_Data/2);
//					}
					X1 = x0 + i * xd;
					XW = xd;
					Y1 = y1 - (ppp + 1) * d;
					YH = d;

					g.FillRectangle(brushColor,X1,Y1, XW, YH);
					//g.DrawRectangle(brushColor,X1,Y1, XW, YH);
				}
			}
		}


		/// <summary>
		/// RGB 값 얻어오기
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		private Color GetRGB(double y)
		{
			RGB_Data_List clsRGB_Data_List = new RGB_Data_List();
			int dIndex = 0;

			try
			{
				dIndex = (int)(((y - yRangeStart) * (clsRGB_Data_List.clsRGB_Data.Length-1)) / (yRangeEnd - yRangeStart));

				if (dIndex<0)
				{
					dIndex = 0;
				}
				if (dIndex>(clsRGB_Data_List.clsRGB_Data.Length-1))
				{
					dIndex = clsRGB_Data_List.clsRGB_Data.Length-1;
				}

			}
			catch
			{
			}

			RGB_Data clsRGB_Data = clsRGB_Data_List.clsRGB_Data[dIndex];

			return Color.FromArgb((int)(clsRGB_Data.dimData[0] * 255),(int)(clsRGB_Data.dimData[1] * 255),(int)(clsRGB_Data.dimData[2] * 255));
		}


		/// <summary>
		/// Color Bar 그리기
		/// </summary>
		/// <param name="g"></param>
		private void ColorBar_Draw(Graphics g)
		{
			RGB_Data_List clsRGB_Data_List = new RGB_Data_List();

			float x0, y0, x1, y1, w0, h0;

			// calculate coordinates, width and hight inside
			x0 = ClientRectangle.Left + borderLeft;
			y0 = ClientRectangle.Top + borderTop;
			w0 = ClientRectangle.Width - borderLeft - borderRight;
			h0 = ClientRectangle.Height - borderTop - borderBottom;
			x1 = ClientRectangle.Right - borderRight;
			y1 = ClientRectangle.Bottom - borderBottom;

			// prepare the tools
			Pen penGrid = new Pen(colorGrid, 1);
			Pen penAxis = new Pen(colorAxis, 1);
			SolidBrush brushAxis = new SolidBrush(colorAxis);

			float d = h0 / Convert.ToInt32(clsRGB_Data_List.clsRGB_Data.Length);

			float X1, XW, Y1, YH;
			X1 = x1 + 10;
			XW = this.ColorBarGap;

			for (int i = 0; i < clsRGB_Data_List.clsRGB_Data.Length ; i++)
			{
				Y1 = y1 - (i + 1) * d;
				YH = d;

				Color color = Color.FromArgb((int)(clsRGB_Data_List.clsRGB_Data[i].dimData[0] * 255),(int)(clsRGB_Data_List.clsRGB_Data[i].dimData[1] * 255),(int)(clsRGB_Data_List.clsRGB_Data[i].dimData[2] * 255));

				SolidBrush brushColor = new SolidBrush(color);

				g.FillRectangle(brushColor,X1 - this.ColorBarGap,Y1, XW, YH);
				//g.DrawRectangle(penAxis,X1 - this.ColorBarGap,Y1, XW, YH);
			}

			// Bar MIN 값을 표시
			string s = this.yRangeStart.ToString();
			SizeF sf = g.MeasureString(s, fontAxis);
			g.DrawString(s, fontAxis, brushAxis, X1 + sf.Width / 2, y1 - sf.Height);

			// Bar MAX 값을 표시
			s = this.yRangeEnd.ToString();
			sf = g.MeasureString(s, fontAxis);
			g.DrawString(s, fontAxis, brushAxis, X1, y0);

			// Bar Middle 값을 표시
			double dMidTemp = (this.yRangeEnd + this.YRangeStart) / 2;
			s = dMidTemp.ToString();
			sf = g.MeasureString(s, fontAxis);
			float fMidTemp = ((y1 + sf.Height / 2) + (y0 - 10 - sf.Height / 2)) / 2;
			g.DrawString(s, fontAxis, brushAxis, X1, fMidTemp);
		}


		private void Plotter_Resize(object sender, System.EventArgs e)
		{
			this.Refresh();
		}

		private void Plotter_Load(object sender, System.EventArgs e)
		{
		
		}

		[System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
		private static extern bool BitBlt(
			IntPtr hdcDest, // handle to destination DC
			int nXDest,  // x-coord of destination upper-left corner
			int nYDest,  // y-coord of destination upper-left corner
			int nWidth,  // width of destination rectangle
			int nHeight, // height of destination rectangle
			IntPtr hdcSrc,  // handle to source DC
			int nXSrc,   // x-coordinate of source upper-left corner
			int nYSrc,   // y-coordinate of source upper-left corner
			System.Int32 dwRop  // raster operation code
			);

		/// <summary>
		/// 이미지 저장 루틴. 화면에 그려진 이미지를 저장한다. 저장전에 Refresh 필요.
		/// </summary>
		/// <param name="FilePath"></param>
		/// <param name="iFormat"></param>
		public void Save(String FilePath, System.Drawing.Imaging.ImageFormat iFormat)
		{
			Graphics g1 = this.CreateGraphics();
			// 정기리가 수정한 부분
			PaintEventArgs PaintEventArgs1 = new PaintEventArgs(g1,ClientRectangle);
			this.OnPaint(PaintEventArgs1);
			// 여기까지

			Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
			Graphics g2 = Graphics.FromImage(MyImage);
			IntPtr dc1 = g1.GetHdc();
			IntPtr dc2 = g2.GetHdc();
			BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
			g1.ReleaseHdc(dc1);
			g2.ReleaseHdc(dc2);
			MyImage.Save(@FilePath, iFormat);

			//g2.
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.XRangeStart = double.Parse(dgInputValue1.ctValue);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miXRangeEnd_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.XRangeEnd = double.Parse(dgInputValue1.ctValue);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miXGrid_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.XGrid = double.Parse(dgInputValue1.ctValue);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miYRangeStart_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.YRangeStart = double.Parse(dgInputValue1.ctValue);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miRangeEnd_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.YRangeEnd = double.Parse(dgInputValue1.ctValue);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miYGrid_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.YGrid = double.Parse(dgInputValue1.ctValue);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miColorGrid_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.ColorGrid = colorDialog1.Color;
			}

			this.Refresh();
		}

		private void miColorBackGround_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.BackColor = colorDialog1.Color;
			}

			this.Refresh();
		}

		private void miXLabel_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.xlabel = dgInputValue1.ctValue;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miLabel_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.ylabel = dgInputValue1.ctValue;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miTitle_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.title = dgInputValue1.ctValue;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miAxisFont_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(fontDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.fontAxis = fontDialog1.Font;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miLabelFont_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(fontDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.FontLabel = fontDialog1.Font;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miTitleFont_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(fontDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.FontTitle = fontDialog1.Font;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miPlus_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Plus;
			this.Refresh();
		}

		private void miNone_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.None;
			this.Refresh();
		}

		private void miCircle_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Circle;
			this.Refresh();
		}

		private void miSquare_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Square;
			this.Refresh();
		}

		private void miCross_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Cross;
			this.Refresh();
		}

		private void miTriangle_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Triangle;
			this.Refresh();
		}

		private void miDiamond_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Diamond;
			this.Refresh();
		}

		private void miAsterik_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Asterik;
			this.Refresh();
		}

		private void miLeft_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Left;
			this.Refresh();
		}

		private void miRight_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Right;
			this.Refresh();
		}

		private void miDown_Click(object sender, System.EventArgs e)
		{
			this.MarkerType = MarkerModeType.Down;
			this.Refresh();
		}

		private void miPenwidth_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.PenWidth = int.Parse(dgInputValue1.ctValue);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void miShowGrid_Click(object sender, System.EventArgs e)
		{
			this.ShowGrid = !((MenuItem)sender).Checked;
			this.Refresh();

			bShowGrid = !((MenuItem)sender).Checked;
		}

		private void miShowLegend_Click(object sender, System.EventArgs e)
		{
			this.ShowLegend = !((MenuItem)sender).Checked;
			this.Refresh();

			bShowLegend = !((MenuItem)sender).Checked;
		}

		private void miAxisMode_Linear_Click(object sender, System.EventArgs e)
		{
			this.XAxisMode = XAxisModeType.Linear;
			this.Refresh();
		}

		private void miAxisMode_Log10_Click(object sender, System.EventArgs e)
		{
			this.XAxisMode = XAxisModeType.Log10;
			this.Refresh();
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			miShowGrid.Checked = bShowGrid;
			miShowLegend.Checked = bShowLegend;

			miDataSeries.MenuItems.Clear();
			MenuItem item;
			for(int i = 0 ; i < this.series.Count ; i++)
			{
				item = new MenuItem(((DataSeries)series[i]).Name);
				MenuItem item_Name = new MenuItem("Name");
				item_Name.Click += new EventHandler(item_Name_Click);
				item.MenuItems.Add(item_Name);
				MenuItem item_Color = new MenuItem("Color");
				item_Color.Click += new EventHandler(item_Color_Click);
				item.MenuItems.Add(item_Color);
				miDataSeries.MenuItems.Add(i,item);
			}

			if(this.series.Count < 1)
			{
				miDataSeries.Enabled = false;
			}
			else
			{
				miDataSeries.Enabled = true;
			}
		}

		private void item_Name_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				((DataSeries)this.series[((MenuItem)((MenuItem)sender).Parent).Index]).Name = dgInputValue1.ctValue;
			}

			this.Refresh();
		}

		private void item_Color_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				((DataSeries)this.series[((MenuItem)((MenuItem)sender).Parent).Index]).Color = colorDialog1.Color;
			}

			this.Refresh();
		}

		private void miMakerSize_Click(object sender, System.EventArgs e)
		{
			HONUS.dgInputValue dgInputValue1 = new HONUS.dgInputValue();
			if(dgInputValue1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.MarkerSize = int.Parse(dgInputValue1.ctValue);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				this.Refresh();
			}
		}

		private void mi_Title_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.TitleColor = colorDialog1.Color;
			}

			this.Refresh();
		}

		private void miColorXLabel_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.XLabelColor = colorDialog1.Color;
			}

			this.Refresh();
		}

		private void miColorYLabel_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.YLabelColor = colorDialog1.Color;
			}

			this.Refresh();
		}

		private void miLinear_Click(object sender, System.EventArgs e)
		{
			this.YAxisMode = YAxisModeType.Linear;
			this.Refresh();
		}

		private void miLog10_Click(object sender, System.EventArgs e)
		{
			this.YAxisMode = YAxisModeType.Log10;
			this.Refresh();
		}

		private void miDB_Click(object sender, System.EventArgs e)
		{
			this.YAxisMode = YAxisModeType.dB;
			this.Refresh();
		}

		private void miLegendPosition_LeftTop_Click(object sender, System.EventArgs e)
		{
			this.LegendPosition_Proferty = LegendPosition_Enum.LEFT_TOP;
			this.Refresh();
		}

		private void miLegendPosition_LeftRight_Click(object sender, System.EventArgs e)
		{
			this.LegendPosition_Proferty = LegendPosition_Enum.LEFT_DOWN;
			this.Refresh();
		}

		private void miLegendPosition_RightTop_Click(object sender, System.EventArgs e)
		{
			this.LegendPosition_Proferty = LegendPosition_Enum.RIGHT_TOP;
			this.Refresh();
		}

		private void miLegendPosition_RightDown_Click(object sender, System.EventArgs e)
		{
			this.LegendPosition_Proferty = LegendPosition_Enum.RIGHT_DOWN;
			this.Refresh();
		}

		private void miGraphSave_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.Filter = "(*.Bmp)|*.Bmp|(*.Emf)|*.Emf|(*.Exif)|*.Exif|(*.Gif)|*.Gif|(*.Icon)|*.Icon|(*.Jpeg)|*.Jpeg|(*.MemoryBmp)|*.MemoryBmp|(*.Png)|*.Png|(*.Tiff)|*.Tiff|(*.Wmf)|*.Wmf";

			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string path = saveFileDialog1.FileName;
				string strExtension = System.IO.Path.GetExtension(saveFileDialog1.FileName);
				switch(strExtension)
				{
					case ".Bmp" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.Bmp);
						break;
					case ".Emf" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.Emf);
						break;
					case ".Exif" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.Exif);
						break;
					case ".Gif" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.Gif);
						break;
					case ".Icon" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.Icon);
						break;
					case ".Jpeg" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.Jpeg);
						break;
					case ".MemoryBmp" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.MemoryBmp);
						break;
					case ".Png" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.Png);
						break;
					case ".Tiff" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.Tiff);
						break;
					case ".Wmf" :
						this.Save(path,System.Drawing.Imaging.ImageFormat.Wmf);
						break;
				}
			}
		}

		public void AutoRange()
		{
			for(int i = 0 ; i < series.Count ; i++)
			{
				if(i == 0)
				{
					XRangeStart = GetMIN(((DataSeries)series[i]).XData);
					XRangeEnd = GetMAX(((DataSeries)series[i]).XData);

					YRangeStart =  GetMIN(((DataSeries)series[i]).YData) - (GetMIN(((DataSeries)series[i]).YData) / 10);
					if(YRangeStart == 0)
					{
						YRangeStart = -1;
					}
					YRangeEnd = GetMAX(((DataSeries)series[i]).YData);

				}
				else
				{
					if(XRangeStart > GetMIN(((DataSeries)series[i]).XData))
					{
						XRangeStart = GetMIN(((DataSeries)series[i]).XData);
					}
					if(XRangeEnd < GetMAX(((DataSeries)series[i]).XData))
					{
						XRangeEnd = GetMAX(((DataSeries)series[i]).XData);
					}
					if(YRangeStart > GetMIN(((DataSeries)series[i]).YData) - (GetMIN(((DataSeries)series[i]).YData) / 10))
					{
						YRangeStart =  GetMIN(((DataSeries)series[i]).YData) - (GetMIN(((DataSeries)series[i]).YData) / 10);
					}
					if(YRangeStart == 0)
					{
						YRangeStart = -1;
					}
					if(YRangeEnd < GetMAX(((DataSeries)series[i]).YData))
					{
						YRangeEnd = GetMAX(((DataSeries)series[i]).YData);
					}
				}
			}

			double TickBase = (XRangeEnd - XRangeStart) / 5;
			XGrid = Floor(TickBase, -GetDigit(TickBase));
			XRangeStart = Math.Floor(XRangeStart / XGrid) * XGrid;

			TickBase = (YRangeEnd - YRangeStart) / 5;
			YGrid = Floor(TickBase, -GetDigit(TickBase));
			YRangeStart = Math.Floor(YRangeStart / YGrid) * YGrid;

		}

		private double GetMAX(double [] df)
		{
			double dfResult = 0.0F;

			if(df != null)
			{
				for(int i = 0 ; i < df.Length ; i++)
				{
					if(dfResult < df[i])
					{
						dfResult = df[i];
					}
				}
			}

			return dfResult;
		}

		private double GetMIN(double [] df)
		{
			double dfResult = 99999.0F;

			if(df != null)
			{
				for(int i = 0 ; i < df.Length ; i++)
				{
					if(dfResult > df[i])
					{
						dfResult = df[i];
					}
				}
			}

			return dfResult;
		}

		private double Floor(double Val, long Dig)
		{    
			long i;
			double temp;

			if (Val != 0)
			{
				if (Dig > 0 )
				{
					for (i=1;i<=Dig;i++)
					{
						Val = Val * 10;
					} 
				}
				else
				{
					for (i=-1;i>=Dig;i--)
					{
						Val = Val / 10;
					}
				}
            
				if (Val< 1.5)
					temp = 1;
				else if (Val< 4)
					temp = 2;
				else if (Val< 9)
					temp = 5;
				else
					temp = 10;
					
        
				if (Dig > 0)
				{ 
					for (i = 1;i<= Dig;i++) temp = temp / 10; }
				else 
				{
					for (i=-1;i>=Dig;i--) temp = temp * 10; }
			}
			else 
			{
				temp = 0;
			}

			return temp;
		}

		private long GetDigit(double Val ) 
		{
			long temp;
    
			if (Val != 0)
				temp = (long)(Math.Floor(Math.Log(Math.Abs(Val)) / Math.Log(10) + Math.Abs(Val) / 1000000));
			else
				temp = 0;

			return temp;
		}
	}

	/// <summary>
	/// The DataSeries calss is a Legend of Plotter to display 2D data
	/// in an X/Y coordinate system by multiple series.
	/// </summary>
	
	public class DataSeries : Object
	{
		public DataSeries()
		{
			//
		}

		private String name ;
		[Category("DataSeries")]
		[Description("The name of the DataSeries")]
		public String Name
		{
			get { return name ; }
			set { name = value; }
		}

		private Color color;
		[Category("DataSeries")]
		[Description("The color of the DataSeries")]
		public Color Color
		{
			get { return color ; }
			set { color = value; }
		}

		private Font seriesfont = new Font("Arial", 8);
		[Category("DataSeries")]
		[Description("The font of the DataSeries")]
		public Font Font
		{
			get { return seriesfont ; }
			set { seriesfont = value; }
		}

		private int penWidth = 2;
		[Category("DataSeries")]
		[Description("The width of the data line")]
		public int  PenWidth
		{
			get {return ( penWidth >= 2 && penWidth <= 8 ) ? penWidth : 2 ;}
			set {penWidth = value;}
		}

		private double[] xData;
		[Category("DataSeries")]
		[Description("The data to be displayed for x.")]
		public double[] XData
		{
			get {return xData;}
			set {xData = value;}
		}
		
		private double[] yData;
		[Category("DataSeries")]
		[Description("The data to be displayed for y.")]
		public double[] YData
		{
			get {return yData;}
			set {yData = value;}
		} 
		
		private double[] zData;
		[Category("DataSeries")]
		[Description("The data to be displayed for z.")]
		public double[] ZData
		{
			get {return zData;}
			set {zData = value;}
		} 
	}

	public class RGB_Data_List
	{
		public RGB_Data [] clsRGB_Data = new RGB_Data[64];

		public RGB_Data_List()
		{
			for(int i = 0 ; i < clsRGB_Data.Length ; i++)
			{
				clsRGB_Data[i] = new RGB_Data();
			}

			clsRGB_Data[0].dimData = new double[3] {0,0,0.5625};
			clsRGB_Data[1].dimData = new double[3] {0,0,0.6250};
			clsRGB_Data[2].dimData = new double[3] {0,0,0.6875};
			clsRGB_Data[3].dimData = new double[3] {0,0,0.7500};
			clsRGB_Data[4].dimData = new double[3] {0,0,0.8125};
			clsRGB_Data[5].dimData = new double[3] {0,0,0.8750};
			clsRGB_Data[6].dimData = new double[3] {0,0,0.9375};
			clsRGB_Data[7].dimData = new double[3] {0,0,1.0000};
			clsRGB_Data[8].dimData = new double[3] {0,0.0625,1.0000};
			clsRGB_Data[9].dimData = new double[3] {0,0.1250,1.0000};
			clsRGB_Data[10].dimData = new double[3] {0,0.1875,1.0000};
			clsRGB_Data[11].dimData = new double[3] {0,0.2500,1.0000};
			clsRGB_Data[12].dimData = new double[3] {0,0.3125,1.0000};
			clsRGB_Data[13].dimData = new double[3] {0,0.3750,1.0000};
			clsRGB_Data[14].dimData = new double[3] {0,0.4375,1.0000};
			clsRGB_Data[15].dimData = new double[3] {0,0.5000,1.0000};
			clsRGB_Data[16].dimData = new double[3] {0,0.5625,1.0000};
			clsRGB_Data[17].dimData = new double[3] {0,0.6250,1.0000};
			clsRGB_Data[18].dimData = new double[3] {0,0.6875,1.0000};
			clsRGB_Data[19].dimData = new double[3] {0,0.7500,1.0000};
			clsRGB_Data[20].dimData = new double[3] {0,0.8125,1.0000};
			clsRGB_Data[21].dimData = new double[3] {0,0.8750,1.0000};
			clsRGB_Data[22].dimData = new double[3] {0,0.9375,1.0000};
			clsRGB_Data[23].dimData = new double[3] {0,1.0000,1.0000};
			clsRGB_Data[24].dimData = new double[3] {0.0625,1.0000,0.9375};
			clsRGB_Data[25].dimData = new double[3] {0.1250,1.0000,0.8750};
			clsRGB_Data[26].dimData = new double[3] {0.1875,1.0000,0.8125};
			clsRGB_Data[27].dimData = new double[3] {0.2500,1.0000,0.7500};
			clsRGB_Data[28].dimData = new double[3] {0.3125,1.0000,0.6875};
			clsRGB_Data[29].dimData = new double[3] {0.3750,1.0000,0.6250};
			clsRGB_Data[30].dimData = new double[3] {0.4375,1.0000,0.5625};
			clsRGB_Data[31].dimData = new double[3] {0.5000,1.0000,0.5000};
			clsRGB_Data[32].dimData = new double[3] {0.5625,1.0000,0.4375};
			clsRGB_Data[33].dimData = new double[3] {0.6250,1.0000,0.3750};
			clsRGB_Data[34].dimData = new double[3] {0.6875,1.0000,0.3125};
			clsRGB_Data[35].dimData = new double[3] {0.7500,1.0000,0.2500};
			clsRGB_Data[36].dimData = new double[3] {0.8125,1.0000,0.1875};
			clsRGB_Data[37].dimData = new double[3] {0.8750,1.0000,0.1250};
			clsRGB_Data[38].dimData = new double[3] {0.9375,1.0000,0.0625};
			clsRGB_Data[39].dimData = new double[3] {1.0000,1.0000,0};
			clsRGB_Data[40].dimData = new double[3] {1.0000,0.9375,0};
			clsRGB_Data[41].dimData = new double[3] {1.0000,0.8750,0};
			clsRGB_Data[42].dimData = new double[3] {1.0000,0.8125,0};
			clsRGB_Data[43].dimData = new double[3] {1.0000,0.7500,0};
			clsRGB_Data[44].dimData = new double[3] {1.0000,0.6875,0};
			clsRGB_Data[45].dimData = new double[3] {1.0000,0.6250,0};
			clsRGB_Data[46].dimData = new double[3] {1.0000,0.5625,0};
			clsRGB_Data[47].dimData = new double[3] {1.0000,0.5000,0};
			clsRGB_Data[48].dimData = new double[3] {1.0000,0.4375,0};
			clsRGB_Data[49].dimData = new double[3] {1.0000,0.3750,0};
			clsRGB_Data[50].dimData = new double[3] {1.0000,0.3125,0};
			clsRGB_Data[51].dimData = new double[3] {1.0000,0.2500,0};
			clsRGB_Data[52].dimData = new double[3] {1.0000,0.1875,0};
			clsRGB_Data[53].dimData = new double[3] {1.0000,0.1250,0};
			clsRGB_Data[54].dimData = new double[3] {1.0000,0.0625,0};
			clsRGB_Data[55].dimData = new double[3] {1.0000,0,0};
			clsRGB_Data[56].dimData = new double[3] {0.9375,0,0};
			clsRGB_Data[57].dimData = new double[3] {0.8750,0,0};
			clsRGB_Data[58].dimData = new double[3] {0.8125,0,0};
			clsRGB_Data[59].dimData = new double[3] {0.7500,0,0};
			clsRGB_Data[60].dimData = new double[3] {0.6875,0,0};
			clsRGB_Data[61].dimData = new double[3] {0.6250,0,0};
			clsRGB_Data[62].dimData = new double[3] {0.5625,0,0};
			clsRGB_Data[63].dimData = new double[3] {0.5000,0,0};
		}
	}

	public class RGB_Data
	{
		public double [] dimData = new double[3];

		public RGB_Data()
		{
		}
	}

	public class Point_Data
	{
		public double y_Data;
		public double x_Data;

		public Point_Data()
		{
			y_Data = 0.0F;
			x_Data = 0.0F;
		}

		public Point_Data(float x,float y)
		{
			y_Data = y;
			x_Data = x;
		}
	}
}

