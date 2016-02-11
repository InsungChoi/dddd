using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using HONUS.Common_Class;

namespace HONUS.MaterialPerformanceAnalysis.UserControl
{
	/// <summary>
	/// ucMaterialPerformanceAnalysis에 대한 요약 설명입니다.
	/// </summary>
	public class ucMaterialPerformanceAnalysis : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button btnRigidBacking;
		private System.Windows.Forms.Button btnAnechoicTermination;
		private System.Windows.Forms.Button btnTransmissionLoss;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Button btnGraphSave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Button btnGraphEdit;
		private System.Windows.Forms.Button btnGraphHide;
		private System.Windows.Forms.PictureBox pictureBox8;
		private DataPlotter.Plotter plotter1;

		public MPALayer MPALayer1;
		private System.Windows.Forms.PictureBox pictureBox9;

		/// <summary>
		/// Narrow = 0,Octave 1,3/1 Octave 2.
		/// </summary>
		public int dOctave = 0;

		public ucMaterialPerformanceAnalysis()
		{
			// 이 호출은 Windows.Forms Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			//NullGraph();

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

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRigidBacking = new System.Windows.Forms.Button();
			this.btnAnechoicTermination = new System.Windows.Forms.Button();
			this.btnTransmissionLoss = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.plotter1 = new DataPlotter.Plotter();
			this.btnGraphSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnGraphEdit = new System.Windows.Forms.Button();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.btnGraphHide = new System.Windows.Forms.Button();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnRigidBacking
			// 
			this.btnRigidBacking.BackColor = System.Drawing.SystemColors.Control;
			this.btnRigidBacking.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnRigidBacking.Location = new System.Drawing.Point(0, 16);
			this.btnRigidBacking.Name = "btnRigidBacking";
			this.btnRigidBacking.Size = new System.Drawing.Size(690, 24);
			this.btnRigidBacking.TabIndex = 0;
			this.btnRigidBacking.Text = "Absorption Coefficient for rigid backing";
			this.btnRigidBacking.Click += new System.EventHandler(this.btnRigidBacking_Click);
			// 
			// btnAnechoicTermination
			// 
			this.btnAnechoicTermination.BackColor = System.Drawing.SystemColors.Control;
			this.btnAnechoicTermination.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnAnechoicTermination.Location = new System.Drawing.Point(0, 52);
			this.btnAnechoicTermination.Name = "btnAnechoicTermination";
			this.btnAnechoicTermination.Size = new System.Drawing.Size(690, 24);
			this.btnAnechoicTermination.TabIndex = 1;
			this.btnAnechoicTermination.Text = "Absorption Coefficient for anechoic termination";
			this.btnAnechoicTermination.Click += new System.EventHandler(this.btnAnechoicTermination_Click);
			// 
			// btnTransmissionLoss
			// 
			this.btnTransmissionLoss.BackColor = System.Drawing.SystemColors.Control;
			this.btnTransmissionLoss.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnTransmissionLoss.Location = new System.Drawing.Point(0, 88);
			this.btnTransmissionLoss.Name = "btnTransmissionLoss";
			this.btnTransmissionLoss.Size = new System.Drawing.Size(690, 24);
			this.btnTransmissionLoss.TabIndex = 2;
			this.btnTransmissionLoss.Text = "Transmission Loss";
			this.btnTransmissionLoss.Click += new System.EventHandler(this.btnTransmissionLoss_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 572);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox2.Location = new System.Drawing.Point(10, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(700, 10);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox3.Location = new System.Drawing.Point(10, 562);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(700, 10);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox4.Location = new System.Drawing.Point(700, 10);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 552);
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox9);
			this.panel1.Controls.Add(this.btnRigidBacking);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.btnAnechoicTermination);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.btnTransmissionLoss);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(10, 450);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(690, 112);
			this.panel1.TabIndex = 9;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox6.Location = new System.Drawing.Point(0, 40);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(690, 12);
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox5.Location = new System.Drawing.Point(0, 76);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(690, 12);
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(500, 10);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.SelectedObject = this.plotter1;
			this.propertyGrid1.Size = new System.Drawing.Size(200, 440);
			this.propertyGrid1.TabIndex = 11;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.propertyGrid1.Visible = false;
			this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
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
			this.plotter1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plotter1.DrawMode = DataPlotter.Plotter.DrawModeType.Line;
			this.plotter1.FontAxis = new System.Drawing.Font("Arial", 8F);
			this.plotter1.FontLabel = new System.Drawing.Font("굴림", 9F);
			this.plotter1.FontTitle = new System.Drawing.Font("굴림", 9F);
			this.plotter1.Interval = 0;
			this.plotter1.IsOctave = false;
			this.plotter1.Location = new System.Drawing.Point(10, 10);
			this.plotter1.MarkerSize = 4;
			this.plotter1.MarkerType = DataPlotter.Plotter.MarkerModeType.None;
			this.plotter1.Name = "plotter1";
			this.plotter1.PenWidth = 1;
			this.plotter1.ShowGrid = true;
			this.plotter1.ShowLegend = false;
			this.plotter1.Size = new System.Drawing.Size(490, 417);
			this.plotter1.TabIndex = 14;
			this.plotter1.Title = "Plotter Example";
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
			// btnGraphSave
			// 
			this.btnGraphSave.BackColor = System.Drawing.SystemColors.Control;
			this.btnGraphSave.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnGraphSave.Location = new System.Drawing.Point(0, 0);
			this.btnGraphSave.Name = "btnGraphSave";
			this.btnGraphSave.Size = new System.Drawing.Size(160, 23);
			this.btnGraphSave.TabIndex = 12;
			this.btnGraphSave.Text = "Graph Save";
			this.btnGraphSave.Click += new System.EventHandler(this.btnGraphSave_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnGraphEdit);
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Controls.Add(this.btnGraphHide);
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.btnGraphSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(10, 427);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(490, 23);
			this.panel2.TabIndex = 13;
			// 
			// btnGraphEdit
			// 
			this.btnGraphEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnGraphEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnGraphEdit.Location = new System.Drawing.Point(170, 0);
			this.btnGraphEdit.Name = "btnGraphEdit";
			this.btnGraphEdit.Size = new System.Drawing.Size(174, 23);
			this.btnGraphEdit.TabIndex = 14;
			this.btnGraphEdit.Text = "Graph Edit";
			this.btnGraphEdit.Click += new System.EventHandler(this.btnGraphEdit_Click);
			// 
			// pictureBox8
			// 
			this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox8.Location = new System.Drawing.Point(344, 0);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(10, 23);
			this.pictureBox8.TabIndex = 16;
			this.pictureBox8.TabStop = false;
			// 
			// btnGraphHide
			// 
			this.btnGraphHide.BackColor = System.Drawing.SystemColors.Control;
			this.btnGraphHide.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnGraphHide.Enabled = false;
			this.btnGraphHide.Location = new System.Drawing.Point(354, 0);
			this.btnGraphHide.Name = "btnGraphHide";
			this.btnGraphHide.Size = new System.Drawing.Size(136, 23);
			this.btnGraphHide.TabIndex = 15;
			this.btnGraphHide.Text = "Edit Cancel";
			this.btnGraphHide.Click += new System.EventHandler(this.btnGraphHide_Click);
			// 
			// pictureBox7
			// 
			this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox7.Location = new System.Drawing.Point(160, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(10, 23);
			this.pictureBox7.TabIndex = 13;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox9.Location = new System.Drawing.Point(0, 4);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(690, 12);
			this.pictureBox9.TabIndex = 6;
			this.pictureBox9.TabStop = false;
			// 
			// ucMaterialPerformanceAnalysis
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.plotter1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ucMaterialPerformanceAnalysis";
			this.Size = new System.Drawing.Size(710, 572);
			this.Load += new System.EventHandler(this.ucMaterialPerformanceAnalysis_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ucMaterialPerformanceAnalysis_Load(object sender, System.EventArgs e)
		{
			//GraphDraw();
		}

		public void GraphDraw(string strType)
		{
			DataPlotter.DataSeries pSeries1 = new DataPlotter.DataSeries();

			//plotter1.ColorBg = Color.LightYellow;
			plotter1.ColorGrid = Color.LightGray;
			//plotter1.XLogBase = 0;
			plotter1.XRangeStart = 0;
			plotter1.XRangeEnd = 8000;
			plotter1.XGrid = 1000;
			//plotter1.YLogBase = 0;
			plotter1.YRangeStart = 0;
			plotter1.YRangeEnd = 1;
			plotter1.YGrid = 2;
			plotter1.Series.Clear();

			pSeries1.Name  = "Data 01";
			pSeries1.Color = Color.Blue ;

			bool DataExist = false;

			if(MPALayer1 != null)
			{
				#region 예전
//				object [] ar = new object[3];
//
//				DataTable table = new DataTable();
//
//				table.Columns.Add("GroupName",typeof(int));
//				table.Columns.Add("my_X",typeof(double));
//				table.Columns.Add("my_Y",typeof(double));
				#endregion

				if(strType == "")
				{
					strType = "Absorption Coefficient for rigid backing";
				}

				if(strType == "Absorption Coefficient for rigid backing")
				{
					#region 예전
//					for(int i = 0 ; i < MPALayer1.Frequency.GetCount() ; i++)
//					{
						
//						DataRow row = table.NewRow();
//						ar[0] = i.ToString();
//						ar[1] = MPALayer1.Frequency.GetData(i).ToString();
//						ar[2] = MPALayer1.RigidBacking.GetData(i).ToString();
//						row.ItemArray = ar;
//						table.Rows.Add(row);
//					}
					#endregion

					pSeries1.XData = MPALayer1.Frequency.GetData();
					pSeries1.YData = MPALayer1.RigidBacking.GetData();

					DataExist = true;

					plotter1.YGrid = 0.2;
				}
				else if(strType == "Absorption Coefficient for anechoic termination")
				{
					#region 예전
//					for(int i = 0 ; i < MPALayer1.Frequency.GetCount() ; i++)
//					{
						
//						DataRow row = table.NewRow();
//						ar[0] = i.ToString();
//						ar[1] = MPALayer1.Frequency.GetData(i).ToString();
//						ar[2] = MPALayer1.AnechoicTermination.GetData(i).ToString();
//						row.ItemArray = ar;
//						table.Rows.Add(row);
//					}
					#endregion

					pSeries1.XData = MPALayer1.Frequency.GetData();
					pSeries1.YData = MPALayer1.AnechoicTermination.GetData();

					DataExist = true;

					plotter1.YGrid = 0.2;
				}
				else if(strType == "Transmission Loss")
				{
					#region 예전
//					for(int i = 0 ; i < MPALayer1.Frequency.GetCount() ; i++)
//					{
						
//						DataRow row = table.NewRow();
//						ar[0] = i.ToString();
//						ar[1] = MPALayer1.Frequency.GetData(i).ToString();
//						ar[2] = MPALayer1.TransmissionLoss.GetData(i).ToString();
//						row.ItemArray = ar;
//						table.Rows.Add(row);
//					}
					#endregion

					pSeries1.XData = MPALayer1.Frequency.GetData();
					pSeries1.YData = MPALayer1.TransmissionLoss.GetData();

					DataExist = true;

					plotter1.YGrid = 20;
					plotter1.YRangeEnd = 100;
					plotter1.XRangeStart = 0;
					plotter1.XRangeEnd = 8000;
				}

				if(DataExist == true)
				{
					#region 예전
//					ultraChart1.DataSource = table;
//					ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
//					ultraChart1.ScatterChart.ConnectWithLines = true;
					#endregion

					if(dOctave != 0)
					{
						//plotter1.IsOctave = true;

						if(dOctave == 2)
						{
							plotter1.Interval = 2;
						}
						else
						{
							plotter1.Interval = 0;
						}
					}
					else
					{
						plotter1.IsOctave = false;

						plotter1.XRangeEnd = 7000;
						plotter1.XGrid = 1000;
					}
					plotter1.Series.Clear();
					plotter1.Series.Add(pSeries1);
					plotter1.Refresh();
				}
//				else
//				{
//					NullGraph();
//				}
			}
//			else
//			{
//				NullGraph();
//			}
		}

//		private void NullGraph()
//		{
//			object [] ar = new object[3];
//		
//			DataTable table = new DataTable();
//		
//			table.Columns.Add("GroupName",typeof(int));
//			table.Columns.Add("my_X",typeof(int));
//			table.Columns.Add("my_Y",typeof(int));
//		
//			DataRow row = table.NewRow();
//			ar[0] = "1";
//			ar[1] = 0;
//			ar[2] = 0;
//			row.ItemArray = ar;
//			table.Rows.Add(row);
//
//			ultraChart1.DataSource = table;
//			ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
//			ultraChart1.ScatterChart.ConnectWithLines = true;
//		}

		private void btnRigidBacking_Click(object sender, System.EventArgs e)
		{
			GraphDraw(btnRigidBacking.Text);
		}

		private void btnAnechoicTermination_Click(object sender, System.EventArgs e)
		{
			GraphDraw(btnAnechoicTermination.Text);
		}

		private void btnTransmissionLoss_Click(object sender, System.EventArgs e)
		{
			GraphDraw(btnTransmissionLoss.Text);
		}

		private void propertyGrid1_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			plotter1.Refresh();
		}

		private void btnGraphSave_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.Filter = "(*.Bmp)|*.Bmp|(*.Emf)|*.Emf|(*.Exif)|*.Exif|(*.Gif)|*.Gif|(*.Icon)|*.Icon|(*.Jpeg)|*.Jpeg|(*.MemoryBmp)|*.MemoryBmp|(*.Png)|*.Png|(*.Tiff)|*.Tiff|(*.Wmf)|*.Wmf";

			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string path = saveFileDialog1.FileName;
				string strExtension = System.IO.Path.GetExtension(saveFileDialog1.FileName);
				switch(strExtension)
				{
					case ".Bmp" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Bmp);
						break;
					case ".Emf" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Emf);
						break;
					case ".Exif" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Exif);
						break;
					case ".Gif" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Gif);
						break;
					case ".Icon" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Icon);
						break;
					case ".Jpeg" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Jpeg);
						break;
					case ".MemoryBmp" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.MemoryBmp);
						break;
					case ".Png" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Png);
						break;
					case ".Tiff" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Tiff);
						break;
					case ".Wmf" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Wmf);
						break;
				}
			}
		}

		private void btnGraphEdit_Click(object sender, System.EventArgs e)
		{
			propertyGrid1.Visible = true;

			btnGraphHide.Enabled = true;
			btnGraphEdit.Enabled = false;
		}

		private void btnGraphHide_Click(object sender, System.EventArgs e)
		{
			propertyGrid1.Visible = false;

			btnGraphHide.Enabled = false;
			btnGraphEdit.Enabled = true;
		}

//		private void btnSaveDatabase_Click(object sender, System.EventArgs e)
//		{
//			if(MPALayer1 != null)
//			{
//				MPALayer1.DBSave();
//			}
//		}
	}
}
