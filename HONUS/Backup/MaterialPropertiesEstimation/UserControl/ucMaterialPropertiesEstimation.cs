using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using HONUS.Common_Class;
using HONUS.MaterialPropertiesEstimation.Component;

namespace HONUS.MaterialPropertiesEstimation.UserControl
{
	/// <summary>
	/// ucMaterialPropertiesEstimation에 대한 요약 설명입니다.
	/// </summary>
	public class ucMaterialPropertiesEstimation : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox edtLossFactor;
		private System.Windows.Forms.TextBox edtPoissionsRatio;
		private System.Windows.Forms.TextBox edtYoungsModulus;
		private System.Windows.Forms.TextBox edtThermalCharLength;
		private System.Windows.Forms.TextBox edtStructureFactor;
		private System.Windows.Forms.TextBox edtProsity;
		private System.Windows.Forms.TextBox edtViscousCharLength;
		private System.Windows.Forms.TextBox edtFlowResistivity;
		private System.Windows.Forms.TextBox edtThickness;
		private System.Windows.Forms.TextBox edtBulkDensity;
		private System.Windows.Forms.CheckBox chFlowResistivity;
		private System.Windows.Forms.CheckBox chStructureFactor;
		private System.Windows.Forms.CheckBox chProsity;
		private System.Windows.Forms.CheckBox chViscousCharLength;
		private System.Windows.Forms.CheckBox chThermalCharLength;
		private System.Windows.Forms.CheckBox chPoissionsRatio;
		private System.Windows.Forms.CheckBox chYoungsModulus;
		private System.Windows.Forms.CheckBox chLossFactor;
		private System.Windows.Forms.RadioButton rdoAbsorption;
		private System.Windows.Forms.RadioButton rdoSurface;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Button btnGraphSave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnEditCancel;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button btnGraphEdit;
		private DataPlotter.Plotter plotter1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;

		MPEClass mpeClass;

