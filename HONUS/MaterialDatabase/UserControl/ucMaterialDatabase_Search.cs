using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using HONUS.Common_Class;
using HONUS.MaterialDatabase.Component;
using HONUS.MaterialDatabase.Form;

namespace HONUS.MaterialDatabase.UserControl
{
	/// <summary>
	/// ucMaterialDatabase_Search에 대한 요약 설명입니다.
	/// </summary>
	public class ucMaterialDatabase_Search : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ListView lstSearchResultList;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public delegate void MyListClickedDelegate(string strName,string strAddition,bool bIsSingle);
		public event MyListClickedDelegate MyListClickedEvent;

		MPALayer MPALayer1;
		DataSet dsSearchResult;
		string strSearchResult_Selected_ID;
		string strSingle_Multi;
		private System.Windows.Forms.Panel pnlGraphOption;
		private System.Windows.Forms.CheckBox chMeasured;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdoRandom;
		private System.Windows.Forms.RadioButton rdoNormal;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton rdoOctave_3_1;
		private System.Windows.Forms.RadioButton rdoOctave;
		private System.Windows.Forms.RadioButton rdoTransmissionLoss;
		private System.Windows.Forms.RadioButton rdoAbsorptionCoefficient_RB;
		private System.Windows.Forms.RadioButton rdoAbsorptionCoefficient_AT;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;

		bool bIsSingle = true;

		//string strID = "";
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtTemperature;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtAngle;
		string strSelectedName = "";
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Button btnGraphSave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Button btnEditCancel;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Button btnGraphEdit;

		int dGraph_ID;
		private DataPlotter.Plotter plotter1;

		private string strMeterialTypeChange = "";
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Panel pnlGraphOption2;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.RadioButton radioButton1;

		DataPlotter.DataSeries pSeries_Search;

		public ucMaterialDatabase_Search()
		{
			// 이 호출은 Windows.Forms Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			dsSearchResult = new DataSet();
			
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

		#region 그래프 테스트용
//		private void GraphDraw()
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
//			ar[1] = 10;
//			ar[2] = 10;
//			row.ItemArray = ar;
//			table.Rows.Add(row);
//
//			row = table.NewRow();
//			ar[0] = "1";
//			ar[1] = 20;
//			ar[2] = 5;
//			row.ItemArray = ar;
//			table.Rows.Add(row);
//
//			row = table.NewRow();
//			ar[0] = "1";
//			ar[1] = 30;
//			ar[2] = 15;
//			row.ItemArray = ar;
//			table.Rows.Add(row);
//
//			row = table.NewRow();
//			ar[0] = "1";
//			ar[1] = 40;
//			ar[2] = 3;
//			row.ItemArray = ar;
//			table.Rows.Add(row);
//
//			ultraChart1.DataSource = table;
//			ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
//			ultraChart1.ScatterChart.ConnectWithLines = true;
//		}
		#endregion

		public void GraphDraw_Multi(string strType)
		{
			DataPlotter.DataSeries pSeries1 = new DataPlotter.DataSeries();

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

			bool DataExist = false;

			MPALayer1 = new MPALayer();
			MPALayer1.LID = int.Parse(strSearchResult_Selected_ID);
			MPALayer1.DBLoad();

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
//
//						DataExist = true;
//					}
					#endregion

					DataExist = true;

					pSeries1.XData = MPALayer1.Frequency.GetData();
					pSeries1.YData = MPALayer1.RigidBacking.GetData();
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
//
//						DataExist = true;
//					}
					#endregion

					DataExist = true;

					pSeries1.XData = MPALayer1.Frequency.GetData();
					pSeries1.YData = MPALayer1.AnechoicTermination.GetData();
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
//
//						DataExist = true;
//					}
					#endregion

					DataExist = true;

					pSeries1.XData = MPALayer1.Frequency.GetData();
					pSeries1.YData = MPALayer1.TransmissionLoss.GetData();
				}

				if(DataExist == true)
				{
					#region 예전
//					ultraChart1.DataSource = table;
//					ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
//					ultraChart1.ScatterChart.ConnectWithLines = true;
					#endregion

					plotter1.Series.Add(pSeries1);
					//plotter1.IsOctave_ = true;
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

		public void GraphDraw()
		{
			DataPlotter.DataSeries pSeries1;

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

			if(pSeries_Search != null)
			{
				plotter1.Series.Add(pSeries_Search);
			}

			bool DataExist = false;

			MPEData MPEData1;
			MD_DB MD_DB1 = new MD_DB();
			
			for(int i = 0 ; i < lstSearchResultList.SelectedIndices.Count ; i++)
			{
				dGraph_ID = MD_DB1.IsGraphExist(bIsSingle,GetMeasured(),GetIncidence(),GetFreqBand(),GetGraphType(),int.Parse(lstSearchResultList.SelectedItems[i].Text));

				if(dGraph_ID != -1)
				{
					MPEData1 = new MPEData();
					if(MPEData1.DBLoad(bIsSingle,dGraph_ID) == true)
					{
						#region 예전
						//				object [] ar = new object[3];
						//
						//				DataTable table = new DataTable();
						//
						//				table.Columns.Add("GroupName",typeof(int));
						//				table.Columns.Add("my_X",typeof(double));
						//				table.Columns.Add("my_Y",typeof(double));
				
						//				for(int i = 0 ; i < MPEData1.Frequency.GetCount() ; i++)
						//				{
						//					DataRow row = table.NewRow();
						//					ar[0] = i.ToString();
						//					ar[1] = MPEData1.Frequency.GetData(i).ToString();
						//					ar[2] = MPEData1.MAbsorption.GetData(i).ToString();
						//					row.ItemArray = ar;
						//					table.Rows.Add(row);
						//
						//					DataExist = true;
						//				}
						#endregion

						DataExist = true;

						pSeries1 = new DataPlotter.DataSeries();
						pSeries1.Name  = "Data " + i.ToString();

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

						if(DataExist == true)
						{
							#region 예전
							//					ultraChart1.DataSource = table;
							//					ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
							//					ultraChart1.ScatterChart.ConnectWithLines = true;
							#endregion

							if(pSeries1.XData.Length == pSeries1.YData.Length)
							{
								plotter1.Series.Add(pSeries1);
							}

							//plotter1.IsOctave_ = true;
						}
					}
				}
			}

			switch(GetGraphType())
			{
				case 1 :
					plotter1.YLabel = "Absorption Coefficient for Rigid Backing";
					plotter1.XLabel = "Frequency [Hz]";
					break;
				case 2 :
					plotter1.YLabel = "Absotpyion Coefficient for Anechoic termiation";
					plotter1.XLabel = "Frequency [Hz]";
					break;
				case 3 :
					plotter1.YLabel = "Transmission Loss [dB]";
					plotter1.XLabel = "Frequency [Hz]";
					break;
			}

			plotter1.AutoRange();
			plotter1.Refresh();
		}

		private void SearchResultList_Init()
		{
			lstSearchResultList.Columns.Clear();

			ColumnHeader col;

			col = new ColumnHeader();
			col.Text = "ID";
			col.Width = 10;
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Name";
			lstSearchResultList.Columns.Add(col);

//			col = new ColumnHeader();
//			col.Text = "Type";
//			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Thickness";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "BulkDensity";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "LossFactor";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "FlowResistivity";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "YoungsModulus";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "PoissonsRatio";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "ThermalCharLength";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "ViscousCharLength";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Porosity";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "StructureFactor";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Emp1";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Pratiop1";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "hp1";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "densityp1";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "hp2";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "densityp2";
			lstSearchResultList.Columns.Add(col);			

			col = new ColumnHeader();
			col.Text = "Emp2";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Pratiop2";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "MID";
			lstSearchResultList.Columns.Add(col);

//			col = new ColumnHeader();
//			col.Text = "MultiLayerID";
//			lstSearchResultList.Columns.Add(col);
		}

		public void MeterialTypeChange(string str)
		{
			strMeterialTypeChange = str;

			if(str == "ALL")
			{
				SearchResultList_Init();
			}
			else
			{
				for(int i = 0 ; i < lstSearchResultList.Columns.Count ; i++)
				{
					lstSearchResultList.Columns[i].Width = 0;
				}

				switch(str)
				{
					case "Air" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						break;
					case "Panel" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[6].Width = 100;
						lstSearchResultList.Columns[7].Width = 100;
						break;
					case "Impermeable membrane" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						break;
					case "Permeable membrane" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						break;
					case "Limp porous material" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						lstSearchResultList.Columns[11].Width = 100;
						lstSearchResultList.Columns[10].Width = 100;
						lstSearchResultList.Columns[8].Width = 100;
						lstSearchResultList.Columns[9].Width = 100;
						break;
					case "Rigid porous material" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						lstSearchResultList.Columns[11].Width = 100;
						lstSearchResultList.Columns[10].Width = 100;
						lstSearchResultList.Columns[8].Width = 100;
						lstSearchResultList.Columns[9].Width = 100;
						break;
					case "Elastic porous material" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						lstSearchResultList.Columns[11].Width = 100;
						lstSearchResultList.Columns[10].Width = 100;
						lstSearchResultList.Columns[8].Width = 100;
						lstSearchResultList.Columns[9].Width = 100;
						lstSearchResultList.Columns[6].Width = 100;
						lstSearchResultList.Columns[4].Width = 100;
						lstSearchResultList.Columns[7].Width = 100;
						break;
					case "Panel-Elastic (BU)" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[14].Width = 100;
						lstSearchResultList.Columns[15].Width = 100;
						lstSearchResultList.Columns[12].Width = 100;
						lstSearchResultList.Columns[13].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						lstSearchResultList.Columns[11].Width = 100;
						lstSearchResultList.Columns[10].Width = 100;
						lstSearchResultList.Columns[8].Width = 100;
						lstSearchResultList.Columns[9].Width = 100;
						break;
					case "Elastic-Panel (UB)" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						lstSearchResultList.Columns[11].Width = 100;
						lstSearchResultList.Columns[10].Width = 100;
						lstSearchResultList.Columns[8].Width = 100;
						lstSearchResultList.Columns[9].Width = 100;
						lstSearchResultList.Columns[16].Width = 100;
						lstSearchResultList.Columns[17].Width = 100;
						lstSearchResultList.Columns[18].Width = 100;
						lstSearchResultList.Columns[19].Width = 100;
						break;
					case "Panel-Elastic-Panel (BB)" :
						lstSearchResultList.Columns[1].Width = 100;
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[14].Width = 100;
						lstSearchResultList.Columns[15].Width = 100;
						lstSearchResultList.Columns[12].Width = 100;
						lstSearchResultList.Columns[13].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						lstSearchResultList.Columns[11].Width = 100;
						lstSearchResultList.Columns[10].Width = 100;
						lstSearchResultList.Columns[8].Width = 100;
						lstSearchResultList.Columns[9].Width = 100;
						lstSearchResultList.Columns[16].Width = 100;
						lstSearchResultList.Columns[17].Width = 100;
						lstSearchResultList.Columns[18].Width = 100;
						lstSearchResultList.Columns[19].Width = 100;
						break;
				}
			}
		}

		/// <summary>
		/// 조회 함수
		/// </summary>
		/// <param name="Category"></param>
		/// <param name="IncidenceCondition"></param>
		/// <param name="MaterialType"></param>
		/// <param name="Option"></param>
		/// <param name="Frequency">1,Narrow band 2,Octave 3,1/3 Octav</param>
		public void Search(string Category,string IncidenceCondition,string MaterialType,string Option,string Frequency,
			clsAbsorptionCoefficient_Find clsAbsorptionCoefficient_RB,clsAbsorptionCoefficient_Find clsAbsorptionCoefficient_AT,
			clsAbsorptionCoefficient_Find clsAbsorptionCoefficient_TL,clsParameters clsParameters1,clsMultiLayer_Find clsMultiLayer_Find1,string strVendor,
			string strProducing,string strDate,int dMeasured)
		{
			string strIDs = "";
			bool bFlag = false;

			MD_DB MD_DB1 = new MD_DB();

			switch(Option)
			{
				case "Absorption coefficient-rigid backing":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,Frequency,clsAbsorptionCoefficient_RB.strName,strVendor,strProducing,strDate,dMeasured);
					strIDs = AbsorptionCoefficient_RigidBackingCheck(dsSearchResult,clsAbsorptionCoefficient_RB);
					break;
				case "Absorption coefficient-anechoic termination":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,Frequency,clsAbsorptionCoefficient_AT.strName,strVendor,strProducing,strDate,dMeasured);
					strIDs = AbsorptionCoefficient_AnechoicTerminationCheck(dsSearchResult,clsAbsorptionCoefficient_AT);
					break;
				case "Transmission Loss":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,Frequency,clsAbsorptionCoefficient_TL.strName,strVendor,strProducing,strDate,dMeasured);
					strIDs = TransmissionLossCheck(dsSearchResult,clsAbsorptionCoefficient_TL);
					break;
				case "Parameters":
					dsSearchResult = MD_DB1.Search_Parameter(Category,IncidenceCondition,MaterialType,Frequency,clsParameters1.strName,strVendor,strProducing,strDate,dMeasured);
					strIDs = ParametersCheck(dsSearchResult,clsParameters1);
					
					bFlag = true;
					pSeries_Search = null;
					break;
				case "MultiLayer":
					dsSearchResult = MD_DB1.Search("Multi",IncidenceCondition,MaterialType,Frequency,"",strVendor,strProducing,strDate,dMeasured);
					Category = "Multi";
					strIDs = MultiLayerCheck(dsSearchResult,clsMultiLayer_Find1.strName,clsMultiLayer_Find1.strTotalThick);
					bFlag = true;

					pSeries_Search = null;
					break;
				case "Select":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,Frequency,"",strVendor,strProducing,strDate,dMeasured);
					bFlag = true;

