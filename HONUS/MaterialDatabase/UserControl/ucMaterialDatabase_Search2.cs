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
	public class ucMaterialDatabase_Search2 : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.ListView lstSearchResultList;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public delegate void MyListClickedDelegate(string strName,string strAddition,bool bIsSingle);
		public event MyListClickedDelegate MyListClickedEvent;

		//MPALayer MPALayer1;
		DataSet dsSearchResult;
		string strSearchResult_Selected_ID;
		string strSingle_Multi;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;

		bool bIsSingle = true;
		string strSelectedName = "";
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;

		//int dGraph_ID;

		private string strMeterialTypeChange = "";

		public ucMaterialDatabase_Search2()
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

//		public void GraphDraw_Multi(string strType)
//		{
//			DataPlotter.DataSeries pSeries1 = new DataPlotter.DataSeries();
//
//			//plotter1.ColorBg = Color.LightYellow;
//			plotter1.ColorGrid = Color.LightGray;
//			plotter1.XLogBase = 0;
//			plotter1.XRangeStart = -100;
//			plotter1.XRangeEnd = 1000;
//			plotter1.XGrid = 100;
//			plotter1.YLogBase = 0;
//			plotter1.YRangeStart = -10;
//			plotter1.YRangeEnd = 10;
//			plotter1.YGrid = 2;
//			plotter1.Series.Clear();
//
//			pSeries1.Name  = "Data 01";
//			pSeries1.Color = Color.Blue ;
//
//			bool DataExist = false;
//
//			MPALayer1 = new MPALayer();
//			MPALayer1.LID = int.Parse(strSearchResult_Selected_ID);
//			MPALayer1.DBLoad();
//
//			if(MPALayer1 != null)
//			{
//				#region 예전
////				object [] ar = new object[3];
////
////				DataTable table = new DataTable();
////
////				table.Columns.Add("GroupName",typeof(int));
////				table.Columns.Add("my_X",typeof(double));
////				table.Columns.Add("my_Y",typeof(double));
//				#endregion
//
//				if(strType == "")
//				{
//					strType = "Absorption Coefficient for rigid backing";
//				}
//
//				if(strType == "Absorption Coefficient for rigid backing")
//				{
//					#region 예전
////					for(int i = 0 ; i < MPALayer1.Frequency.GetCount() ; i++)
////					{
////						DataRow row = table.NewRow();
////						ar[0] = i.ToString();
////						ar[1] = MPALayer1.Frequency.GetData(i).ToString();
////						ar[2] = MPALayer1.RigidBacking.GetData(i).ToString();
////						row.ItemArray = ar;
////						table.Rows.Add(row);
////
////						DataExist = true;
////					}
//					#endregion
//
//					DataExist = true;
//
//					pSeries1.XData = MPALayer1.Frequency.GetData();
//					pSeries1.YData = MPALayer1.RigidBacking.GetData();
//				}
//				else if(strType == "Absorption Coefficient for anechoic termination")
//				{
//					#region 예전
////					for(int i = 0 ; i < MPALayer1.Frequency.GetCount() ; i++)
////					{
////						DataRow row = table.NewRow();
////						ar[0] = i.ToString();
////						ar[1] = MPALayer1.Frequency.GetData(i).ToString();
////						ar[2] = MPALayer1.AnechoicTermination.GetData(i).ToString();
////						row.ItemArray = ar;
////						table.Rows.Add(row);
////
////						DataExist = true;
////					}
//					#endregion
//
//					DataExist = true;
//
//					pSeries1.XData = MPALayer1.Frequency.GetData();
//					pSeries1.YData = MPALayer1.AnechoicTermination.GetData();
//				}
//				else if(strType == "Transmission Loss")
//				{
//					#region 예전
////					for(int i = 0 ; i < MPALayer1.Frequency.GetCount() ; i++)
////					{
////						DataRow row = table.NewRow();
////						ar[0] = i.ToString();
////						ar[1] = MPALayer1.Frequency.GetData(i).ToString();
////						ar[2] = MPALayer1.TransmissionLoss.GetData(i).ToString();
////						row.ItemArray = ar;
////						table.Rows.Add(row);
////
////						DataExist = true;
////					}
//					#endregion
//
//					DataExist = true;
//
//					pSeries1.XData = MPALayer1.Frequency.GetData();
//					pSeries1.YData = MPALayer1.TransmissionLoss.GetData();
//				}
//
//				if(DataExist == true)
//				{
//					#region 예전
////					ultraChart1.DataSource = table;
////					ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
////					ultraChart1.ScatterChart.ConnectWithLines = true;
//					#endregion
//
//					plotter1.Series.Add(pSeries1);
//					plotter1.Refresh();
//				}
////				else
////				{
////					NullGraph();
////				}
//			}
////			else
////			{
////				NullGraph();
////			}
//		}

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