		public ucMaterialPropertiesEstimation()
		{
			// 이 호출은 Windows.Forms Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			//mpeClass = new MPEClass();

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

		public void GraphDraw(MPEClass mpeClass)
		{
			DataPlotter.DataSeries pSeries1 = new DataPlotter.DataSeries();
			DataPlotter.DataSeries pSeries2 = new DataPlotter.DataSeries();
			DataPlotter.DataSeries pSeries3;
			DataPlotter.DataSeries pSeries4;
			DataPlotter.DataSeries pSeries5;
			DataPlotter.DataSeries pSeries6;
			DataPlotter.DataSeries pSeries7;
			DataPlotter.DataSeries pSeries8;

			//plotter1.ColorBg = Color.LightYellow;
			plotter1.ColorGrid = Color.LightGray;
			//plotter1.XLogBase = 0;
			plotter1.XRangeStart = -100;
			plotter1.XRangeEnd = 1000;
			plotter1.XGrid = 100;
			//plotter1.YLogBase = 0;
			plotter1.YRangeStart = 0;
			plotter1.YRangeEnd = 1;
			plotter1.YGrid = 2;
			plotter1.Series.Clear();

			pSeries1.Name  = "Data 01";
			pSeries1.Color = Color.Blue ;

			pSeries2.Name  = "Data 02";
			pSeries2.Color = Color.Red ;

			if(mpeClass != null)
			{
				this.mpeClass = mpeClass;

				#region 예전
//				object [] ar = new object[3];

				
//				DataTable table = new DataTable();

//				table.Columns.Add("GroupName",typeof(int));
//				table.Columns.Add("my_X",typeof(double));
//				table.Columns.Add("my_Y",typeof(double));
				#endregion

				if(rdoAbsorption.Checked)
				{
					#region 예전
//					for(int i = 0 ; i < mpeClass.Frequency.GetCount() ; i++)
//					{
//						DataRow row = table.NewRow();
//						ar[0] = "1";
//						ar[1] = mpeClass.Frequency.GetData(i).ToString();
//						ar[2] = mpeClass.MAbsorption.GetData(i).ToString();
//						row.ItemArray = ar;
//						table.Rows.Add(row);
//					}
					#endregion

					pSeries1.XData = mpeClass.Frequency.GetData();
					pSeries1.YData = mpeClass.MAbsorption.GetData();

					pSeries2.XData = mpeClass.Frequency.GetData();
					pSeries2.YData = mpeClass.CAbsorption.GetData();

					plotter1.YLabel ="Absorption Coefficient";
					plotter1.XLabel ="Frequency [Hz]";

				}
				else
				{
					#region 예전
//					for(int i = 0 ; i < mpeClass.Frequency.GetCount() ; i++)
//					{
//						DataRow row = table.NewRow();
//						ar[0] = "1";
//						ar[1] = mpeClass.Frequency.GetData(i).ToString();
//						ar[2] = mpeClass.MSurfaceImpedance.GetData(i).ToString();
//						row.ItemArray = ar;
//						table.Rows.Add(row);
//					}
					#endregion

					pSeries1.XData = mpeClass.Frequency.GetData();
					pSeries1.YData = mpeClass.MRealSurfaceImpedance.GetData();

					pSeries2.XData = mpeClass.Frequency.GetData();
					pSeries2.YData = mpeClass.CRealSurfaceImpedance.GetData();

					pSeries5 = new DataPlotter.DataSeries();
					pSeries6 = new DataPlotter.DataSeries();

					pSeries5.Name  = "Data 05";
					pSeries5.Color = Color.Blue ;

					pSeries6.Name  = "Data 06";
					pSeries6.Color = Color.Red ;

					pSeries5.XData = mpeClass.Frequency.GetData();
					pSeries5.YData = mpeClass.MImagSurfaceImpedance.GetData();

					pSeries6.XData = mpeClass.Frequency.GetData();
					pSeries6.YData = mpeClass.CImagSurfaceImpedance.GetData();

					plotter1.Series.Add(pSeries5);
					plotter1.Series.Add(pSeries6);

					plotter1.YLabel ="Normalized Surface Impdedance";
					plotter1.XLabel ="Frequency [Hz]";
				}

//				plotter1.IsOctave_ = true;
//				plotter1.Interval_ = 50;
				plotter1.Series.Add(pSeries1);
				plotter1.Series.Add(pSeries2);

				for(int i = 1 ; i < mpeClass.EstData.Count ; i++)
				{
					MPEData MPEDataTemp = (MPEData)mpeClass.EstData[i];
					pSeries3 = new DataPlotter.DataSeries();
					pSeries4 = new DataPlotter.DataSeries();
					pSeries7 = new DataPlotter.DataSeries();
					pSeries8 = new DataPlotter.DataSeries();

					
					pSeries3.Name  = "Data 03";
					pSeries3.Color = Color.Yellow ;

					pSeries4.Name  = "Data 04";
					pSeries4.Color = Color.Green ;

					pSeries7.Name  = "Data 07";
					pSeries7.Color = Color.Yellow ;

					pSeries8.Name  = "Data 08";
					pSeries8.Color = Color.Green ;

					if(rdoAbsorption.Checked)
					{
						pSeries3.XData = MPEDataTemp.Frequency.GetData();
						pSeries3.YData = MPEDataTemp.MAbsorption.GetData();

						plotter1.Series.Add(pSeries3);

						pSeries4.XData = MPEDataTemp.Frequency.GetData();
						pSeries4.YData = MPEDataTemp.CAbsorption.GetData();

						plotter1.Series.Add(pSeries4);
					}
					else
					{
						pSeries3.XData = MPEDataTemp.Frequency.GetData();
						pSeries3.YData = MPEDataTemp.MRealSurfaceImpedance.GetData();

						plotter1.Series.Add(pSeries3);

						pSeries4.XData = MPEDataTemp.Frequency.GetData();
						pSeries4.YData = MPEDataTemp.CRealSurfaceImpedance.GetData();

						plotter1.Series.Add(pSeries4);

						pSeries7.XData = mpeClass.Frequency.GetData();
						pSeries7.YData = mpeClass.MImagSurfaceImpedance.GetData();

						plotter1.Series.Add(pSeries7);

						pSeries8.XData = mpeClass.Frequency.GetData();
						pSeries8.YData = mpeClass.CImagSurfaceImpedance.GetData();

						plotter1.Series.Add(pSeries8);						
					}
				}
				
				plotter1.AutoRange();
				if(rdoAbsorption.Checked)
				{
					plotter1.YRangeStart = 0.0;
					plotter1.YGrid = 0.2;
					plotter1.YRangeEnd = 1.0;
				}
				else
				{
					plotter1.YRangeStart = -20.0;
					plotter1.YGrid = 5;
					plotter1.YRangeEnd = 20;
				}
				plotter1.Refresh();//.DataSource = table;
			}
//			else
//			{
//				NullGraph();
//			}
		}

		public void TextBoxFill(MPEClass mpeClass)
		{
			edtLossFactor.Text = mpeClass.LossFactor.ToString();
			edtPoissionsRatio.Text = mpeClass.PoissonR.ToString();
			edtYoungsModulus.Text = mpeClass.Ymodulus.ToString();
			edtThermalCharLength.Text = mpeClass.ThermalCL.ToString();
			edtStructureFactor.Text = mpeClass.SFactor.ToString();
			edtProsity.Text = mpeClass.Porosity.ToString();
			edtViscousCharLength.Text = mpeClass.ViscousCL.ToString();
			edtFlowResistivity.Text = mpeClass.FResist.ToString();
			edtThickness.Text = mpeClass.Thickness.ToString();
			edtBulkDensity.Text = mpeClass.BulkDensity.ToString();
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

		public void EdtBoxInit(string strType,string strOption)
		{
			edtLossFactor.Enabled = false;
			edtPoissionsRatio.Enabled = false;
			edtYoungsModulus.Enabled = false;
			edtThermalCharLength.Enabled = false;
			edtStructureFactor.Enabled = false;
			edtProsity.Enabled = false;
			edtViscousCharLength.Enabled = false;
			edtFlowResistivity.Enabled = false;
			edtThickness.Enabled = false;
			//edtMeasuredAbsorption.Enabled = false;
			edtBulkDensity.Enabled = false;

			chFlowResistivity.Visible = false;
			chStructureFactor.Visible = false;
			chProsity.Visible = false;
			chViscousCharLength.Visible = false;
			chThermalCharLength.Visible = false;
			chPoissionsRatio.Visible = false;
			chYoungsModulus.Visible = false;
			chLossFactor.Visible = false;

			chFlowResistivity.Checked = false;
			chStructureFactor.Checked = false;
			chProsity.Checked = false;
			chViscousCharLength.Checked = false;
			chThermalCharLength.Checked = false;
			chPoissionsRatio.Checked = false;
			chYoungsModulus.Checked = false;
			chLossFactor.Checked = false;

			if(strType == "Limp porous material")
			{
				if(strOption == "4 parameters estimation")
				{
					//edtMeasuredAbsorption.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;

					chFlowResistivity.Checked = false;
				}
				else if(strOption == "5 parameters estimation")
				{
					//edtMeasuredAbsorption.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
				}
				else if(strOption == "Optional estimation")
				{
					edtYoungsModulus.Enabled = false;
					edtPoissionsRatio.Enabled = false;
					edtLossFactor.Enabled = false;
					chPoissionsRatio.Visible = false;
					chYoungsModulus.Visible = false;
					chLossFactor.Visible = false;
					
					edtThermalCharLength.Enabled = true;
					edtStructureFactor.Enabled = true;
					edtProsity.Enabled = true;
					edtViscousCharLength.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;

					chFlowResistivity.Visible = true;
					chStructureFactor.Visible = true;
					chProsity.Visible = true;
					chViscousCharLength.Visible = true;
					chThermalCharLength.Visible = true;
				}
			}
			else if(strType == "Rigid porous material")
			{
				if(strOption == "4 parameters estimation")
				{
					//edtMeasuredAbsorption.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;

					chFlowResistivity.Checked = false;
				}
				else if(strOption == "5 parameters estimation")
				{
					//edtMeasuredAbsorption.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
				}
				else if(strOption == "Optional estimation")
				{
					edtYoungsModulus.Enabled = false;
					edtPoissionsRatio.Enabled = false;
					edtLossFactor.Enabled = false;
					chPoissionsRatio.Visible = false;
					chYoungsModulus.Visible = false;
					chLossFactor.Visible = false;
					
					edtThermalCharLength.Enabled = true;
					edtStructureFactor.Enabled = true;
					edtProsity.Enabled = true;
					edtViscousCharLength.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;

					chFlowResistivity.Visible = true;
					chStructureFactor.Visible = true;
					chProsity.Visible = true;
					chViscousCharLength.Visible = true;
					chThermalCharLength.Visible = true;
				}
			}
			else if(strType == "Elastic porous material")
			{
				if(strOption == "4 parameters estimation")
				{
					//edtMeasuredAbsorption.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtYoungsModulus.Enabled = true;
					edtPoissionsRatio.Enabled = true;
					edtLossFactor.Enabled = true;

					chFlowResistivity.Checked = false;
					chYoungsModulus.Checked = false;
					chPoissionsRatio.Checked = false;
					chLossFactor.Checked = false;
				}
				else if(strOption == "5 parameters estimation")
				{
					//edtMeasuredAbsorption.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtYoungsModulus.Enabled = true;
					edtPoissionsRatio.Enabled = true;
					edtLossFactor.Enabled = true;

					chYoungsModulus.Checked = false;
					chPoissionsRatio.Checked = false;
					chLossFactor.Checked = false;
				}
				else if(strOption == "8 parameters estimation")
				{
					//edtMeasuredAbsorption.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
				}
				else if(strOption == "Optional estimation")
				{
					edtLossFactor.Enabled = true;
					edtPoissionsRatio.Enabled = true;
					edtYoungsModulus.Enabled = true;
					edtThermalCharLength.Enabled = true;
					edtStructureFactor.Enabled = true;
					edtProsity.Enabled = true;
					edtViscousCharLength.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;

					chFlowResistivity.Visible = true;
					chStructureFactor.Visible = true;
					chProsity.Visible = true;
					chViscousCharLength.Visible = true;
					chThermalCharLength.Visible = true;
					chPoissionsRatio.Visible = true;
					chYoungsModulus.Visible = true;
					chLossFactor.Visible = true;
				}
			}
		}


		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.edtName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.chLossFactor = new System.Windows.Forms.CheckBox();
			this.chYoungsModulus = new System.Windows.Forms.CheckBox();
			this.chPoissionsRatio = new System.Windows.Forms.CheckBox();
			this.chThermalCharLength = new System.Windows.Forms.CheckBox();
			this.chViscousCharLength = new System.Windows.Forms.CheckBox();
			this.chProsity = new System.Windows.Forms.CheckBox();
			this.chStructureFactor = new System.Windows.Forms.CheckBox();
			this.chFlowResistivity = new System.Windows.Forms.CheckBox();
			this.edtThickness = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.edtBulkDensity = new System.Windows.Forms.TextBox();
			this.edtThermalCharLength = new System.Windows.Forms.TextBox();
			this.edtStructureFactor = new System.Windows.Forms.TextBox();
			this.edtProsity = new System.Windows.Forms.TextBox();
			this.edtViscousCharLength = new System.Windows.Forms.TextBox();
			this.edtFlowResistivity = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.edtPoissionsRatio = new System.Windows.Forms.TextBox();
			this.edtYoungsModulus = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.edtLossFactor = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.rdoAbsorption = new System.Windows.Forms.RadioButton();
			this.rdoSurface = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.plotter1 = new DataPlotter.Plotter();
			this.btnGraphSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnGraphEdit = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnEditCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.edtName);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.chLossFactor);
			this.groupBox1.Controls.Add(this.chYoungsModulus);
			this.groupBox1.Controls.Add(this.chPoissionsRatio);
			this.groupBox1.Controls.Add(this.chThermalCharLength);
			this.groupBox1.Controls.Add(this.chViscousCharLength);
			this.groupBox1.Controls.Add(this.chProsity);
			this.groupBox1.Controls.Add(this.chStructureFactor);
			this.groupBox1.Controls.Add(this.chFlowResistivity);
			this.groupBox1.Controls.Add(this.edtThickness);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.edtBulkDensity);
			this.groupBox1.Controls.Add(this.edtThermalCharLength);
			this.groupBox1.Controls.Add(this.edtStructureFactor);
			this.groupBox1.Controls.Add(this.edtProsity);
			this.groupBox1.Controls.Add(this.edtViscousCharLength);
			this.groupBox1.Controls.Add(this.edtFlowResistivity);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.edtPoissionsRatio);
			this.groupBox1.Controls.Add(this.edtYoungsModulus);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.edtLossFactor);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(5, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(700, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Estimated Properties";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(608, 48);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(88, 23);
			this.label22.TabIndex = 47;
			this.label22.Text = "MKS Rayls/m";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label17.Location = new System.Drawing.Point(608, 144);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(32, 23);
			this.label17.TabIndex = 46;
			this.label17.Text = "㎛";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label18.Location = new System.Drawing.Point(608, 120);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(32, 23);
			this.label18.TabIndex = 45;
			this.label18.Text = "㎛";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(608, 96);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(32, 23);
			this.label19.TabIndex = 44;
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(608, 72);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(40, 23);
			this.label20.TabIndex = 43;
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(272, 144);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(32, 23);
			this.label16.TabIndex = 41;
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(272, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(32, 23);
			this.label15.TabIndex = 40;
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(272, 96);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(32, 23);
			this.label14.TabIndex = 39;
			this.label14.Text = "Pa";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(272, 72);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(40, 23);
			this.label13.TabIndex = 38;
			this.label13.Text = "Kg/㎥";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(272, 47);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 23);
			this.label12.TabIndex = 37;
			this.label12.Text = "[m]";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(168, 24);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(104, 21);
			this.edtName.TabIndex = 1;
			this.edtName.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(40, 24);
			this.label10.Name = "label10";
			this.label10.TabIndex = 36;
			this.label10.Text = "Name";
			// 
			// chLossFactor
			// 
			this.chLossFactor.Location = new System.Drawing.Point(16, 144);
			this.chLossFactor.Name = "chLossFactor";
			this.chLossFactor.Size = new System.Drawing.Size(16, 24);
			this.chLossFactor.TabIndex = 35;
			this.chLossFactor.CheckedChanged += new System.EventHandler(this.chLossFactor_CheckedChanged);
			// 
			// chYoungsModulus
			// 
			this.chYoungsModulus.Location = new System.Drawing.Point(16, 96);
			this.chYoungsModulus.Name = "chYoungsModulus";
			this.chYoungsModulus.Size = new System.Drawing.Size(16, 24);
			this.chYoungsModulus.TabIndex = 32;
			this.chYoungsModulus.CheckedChanged += new System.EventHandler(this.chYoungsModulus_CheckedChanged);
			// 
			// chPoissionsRatio
			// 
			this.chPoissionsRatio.Location = new System.Drawing.Point(16, 120);
			this.chPoissionsRatio.Name = "chPoissionsRatio";
			this.chPoissionsRatio.Size = new System.Drawing.Size(16, 24);
			this.chPoissionsRatio.TabIndex = 31;
			this.chPoissionsRatio.CheckedChanged += new System.EventHandler(this.chPoissionsRatio_CheckedChanged);
			// 
			// chThermalCharLength
			// 
			this.chThermalCharLength.Location = new System.Drawing.Point(328, 144);
			this.chThermalCharLength.Name = "chThermalCharLength";
			this.chThermalCharLength.Size = new System.Drawing.Size(16, 24);
			this.chThermalCharLength.TabIndex = 28;
			this.chThermalCharLength.CheckedChanged += new System.EventHandler(this.chThermalCharLength_CheckedChanged);
			// 
			// chViscousCharLength
			// 
			this.chViscousCharLength.Location = new System.Drawing.Point(328, 120);
			this.chViscousCharLength.Name = "chViscousCharLength";
			this.chViscousCharLength.Size = new System.Drawing.Size(16, 24);
			this.chViscousCharLength.TabIndex = 27;
			this.chViscousCharLength.CheckedChanged += new System.EventHandler(this.chViscousCharLength_CheckedChanged);
			// 
			// chProsity
			// 
			this.chProsity.Location = new System.Drawing.Point(328, 96);
			this.chProsity.Name = "chProsity";
			this.chProsity.Size = new System.Drawing.Size(16, 24);
			this.chProsity.TabIndex = 26;
			this.chProsity.CheckedChanged += new System.EventHandler(this.chProsity_CheckedChanged);
			// 
			// chStructureFactor
			// 
			this.chStructureFactor.Location = new System.Drawing.Point(328, 72);
			this.chStructureFactor.Name = "chStructureFactor";
			this.chStructureFactor.Size = new System.Drawing.Size(16, 24);
			this.chStructureFactor.TabIndex = 25;
			this.chStructureFactor.CheckedChanged += new System.EventHandler(this.chStructureFactor_CheckedChanged);
			// 
			// chFlowResistivity
			// 
			this.chFlowResistivity.Location = new System.Drawing.Point(328, 48);
			this.chFlowResistivity.Name = "chFlowResistivity";
			this.chFlowResistivity.Size = new System.Drawing.Size(16, 24);
			this.chFlowResistivity.TabIndex = 24;
			this.chFlowResistivity.CheckedChanged += new System.EventHandler(this.chFlowResistivity_CheckedChanged);
			// 
			// edtThickness
			// 
			this.edtThickness.Enabled = false;
			this.edtThickness.Location = new System.Drawing.Point(168, 48);
			this.edtThickness.Name = "edtThickness";
			this.edtThickness.Size = new System.Drawing.Size(104, 21);
			this.edtThickness.TabIndex = 2;
			this.edtThickness.Text = "";
			this.edtThickness.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(40, 72);
			this.label9.Name = "label9";
			this.label9.TabIndex = 17;
			this.label9.Text = "Bulk Density";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(40, 48);
			this.label11.Name = "label11";
			this.label11.TabIndex = 18;
			this.label11.Text = "Thickness";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtBulkDensity
			// 
			this.edtBulkDensity.Enabled = false;
			this.edtBulkDensity.Location = new System.Drawing.Point(168, 72);
			this.edtBulkDensity.Name = "edtBulkDensity";
			this.edtBulkDensity.Size = new System.Drawing.Size(104, 21);
			this.edtBulkDensity.TabIndex = 3;
			this.edtBulkDensity.Text = "";
			this.edtBulkDensity.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtThermalCharLength
			// 
			this.edtThermalCharLength.Enabled = false;
			this.edtThermalCharLength.Location = new System.Drawing.Point(488, 144);
			this.edtThermalCharLength.Name = "edtThermalCharLength";
			this.edtThermalCharLength.Size = new System.Drawing.Size(120, 21);
			this.edtThermalCharLength.TabIndex = 11;
			this.edtThermalCharLength.Text = "";
			this.edtThermalCharLength.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtStructureFactor
			// 
			this.edtStructureFactor.Enabled = false;
			this.edtStructureFactor.Location = new System.Drawing.Point(488, 72);
			this.edtStructureFactor.Name = "edtStructureFactor";
			this.edtStructureFactor.Size = new System.Drawing.Size(120, 21);
			this.edtStructureFactor.TabIndex = 8;
			this.edtStructureFactor.Text = "";
			this.edtStructureFactor.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtProsity
			// 
			this.edtProsity.Enabled = false;
			this.edtProsity.Location = new System.Drawing.Point(488, 96);
			this.edtProsity.Name = "edtProsity";
			this.edtProsity.Size = new System.Drawing.Size(120, 21);
			this.edtProsity.TabIndex = 9;
			this.edtProsity.Text = "";
			this.edtProsity.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtViscousCharLength
			// 
			this.edtViscousCharLength.Enabled = false;
			this.edtViscousCharLength.Location = new System.Drawing.Point(488, 120);
			this.edtViscousCharLength.Name = "edtViscousCharLength";
			this.edtViscousCharLength.Size = new System.Drawing.Size(120, 21);
			this.edtViscousCharLength.TabIndex = 10;
			this.edtViscousCharLength.Text = "";
			this.edtViscousCharLength.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtFlowResistivity
			// 
			this.edtFlowResistivity.HideSelection = false;
			this.edtFlowResistivity.Location = new System.Drawing.Point(488, 48);
			this.edtFlowResistivity.Name = "edtFlowResistivity";
			this.edtFlowResistivity.Size = new System.Drawing.Size(120, 21);
			this.edtFlowResistivity.TabIndex = 7;
			this.edtFlowResistivity.Text = "";
			this.edtFlowResistivity.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(352, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Thermal Char. Length";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(352, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Viscous Char. Length";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(352, 96);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Porosity";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(352, 72);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Structure Factor";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(352, 48);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Flow Resistivity";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtPoissionsRatio
			// 
			this.edtPoissionsRatio.Enabled = false;
			this.edtPoissionsRatio.Location = new System.Drawing.Point(168, 120);
			this.edtPoissionsRatio.Name = "edtPoissionsRatio";
			this.edtPoissionsRatio.Size = new System.Drawing.Size(104, 21);
			this.edtPoissionsRatio.TabIndex = 5;
			this.edtPoissionsRatio.Text = "";
			this.edtPoissionsRatio.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtYoungsModulus
			// 
			this.edtYoungsModulus.Enabled = false;
			this.edtYoungsModulus.Location = new System.Drawing.Point(168, 96);
			this.edtYoungsModulus.Name = "edtYoungsModulus";
			this.edtYoungsModulus.Size = new System.Drawing.Size(104, 21);
			this.edtYoungsModulus.TabIndex = 4;
			this.edtYoungsModulus.Text = "";
			this.edtYoungsModulus.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 144);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Loss Factor";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(40, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "Young’s Modulus";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(40, 120);
			this.label7.Name = "label7";
			this.label7.TabIndex = 6;
			this.label7.Text = "Poisson’s Ratio";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtLossFactor
			// 
			this.edtLossFactor.Enabled = false;
			this.edtLossFactor.Location = new System.Drawing.Point(168, 144);
			this.edtLossFactor.Name = "edtLossFactor";
			this.edtLossFactor.Size = new System.Drawing.Size(104, 21);
			this.edtLossFactor.TabIndex = 6;
			this.edtLossFactor.Text = "";
			this.edtLossFactor.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(0, 0);
			this.label21.Name = "label21";
			this.label21.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(5, 572);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox2.Location = new System.Drawing.Point(705, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(5, 572);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// rdoAbsorption
			// 
			this.rdoAbsorption.Checked = true;
			this.rdoAbsorption.Location = new System.Drawing.Point(8, 8);
			this.rdoAbsorption.Name = "rdoAbsorption";
			this.rdoAbsorption.Size = new System.Drawing.Size(176, 48);
			this.rdoAbsorption.TabIndex = 6;
			this.rdoAbsorption.TabStop = true;
			this.rdoAbsorption.Text = "Absorption Coefficient (Rigid Backing)";
			// 
			// rdoSurface
			// 
			this.rdoSurface.Location = new System.Drawing.Point(8, 56);
			this.rdoSurface.Name = "rdoSurface";
			this.rdoSurface.Size = new System.Drawing.Size(176, 40);
			this.rdoSurface.TabIndex = 7;
			this.rdoSurface.Text = "Surface Impedance (Normalized)";
			this.rdoSurface.CheckedChanged += new System.EventHandler(this.rdoSurface_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.rdoAbsorption);
			this.panel1.Controls.Add(this.rdoSurface);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(545, 176);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(160, 396);
			this.panel1.TabIndex = 8;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(369, 176);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.SelectedObject = this.plotter1;
			this.propertyGrid1.Size = new System.Drawing.Size(176, 396);
			this.propertyGrid1.TabIndex = 10;
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
			this.plotter1.LegendPosition_Proferty = DataPlotter.Plotter.LegendPosition_Enum.LEFT_TOP;
			this.plotter1.Location = new System.Drawing.Point(5, 176);
			this.plotter1.MarkerSize = 4;
			this.plotter1.MarkerType = DataPlotter.Plotter.MarkerModeType.None;
			this.plotter1.Name = "plotter1";
			this.plotter1.PenWidth = 1;
			this.plotter1.ShowGrid = true;
			this.plotter1.ShowLegend = false;
			this.plotter1.Size = new System.Drawing.Size(364, 373);
			this.plotter1.TabIndex = 13;
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
			this.btnGraphSave.Size = new System.Drawing.Size(104, 23);
			this.btnGraphSave.TabIndex = 11;
			this.btnGraphSave.Text = "Graph Save";
			this.btnGraphSave.Click += new System.EventHandler(this.btnGraphSave_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnGraphEdit);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.btnEditCancel);
			this.panel2.Controls.Add(this.btnGraphSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(5, 549);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(364, 23);
			this.panel2.TabIndex = 12;
			// 
			// btnGraphEdit
			// 
			this.btnGraphEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnGraphEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnGraphEdit.Location = new System.Drawing.Point(114, 0);
			this.btnGraphEdit.Name = "btnGraphEdit";
			this.btnGraphEdit.Size = new System.Drawing.Size(136, 23);
			this.btnGraphEdit.TabIndex = 15;
			this.btnGraphEdit.Text = "Graph Edit";
			this.btnGraphEdit.Click += new System.EventHandler(this.btnGraphEdit_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox4.Location = new System.Drawing.Point(104, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 23);
			this.pictureBox4.TabIndex = 14;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox3.Location = new System.Drawing.Point(250, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 23);
			this.pictureBox3.TabIndex = 13;
			this.pictureBox3.TabStop = false;
			// 
			// btnEditCancel
			// 
			this.btnEditCancel.BackColor = System.Drawing.SystemColors.Control;
			this.btnEditCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnEditCancel.Enabled = false;
			this.btnEditCancel.Location = new System.Drawing.Point(260, 0);
			this.btnEditCancel.Name = "btnEditCancel";
			this.btnEditCancel.Size = new System.Drawing.Size(104, 23);
			this.btnEditCancel.TabIndex = 12;
			this.btnEditCancel.Text = "Edit Cancel";
			this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
			// 
			// ucMaterialPropertiesEstimation
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.plotter1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "ucMaterialPropertiesEstimation";
			this.Size = new System.Drawing.Size(710, 572);
			this.Load += new System.EventHandler(this.ucMaterialPropertiesEstimation_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ucMaterialPropertiesEstimation_Load(object sender, System.EventArgs e)
		{
			//GraphDraw();
		}

		private void chYoungsModulus_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chYoungsModulus.Checked == true)
			{
				edtYoungsModulus.Enabled = false;
			}
			else
			{
				edtYoungsModulus.Enabled = true;
			}
		}

		private void chPoissionsRatio_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chPoissionsRatio.Checked == true)
			{
				edtPoissionsRatio.Enabled = false;
			}
			else
			{
				edtPoissionsRatio.Enabled = true;
			}
		}

		private void chLossFactor_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chLossFactor.Checked == true)
			{
				edtLossFactor.Enabled = false;
			}
			else
			{
				edtLossFactor.Enabled = true;
			}
		}

		private void chFlowResistivity_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chFlowResistivity.Checked == true)
			{
				edtFlowResistivity.Enabled = false;
			}
			else
			{
				edtFlowResistivity.Enabled = true;
			}
		}

		private void chStructureFactor_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chStructureFactor.Checked == true)
			{
				edtStructureFactor.Enabled = false;
			}
			else
			{
				edtStructureFactor.Enabled = true;
			}
		}

		private void chProsity_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chProsity.Checked == true)
			{
				edtProsity.Enabled = false;
			}
			else
			{
				edtProsity.Enabled = true;
			}
		}

		private void chViscousCharLength_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chViscousCharLength.Checked == true)
			{
				edtViscousCharLength.Enabled = false;
			}
			else
			{
				edtViscousCharLength.Enabled = true;
			}
		}

		private void chThermalCharLength_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chThermalCharLength.Checked == true)
			{
				edtThermalCharLength.Enabled = false;
			}
			else
			{
				edtThermalCharLength.Enabled = true;
			}
		}		

		private void rdoSurface_CheckedChanged(object sender, System.EventArgs e)
		{
			GraphDraw(mpeClass);
		}

		private string NumberCheck(string str)
		{
			if(str == "")
			{
				return "0";
			}
			else
			{
				return str;
			}
		}

		private bool IsNumber(string str)
		{
			try
			{
				double a = double.Parse(str);
				
				return true;
			}
			catch
			{
				return false;
			}
		}

		public void Save(string MID,string Measured,string Temperature,string Incidence,string IncAngle,string FreqBand)
		{
			if(edtName.Text != "")
			{
				if(mpeClass != null)
				{
					MPE_DB MPE_DB1 = new MPE_DB();

					if(MPE_DB1.ISNameSame(edtName.Text) > 0)
					{
						MessageBox.Show("이미 같은 이름이 존재합니다.");

						int dMax_ID_SingleMeterial = MPE_DB1.GetMax_ID_SingleMeterial();
						MPE_DB1.CreateSingleMeterial(dMax_ID_SingleMeterial,edtName.Text,MID,mpeClass.Thickness.ToString(),mpeClass.BulkDensity.ToString(),
							mpeClass.FResist.ToString(),mpeClass.SFactor.ToString(),mpeClass.Porosity.ToString(),mpeClass.ViscousCL.ToString(),mpeClass.ThermalCL.ToString(),
							mpeClass.Ymodulus.ToString(),mpeClass.PoissonR.ToString(),mpeClass.LossFactor.ToString(),"0","0","0","0","0","0","0","0");

						int dMax_ID_SingleMeterialGraph = MPE_DB1.GetMax_ID_SingleMeterialGraph();
						string GraphType = GetGraphType();
						//				MPE_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dMax_ID_SingleMeterial,"",Measured,Temperature,Incidence,IncAngle,FreqBand,"1",
						//					mpeClass.Frequency.GetString(),mpeClass.CAbsorption.GetString(),mpeClass.CSurfaceImpedance.GetString(),"");
						MPE_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dMax_ID_SingleMeterial,edtName.Text,Measured,Temperature,Incidence,IncAngle,FreqBand,"1",
							mpeClass.Frequency.GetString(),mpeClass.MAbsorption.GetString(),"","");

						MessageBox.Show("저장되었습니다.","저장");
					}
					else
					{
						int dMax_ID_SingleMeterial = MPE_DB1.GetMax_ID_SingleMeterial();
						MPE_DB1.CreateSingleMeterial(dMax_ID_SingleMeterial,edtName.Text,MID,mpeClass.Thickness.ToString(),mpeClass.BulkDensity.ToString(),
							mpeClass.FResist.ToString(),mpeClass.SFactor.ToString(),mpeClass.Porosity.ToString(),mpeClass.ViscousCL.ToString(),mpeClass.ThermalCL.ToString(),
							mpeClass.Ymodulus.ToString(),mpeClass.PoissonR.ToString(),mpeClass.LossFactor.ToString(),"0","0","0","0","0","0","0","0");

						int dMax_ID_SingleMeterialGraph = MPE_DB1.GetMax_ID_SingleMeterialGraph();
						string GraphType = GetGraphType();
						//				MPE_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dMax_ID_SingleMeterial,"",Measured,Temperature,Incidence,IncAngle,FreqBand,"1",
						//					mpeClass.Frequency.GetString(),mpeClass.CAbsorption.GetString(),mpeClass.CSurfaceImpedance.GetString(),"");
						MPE_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dMax_ID_SingleMeterial,edtName.Text,Measured,Temperature,Incidence,IncAngle,FreqBand,"1",
							mpeClass.Frequency.GetString(),mpeClass.MAbsorption.GetString(),"","");

						MessageBox.Show("저장되었습니다.","저장");
					}
				}
			}
			else
			{
				MessageBox.Show("Name 을 입력하여 주십시오");
			}
		}

		private string GetGraphType()
		{
			string result = "0";

			if(rdoAbsorption.Checked)
			{
				result = "1";
			}
			else
			{
				result = "2";
			}

			return result;
		}

		/// <summary>
		/// 입력해야 할 텍스트에 다 입력했는지 체크 (정상이면 true)
		/// </summary>
		/// <returns></returns>
		public bool InputCheck()
		{
			bool bResult = true;

			if(edtLossFactor.Enabled == true)
			{
				if(edtLossFactor.Text == "")
				{
					bResult = false;
				}
			}
			if(edtPoissionsRatio.Enabled == true)
			{
				if(edtPoissionsRatio.Text == "")
				{
					bResult = false;
				}
			}
			if(edtYoungsModulus.Enabled == true)
			{
				if(edtYoungsModulus.Text == "")
				{
					bResult = false;
				}
			}
			if(edtThermalCharLength.Enabled == true)
			{
				if(edtThermalCharLength.Text == "")
				{
					bResult = false;
				}
			}
			if(edtStructureFactor.Enabled == true)
			{
				if(edtStructureFactor.Text == "")
				{
					bResult = false;
				}
			}
			if(edtProsity.Enabled == true)
			{
				if(edtProsity.Text == "")
				{
					bResult = false;
				}
			}
			if(edtViscousCharLength.Enabled == true)
			{
				if(edtViscousCharLength.Text == "")
				{
					bResult = false;
				}
			}
			if(edtFlowResistivity.Enabled == true)
			{
				if(edtFlowResistivity.Text == "")
				{
					bResult = false;
				}
			}
			if(edtThickness.Enabled == true)
			{
				if(edtThickness.Text == "")
				{
					bResult = false;
				}
			}
			if(edtBulkDensity.Enabled == true)
			{
				if(edtBulkDensity.Text == "")
				{
					bResult = false;
				}
			}

			return bResult;
		}

		private void edtThickness_TextChanged(object sender, System.EventArgs e)
		{
			string str = ((TextBox)sender).Text;
			// 숫자형이 아니면
			if(str != "")
			{
				if(IsNumber(str) == false)
				{
					((TextBox)sender).Text = str.Substring(0,str.Length - 1);
				}
			}
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

			btnGraphEdit.Enabled = false;
			btnEditCancel.Enabled = true;
		}

		private void btnEditCancel_Click(object sender, System.EventArgs e)
		{
			propertyGrid1.Visible = false;

			btnGraphEdit.Enabled = true;
			btnEditCancel.Enabled = false;
		}

		#region 접근자

		public string strLossFactor
		{
			get
			{
				return NumberCheck(edtLossFactor.Text);
			}
		}

		public string strPoissionsRatio
		{
			get
			{
				return NumberCheck(edtPoissionsRatio.Text);
			}
		}
		public string strYoungsModulus
		{
			get
			{
				return NumberCheck(edtYoungsModulus.Text);
			}
		}
		public string strThermalCharLength
		{
			get
			{
				return NumberCheck(edtThermalCharLength.Text);
			}
		}
		public string strStructureFactor
		{
			get
			{
				return NumberCheck(edtStructureFactor.Text);
			}
		}
		public string strProsity
		{
			get
			{
				return NumberCheck(edtProsity.Text);
			}
		}
		public string strViscousCharLength
		{
			get
			{
				return NumberCheck(edtViscousCharLength.Text);
			}
		}
		public string strFlowResistivity
		{
			get
			{
				return NumberCheck(edtFlowResistivity.Text);
			}
		}
		public string strThickness
		{
			get
			{
				return NumberCheck(edtThickness.Text);
			}
		}