					pSeries_Search = null;
					break;
			}
			if(bFlag == false)
			{
				dsSearchResult = MD_DB1.Search_IDs(Category,strIDs);
			}

			strSingle_Multi = Category;

			lstSearchResultList.Items.Clear();

			if(dsSearchResult != null)
			{
				if(Category != "Single")
				{
					MultiListSetting();
				}
				else
				{
					SearchResultList_Init();

					MeterialTypeChange(this.strMeterialTypeChange);
				}

				for(int i = 0 ; i < dsSearchResult.Tables[0].Rows.Count ; i++)
				{
					ListViewItem item = new ListViewItem();

					if(Category == "Single")
					{
						item.SubItems[0].Text = dsSearchResult.Tables[0].Rows[i]["SID"].ToString();
				
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Name"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Thick"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["BulkDens"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["LossFactor"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["FlowRes"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Ymodulus"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["PoissionR"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["ThermalCL"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["ViscousCL"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Prosity"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Sfactor"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["EmP1"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["PRatioP1"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["DensityP1"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["EmP2"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["HP2"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["HP2"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["HP1"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["PRatioP2"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["MID"].ToString());

						bIsSingle = true;
					}
					else
					{
						item.SubItems[0].Text = dsSearchResult.Tables[0].Rows[i]["LID"].ToString();
				
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["MultiLayer.Name"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["TotalThick"].ToString());

						bIsSingle = false;
					}

					lstSearchResultList.Items.Add(item);

					//strSearchResult_Selected_ID = item.SubItems[0].Text;
				}
			}

			if(dsSearchResult == null || dsSearchResult.Tables[0].Rows.Count == 0)
			{
				MessageBox.Show("검색 결과가 없습니다");
			}

			pnlGraphOption.Enabled = false;
			pnlGraphOption2.Enabled = false;
			
		}

		public void Search(string Category,string IncidenceCondition,string MaterialType,string Option,string Frequency,
			clsAbsorptionCoefficient_FindDetail clsAbsorptionCoefficient_RB,clsAbsorptionCoefficient_FindDetail clsAbsorptionCoefficient_AT,
			clsAbsorptionCoefficient_FindDetail clsAbsorptionCoefficient_TL,clsParameters clsParameters1,clsMultiLayer_Find clsMultiLayer_Find1,string strVendor,
			string strProducing,string strDate,int dMeasured)
		{
			string strIDs = "";
			bool bFlag = false;

			MD_DB MD_DB1 = new MD_DB();

			switch(Option)
			{
				case "Absorption coefficient-rigid backing":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,Frequency,clsAbsorptionCoefficient_RB.strName,strVendor,strProducing,strDate,dMeasured);
					strIDs = AbsorptionCoefficient_RigidBackingCheck(dsSearchResult,clsAbsorptionCoefficient_RB);
					break;
				case "Absorption coefficient-anechoic termination":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,Frequency,clsAbsorptionCoefficient_AT.strName,strVendor,strProducing,strDate,dMeasured);
					strIDs = AbsorptionCoefficient_AnechoicTerminationCheck(dsSearchResult,clsAbsorptionCoefficient_AT);
					break;
				case "Transmission Loss":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,Frequency,clsAbsorptionCoefficient_TL.strName,strVendor,strProducing,strDate,dMeasured);
					strIDs = TransmissionLossCheck(dsSearchResult,clsAbsorptionCoefficient_TL);
					break;
				case "Parameters":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,Frequency,clsParameters1.strName,strVendor,strProducing,strDate,dMeasured);
					strIDs = ParametersCheck(dsSearchResult,clsParameters1);
					
					pSeries_Search = null;
					break;
				case "MultiLayer":
					dsSearchResult = MD_DB1.Search("Multi",IncidenceCondition,MaterialType,Frequency,"",strVendor,strProducing,strDate,dMeasured);
					Category = "Multi";
					strIDs = MultiLayerCheck(dsSearchResult,clsMultiLayer_Find1.strName,clsMultiLayer_Find1.strTotalThick);
					bFlag = true;

					pSeries_Search = null;
					break;
				case "Select":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,Frequency,"",strVendor,strProducing,strDate,dMeasured);
					bFlag = true;

					pSeries_Search = null;
					break;
			}
			if(bFlag == false)
			{
				dsSearchResult = MD_DB1.Search_IDs(Category,strIDs);
			}

			strSingle_Multi = Category;

			lstSearchResultList.Items.Clear();

			if(dsSearchResult != null)
			{
				if(Category != "Single")
				{
					MultiListSetting();
				}
				else
				{
					SearchResultList_Init();

					MeterialTypeChange(this.strMeterialTypeChange);
				}

				for(int i = 0 ; i < dsSearchResult.Tables[0].Rows.Count ; i++)
				{
					ListViewItem item = new ListViewItem();

					if(Category == "Single")
					{
						item.SubItems[0].Text = dsSearchResult.Tables[0].Rows[i]["SID"].ToString();
				
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Name"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Thick"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["BulkDens"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["LossFactor"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["FlowRes"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Ymodulus"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["PoissionR"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["ThermalCL"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["ViscousCL"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Prosity"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Sfactor"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["EmP1"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["PRatioP1"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["DensityP1"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["EmP2"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["HP2"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["HP2"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["HP1"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["PRatioP2"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["MID"].ToString());

						bIsSingle = true;
					}
					else
					{
						item.SubItems[0].Text = dsSearchResult.Tables[0].Rows[i]["LID"].ToString();
				
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["MultiLayer.Name"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["TotalThick"].ToString());

						bIsSingle = false;
					}

					lstSearchResultList.Items.Add(item);

					//strSearchResult_Selected_ID = item.SubItems[0].Text;
				}
			}

			if(dsSearchResult == null || dsSearchResult.Tables[0].Rows.Count == 0)
			{
				MessageBox.Show("검색 결과가 없습니다");
			}

			pnlGraphOption.Enabled = false;
			pnlGraphOption2.Enabled = false;
			
		}

		public void AfterSearch(string Category,string strDate,string strDate2)
		{
			if(dsSearchResult != null)
			{
				/*
				 string str = String.Format("DATEDIFF('d','{0}','{1}') >= 0 AND DATEDIFF('d',Occurred_Date,'{1}') >= 0 AND "
				+ " DATEDIFF('d','{0}','{1}') >= DATEDIFF('d',Occurred_Date,'{1}')",strDate,strDate2);//*/

				string str = String.Format("Occurred_Date >= '{0}' AND Occurred_Date <= '{1}'",strDate,strDate2);

			DataRow [] dimRow = dsSearchResult.Tables[0].Select(str);

			strSingle_Multi = Category;

			lstSearchResultList.Items.Clear();

			
				if(Category != "Single")
				{
					MultiListSetting();
				}
				else
				{
					SearchResultList_Init();

					MeterialTypeChange(this.strMeterialTypeChange);
				}

				for(int i = 0 ; i < dimRow.Length ; i++)
				{
					ListViewItem item = new ListViewItem();

					if(Category == "Single")
					{
						item.SubItems[0].Text = dimRow[i]["SID"].ToString();
				
						item.SubItems.Add(dimRow[i]["Name"].ToString());
						item.SubItems.Add(dimRow[i]["Thick"].ToString());
						item.SubItems.Add(dimRow[i]["BulkDens"].ToString());
						item.SubItems.Add(dimRow[i]["LossFactor"].ToString());
						item.SubItems.Add(dimRow[i]["FlowRes"].ToString());
						item.SubItems.Add(dimRow[i]["Ymodulus"].ToString());
						item.SubItems.Add(dimRow[i]["PoissionR"].ToString());
						item.SubItems.Add(dimRow[i]["ThermalCL"].ToString());
						item.SubItems.Add(dimRow[i]["ViscousCL"].ToString());
						item.SubItems.Add(dimRow[i]["Prosity"].ToString());
						item.SubItems.Add(dimRow[i]["Sfactor"].ToString());
						item.SubItems.Add(dimRow[i]["EmP1"].ToString());
						item.SubItems.Add(dimRow[i]["PRatioP1"].ToString());
						item.SubItems.Add(dimRow[i]["DensityP1"].ToString());
						item.SubItems.Add(dimRow[i]["EmP2"].ToString());
						item.SubItems.Add(dimRow[i]["HP2"].ToString());
						item.SubItems.Add(dimRow[i]["HP2"].ToString());
						item.SubItems.Add(dimRow[i]["HP1"].ToString());
						item.SubItems.Add(dimRow[i]["PRatioP2"].ToString());
						item.SubItems.Add(dimRow[i]["MID"].ToString());

						bIsSingle = true;
					}
					else
					{
						item.SubItems[0].Text = dimRow[i]["LID"].ToString();
				
						item.SubItems.Add(dimRow[i]["MultiLayer.Name"].ToString());
						item.SubItems.Add(dimRow[i]["TotalThick"].ToString());

						bIsSingle = false;
					}

					lstSearchResultList.Items.Add(item);

					//strSearchResult_Selected_ID = item.SubItems[0].Text;
				}
			}

			if(dsSearchResult == null || dsSearchResult.Tables[0].Rows.Count == 0)
			{
				MessageBox.Show("검색 결과가 없습니다");
			}

			pnlGraphOption.Enabled = false;
			pnlGraphOption2.Enabled = false;
			
		}

		public void ReSearch()
		{
			lstSearchResultList.Items.Clear();
		}

		private void MultiListSetting()
		{
			lstSearchResultList.Columns.Clear();

			ColumnHeader col;

			col = new ColumnHeader();
			col.Text = "ID";
			col.Width = 10;
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Name";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "TotalThick";
			lstSearchResultList.Columns.Add(col);
		}

		private string AbsorptionCoefficient_RigidBackingCheck(DataSet ds,clsAbsorptionCoefficient_Find cls)
		{
			string strIDs = "";
			string strFreq = "";
			string strY = "";
			string [] arrFreq;
			string [] arrY;

			string Y_16 = ""; // 주파수가 16 일때 Y 값
			string Y_31_5 = "";
			string Y_63 = "";
			string Y_125 = "";
			string Y_250 = "";
			string Y_500 = "";
			string Y_1000 = "";
			string Y_2000 = "";
			string Y_4000 = "";
			string Y_8000 = "";
			string Y_10000 = "";

			pSeries_Search = new DataPlotter.DataSeries();
			double [] dimdf_X = new double[11];
			double [] dimdf_Y = new double[11];

			pSeries_Search.Color = Color.SkyBlue;
			pSeries_Search.Name = "Search Axis";

			for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++)
			{
				bool bResult = true;

				strFreq = ds.Tables[0].Rows[i]["X_Axis"].ToString();
				strY = ds.Tables[0].Rows[i]["Y_RigidBacking"].ToString();
				if(strFreq != "")
				{
					arrFreq = strFreq.Split(",".ToCharArray());
					arrY = strY.Split(",".ToCharArray());

					if(arrFreq.Length == arrY.Length)
					{
						for(int j = 0 ; j < arrFreq.Length ; j++)
						{
							#region DB 에서 각 주파수별로 Y 값 추출해 내기
							switch(arrFreq[j].ToString())
							{
								case "16" :
									Y_16 = arrY[j].ToString();
									break;
								case "31.5" :
									Y_31_5 = arrY[j].ToString();
									break;
								case "63" :
									Y_63 = arrY[j].ToString();
									break;
								case "125" :
									Y_125 = arrY[j].ToString();
									break;
								case "250" :
									Y_250 = arrY[j].ToString();
									break;
								case "500" :
									Y_500 = arrY[j].ToString();
									break;
								case "1000" :
									Y_1000 = arrY[j].ToString();
									break;
								case "2000" :
									Y_2000 = arrY[j].ToString();
									break;
								case "4000" :
									Y_4000 = arrY[j].ToString();
									break;
								case "8000" :
									Y_8000 = arrY[j].ToString();
									break;
								case "10000" :
									Y_10000 = arrY[j].ToString();
									break;
							}
							#endregion
						}

						#region 범위에 드는지 체크 범위에 들지 않는게 하나라도 있으면 false
						double temp_cls = 0.0;
						double temp_db = 0.0;

						if(cls.str500 != "")
						{
							temp_cls = double.Parse(cls.str500);
							temp_db = double.Parse(Y_500);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[5] = 500;
							dimdf_Y[5] = temp_db;
						}
						if(cls.str1000 != "")
						{
							temp_cls = double.Parse(cls.str1000);
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[6] = 1000;
							dimdf_Y[6] = temp_db;
						}
						if(cls.str2000 != "")
						{
							temp_cls = double.Parse(cls.str2000);
							temp_db = double.Parse(Y_2000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[7] = 2000;
							dimdf_Y[7] = temp_db;
						}
						if(cls.str4000 != "")
						{
							temp_cls = double.Parse(cls.str4000);
							temp_db = double.Parse(Y_4000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[8] = 4000;
							dimdf_Y[8] = temp_db;
						}
						if(cls.str8000 != "")
						{
							temp_cls = double.Parse(cls.str8000);
							temp_db = double.Parse(Y_8000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[9] = 8000;
							dimdf_Y[9] = temp_db;
						}
						if(cls.str10000 != "")
						{
							temp_cls = double.Parse(cls.str10000);
							if(Y_10000 == "")
							{
								Y_10000 = "0";
							}
							temp_db = double.Parse(Y_10000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[10] = 10000;
							dimdf_Y[10] = temp_db;
						}
						#endregion
					}
					else
					{
						bResult = false;
					}
				}
				else
				{
					bResult = false;
				}

				if(bResult == true) // 조건에 만족하면ID 를 추가한다
				{
					strIDs = strIDs + ds.Tables[0].Rows[i]["SGID"].ToString() + ",";
				}
			}

			if(strIDs != "")
			{
				strIDs = strIDs.Substring(0,strIDs.Length - 1);
			}
			
			return strIDs;
		}

		private string AbsorptionCoefficient_RigidBackingCheck(DataSet ds,clsAbsorptionCoefficient_FindDetail cls)
		{
			string strIDs = "";
			string strFreq = "";
			string strY = "";
			string [] arrFreq;
			string [] arrY;

			string Y_400 = "";
			string Y_500 = "";
			string Y_630 = "";
			string Y_800 = "";
			string Y_1000 = "";
			string Y_1250 = "";
			string Y_1600 = "";
			string Y_2000 = "";
			string Y_3150 = "";
			string Y_4000 = "";
			string Y_5000 = "";
			string Y_6300 = "";
			string Y_8000 = "";
			string Y_10000 = "";

			pSeries_Search = new DataPlotter.DataSeries();
			double [] dimdf_X = new double[14];
			double [] dimdf_Y = new double[14];

			pSeries_Search.Color = Color.SkyBlue;
			pSeries_Search.Name = "Search Axis";

			for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++)
			{
				bool bResult = true;

				strFreq = ds.Tables[0].Rows[i]["X_Axis"].ToString();
				strY = ds.Tables[0].Rows[i]["Y_RigidBacking"].ToString();
				if(strFreq != "" && strY != "")
				{
					arrFreq = strFreq.Split(",".ToCharArray());
					arrY = strY.Split(",".ToCharArray());

					if(arrFreq.Length == arrY.Length)
					{
						for(int j = 0 ; j < arrFreq.Length ; j++)
						{
							#region DB 에서 각 주파수별로 Y 값 추출해 내기
							switch(arrFreq[j].ToString())
							{
								case "400" :
									Y_400 = arrY[j].ToString();
									break;
								case "500" :
									Y_500 = arrY[j].ToString();
									break;
								case "630" :
									Y_630 = arrY[j].ToString();
									break;
								case "800" :
									Y_800 = arrY[j].ToString();
									break;
								case "1000" :
									Y_1000 = arrY[j].ToString();
									break;
								case "1250" :
									Y_1250 = arrY[j].ToString();
									break;
								case "1600" :
									Y_1600 = arrY[j].ToString();
									break;
								case "2000" :
									Y_2000 = arrY[j].ToString();
									break;
								case "3150" :
									Y_3150 = arrY[j].ToString();
									break;
								case "4000" :
									Y_4000 = arrY[j].ToString();
									break;
								case "5000" :
									Y_5000 = arrY[j].ToString();
									break;
								case "6300" :
									Y_6300 = arrY[j].ToString();
									break;
								case "8000" :
									Y_8000 = arrY[j].ToString();
									break;
								case "10000" :
									Y_10000 = arrY[j].ToString();
									break;
							}
							#endregion
						}

						#region 범위에 드는지 체크 범위에 들지 않는게 하나라도 있으면 false
						double temp_cls = 0.0;
						double temp_db = 0.0;

						if(cls.str400 != "")
						{
							temp_cls = double.Parse(cls.str400);
							temp_db = double.Parse(Y_400);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[0] = 400;
							dimdf_Y[0] = temp_db;
						}
						if(cls.str500 != "")
						{
							temp_cls = double.Parse(cls.str500);
							temp_db = double.Parse(Y_500);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[1] = 500;
							dimdf_Y[1] = temp_db;
						}
						if(cls.str630 != "")
						{
							temp_cls = double.Parse(cls.str630);
							temp_db = double.Parse(Y_630);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[2] = 630;
							dimdf_Y[2] = temp_db;
						}
						if(cls.str800 != "")
						{
							temp_cls = double.Parse(cls.str800);
							temp_db = double.Parse(Y_800);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[3] = 800;
							dimdf_Y[3] = temp_db;
						}
						if(cls.str1000 != "")
						{
							temp_cls = double.Parse(cls.str1000);
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[4] = 1000;
							dimdf_Y[4] = temp_db;
						}
						if(cls.str1250 != "")
						{
							temp_cls = double.Parse(cls.str1250);
							temp_db = double.Parse(Y_1250);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[5] = 1250;
							dimdf_Y[5] = temp_db;
						}
						if(cls.str1600 != "")
						{
							temp_cls = double.Parse(cls.str1600);
							temp_db = double.Parse(Y_1600);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[6] = 1600;
							dimdf_Y[6] = temp_db;
						}
						if(cls.str2000 != "")
						{
							temp_cls = double.Parse(cls.str2000);
							temp_db = double.Parse(Y_2000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[7] = 2000;
							dimdf_Y[7] = temp_db;
						}
						if(cls.str3150 != "")
						{
							temp_cls = double.Parse(cls.str3150);
							temp_db = double.Parse(Y_3150);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[8] = 3150;
							dimdf_Y[8] = temp_db;
						}
						if(cls.str4000 != "")
						{
							temp_cls = double.Parse(cls.str4000);
							temp_db = double.Parse(Y_4000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[9] = 4000;
							dimdf_Y[9] = temp_db;
						}
						if(cls.str5000 != "")
						{
							temp_cls = double.Parse(cls.str5000);
							temp_db = double.Parse(Y_5000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[10] = 5000;
							dimdf_Y[10] = temp_db;
						}
						if(cls.str6300 != "")
						{
							temp_cls = double.Parse(cls.str6300);
							temp_db = double.Parse(Y_6300);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[11] = 6300;
							dimdf_Y[11] = temp_db;
						}
						if(cls.str8000 != "")
						{
							temp_cls = double.Parse(cls.str8000);
							temp_db = double.Parse(Y_8000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[12] = 8000;
							dimdf_Y[12] = temp_db;
						}
						if(cls.str1000 != "")
						{
							temp_cls = double.Parse(cls.str1000);
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[13] = 1000;
							dimdf_Y[13] = temp_db;
						}
						#endregion
					}
					else
					{
						bResult = false;
					}
				}
				else
				{
					bResult = false;
				}

				if(bResult == true) // 조건에 만족하면ID 를 추가한다
				{
					strIDs = strIDs + ds.Tables[0].Rows[i]["SGID"].ToString() + ",";
				}
			}

			if(strIDs != "")
			{
				strIDs = strIDs.Substring(0,strIDs.Length - 1);
			}
			
			return strIDs;
		}


		private string AbsorptionCoefficient_AnechoicTerminationCheck(DataSet ds,clsAbsorptionCoefficient_Find cls)
		{
			string strIDs = "";
			string strFreq = "";
			string strY = "";
			string [] arrFreq;
			string [] arrY;

			string Y_16 = ""; // 주파수가 16 일때 Y 값
			string Y_31_5 = "";
			string Y_63 = "";
			string Y_125 = "";
			string Y_250 = "";
			string Y_500 = "";
			string Y_1000 = "";
			string Y_2000 = "";
			string Y_4000 = "";
			string Y_8000 = "";
			string Y_10000 = "";

			pSeries_Search = new DataPlotter.DataSeries();
			double [] dimdf_X = new double[11];
			double [] dimdf_Y = new double[11];

			pSeries_Search.Color = Color.SkyBlue;
			pSeries_Search.Name = "Search Axis";

			for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++)
			{
				bool bResult = true;

				strFreq = ds.Tables[0].Rows[i]["X_Axis"].ToString();
				strY = ds.Tables[0].Rows[i]["Y_AnechoicTermination"].ToString();
				if(strFreq != "")
				{
					arrFreq = strFreq.Split(",".ToCharArray());
					arrY = strY.Split(",".ToCharArray());

					if(arrFreq.Length == arrY.Length)
					{
						for(int j = 0 ; j < arrFreq.Length ; j++)
						{
							#region DB 에서 각 주파수별로 Y 값 추출해 내기
							switch(arrFreq[j].ToString())
							{
								case "16" :
									Y_16 = arrY[j].ToString();
									break;
								case "31.5" :
									Y_31_5 = arrY[j].ToString();
									break;
								case "63" :
									Y_63 = arrY[j].ToString();
									break;
								case "125" :
									Y_125 = arrY[j].ToString();
									break;
								case "250" :
									Y_250 = arrY[j].ToString();
									break;
								case "500" :
									Y_500 = arrY[j].ToString();
									break;
								case "1000" :
									Y_1000 = arrY[j].ToString();
									break;
								case "2000" :
									Y_2000 = arrY[j].ToString();
									break;
								case "4000" :
									Y_4000 = arrY[j].ToString();
									break;
								case "8000" :
									Y_8000 = arrY[j].ToString();
									break;
								case "10000" :
									Y_10000 = arrY[j].ToString();
									break;
							}
							#endregion
						}

						#region 범위에 드는지 체크 범위에 들지 않는게 하나라도 있으면 false
						double temp_cls = 0.0;
						double temp_db = 0.0;

						if(cls.str500 != "")
						{
							temp_cls = double.Parse(cls.str500);
							temp_db = double.Parse(Y_500);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[5] = 500;
							dimdf_Y[5] = temp_db;
						}
						if(cls.str1000 != "")
						{
							temp_cls = double.Parse(cls.str1000);
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[6] = 1000;
							dimdf_Y[6] = temp_db;
						}
						if(cls.str2000 != "")
						{
							temp_cls = double.Parse(cls.str2000);
							temp_db = double.Parse(Y_2000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[7] = 2000;
							dimdf_Y[7] = temp_db;
						}
						if(cls.str4000 != "")
						{
							temp_cls = double.Parse(cls.str4000);
							temp_db = double.Parse(Y_4000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[8] = 4000;
							dimdf_Y[8] = temp_db;
						}
						if(cls.str8000 != "")
						{
							temp_cls = double.Parse(cls.str8000);
							temp_db = double.Parse(Y_8000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[9] = 8000;
							dimdf_Y[9] = temp_db;
						}
						if(cls.str10000 != "")
						{
							temp_cls = double.Parse(cls.str10000);
							temp_db = double.Parse(Y_10000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[10] = 10000;
							dimdf_Y[10] = temp_db;
						}
						#endregion
					}
					else
					{
						bResult = false;
					}
				}
				else
				{
					bResult = false;
				}

				if(bResult == true) // 조건에 만족하면ID 를 추가한다
				{
					strIDs = strIDs + ds.Tables[0].Rows[i]["SGID"].ToString() + ",";
				}
			}

			pSeries_Search.XData = dimdf_X;
			pSeries_Search.YData = dimdf_Y;

			if(strIDs != "")
			{
				strIDs = strIDs.Substring(0,strIDs.Length - 1);
			}
			
			return strIDs;
		}

		private string AbsorptionCoefficient_AnechoicTerminationCheck(DataSet ds,clsAbsorptionCoefficient_FindDetail cls)
		{
			string strIDs = "";
			string strFreq = "";
			string strY = "";
			string [] arrFreq;
			string [] arrY;

			string Y_400 = "";
			string Y_500 = "";
			string Y_630 = "";
			string Y_800 = "";
			string Y_1000 = "";
			string Y_1250 = "";
			string Y_1600 = "";
			string Y_2000 = "";
			string Y_3150 = "";
			string Y_4000 = "";
			string Y_5000 = "";
			string Y_6300 = "";
			string Y_8000 = "";
			string Y_10000 = "";

			pSeries_Search = new DataPlotter.DataSeries();
			double [] dimdf_X = new double[14];
			double [] dimdf_Y = new double[14];

			pSeries_Search.Color = Color.SkyBlue;
			pSeries_Search.Name = "Search Axis";

			for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++)
			{
				bool bResult = true;

				strFreq = ds.Tables[0].Rows[i]["X_Axis"].ToString();
				strY = ds.Tables[0].Rows[i]["Y_AnechoicTermination"].ToString();
				if(strFreq != "" && strY != "")
				{
					arrFreq = strFreq.Split(",".ToCharArray());
					arrY = strY.Split(",".ToCharArray());

					if(arrFreq.Length == arrY.Length)
					{
						for(int j = 0 ; j < arrFreq.Length ; j++)
						{
							#region DB 에서 각 주파수별로 Y 값 추출해 내기
							switch(arrFreq[j].ToString())
							{
								case "400" :
									Y_400 = arrY[j].ToString();
									break;
								case "500" :
									Y_500 = arrY[j].ToString();
									break;
								case "630" :
									Y_630 = arrY[j].ToString();
									break;
								case "800" :
									Y_800 = arrY[j].ToString();
									break;
								case "1000" :
									Y_1000 = arrY[j].ToString();
									break;
								case "1250" :
									Y_1250 = arrY[j].ToString();
									break;
								case "1600" :
									Y_1600 = arrY[j].ToString();
									break;
								case "2000" :
									Y_2000 = arrY[j].ToString();
									break;
								case "3150" :
									Y_3150 = arrY[j].ToString();
									break;
								case "4000" :
									Y_4000 = arrY[j].ToString();
									break;
								case "5000" :
									Y_5000 = arrY[j].ToString();
									break;
								case "6300" :
									Y_6300 = arrY[j].ToString();
									break;
								case "8000" :
									Y_8000 = arrY[j].ToString();
									break;
								case "10000" :
									Y_10000 = arrY[j].ToString();
									break;
							}
							#endregion
						}

						#region 범위에 드는지 체크 범위에 들지 않는게 하나라도 있으면 false
						double temp_cls = 0.0;
						double temp_db = 0.0;

						if(cls.str400 != "")
						{
							temp_cls = double.Parse(cls.str400);
							temp_db = double.Parse(Y_400);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[0] = 400;
							dimdf_Y[0] = temp_db;
						}
						if(cls.str500 != "")
						{
							temp_cls = double.Parse(cls.str500);
							temp_db = double.Parse(Y_500);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[1] = 500;
							dimdf_Y[1] = temp_db;
						}
						if(cls.str630 != "")
						{
							temp_cls = double.Parse(cls.str630);
							temp_db = double.Parse(Y_630);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[2] = 630;
							dimdf_Y[2] = temp_db;
						}
						if(cls.str800 != "")
						{
							temp_cls = double.Parse(cls.str800);
							temp_db = double.Parse(Y_800);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[3] = 800;
							dimdf_Y[3] = temp_db;
						}
						if(cls.str1000 != "")
						{
							temp_cls = double.Parse(cls.str1000);
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[4] = 1000;
							dimdf_Y[4] = temp_db;
						}
						if(cls.str1250 != "")
						{
							temp_cls = double.Parse(cls.str1250);
							temp_db = double.Parse(Y_1250);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[5] = 1250;
							dimdf_Y[5] = temp_db;
						}
						if(cls.str1600 != "")
						{
							temp_cls = double.Parse(cls.str1600);
							temp_db = double.Parse(Y_1600);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[6] = 1600;
							dimdf_Y[6] = temp_db;
						}
						if(cls.str2000 != "")
						{
							temp_cls = double.Parse(cls.str2000);
							temp_db = double.Parse(Y_2000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[7] = 2000;
							dimdf_Y[7] = temp_db;
						}
						if(cls.str3150 != "")
						{
							temp_cls = double.Parse(cls.str3150);
							temp_db = double.Parse(Y_3150);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[8] = 3150;
							dimdf_Y[8] = temp_db;
						}
						if(cls.str4000 != "")
						{
							temp_cls = double.Parse(cls.str4000);
							temp_db = double.Parse(Y_4000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[9] = 4000;
							dimdf_Y[9] = temp_db;
						}
						if(cls.str5000 != "")
						{
							temp_cls = double.Parse(cls.str5000);
							temp_db = double.Parse(Y_5000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[10] = 5000;
							dimdf_Y[10] = temp_db;
						}
						if(cls.str6300 != "")
						{
							temp_cls = double.Parse(cls.str6300);
							temp_db = double.Parse(Y_6300);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[11] = 6300;
							dimdf_Y[11] = temp_db;
						}
						if(cls.str8000 != "")
						{
							temp_cls = double.Parse(cls.str8000);
							temp_db = double.Parse(Y_8000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[12] = 8000;
							dimdf_Y[12] = temp_db;
						}
						if(cls.str1000 != "")
						{
							temp_cls = double.Parse(cls.str1000);
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[13] = 1000;
							dimdf_Y[13] = temp_db;
						}
						
						#endregion
					}
					else
					{
						bResult = false;
					}
				}
				else
				{
					bResult = false;
				}

				if(bResult == true) // 조건에 만족하면ID 를 추가한다
				{
					strIDs = strIDs + ds.Tables[0].Rows[i]["SGID"].ToString() + ",";
				}
			}

			pSeries_Search.XData = dimdf_X;
			pSeries_Search.YData = dimdf_Y;

			if(strIDs != "")
			{
				strIDs = strIDs.Substring(0,strIDs.Length - 1);
			}
			
			return strIDs;
		}


		private string TransmissionLossCheck(DataSet ds,clsAbsorptionCoefficient_Find cls)
		{
			string strIDs = "";
			string strFreq = "";
			string strY = "";
			string [] arrFreq;
			string [] arrY;

			string Y_16 = ""; // 주파수가 16 일때 Y 값
			string Y_31_5 = "";
			string Y_63 = "";
			string Y_125 = "";
			string Y_250 = "";
			string Y_500 = "";
			string Y_1000 = "";
			string Y_2000 = "";
			string Y_4000 = "";
			string Y_8000 = "";
			string Y_10000 = "";

			pSeries_Search = new DataPlotter.DataSeries();
			double [] dimdf_X = new double[6];
			double [] dimdf_Y = new double[6];

			pSeries_Search.Color = Color.SkyBlue;
			pSeries_Search.Name = "Search Axis";

			for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++)
			{
				bool bResult = true;

				strFreq = ds.Tables[0].Rows[i]["X_Axis"].ToString();
				strY = ds.Tables[0].Rows[i]["Y_TransmissionLoss"].ToString();
				if(strFreq != "")
				{
					arrFreq = strFreq.Split(",".ToCharArray());
					arrY = strY.Split(",".ToCharArray());

					if(arrFreq.Length == arrY.Length)
					{
						for(int j = 0 ; j < arrFreq.Length ; j++)
						{
							#region DB 에서 각 주파수별로 Y 값 추출해 내기
							switch(arrFreq[j].ToString())
							{
								case "16" :
									Y_16 = arrY[j].ToString();
									break;
								case "31.5" :
									Y_31_5 = arrY[j].ToString();
									break;
								case "63" :
									Y_63 = arrY[j].ToString();
									break;
								case "125" :
									Y_125 = arrY[j].ToString();
									break;
								case "250" :
									Y_250 = arrY[j].ToString();
									break;
								case "500" :
									Y_500 = arrY[j].ToString();
									break;
								case "1000" :
									Y_1000 = arrY[j].ToString();
									break;
								case "2000" :
									Y_2000 = arrY[j].ToString();
									break;
								case "4000" :
									Y_4000 = arrY[j].ToString();
									break;
								case "8000" :
									Y_8000 = arrY[j].ToString();
									break;
								case "10000" :
									Y_10000 = arrY[j].ToString();
									break;
							}
							#endregion
						}

						#region 범위에 드는지 체크 범위에 들지 않는게 하나라도 있으면 false
						double temp_cls = 0.0;
						double temp_db = 0.0;

						if(cls.str500 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str500);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(500) + temp_cls;
							}
							
							temp_db = double.Parse(Y_500);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[0] = 400;
							dimdf_Y[0] = temp_cls;
						}
						if(cls.str1000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str1000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(1000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[1] = 1000;
							dimdf_Y[1] = temp_cls;
						}
						if(cls.str2000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str2000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(2000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_2000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[2] = 2000;
							dimdf_Y[2] = temp_cls;
						}
						if(cls.str4000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str4000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(4000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_4000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[3] = 4000;
							dimdf_Y[3] = temp_cls;
						}
						if(cls.str8000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str8000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(8000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_8000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[4] = 8000;
							dimdf_Y[4] = temp_cls;
						}
						if(cls.str10000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str10000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(10000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_10000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[5] = 10000;
							dimdf_Y[5] = temp_cls;
						}
						#endregion
					}
					else
					{
						bResult = false;
					}
				}
				else
				{
					bResult = false;
				}

				if(bResult == true) // 조건에 만족하면ID 를 추가한다
				{
					strIDs = strIDs + ds.Tables[0].Rows[i]["SGID"].ToString() + ",";
				}
			}

			if(strIDs != "")
			{
				strIDs = strIDs.Substring(0,strIDs.Length - 1);
			}
			
			pSeries_Search.XData = dimdf_X;
			pSeries_Search.YData = dimdf_Y;


			return strIDs;
		}
		
		private string TransmissionLossCheck(DataSet ds,clsAbsorptionCoefficient_FindDetail cls)
		{
			string strIDs = "";
			string strFreq = "";
			string strY = "";
			string [] arrFreq;
			string [] arrY;

			string Y_400 = "";
			string Y_500 = "";
			string Y_630 = "";
			string Y_800 = "";
			string Y_1000 = "";
			string Y_1250 = "";
			string Y_1600 = "";
			string Y_2000 = "";
			string Y_3150 = "";
			string Y_4000 = "";
			string Y_5000 = "";
			string Y_6300 = "";
			string Y_8000 = "";
			string Y_10000 = "";

			pSeries_Search = new DataPlotter.DataSeries();
			double [] dimdf_X = new double[14];
			double [] dimdf_Y = new double[14];

			pSeries_Search.Color = Color.SkyBlue;
			pSeries_Search.Name = "Search Axis";

			for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++)
			{
				bool bResult = true;

				strFreq = ds.Tables[0].Rows[i]["X_Axis"].ToString();
				strY = ds.Tables[0].Rows[i]["Y_TransmissionLoss"].ToString();
				if(strFreq != "" && strY != "")
				{
					arrFreq = strFreq.Split(",".ToCharArray());
					arrY = strY.Split(",".ToCharArray());

					if(arrFreq.Length == arrY.Length)
					{
						for(int j = 0 ; j < arrFreq.Length ; j++)
						{
							#region DB 에서 각 주파수별로 Y 값 추출해 내기
							switch(arrFreq[j].ToString())
							{
								case "400" :
									Y_400 = arrY[j].ToString();
									break;
								case "500" :
									Y_500 = arrY[j].ToString();
									break;
								case "630" :
									Y_630 = arrY[j].ToString();
									break;
								case "800" :
									Y_800 = arrY[j].ToString();
									break;
								case "1000" :
									Y_1000 = arrY[j].ToString();
									break;
								case "1250" :
									Y_1250 = arrY[j].ToString();
									break;
								case "1600" :
									Y_1600 = arrY[j].ToString();
									break;
								case "2000" :
									Y_2000 = arrY[j].ToString();
									break;
								case "3150" :
									Y_3150 = arrY[j].ToString();
									break;
								case "4000" :
									Y_4000 = arrY[j].ToString();
									break;
								case "5000" :
									Y_5000 = arrY[j].ToString();
									break;
								case "6300" :
									Y_6300 = arrY[j].ToString();
									break;
								case "8000" :
									Y_8000 = arrY[j].ToString();
									break;
								case "10000" :
									Y_10000 = arrY[j].ToString();
									break;
							}
							#endregion
						}

						#region 범위에 드는지 체크 범위에 들지 않는게 하나라도 있으면 false
						double temp_cls = 0.0;
						double temp_db = 0.0;

						if(cls.str400 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str400);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(400) + temp_cls;
							}
							
							temp_db = double.Parse(Y_400);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[0] = 400;
							dimdf_Y[0] = temp_cls;
						}
						if(cls.str500 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str500);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(500) + temp_cls;
							}
							
							temp_db = double.Parse(Y_500);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[1] = 500;
							dimdf_Y[1] = temp_cls;
						}
						if(cls.str630 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str630);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(630) + temp_cls;
							}
							
							temp_db = double.Parse(Y_630);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[2] = 630;
							dimdf_Y[2] = temp_cls;
						}
						if(cls.str800 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str800);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(800) + temp_cls;
							}
							
							temp_db = double.Parse(Y_800);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[3] = 800;
							dimdf_Y[3] = temp_cls;
						}
						if(cls.str1000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str1000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(1000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[4] = 1000;
							dimdf_Y[4] = temp_cls;
						}
						if(cls.str1250 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str1250);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(1250) + temp_cls;
							}
							
							temp_db = double.Parse(Y_1250);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[5] = 1250;
							dimdf_Y[5] = temp_cls;
						}
						if(cls.str1600 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str1600);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(1600) + temp_cls;
							}
							
							temp_db = double.Parse(Y_1600);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[6] = 1600;
							dimdf_Y[6] = temp_cls;
						}
						if(cls.str2000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str2000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(2000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_2000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[7] = 2000;
							dimdf_Y[7] = temp_cls;
						}
						if(cls.str3150 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str3150);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(3150) + temp_cls;
							}
							
							temp_db = double.Parse(Y_3150);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[8] = 3150;
							dimdf_Y[8] = temp_cls;
						}
						if(cls.str4000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str4000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(4000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_4000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[9] = 4000;
							dimdf_Y[9] = temp_cls;
						}
						if(cls.str5000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str5000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(5000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_5000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[10] = 5000;
							dimdf_Y[10] = temp_cls;
						}
						if(cls.str6300 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str6300);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(6300) + temp_cls;
							}
							
							temp_db = double.Parse(Y_6300);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[11] = 6300;
							dimdf_Y[11] = temp_cls;
						}
						if(cls.str8000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str8000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(8000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_8000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[12] = 8000;
							dimdf_Y[12] = temp_cls;
						}
						if(cls.str10000 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str10000);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
								temp_cls = Math.Log10(10000) + temp_cls;
							}
							
							temp_db = double.Parse(Y_10000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}

							dimdf_X[13] = 10000;
							dimdf_Y[13] = temp_cls;
						}
						#endregion
					}
					else
					{
						bResult = false;
					}
				}
				else
				{
					bResult = false;
				}

				if(bResult == true) // 조건에 만족하면ID 를 추가한다
				{
					strIDs = strIDs + ds.Tables[0].Rows[i]["SGID"].ToString() + ",";
				}
			}

			if(strIDs != "")
			{
				strIDs = strIDs.Substring(0,strIDs.Length - 1);
			}
			
			pSeries_Search.XData = dimdf_X;
			pSeries_Search.YData = dimdf_Y;

			return strIDs;
		}


		private string ParametersCheck(DataSet ds,clsParameters cls)
		{
			string strIDs = "";

			bool bResult = true;

			for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++)
			{
				#region 각 파라메터 별로 체크 (해당되지 않으면 false 입력)
				// BulkDens
				if(cls.strBulkDensity_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["BulkDens"].ToString()) < double.Parse(cls.strBulkDensity_Low))
					{
						bResult = false;
					}
				}
				if(cls.strBulkDensity_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["BulkDens"].ToString()) > double.Parse(cls.strBulkDensity_High))
					{
						bResult = false;
					}
				}
				// FlowRes
				if(cls.strFlowResistivity_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["FlowRes"].ToString()) < double.Parse(cls.strFlowResistivity_Low))
					{
						bResult = false;
					}
				}
				if(cls.strFlowResistivity_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["FlowRes"].ToString()) > double.Parse(cls.strFlowResistivity_High))
					{
						bResult = false;
					}
				}
				// LossFactor
				if(cls.strLossFactor_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["LossFactor"].ToString()) < double.Parse(cls.strLossFactor_Low))
					{
						bResult = false;
					}
				}
				if(cls.strLossFactor_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["LossFactor"].ToString()) > double.Parse(cls.strLossFactor_High))
					{
						bResult = false;
					}
				}
				// PoissionR
				if(cls.strPoissionsRatio_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["PoissionR"].ToString()) < double.Parse(cls.strPoissionsRatio_Low))
					{
						bResult = false;
					}
				}
				if(cls.strPoissionsRatio_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["PoissionR"].ToString()) > double.Parse(cls.strPoissionsRatio_High))
					{
						bResult = false;
					}
				}
				// Prosity
				if(cls.strProsity_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["Prosity"].ToString()) < double.Parse(cls.strProsity_Low))
					{
						bResult = false;
					}
				}
				if(cls.strProsity_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["Prosity"].ToString()) > double.Parse(cls.strProsity_High))
					{
						bResult = false;
					}
				}
				// Sfactor
				if(cls.strStructureFactor_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["Sfactor"].ToString()) < double.Parse(cls.strStructureFactor_Low))
					{
						bResult = false;
					}
				}
				if(cls.strStructureFactor_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["Sfactor"].ToString()) > double.Parse(cls.strStructureFactor_High))
					{
						bResult = false;
					}
				}
				// ThermalCL
				if(cls.strThermalCharLength_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["ThermalCL"].ToString()) < double.Parse(cls.strThermalCharLength_Low))
					{
						bResult = false;
					}
				}
				if(cls.strThermalCharLength_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["ThermalCL"].ToString()) > double.Parse(cls.strThermalCharLength_High))
					{
						bResult = false;
					}
				}
				// Thick
				if(cls.strThickness_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["Thick"].ToString()) < double.Parse(cls.strThickness_Low))
					{
						bResult = false;
					}
				}
				if(cls.strThickness_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["Thick"].ToString()) > double.Parse(cls.strThickness_High))
					{
						bResult = false;
					}
				}
				// ViscousCL
				if(cls.strViscousCharLength_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["ViscousCL"].ToString()) < double.Parse(cls.strViscousCharLength_Low))
					{
						bResult = false;
					}
				}
				if(cls.strViscousCharLength_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["ViscousCL"].ToString()) > double.Parse(cls.strViscousCharLength_High))
					{
						bResult = false;
					}
				}
				// Ymodulus
				if(cls.strYoungsModulus_Low != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["Ymodulus"].ToString()) < double.Parse(cls.strYoungsModulus_Low))
					{
						bResult = false;
					}
				}
				if(cls.strYoungsModulus_High != "")
				{
					if(double.Parse(ds.Tables[0].Rows[i]["Ymodulus"].ToString()) > double.Parse(cls.strYoungsModulus_High))
					{
						bResult = false;
					}
				}
				#endregion

				if(bResult == true) // 조건에 만족하면ID 를 추가한다
				{
					strIDs = strIDs + ds.Tables[0].Rows[i][0].ToString() + ",";
				}
			}

			if(strIDs != "")
			{
				strIDs = strIDs.Substring(0,strIDs.Length - 1);
			}
			
			return strIDs;
		}

		private string MultiLayerCheck(DataSet ds,string strName,string strTotalThick)
		{
			string strIDs = "";

			MD_DB MD_DB1 = new MD_DB();

			for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++)
			{
				bool bResult = true;

				if(strName != null)
				{
					if(ds.Tables[0].Rows[i]["MultiLayer.Name"].ToString() != strName)
					{
						bResult = false;
					}
				}
				if(strTotalThick != null)
				{
					if(ds.Tables[0].Rows[i]["TotalThick"].ToString() != strTotalThick)
					{
						bResult = false;
					}
				}

				if(bResult == true) // 조건에 만족하면ID 를 추가한다
				{
					strIDs = strIDs + ds.Tables[0].Rows[i][0].ToString() + ",";
				}
			}

			if(strIDs != "")
			{
				strIDs = strIDs.Substring(0,strIDs.Length - 1);
			}
			
			return strIDs;
		}

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lstSearchResultList = new System.Windows.Forms.ListView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCreate = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnlGraphOption = new System.Windows.Forms.Panel();
			this.edtAngle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtTemperature = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rdoAbsorptionCoefficient_AT = new System.Windows.Forms.RadioButton();
			this.rdoAbsorptionCoefficient_RB = new System.Windows.Forms.RadioButton();
			this.rdoTransmissionLoss = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.rdoOctave_3_1 = new System.Windows.Forms.RadioButton();
			this.rdoOctave = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdoRandom = new System.Windows.Forms.RadioButton();
			this.rdoNormal = new System.Windows.Forms.RadioButton();
			this.chMeasured = new System.Windows.Forms.CheckBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.plotter1 = new DataPlotter.Plotter();
			this.btnGraphSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnGraphEdit = new System.Windows.Forms.Button();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.btnEditCancel = new System.Windows.Forms.Button();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnView = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.pnlGraphOption2 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlGraphOption.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.pnlGraphOption2.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(710, 10);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox2.Location = new System.Drawing.Point(0, 562);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(710, 10);
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox3.Location = new System.Drawing.Point(700, 10);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 552);
			this.pictureBox3.TabIndex = 12;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox4.Location = new System.Drawing.Point(0, 10);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 552);
			this.pictureBox4.TabIndex = 13;
			this.pictureBox4.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lstSearchResultList);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(10, 10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(690, 166);
			this.panel1.TabIndex = 14;
			// 
			// lstSearchResultList
			// 
			this.lstSearchResultList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstSearchResultList.FullRowSelect = true;
			this.lstSearchResultList.GridLines = true;
			this.lstSearchResultList.HideSelection = false;
			this.lstSearchResultList.Location = new System.Drawing.Point(0, 16);
			this.lstSearchResultList.Name = "lstSearchResultList";
			this.lstSearchResultList.Size = new System.Drawing.Size(690, 117);
			this.lstSearchResultList.TabIndex = 1;
			this.lstSearchResultList.View = System.Windows.Forms.View.Details;
			this.lstSearchResultList.DoubleClick += new System.EventHandler(this.lstSearchResultList_DoubleClick);
			this.lstSearchResultList.SelectedIndexChanged += new System.EventHandler(this.lstSearchResultList_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnCreate);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 133);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(690, 33);
			this.panel2.TabIndex = 2;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.SystemColors.Control;
			this.btnCreate.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCreate.Location = new System.Drawing.Point(615, 10);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.TabIndex = 1;
			this.btnCreate.Text = "추가";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(690, 10);
			this.panel4.TabIndex = 0;
			// 
			// pnlGraphOption
			// 
			this.pnlGraphOption.Controls.Add(this.edtAngle);
			this.pnlGraphOption.Controls.Add(this.label2);
			this.pnlGraphOption.Controls.Add(this.edtTemperature);
			this.pnlGraphOption.Controls.Add(this.label1);
			this.pnlGraphOption.Controls.Add(this.rdoAbsorptionCoefficient_AT);
			this.pnlGraphOption.Controls.Add(this.rdoAbsorptionCoefficient_RB);
			this.pnlGraphOption.Controls.Add(this.rdoTransmissionLoss);
			this.pnlGraphOption.Controls.Add(this.groupBox5);
			this.pnlGraphOption.Controls.Add(this.groupBox2);
			this.pnlGraphOption.Controls.Add(this.chMeasured);
			this.pnlGraphOption.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlGraphOption.Enabled = false;
			this.pnlGraphOption.Location = new System.Drawing.Point(0, 0);
			this.pnlGraphOption.Name = "pnlGraphOption";
			this.pnlGraphOption.Size = new System.Drawing.Size(200, 336);
			this.pnlGraphOption.TabIndex = 15;
			// 
			// edtAngle
			// 
			this.edtAngle.Location = new System.Drawing.Point(99, 32);
			this.edtAngle.Name = "edtAngle";
			this.edtAngle.Size = new System.Drawing.Size(70, 21);
			this.edtAngle.TabIndex = 17;
			this.edtAngle.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "Angle";
			// 
			// edtTemperature
			// 
			this.edtTemperature.Location = new System.Drawing.Point(99, 8);
			this.edtTemperature.Name = "edtTemperature";
			this.edtTemperature.Size = new System.Drawing.Size(70, 21);
			this.edtTemperature.TabIndex = 17;
			this.edtTemperature.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Temperature";
			// 
			// rdoAbsorptionCoefficient_AT
			// 
			this.rdoAbsorptionCoefficient_AT.Location = new System.Drawing.Point(16, 272);
			this.rdoAbsorptionCoefficient_AT.Name = "rdoAbsorptionCoefficient_AT";
			this.rdoAbsorptionCoefficient_AT.Size = new System.Drawing.Size(152, 32);
			this.rdoAbsorptionCoefficient_AT.TabIndex = 13;
			this.rdoAbsorptionCoefficient_AT.Text = "Absorption Coefficient (anechoic termination)";
			this.rdoAbsorptionCoefficient_AT.CheckedChanged += new System.EventHandler(this.rdoAbsorptionCoefficient_AT_CheckedChanged);
			// 
			// rdoAbsorptionCoefficient_RB
			// 
			this.rdoAbsorptionCoefficient_RB.Checked = true;
			this.rdoAbsorptionCoefficient_RB.Location = new System.Drawing.Point(16, 240);
			this.rdoAbsorptionCoefficient_RB.Name = "rdoAbsorptionCoefficient_RB";
			this.rdoAbsorptionCoefficient_RB.Size = new System.Drawing.Size(152, 32);
			this.rdoAbsorptionCoefficient_RB.TabIndex = 12;
			this.rdoAbsorptionCoefficient_RB.TabStop = true;
			this.rdoAbsorptionCoefficient_RB.Text = "Absorption Coefficient (Rigid Backing)";
			this.rdoAbsorptionCoefficient_RB.CheckedChanged += new System.EventHandler(this.rdoAbsorptionCoefficient_RB_CheckedChanged);
			// 
			// rdoTransmissionLoss
			// 
			this.rdoTransmissionLoss.Location = new System.Drawing.Point(16, 304);
			this.rdoTransmissionLoss.Name = "rdoTransmissionLoss";
			this.rdoTransmissionLoss.Size = new System.Drawing.Size(152, 24);
			this.rdoTransmissionLoss.TabIndex = 11;
			this.rdoTransmissionLoss.Text = "Transmission Loss";
			this.rdoTransmissionLoss.CheckedChanged += new System.EventHandler(this.rdoTransmissionLoss_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.radioButton1);
			this.groupBox5.Controls.Add(this.rdoOctave_3_1);
			this.groupBox5.Controls.Add(this.rdoOctave);
			this.groupBox5.Location = new System.Drawing.Point(8, 152);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(168, 80);
			this.groupBox5.TabIndex = 10;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Target  Frequency";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(8, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(112, 24);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Narrow Band";
			// 
			// rdoOctave_3_1
			// 
			this.rdoOctave_3_1.Location = new System.Drawing.Point(72, 48);
			this.rdoOctave_3_1.Name = "rdoOctave_3_1";
			this.rdoOctave_3_1.Size = new System.Drawing.Size(88, 24);
			this.rdoOctave_3_1.TabIndex = 1;
			this.rdoOctave_3_1.Text = "1/3 Octave";
			// 
			// rdoOctave
			// 
			this.rdoOctave.Location = new System.Drawing.Point(8, 48);
			this.rdoOctave.Name = "rdoOctave";
			this.rdoOctave.Size = new System.Drawing.Size(64, 24);
			this.rdoOctave.TabIndex = 0;
			this.rdoOctave.Text = "Octave";
			this.rdoOctave.CheckedChanged += new System.EventHandler(this.rdoOctave_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdoRandom);
			this.groupBox2.Controls.Add(this.rdoNormal);
			this.groupBox2.Location = new System.Drawing.Point(8, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(160, 56);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Incidence Condition";
			// 
			// rdoRandom
			// 
			this.rdoRandom.Location = new System.Drawing.Point(80, 24);
			this.rdoRandom.Name = "rdoRandom";
			this.rdoRandom.Size = new System.Drawing.Size(72, 24);
			this.rdoRandom.TabIndex = 1;
			this.rdoRandom.Text = "Random";
			// 
			// rdoNormal
			// 
			this.rdoNormal.Checked = true;
			this.rdoNormal.Location = new System.Drawing.Point(8, 24);
			this.rdoNormal.Name = "rdoNormal";
			this.rdoNormal.Size = new System.Drawing.Size(64, 24);
			this.rdoNormal.TabIndex = 0;
			this.rdoNormal.TabStop = true;
			this.rdoNormal.Text = "Normal";
			this.rdoNormal.CheckedChanged += new System.EventHandler(this.rdoNormal_CheckedChanged);
			// 
			// chMeasured
			// 
			this.chMeasured.Location = new System.Drawing.Point(32, 56);
			this.chMeasured.Name = "chMeasured";
			this.chMeasured.TabIndex = 8;
			this.chMeasured.Text = "Measured";
			this.chMeasured.CheckedChanged += new System.EventHandler(this.chMeasured_CheckedChanged);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox5.Location = new System.Drawing.Point(10, 176);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(690, 10);
			this.pictureBox5.TabIndex = 16;
			this.pictureBox5.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(10, 552);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(490, 10);
			this.panel3.TabIndex = 17;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Cursor = System.Windows.Forms.Cursors.HSplit;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(312, 186);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.SelectedObject = this.plotter1;
			this.propertyGrid1.Size = new System.Drawing.Size(188, 343);
			this.propertyGrid1.TabIndex = 18;
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
			this.plotter1.Location = new System.Drawing.Point(10, 186);
			this.plotter1.MarkerSize = 4;
			this.plotter1.MarkerType = DataPlotter.Plotter.MarkerModeType.None;
			this.plotter1.Name = "plotter1";
			this.plotter1.PenWidth = 1;
			this.plotter1.ShowGrid = true;
			this.plotter1.ShowLegend = false;
			this.plotter1.Size = new System.Drawing.Size(302, 343);
			this.plotter1.TabIndex = 22;
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
			this.btnGraphSave.Size = new System.Drawing.Size(96, 23);
			this.btnGraphSave.TabIndex = 20;
			this.btnGraphSave.Text = "Graph Save";
			this.btnGraphSave.Click += new System.EventHandler(this.btnGraphSave_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.btnGraphEdit);
			this.panel5.Controls.Add(this.pictureBox7);
			this.panel5.Controls.Add(this.btnEditCancel);
			this.panel5.Controls.Add(this.pictureBox6);
			this.panel5.Controls.Add(this.btnGraphSave);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(10, 529);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(490, 23);
			this.panel5.TabIndex = 21;
			// 
			// btnGraphEdit
			// 
			this.btnGraphEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnGraphEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnGraphEdit.Location = new System.Drawing.Point(106, 0);
			this.btnGraphEdit.Name = "btnGraphEdit";
			this.btnGraphEdit.Size = new System.Drawing.Size(286, 23);
			this.btnGraphEdit.TabIndex = 24;
			this.btnGraphEdit.Text = "Graph Edit";
			this.btnGraphEdit.Click += new System.EventHandler(this.btnGraphEdit_Click);
			// 
			// pictureBox7
			// 
			this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox7.Location = new System.Drawing.Point(392, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(10, 23);
			this.pictureBox7.TabIndex = 23;
			this.pictureBox7.TabStop = false;
			// 
			// btnEditCancel
			// 
			this.btnEditCancel.BackColor = System.Drawing.SystemColors.Control;
			this.btnEditCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnEditCancel.Enabled = false;
			this.btnEditCancel.Location = new System.Drawing.Point(402, 0);
			this.btnEditCancel.Name = "btnEditCancel";
			this.btnEditCancel.Size = new System.Drawing.Size(88, 23);
			this.btnEditCancel.TabIndex = 22;
			this.btnEditCancel.Text = "Edit Cancel";
			this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox6.Location = new System.Drawing.Point(96, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(10, 23);
			this.pictureBox6.TabIndex = 21;
			this.pictureBox6.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.btnView);
			this.panel6.Controls.Add(this.button1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 336);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(136, 40);
			this.panel6.TabIndex = 23;
			// 
			// btnView
			// 
			this.btnView.BackColor = System.Drawing.SystemColors.Control;
			this.btnView.Location = new System.Drawing.Point(8, 8);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(40, 23);
			this.btnView.TabIndex = 20;
			this.btnView.Text = "View";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(56, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 23);
			this.button1.TabIndex = 22;
			this.button1.Text = "Compare";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
			this.btnAdd.Location = new System.Drawing.Point(0, 8);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(40, 23);
			this.btnAdd.TabIndex = 21;
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pnlGraphOption2
			// 
			this.pnlGraphOption2.Controls.Add(this.btnAdd);
			this.pnlGraphOption2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGraphOption2.Enabled = false;
			this.pnlGraphOption2.Location = new System.Drawing.Point(136, 336);
			this.pnlGraphOption2.Name = "pnlGraphOption2";
			this.pnlGraphOption2.Size = new System.Drawing.Size(64, 40);
			this.pnlGraphOption2.TabIndex = 23;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.pnlGraphOption2);
			this.panel7.Controls.Add(this.panel6);
			this.panel7.Controls.Add(this.pnlGraphOption);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel7.Location = new System.Drawing.Point(500, 186);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(200, 376);
			this.panel7.TabIndex = 24;
			// 
			// ucMaterialDatabase_Search
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.plotter1);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ucMaterialDatabase_Search";
			this.Size = new System.Drawing.Size(710, 572);
			this.Load += new System.EventHandler(this.ucMaterialDatabase_Search_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnlGraphOption.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.pnlGraphOption2.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ucMaterialDatabase_Search_Load(object sender, System.EventArgs e)
		{
			//GraphDraw();
			SearchResultList_Init();
		}

		private void lstSearchResultList_DoubleClick(object sender, System.EventArgs e)
		{
			pnlGraphOption.Enabled = true;
			pnlGraphOption2.Enabled = true;

			// 클릭된 로우의 데이터를 MPALayer1 클레스에 복사하는 루틴 추가

			//

//			if(bIsSingle == true)
//			{
			strSearchResult_Selected_ID = lstSearchResultList.SelectedItems[0].Text;
			strSelectedName = lstSearchResultList.SelectedItems[0].SubItems[1].Text;
//			}
//			else
//			{
//				//strID = lstSearchResultList.SelectedItems[20].Text;
//			}

			if(((frmMD_Main)this.ParentForm).bIsSearchPopup == false)
			{
				IsGraphExist();
				if(bIsSingle == true)
				{
					clsParameter clsParameter1 = new clsParameter();

					clsParameter1.str_ID = lstSearchResultList.SelectedItems[0].Text;
					clsParameter1.strName = lstSearchResultList.SelectedItems[0].SubItems[1].Text;
					clsParameter1.strThickness = lstSearchResultList.SelectedItems[0].SubItems[2].Text;
					clsParameter1.strBulkDensity = lstSearchResultList.SelectedItems[0].SubItems[3].Text;
					clsParameter1.strLossFactor = lstSearchResultList.SelectedItems[0].SubItems[4].Text;
					clsParameter1.strFlowResistivity = lstSearchResultList.SelectedItems[0].SubItems[5].Text;
					clsParameter1.strYoungsModulus = lstSearchResultList.SelectedItems[0].SubItems[6].Text;
					clsParameter1.strPoissionsRatio = lstSearchResultList.SelectedItems[0].SubItems[7].Text;
					clsParameter1.strThermalCharLength = lstSearchResultList.SelectedItems[0].SubItems[8].Text;
					clsParameter1.strViscousCharLength = lstSearchResultList.SelectedItems[0].SubItems[9].Text;
					clsParameter1.strProsity = lstSearchResultList.SelectedItems[0].SubItems[10].Text;
					clsParameter1.strStructureFactor = lstSearchResultList.SelectedItems[0].SubItems[11].Text;
					clsParameter1.strM_ID = lstSearchResultList.SelectedItems[0].SubItems[20].Text;

					MD_DB MD_DB1 = new MD_DB();
					DataSet dsSingle = MD_DB1.GetSingleMaterial(clsParameter1.str_ID);

					clsParameter1.strVendor = dsSingle.Tables[0].Rows[0]["Vendor"].ToString();
					clsParameter1.strProducing = dsSingle.Tables[0].Rows[0]["Producing"].ToString();
					clsParameter1.strRemark = dsSingle.Tables[0].Rows[0]["Remark"].ToString();

					dgSingleMaterial_View dgSingleMaterial_View1 = new dgSingleMaterial_View();

					dgSingleMaterial_View1.clsParameter1 = clsParameter1;
					dgSingleMaterial_View1.IsCreate(false);
					dgSingleMaterial_View1.ShowDialog();

					lstSearchResultList.SelectedItems[0].SubItems[2].Text = clsParameter1.strThickness;
					lstSearchResultList.SelectedItems[0].SubItems[3].Text = clsParameter1.strBulkDensity;
					lstSearchResultList.SelectedItems[0].SubItems[4].Text = clsParameter1.strLossFactor;
					lstSearchResultList.SelectedItems[0].SubItems[5].Text = clsParameter1.strFlowResistivity;
					lstSearchResultList.SelectedItems[0].SubItems[6].Text = clsParameter1.strYoungsModulus;
					lstSearchResultList.SelectedItems[0].SubItems[7].Text = clsParameter1.strPoissionsRatio;
					lstSearchResultList.SelectedItems[0].SubItems[8].Text = clsParameter1.strThermalCharLength;
					lstSearchResultList.SelectedItems[0].SubItems[9].Text = clsParameter1.strViscousCharLength;
					lstSearchResultList.SelectedItems[0].SubItems[10].Text = clsParameter1.strProsity;
					lstSearchResultList.SelectedItems[0].SubItems[11].Text = clsParameter1.strStructureFactor;
					lstSearchResultList.SelectedItems[0].SubItems[20].Text = clsParameter1.strM_ID;
				}
				else
				{
					MultiMaterial_View MultiMaterial_View1 = new MultiMaterial_View();
					MultiMaterial_View1.strMID = strSearchResult_Selected_ID;
					MultiMaterial_View1.strName = lstSearchResultList.SelectedItems[0].SubItems[1].Text;
					MultiMaterial_View1.strTotalThick = lstSearchResultList.SelectedItems[0].SubItems[2].Text;
					MultiMaterial_View1.ShowDialog();
				}
			}

			MyListClickedEvent("ListClicked",strSearchResult_Selected_ID,bIsSingle);
		}

		private void lstSearchResultList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//
		}

		private void IsGraphExist()
		{
			//int dID = int.Parse(lstSearchResultList.SelectedItems[0].Text);
			int dID = int.Parse(strSearchResult_Selected_ID);

			MD_DB MD_DB1 = new MD_DB();

			dGraph_ID = MD_DB1.IsGraphExist(bIsSingle,GetMeasured(),GetIncidence(),GetFreqBand(),GetGraphType(),dID);
			if(dGraph_ID >= 0)
			{
				//btnView.Enabled = true;
				btnAdd.Enabled = false;
			}
			else
			{
				//btnView.Enabled = false;
				btnAdd.Enabled = true;
			}
		}

		private void chMeasured_CheckedChanged(object sender, System.EventArgs e)
		{
			IsGraphExist();
		}

		private int GetMeasured()
		{
			if(chMeasured.Checked == true)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}

		private int GetIncidence()
		{
			if(rdoNormal.Checked == true)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}

		private int GetFreqBand()
		{
			if(rdoOctave.Checked == true)
			{
				return 2;
			}
			else if(rdoOctave_3_1.Checked == true)
			{
				return 3;
			}
			else
			{
				return 1;
			}
		}

		private int GetGraphType()
		{
			if(rdoAbsorptionCoefficient_RB.Checked == true)
			{
				return 1;
			}
			else if(rdoAbsorptionCoefficient_AT.Checked == true)
			{
				return 2;
			}
			else
			{
				return 3;
			}
		}

		private void rdoNormal_CheckedChanged(object sender, System.EventArgs e)
		{
			IsGraphExist();
		}

		private void rdoOctave_CheckedChanged(object sender, System.EventArgs e)
		{
			IsGraphExist();
		}

		private void rdoAbsorptionCoefficient_RB_CheckedChanged(object sender, System.EventArgs e)
		{
			IsGraphExist();
		}

		private void rdoAbsorptionCoefficient_AT_CheckedChanged(object sender, System.EventArgs e)
		{
			IsGraphExist();
		}

		private void rdoTransmissionLoss_CheckedChanged(object sender, System.EventArgs e)
		{
			IsGraphExist();
		}

		private void btnView_Click(object sender, System.EventArgs e)
		{
			GraphDraw();
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			if(DialogResult.OK == openFileDialog1.ShowDialog())
			{
				string strFileName = openFileDialog1.FileName;

				FileParsing(strFileName);

				IsGraphExist();
			}
		}

		public void FileParsing(string strFileName)
		{
				MPEClass MPEClass1 = new MPEClass();
				MPEData MPEData1 = MPEClass1.NewMPEData();

				bool result = MPEData1.FileLoad_2(strFileName);
				if(result == false) // 유효한 화일이 아니면 삭제한다
				{
					MPEClass1.DeleteMPEData(MPEData1);
				}
				else
				{
					Save(MPEData1);
				}
		}

		public void Save(MPEData MPEData1)
		{
			int dID = int.Parse(strSearchResult_Selected_ID);

			HONUS.MaterialPerformanceAnalysis.Component.MPA_DB MPA_DB1 = new HONUS.MaterialPerformanceAnalysis.Component.MPA_DB();
			
			if(bIsSingle == true)
			{
				int dMax_ID_SingleMeterialGraph = MPA_DB1.GetMax_ID_SingleMeterialGraph();

				if(GetGraphType().ToString() == "1")
				{
					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),MPEData1.MAbsorption.GetString(),"","");
				}
				else if(GetGraphType().ToString() == "2")
				{
					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),"",MPEData1.MAbsorption.GetString(),"");
				}
				else if(GetGraphType().ToString() == "3")
				{
					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),"","",MPEData1.MAbsorption.GetString());
				}
			}
			else
			{
				int dMax_ID_MultiMeterialGraph = MPA_DB1.GetMax_ID_MultiLayerMaterialGraph();

				if(GetGraphType().ToString() == "1")
				{
					MPA_DB1.CreateMultiMaterialGraph(dMax_ID_MultiMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),MPEData1.MAbsorption.GetString(),"","");
				}
				else if(GetGraphType().ToString() == "2")
				{
					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_MultiMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),"",MPEData1.MAbsorption.GetString(),"");
				}
				else if(GetGraphType().ToString() == "3")
				{
					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_MultiMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),"","",MPEData1.MAbsorption.GetString());
				}
			}
			
		}

		private void btnCreate_Click(object sender, System.EventArgs e)
		{
			clsParameter clsParameter1 = new clsParameter();

			dgSingleMaterial_View dgSingleMaterial_View1 = new dgSingleMaterial_View();

			dgSingleMaterial_View1.clsParameter1 = clsParameter1;
			dgSingleMaterial_View1.IsCreate(true);
			dgSingleMaterial_View1.ShowDialog();

			ListViewItem item = new ListViewItem();
			item.SubItems[0].Text = clsParameter1.str_ID;
				
			item.SubItems.Add(clsParameter1.strName);
			item.SubItems.Add(clsParameter1.strThickness);
			item.SubItems.Add(clsParameter1.strBulkDensity);
			item.SubItems.Add(clsParameter1.strLossFactor);
			item.SubItems.Add(clsParameter1.strFlowResistivity);
			item.SubItems.Add(clsParameter1.strYoungsModulus);
			item.SubItems.Add(clsParameter1.strPoissionsRatio);
			item.SubItems.Add(clsParameter1.strThermalCharLength);
			item.SubItems.Add(clsParameter1.strViscousCharLength);
			item.SubItems.Add(clsParameter1.strProsity);
			item.SubItems.Add(clsParameter1.strStructureFactor);
			item.SubItems.Add("0");
			item.SubItems.Add("0");
			item.SubItems.Add("0");
			item.SubItems.Add("0");
			item.SubItems.Add("0");
			item.SubItems.Add("0");
			item.SubItems.Add("0");
			item.SubItems.Add("0");
			item.SubItems.Add(clsParameter1.strM_ID);

			lstSearchResultList.Items.Add(item);
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			string [] strIDs = new string[lstSearchResultList.SelectedItems.Count];

			for(int i = 0 ; i < lstSearchResultList.SelectedItems.Count ; i++)
			{
				strIDs[i] = lstSearchResultList.SelectedItems[i].Text;
			}

			dgMultyGraph dgMultyGraph1 = new dgMultyGraph();
			dgMultyGraph1.bIsSingle = bIsSingle;
			dgMultyGraph1.strID = strIDs;
			dgMultyGraph1.Measured = GetMeasured();
			dgMultyGraph1.Incidence = GetIncidence();
			dgMultyGraph1.FreqBand = GetFreqBand();
			dgMultyGraph1.ShowDialog();
		}
	}
}