//		public void GraphDraw()
//		{
//			DataPlotter.DataSeries pSeries1 = new DataPlotter.DataSeries();
//
//			//plotter1.ColorBg = Color.LightYellow;
//			plotter1.ColorGrid = Color.LightGray;
//			plotter1.XLogBase = 0;
//			plotter1.XRangeStart = -100;
//			plotter1.XRangeEnd = 1000;
//			plotter1.XGrid = 100;
//			plotter1.YLogBase = 0;
//			plotter1.YRangeStart = -10;
//			plotter1.YRangeEnd = 10;
//			plotter1.YGrid = 2;
//			plotter1.Series.Clear();
//
//			pSeries1.Name  = "Data 01";
//			pSeries1.Color = Color.Blue ;
//
//			bool DataExist = false;
//
//			MPEData MPEData1 = new MPEData();
//
//			if(MPEData1.DBLoad(bIsSingle,dGraph_ID) == true)
//			{
//				#region 예전
////				object [] ar = new object[3];
////
////				DataTable table = new DataTable();
////
////				table.Columns.Add("GroupName",typeof(int));
////				table.Columns.Add("my_X",typeof(double));
////				table.Columns.Add("my_Y",typeof(double));
//				
////				for(int i = 0 ; i < MPEData1.Frequency.GetCount() ; i++)
////				{
////					DataRow row = table.NewRow();
////					ar[0] = i.ToString();
////					ar[1] = MPEData1.Frequency.GetData(i).ToString();
////					ar[2] = MPEData1.MAbsorption.GetData(i).ToString();
////					row.ItemArray = ar;
////					table.Rows.Add(row);
////
////					DataExist = true;
////				}
//				#endregion
//
//				DataExist = true;
//
//				pSeries1.XData = MPEData1.Frequency.GetData();
//				pSeries1.YData = MPEData1.MAbsorption.GetData();
//
//				if(DataExist == true)
//				{
//					#region 예전
////					ultraChart1.DataSource = table;
////					ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
////					ultraChart1.ScatterChart.ConnectWithLines = true;
//					#endregion
//
//					plotter1.Series.Add(pSeries1);
//					plotter1.Refresh();
//				}
//			}
//		}

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
			col.Text = "FlowResistivity";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "LossFactor";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "BulkDensity";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "YoungsModulus";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "PoissionsRatio";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "ThermalCharLength";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "ViscousCharLength";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Prosity";
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
						lstSearchResultList.Columns[2].Width = 100;
						break;
					case "Panel" :
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[6].Width = 100;
						lstSearchResultList.Columns[7].Width = 100;
						break;
					case "Impermeable membrane" :
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						break;
					case "Permeable membrane" :
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						break;
					case "Limp porous material" :
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						lstSearchResultList.Columns[11].Width = 100;
						lstSearchResultList.Columns[10].Width = 100;
						lstSearchResultList.Columns[8].Width = 100;
						lstSearchResultList.Columns[9].Width = 100;
						break;
					case "Rigid porous material" :
						lstSearchResultList.Columns[2].Width = 100;
						lstSearchResultList.Columns[5].Width = 100;
						lstSearchResultList.Columns[3].Width = 100;
						lstSearchResultList.Columns[11].Width = 100;
						lstSearchResultList.Columns[10].Width = 100;
						lstSearchResultList.Columns[8].Width = 100;
						lstSearchResultList.Columns[9].Width = 100;
						break;
					case "Elastic porous material" :
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
			string strSID_Temp = "";

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
					dsSearchResult = MD_DB1.Search_Parameter(Category,IncidenceCondition,MaterialType,"0",clsParameters1.strName,strVendor,strProducing,strDate,dMeasured);
					strIDs = ParametersCheck(dsSearchResult,clsParameters1);

					bFlag = true;
					break;
				case "MultiLayer":
					dsSearchResult = MD_DB1.Search("Multi",IncidenceCondition,MaterialType,Frequency,"",strVendor,strProducing,strDate,dMeasured);
					Category = "Multi";
					strIDs = MultiLayerCheck(dsSearchResult,clsMultiLayer_Find1.strName,clsMultiLayer_Find1.strTotalThick);
					bFlag = true;
					break;
				case "Select":
					dsSearchResult = MD_DB1.Search(Category,IncidenceCondition,MaterialType,"0","",strVendor,strProducing,strDate,dMeasured);
					bFlag = true;
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
						if(strSID_Temp != dsSearchResult.Tables[0].Rows[i]["SID"].ToString())
						{
							strSID_Temp = dsSearchResult.Tables[0].Rows[i]["SID"].ToString();

							item.SubItems[0].Text = dsSearchResult.Tables[0].Rows[i]["SID"].ToString();
				
							item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Name"].ToString());
							item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Thick"].ToString());
							item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["FlowRes"].ToString());
							item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["LossFactor"].ToString());
							item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["BulkDens"].ToString());
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

							lstSearchResultList.Items.Add(item);
						}

						bIsSingle = true;
					}
					else
					{
						item.SubItems[0].Text = dsSearchResult.Tables[0].Rows[i]["LID"].ToString();
				
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["MultiLayer.Name"].ToString());
						item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["TotalThick"].ToString());

						bIsSingle = false;

						lstSearchResultList.Items.Add(item);
					}

					//strSearchResult_Selected_ID = item.SubItems[0].Text;
				}
			}

			if(dsSearchResult == null || dsSearchResult.Tables[0].Rows.Count == 0)
			{
				MessageBox.Show("검색 결과가 없습니다");
			}

			//pnlGraphOption.Enabled = false;
			
		}

		public void AfterSearch(string Category,string strDate,string strDate2)
		{
			
			DataRow [] dimRow = dsSearchResult.Tables[0].Select("Occurred_Date >= '" + strDate + "' AND Occurred_Date <= '" + strDate2 + "'");

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

				for(int i = 0 ; i < dimRow.Length ; i++)
				{
					ListViewItem item = new ListViewItem();

					if(Category == "Single")
					{
						item.SubItems[0].Text = dimRow[i]["SID"].ToString();
				
						item.SubItems.Add(dimRow[i]["Name"].ToString());
						item.SubItems.Add(dimRow[i]["Thick"].ToString());
						item.SubItems.Add(dimRow[i]["FlowRes"].ToString());
						item.SubItems.Add(dimRow[i]["LossFactor"].ToString());
						item.SubItems.Add(dimRow[i]["BulkDens"].ToString());
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

			//pnlGraphOption.Enabled = false;
			
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

//						if(cls.str16 != "")
//						{
//							temp_cls = double.Parse(cls.str16);
//							temp_db = double.Parse(Y_16);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str31_5 != "")
//						{
//							temp_cls = double.Parse(cls.str31_5);
//							temp_db = double.Parse(Y_31_5);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str63 != "")
//						{
//							temp_cls = double.Parse(cls.str63);
//							temp_db = double.Parse(Y_63);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str125 != "")
//						{
//							temp_cls = double.Parse(cls.str125);
//							temp_db = double.Parse(Y_125);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str250 != "")
//						{
//							temp_cls = double.Parse(cls.str250);
//							temp_db = double.Parse(Y_250);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
						if(cls.str500 != "")
						{
							temp_cls = double.Parse(cls.str500);
							temp_db = double.Parse(Y_500);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str1000 != "")
						{
							temp_cls = double.Parse(cls.str1000);
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str2000 != "")
						{
							temp_cls = double.Parse(cls.str2000);
							temp_db = double.Parse(Y_2000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str4000 != "")
						{
							temp_cls = double.Parse(cls.str4000);
							temp_db = double.Parse(Y_4000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str8000 != "")
						{
							temp_cls = double.Parse(cls.str8000);
							temp_db = double.Parse(Y_8000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str10000 != "")
						{
							if(Y_10000 == "")
							{
								Y_10000 = "0";
							}

							temp_cls = double.Parse(cls.str10000);
							temp_db = double.Parse(Y_10000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
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
					strIDs = strIDs + ds.Tables[0].Rows[i][0].ToString() + ",";
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

//						if(cls.str16 != "")
//						{
//							temp_cls = double.Parse(cls.str16);
//							temp_db = double.Parse(Y_16);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str31_5 != "")
//						{
//							temp_cls = double.Parse(cls.str31_5);
//							temp_db = double.Parse(Y_31_5);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str63 != "")
//						{
//							temp_cls = double.Parse(cls.str63);
//							temp_db = double.Parse(Y_63);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str125 != "")
//						{
//							temp_cls = double.Parse(cls.str125);
//							temp_db = double.Parse(Y_125);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str250 != "")
//						{
//							temp_cls = double.Parse(cls.str250);
//							temp_db = double.Parse(Y_250);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
						if(cls.str500 != "")
						{
							temp_cls = double.Parse(cls.str500);
							temp_db = double.Parse(Y_500);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str1000 != "")
						{
							temp_cls = double.Parse(cls.str1000);
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str2000 != "")
						{
							temp_cls = double.Parse(cls.str2000);
							temp_db = double.Parse(Y_2000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str4000 != "")
						{
							temp_cls = double.Parse(cls.str4000);
							temp_db = double.Parse(Y_4000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str8000 != "")
						{
							temp_cls = double.Parse(cls.str8000);
							temp_db = double.Parse(Y_8000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
						}
						if(cls.str10000 != "")
						{
							temp_cls = double.Parse(cls.str10000);
							temp_db = double.Parse(Y_10000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
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
					strIDs = strIDs + ds.Tables[0].Rows[i][0].ToString() + ",";
				}
			}

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

//						if(cls.str16 != "")
//						{
//							if(cls.strAlpha == "")
//							{
//								temp_cls = double.Parse(cls.str16);
//							}
//							else
//							{
//								temp_cls = double.Parse(cls.strAlpha);
//							}
//							temp_cls = Math.Log10(16) + temp_cls;
//							temp_db = double.Parse(Y_16);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str31_5 != "")
//						{
//							if(cls.strAlpha == "")
//							{
//								temp_cls = double.Parse(cls.str31_5);
//							}
//							else
//							{
//								temp_cls = double.Parse(cls.strAlpha);
//							}
//							temp_cls = Math.Log10(31.5) + temp_cls;
//							temp_db = double.Parse(Y_31_5);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str63 != "")
//						{
//							if(cls.strAlpha == "")
//							{
//								temp_cls = double.Parse(cls.str63);
//							}
//							else
//							{
//								temp_cls = double.Parse(cls.strAlpha);
//							}
//							temp_cls = Math.Log10(63) + temp_cls;
//							temp_db = double.Parse(Y_63);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str125 != "")
//						{
//							if(cls.strAlpha == "")
//							{
//								temp_cls = double.Parse(cls.str125);
//							}
//							else
//							{
//								temp_cls = double.Parse(cls.strAlpha);
//							}
//							temp_cls = Math.Log10(125) + temp_cls;
//							temp_db = double.Parse(Y_125);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
//						if(cls.str250 != "")
//						{
//							if(cls.strAlpha == "")
//							{
//								temp_cls = double.Parse(cls.str250);
//							}
//							else
//							{
//								temp_cls = double.Parse(cls.strAlpha);
//							}
//							temp_cls = Math.Log10(250) + temp_cls;
//							temp_db = double.Parse(Y_250);
//							if(temp_cls > temp_db)
//							{
//								bResult = false;
//							}
//						}
						if(cls.str500 != "")
						{
							if(cls.strAlpha == "")
							{
								temp_cls = double.Parse(cls.str500);
							}
							else
							{
								temp_cls = double.Parse(cls.strAlpha);
							}
							temp_cls = Math.Log10(500) + temp_cls;
							temp_db = double.Parse(Y_500);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
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
							}
							temp_cls = Math.Log10(1000) + temp_cls;
							temp_db = double.Parse(Y_1000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
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
							}
							temp_cls = Math.Log10(2000) + temp_cls;
							temp_db = double.Parse(Y_2000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
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
							}
							temp_cls = Math.Log10(4000) + temp_cls;
							temp_db = double.Parse(Y_4000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
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
							}
							temp_cls = Math.Log10(8000) + temp_cls;
							temp_db = double.Parse(Y_8000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
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
							}
							temp_cls = Math.Log10(10000) + temp_cls;
							temp_db = double.Parse(Y_10000);
							if(temp_cls > temp_db)
							{
								bResult = false;
							}
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
					strIDs = strIDs + ds.Tables[0].Rows[i][0].ToString() + ",";
				}
			}

			if(strIDs != "")
			{
				strIDs = strIDs.Substring(0,strIDs.Length - 1);
			}
			
			return strIDs;
		}
		
		private string ParametersCheck(DataSet ds,clsParameters cls)
		{
			string strIDs = "";

			for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++)
			{
				bool bResult = true;

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
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lstSearchResultList = new System.Windows.Forms.ListView();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label11.Location = new System.Drawing.Point(0, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(690, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = "Searching Result";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 10);
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
			this.pictureBox3.Location = new System.Drawing.Point(700, 20);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 542);
			this.pictureBox3.TabIndex = 12;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox4.Location = new System.Drawing.Point(0, 20);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 542);
			this.pictureBox4.TabIndex = 13;
			this.pictureBox4.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lstSearchResultList);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(10, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(690, 518);
			this.panel1.TabIndex = 14;
			// 
			// lstSearchResultList
			// 
			this.lstSearchResultList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstSearchResultList.FullRowSelect = true;
			this.lstSearchResultList.GridLines = true;
			this.lstSearchResultList.Location = new System.Drawing.Point(0, 16);
			this.lstSearchResultList.Name = "lstSearchResultList";
			this.lstSearchResultList.Size = new System.Drawing.Size(690, 502);
			this.lstSearchResultList.TabIndex = 1;
			this.lstSearchResultList.View = System.Windows.Forms.View.Details;
			this.lstSearchResultList.DoubleClick += new System.EventHandler(this.lstSearchResultList_DoubleClick);
			this.lstSearchResultList.SelectedIndexChanged += new System.EventHandler(this.lstSearchResultList_SelectedIndexChanged);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox5.Location = new System.Drawing.Point(0, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(710, 10);
			this.pictureBox5.TabIndex = 16;
			this.pictureBox5.TabStop = false;
			// 
			// ucMaterialDatabase_Search2
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox5);
			this.Name = "ucMaterialDatabase_Search2";
			this.Size = new System.Drawing.Size(710, 572);
			this.Load += new System.EventHandler(this.ucMaterialDatabase_Search_Load);
			this.panel1.ResumeLayout(false);
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
			//pnlGraphOption.Enabled = true;

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

			if(((frmMD_Main2)this.ParentForm).bIsSearchPopup == false)
			{
				//IsGraphExist();
				if(bIsSingle == true)
				{
					clsParameter clsParameter1 = new clsParameter();

					clsParameter1.str_ID = lstSearchResultList.SelectedItems[0].Text;
					clsParameter1.strName = lstSearchResultList.SelectedItems[0].SubItems[1].Text;
					clsParameter1.strThickness = lstSearchResultList.SelectedItems[0].SubItems[2].Text;
					clsParameter1.strFlowResistivity = lstSearchResultList.SelectedItems[0].SubItems[3].Text;
					clsParameter1.strLossFactor = lstSearchResultList.SelectedItems[0].SubItems[4].Text;
					clsParameter1.strBulkDensity= lstSearchResultList.SelectedItems[0].SubItems[5].Text;
					clsParameter1.strYoungsModulus = lstSearchResultList.SelectedItems[0].SubItems[6].Text;
					clsParameter1.strPoissionsRatio = lstSearchResultList.SelectedItems[0].SubItems[7].Text;
					clsParameter1.strThermalCharLength = lstSearchResultList.SelectedItems[0].SubItems[8].Text;
					clsParameter1.strViscousCharLength = lstSearchResultList.SelectedItems[0].SubItems[9].Text;
					clsParameter1.strProsity = lstSearchResultList.SelectedItems[0].SubItems[10].Text;
					clsParameter1.strStructureFactor = lstSearchResultList.SelectedItems[0].SubItems[11].Text;
					clsParameter1.strM_ID = lstSearchResultList.SelectedItems[0].SubItems[20].Text;

					dgSingleMaterial_View dgSingleMaterial_View1 = new dgSingleMaterial_View();

					dgSingleMaterial_View1.clsParameter1 = clsParameter1;
					dgSingleMaterial_View1.IsCreate(false);
					dgSingleMaterial_View1.ShowDialog();

					lstSearchResultList.SelectedItems[0].SubItems[2].Text = clsParameter1.strThickness;
					lstSearchResultList.SelectedItems[0].SubItems[3].Text = clsParameter1.strFlowResistivity;
					lstSearchResultList.SelectedItems[0].SubItems[4].Text = clsParameter1.strLossFactor;
					lstSearchResultList.SelectedItems[0].SubItems[5].Text = clsParameter1.strBulkDensity;
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

//		private void IsGraphExist()
//		{
//			//int dID = int.Parse(lstSearchResultList.SelectedItems[0].Text);
//			int dID = int.Parse(strSearchResult_Selected_ID);
//
//			MD_DB MD_DB1 = new MD_DB();
//
//			dGraph_ID = MD_DB1.IsGraphExist(bIsSingle,GetMeasured(),GetIncidence(),GetFreqBand(),GetGraphType(),dID);
////			if(dGraph_ID >= 0)
////			{
////				btnView.Enabled = true;
////				btnAdd.Enabled = false;
////			}
////			else
////			{
////				btnView.Enabled = false;
////				btnAdd.Enabled = true;
////			}
//		}

		private void chMeasured_CheckedChanged(object sender, System.EventArgs e)
		{
			//IsGraphExist();
		}

//		private int GetMeasured()
//		{
//			if(chMeasured.Checked == true)
//			{
//				return 1;
//			}
//			else
//			{
//				return 2;
//			}
//		}
//
//		private int GetIncidence()
//		{
//			if(rdoNormal.Checked == true)
//			{
//				return 1;
//			}
//			else
//			{
//				return 2;
//			}
//		}
//
//		private int GetFreqBand()
//		{
//			if(rdoOctave.Checked == true)
//			{
//				return 1;
//			}
//			else
//			{
//				return 2;
//			}
//		}
//
//		private int GetGraphType()
//		{
//			if(rdoAbsorptionCoefficient_RB.Checked == true)
//			{
//				return 1;
//			}
//			else if(rdoAbsorptionCoefficient_AT.Checked == true)
//			{
//				return 2;
//			}
//			else
//			{
//				return 3;
//			}
//		}

//		private void rdoNormal_CheckedChanged(object sender, System.EventArgs e)
//		{
//			IsGraphExist();
//		}
//
//		private void rdoOctave_CheckedChanged(object sender, System.EventArgs e)
//		{
//			IsGraphExist();
//		}
//
//		private void rdoAbsorptionCoefficient_RB_CheckedChanged(object sender, System.EventArgs e)
//		{
//			IsGraphExist();
//		}
//
//		private void rdoAbsorptionCoefficient_AT_CheckedChanged(object sender, System.EventArgs e)
//		{
//			IsGraphExist();
//		}
//
//		private void rdoTransmissionLoss_CheckedChanged(object sender, System.EventArgs e)
//		{
//			IsGraphExist();
//		}
//
//		private void btnView_Click(object sender, System.EventArgs e)
//		{
//			int dGraphType = GetGraphType();
//
//			if(dGraphType == 1)
//			{
//				GraphDraw();
//			}
//			else if(dGraphType == 2)
//			{
//				GraphDraw();
//			}
//			else if(dGraphType == 3)
//			{
//				GraphDraw();
//			}			
//		}

//		private void btnAdd_Click(object sender, System.EventArgs e)
//		{
//			if(DialogResult.OK == openFileDialog1.ShowDialog())
//			{
//				string strFileName = openFileDialog1.FileName;
//
//				FileParsing(strFileName);
//
//				IsGraphExist();
//			}
//		}

//		public void FileParsing(string strFileName)
//		{
//				MPEClass MPEClass1 = new MPEClass();
//				MPEData MPEData1 = MPEClass1.NewMPEData();
//
//				bool result = MPEData1.FileLoad_2(strFileName);
//				if(result == false) // 유효한 화일이 아니면 삭제한다
//				{
//					MPEClass1.DeleteMPEData(MPEData1);
//				}
//				else
//				{
//					Save(MPEData1);
//				}
//		}

//		public void Save(MPEData MPEData1)
//		{
//			int dID = int.Parse(strSearchResult_Selected_ID);
//
//			HONUS.MaterialPerformanceAnalysis.Component.MPA_DB MPA_DB1 = new HONUS.MaterialPerformanceAnalysis.Component.MPA_DB();
//			
//			if(bIsSingle == true)
//			{
//				int dMax_ID_SingleMeterialGraph = MPA_DB1.GetMax_ID_SingleMeterialGraph();
//
//				if(GetGraphType().ToString() == "1")
//				{
//					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
//						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),MPEData1.MAbsorption.GetString(),"","");
//				}
//				else if(GetGraphType().ToString() == "2")
//				{
//					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
//						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),"",MPEData1.MAbsorption.GetString(),"");
//				}
//				else if(GetGraphType().ToString() == "3")
//				{
//					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_SingleMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
//						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),"","",MPEData1.MAbsorption.GetString());
//				}
//			}
//			else
//			{
//				int dMax_ID_MultiMeterialGraph = MPA_DB1.GetMax_ID_MultiLayerMaterialGraph();
//
//				if(GetGraphType().ToString() == "1")
//				{
//					MPA_DB1.CreateMultiMaterialGraph(dMax_ID_MultiMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
//						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),MPEData1.MAbsorption.GetString(),"","");
//				}
//				else if(GetGraphType().ToString() == "2")
//				{
//					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_MultiMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
//						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),"",MPEData1.MAbsorption.GetString(),"");
//				}
//				else if(GetGraphType().ToString() == "3")
//				{
//					MPA_DB1.CreateSingleMaterialGraph(dMax_ID_MultiMeterialGraph,dID,strSelectedName,GetMeasured().ToString(),edtTemperature.Text,GetIncidence().ToString()
//						,edtAngle.Text,GetFreqBand().ToString(),GetGraphType().ToString(),MPEData1.Frequency.GetString(),"","",MPEData1.MAbsorption.GetString());
//				}
//			}
//			
//		}

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
			item.SubItems.Add(clsParameter1.strFlowResistivity);
			item.SubItems.Add(clsParameter1.strLossFactor);
			item.SubItems.Add(clsParameter1.strBulkDensity);
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

//		private void propertyGrid1_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
//		{
//			plotter1.Refresh();
//		}

//		private void btnGraphSave_Click(object sender, System.EventArgs e)
//		{
//			saveFileDialog1.Filter = "(*.Bmp)|*.Bmp|(*.Emf)|*.Emf|(*.Exif)|*.Exif|(*.Gif)|*.Gif|(*.Icon)|*.Icon|(*.Jpeg)|*.Jpeg|(*.MemoryBmp)|*.MemoryBmp|(*.Png)|*.Png|(*.Tiff)|*.Tiff|(*.Wmf)|*.Wmf";
//
//			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
//			{
//				string path = saveFileDialog1.FileName;
//				string strExtension = System.IO.Path.GetExtension(saveFileDialog1.FileName);
//				switch(strExtension)
//				{
//					case ".Bmp" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Bmp);
//						break;
//					case ".Emf" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Emf);
//						break;
//					case ".Exif" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Exif);
//						break;
//					case ".Gif" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Gif);
//						break;
//					case ".Icon" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Icon);
//						break;
//					case ".Jpeg" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Jpeg);
//						break;
//					case ".MemoryBmp" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.MemoryBmp);
//						break;
//					case ".Png" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Png);
//						break;
//					case ".Tiff" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Tiff);
//						break;
//					case ".Wmf" :
//						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Wmf);
//						break;
//				}
//			}
//		}
//
//		private void btnGraphEdit_Click(object sender, System.EventArgs e)
//		{
//			propertyGrid1.Visible = true;
//
//			btnGraphEdit.Enabled = false;
//			btnEditCancel.Enabled = true;
//		}

//		private void btnEditCancel_Click(object sender, System.EventArgs e)
//		{
//			propertyGrid1.Visible = false;
//
//			btnGraphEdit.Enabled = true;
//			btnEditCancel.Enabled = false;
//		}
	}
}
