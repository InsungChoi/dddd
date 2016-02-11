using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using HONUS.Common_Class;
using HONUS.MaterialDatabase.Component;
using HONUS.MaterialDatabase.Form;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// dgMultyGraph에 대한 요약 설명입니다.
	/// </summary>
	public class dgMultyGraph : System.Windows.Forms.Form
	{
		private DataPlotter.Plotter plotter1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private DataPlotter.Plotter plotter3;
		private DataPlotter.Plotter plotter2;

		public bool bIsSingle;
		public int Measured;
		public int Incidence;
		public int FreqBand;
		public string [] strID;

		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public dgMultyGraph()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
			bIsSingle = false;

			Measured = 0;
			Incidence = 0;
			FreqBand = 0;
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		public void GraphDraw()
		{
			DataPlotter.DataSeries pSeries1;
			DataPlotter.DataSeries pSeries2;
			DataPlotter.DataSeries pSeries3;

			plotter1.ColorGrid = Color.LightGray;
			plotter1.XRangeStart = 0;
			plotter1.XRangeEnd = 6400;
			plotter1.XGrid = 1000;
			plotter1.YRangeStart = 0;
			plotter1.YRangeEnd = 1;
			plotter1.YGrid = 0.2;
			plotter1.Series.Clear();

			plotter2.ColorGrid = Color.LightGray;
			plotter2.XRangeStart = 0;
			plotter2.XRangeEnd = 6400;
			plotter2.XGrid = 1000;
			plotter2.YRangeStart = 0;
			plotter2.YRangeEnd = 1;
			plotter2.YGrid = 0.2;
			plotter2.Series.Clear();

			plotter3.ColorGrid = Color.LightGray;
			plotter3.XRangeStart = 0;
			plotter3.XRangeEnd = 6400;
			plotter3.XGrid = 1000;
			plotter3.YRangeStart = 0;
			plotter3.YRangeEnd = 60;
			plotter3.YGrid = 10;
			plotter3.Series.Clear();

			bool DataExist = false;

			MPEData MPEData1;
			MD_DB MD_DB1 = new MD_DB();

			int dGraph_ID = 0;

			for(int i = 0 ; i < strID.Length ; i++)
			{
				dGraph_ID = MD_DB1.IsGraphExist(bIsSingle,Measured,Incidence,FreqBand,1,int.Parse(strID[i]));
				if(dGraph_ID != -1)
				{
					MPEData1 = new MPEData();

					if(MPEData1.DBLoad(bIsSingle,dGraph_ID) == true)
					{
						DataExist = true;

						pSeries1 = new DataPlotter.DataSeries();
						pSeries1.Name = "Data " + i.ToString();

						int dR = (30 * i * 1000) % 256;
						int dG = (20 * i * 200) % 256;
						int dB = (10 * i * 10) % 256;

						pSeries1.Color = Color.FromArgb(dR,dG,dB);

//						switch(i)
//						{
//							case 0 :
//								pSeries1.Color = Color.Blue ;
//								break;
//							case 1 :
//								pSeries1.Color = Color.Red ;
//								break;
//							case 2 :
//								pSeries1.Color = Color.Yellow ;
//								break;
//							case 3 :
//								pSeries1.Color = Color.Green ;
//								break;
//						}

						pSeries1.XData = MPEData1.Frequency.GetData();
						pSeries1.YData = MPEData1.MAbsorption.GetData();

						
						plotter1.YLabel = "Absorption Coefficient for Rigid Backing";
						plotter1.XLabel = "Frequency [Hz]";
								
						

						if(DataExist == true)
						{
							plotter1.Series.Add(pSeries1);
						}
					}
				}
			}

			//plotter1.AutoRange();
			plotter1.Refresh();

			for(int i = 0 ; i < strID.Length ; i++)
			{
				dGraph_ID = MD_DB1.IsGraphExist(bIsSingle,Measured,Incidence,FreqBand,2,int.Parse(strID[i]));
				if(dGraph_ID != -1)
				{
					MPEData1 = new MPEData();

					if(MPEData1.DBLoad(bIsSingle,dGraph_ID) == true)
					{
						DataExist = true;

						pSeries2 = new DataPlotter.DataSeries();
						pSeries2.Name = "Data " + i.ToString();

						pSeries2.XData = MPEData1.Frequency.GetData();
						pSeries2.YData = MPEData1.MAbsorption.GetData();

						int dR = (30 * i * 1000) % 256;
						int dG = (20 * i * 200) % 256;
						int dB = (10 * i * 10) % 256;

						pSeries2.Color = Color.FromArgb(dR,dG,dB);

//						switch(i)
//						{
//							case 0 :
//								pSeries2.Color = Color.Blue ;
//								break;
//							case 1 :
//								pSeries2.Color = Color.Red ;
//								break;
//							case 2 :
//								pSeries2.Color = Color.Yellow ;
//								break;
//							case 3 :
//								pSeries2.Color = Color.Green ;
//								break;
//						}

						if(DataExist == true)
						{
							plotter2.Series.Add(pSeries2);
						}

						plotter2.YLabel = "Absotpyion Coefficient for Anechoic termiation";
						plotter2.XLabel = "Frequency [Hz]";
					}
				}

				//plotter2.AutoRange();
				plotter2.Refresh();
			}

			for(int i = 0 ; i < strID.Length ; i++)
			{
				dGraph_ID = MD_DB1.IsGraphExist(bIsSingle,Measured,Incidence,FreqBand,3,int.Parse(strID[i]));
				if(dGraph_ID != -1)
				{
					MPEData1 = new MPEData();

					if(MPEData1.DBLoad(bIsSingle,dGraph_ID) == true)
					{
						DataExist = true;

						pSeries3 = new DataPlotter.DataSeries();
						pSeries3.Name = "Data " + i.ToString();

						int dR = (30 * i * 1000) % 256;
						int dG = (20 * i * 200) % 256;
						int dB = (10 * i * 10) % 256;

						pSeries3.Color = Color.FromArgb(dR,dG,dB);

//						switch(i)
//						{
//							case 0 :
//								pSeries3.Color = Color.Blue ;
//								break;
//							case 1 :
//								pSeries3.Color = Color.Red ;
//								break;
//							case 2 :
//								pSeries3.Color = Color.Yellow ;
//								break;
//							case 3 :
//								pSeries3.Color = Color.Green ;
//								break;
//						}

						pSeries3.XData = MPEData1.Frequency.GetData();
						pSeries3.YData = MPEData1.MAbsorption.GetData();

						plotter3.YLabel = "Transmission Loss [dB]";
						plotter3.XLabel = "Frequency [Hz]";

						if(DataExist == true)
						{
							plotter3.Series.Add(pSeries3);
						}
					}
				}
			}

			//plotter3.AutoRange();
			plotter3.Refresh();
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.plotter1 = new DataPlotter.Plotter();
			this.plotter3 = new DataPlotter.Plotter();
			this.plotter2 = new DataPlotter.Plotter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// plotter1
			// 
			this.plotter1.BorderBottom = 50;
			this.plotter1.BorderLeft = 50;
			this.plotter1.BorderRight = 30;
			this.plotter1.BorderTop = 30;
			this.plotter1.ColorAxis = System.Drawing.Color.Black;
			this.plotter1.ColorBg = System.Drawing.Color.White;
			this.plotter1.ColorDraw = System.Drawing.Color.DarkBlue;
			this.plotter1.ColorGrid = System.Drawing.Color.LightGray;
			this.plotter1.Dock = System.Windows.Forms.DockStyle.Left;
			this.plotter1.DrawMode = DataPlotter.Plotter.DrawModeType.Line;
			this.plotter1.FontAxis = new System.Drawing.Font("Arial", 8F);
			this.plotter1.FontLabel = new System.Drawing.Font("굴림", 9F);
			this.plotter1.FontTitle = new System.Drawing.Font("굴림", 9F);
			this.plotter1.Interval = 0;
			this.plotter1.IsOctave = false;
			this.plotter1.Location = new System.Drawing.Point(0, 0);
			this.plotter1.MarkerSize = 4;
			this.plotter1.MarkerType = DataPlotter.Plotter.MarkerModeType.None;
			this.plotter1.Name = "plotter1";
			this.plotter1.PenWidth = 1;
			this.plotter1.ShowGrid = true;
			this.plotter1.ShowLegend = false;
			this.plotter1.Size = new System.Drawing.Size(326, 378);
			this.plotter1.TabIndex = 23;
			this.plotter1.Title = "Absorption Coefficient (Rigid Backing)";
			this.plotter1.TitleColor = System.Drawing.Color.Black;
			this.plotter1.XAxisMode = DataPlotter.Plotter.XAxisModeType.Linear;
			this.plotter1.XGrid = 10;
			this.plotter1.XLabel = "X Axis";
			this.plotter1.XLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter1.XRangeEnd = 100;
			this.plotter1.XRangeStart = 0;
			this.plotter1.YAxisMode = DataPlotter.Plotter.YAxisModeType.Linear;
			this.plotter1.YGrid = 10;
			this.plotter1.YLabel = "Y Axis";
			this.plotter1.YLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter1.YRangeEnd = 100;
			this.plotter1.YRangeStart = 0;
			this.plotter1.ZAxisMode = DataPlotter.Plotter.ZAxisModeType.Linear;
			this.plotter1.ZLabel = "Z Axis";
			this.plotter1.ZLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter1.ZRangeEnd = 100;
			this.plotter1.ZRangeStart = 0;
			// 
			// plotter3
			// 
			this.plotter3.BorderBottom = 50;
			this.plotter3.BorderLeft = 50;
			this.plotter3.BorderRight = 30;
			this.plotter3.BorderTop = 30;
			this.plotter3.ColorAxis = System.Drawing.Color.Black;
			this.plotter3.ColorBg = System.Drawing.Color.White;
			this.plotter3.ColorDraw = System.Drawing.Color.DarkBlue;
			this.plotter3.ColorGrid = System.Drawing.Color.LightGray;
			this.plotter3.Dock = System.Windows.Forms.DockStyle.Right;
			this.plotter3.DrawMode = DataPlotter.Plotter.DrawModeType.Line;
			this.plotter3.FontAxis = new System.Drawing.Font("Arial", 8F);
			this.plotter3.FontLabel = new System.Drawing.Font("굴림", 9F);
			this.plotter3.FontTitle = new System.Drawing.Font("굴림", 9F);
			this.plotter3.Interval = 0;
			this.plotter3.IsOctave = false;
			this.plotter3.Location = new System.Drawing.Point(684, 0);
			this.plotter3.MarkerSize = 4;
			this.plotter3.MarkerType = DataPlotter.Plotter.MarkerModeType.None;
			this.plotter3.Name = "plotter3";
			this.plotter3.PenWidth = 1;
			this.plotter3.ShowGrid = true;
			this.plotter3.ShowLegend = false;
			this.plotter3.Size = new System.Drawing.Size(326, 378);
			this.plotter3.TabIndex = 24;
			this.plotter3.Title = "Transmission Loss";
			this.plotter3.TitleColor = System.Drawing.Color.Black;
			this.plotter3.XAxisMode = DataPlotter.Plotter.XAxisModeType.Linear;
			this.plotter3.XGrid = 10;
			this.plotter3.XLabel = "X Axis";
			this.plotter3.XLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter3.XRangeEnd = 100;
			this.plotter3.XRangeStart = 0;
			this.plotter3.YAxisMode = DataPlotter.Plotter.YAxisModeType.Linear;
			this.plotter3.YGrid = 10;
			this.plotter3.YLabel = "Y Axis";
			this.plotter3.YLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter3.YRangeEnd = 100;
			this.plotter3.YRangeStart = 0;
			this.plotter3.ZAxisMode = DataPlotter.Plotter.ZAxisModeType.Linear;
			this.plotter3.ZLabel = "Z Axis";
			this.plotter3.ZLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter3.ZRangeEnd = 100;
			this.plotter3.ZRangeStart = 0;
			// 
			// plotter2
			// 
			this.plotter2.BorderBottom = 50;
			this.plotter2.BorderLeft = 50;
			this.plotter2.BorderRight = 30;
			this.plotter2.BorderTop = 30;
			this.plotter2.ColorAxis = System.Drawing.Color.Black;
			this.plotter2.ColorBg = System.Drawing.Color.White;
			this.plotter2.ColorDraw = System.Drawing.Color.DarkBlue;
			this.plotter2.ColorGrid = System.Drawing.Color.LightGray;
			this.plotter2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plotter2.DrawMode = DataPlotter.Plotter.DrawModeType.Line;
			this.plotter2.FontAxis = new System.Drawing.Font("Arial", 8F);
			this.plotter2.FontLabel = new System.Drawing.Font("굴림", 9F);
			this.plotter2.FontTitle = new System.Drawing.Font("굴림", 9F);
			this.plotter2.Interval = 0;
			this.plotter2.IsOctave = false;
			this.plotter2.Location = new System.Drawing.Point(336, 0);
			this.plotter2.MarkerSize = 4;
			this.plotter2.MarkerType = DataPlotter.Plotter.MarkerModeType.None;
			this.plotter2.Name = "plotter2";
			this.plotter2.PenWidth = 1;
			this.plotter2.ShowGrid = true;
			this.plotter2.ShowLegend = false;
			this.plotter2.Size = new System.Drawing.Size(338, 378);
			this.plotter2.TabIndex = 25;
			this.plotter2.Title = "Absorption Coefficient (anechoic termination)";
			this.plotter2.TitleColor = System.Drawing.Color.Black;
			this.plotter2.XAxisMode = DataPlotter.Plotter.XAxisModeType.Linear;
			this.plotter2.XGrid = 10;
			this.plotter2.XLabel = "X Axis";
			this.plotter2.XLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter2.XRangeEnd = 100;
			this.plotter2.XRangeStart = 0;
			this.plotter2.YAxisMode = DataPlotter.Plotter.YAxisModeType.Linear;
			this.plotter2.YGrid = 10;
			this.plotter2.YLabel = "Y Axis";
			this.plotter2.YLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter2.YRangeEnd = 100;
			this.plotter2.YRangeStart = 0;
			this.plotter2.ZAxisMode = DataPlotter.Plotter.ZAxisModeType.Linear;
			this.plotter2.ZLabel = "Z Axis";
			this.plotter2.ZLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter2.ZRangeEnd = 100;
			this.plotter2.ZRangeStart = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Location = new System.Drawing.Point(326, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 378);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox2.Location = new System.Drawing.Point(674, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(10, 378);
			this.pictureBox2.TabIndex = 27;
			this.pictureBox2.TabStop = false;
			// 
			// dgMultyGraph
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1010, 378);
			this.Controls.Add(this.plotter2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.plotter3);
			this.Controls.Add(this.plotter1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "dgMultyGraph";
			this.Text = "Graph Compare";
			this.Load += new System.EventHandler(this.dgMultyGraph_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void dgMultyGraph_Load(object sender, System.EventArgs e)
		{
			GraphDraw();
		}
	}
}