//		public string strMeasuredAbsorption
//		{
//			get
//			{
//				return NumberCheck(edtMeasuredAbsorption.Text);
//			}
//		}
		public string strBulkDensity
		{
			get
			{
				return NumberCheck(edtBulkDensity.Text);
			}
		}

		// Enable
		public bool IsEnableLossFactor
		{
			get
			{
				return edtLossFactor.Enabled;
			}
		}

		public bool IsEnablePoissionsRatio
		{
			get
			{
				return edtPoissionsRatio.Enabled;
			}
		}
		public bool IsEnableYoungsModulus
		{
			get
			{
				return edtYoungsModulus.Enabled;
			}
		}
		public bool IsEnableThermalCharLength
		{
			get
			{
				return edtThermalCharLength.Enabled;
			}
		}
		public bool IsEnableStructureFactor
		{
			get
			{
				return edtStructureFactor.Enabled;
			}
		}
		public bool IsEnableProsity
		{
			get
			{
				return edtProsity.Enabled;
			}
		}
		public bool IsEnableViscousCharLength
		{
			get
			{
				return edtViscousCharLength.Enabled;
			}
		}
		public bool IsEnableFlowResistivity
		{
			get
			{
				return edtFlowResistivity.Enabled;
			}
		}
		public bool IsEnableThickness
		{
			get
			{
				return edtThickness.Enabled;
			}
		}
		public bool IsEnableBulkDensity
		{
			get
			{
				return edtBulkDensity.Enabled;
			}
		}

		public string strName
		{
			get
			{
				return edtName.Text;
			}
		}

		#endregion

	}
}
