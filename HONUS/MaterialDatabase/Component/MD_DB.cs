using System;
using System.Data;

using HONUS.Common_Class;
using HONUS.MaterialDatabase.Form;

namespace HONUS.MaterialDatabase.Component
{
	/// <summary>
	/// MD_DB에 대한 요약 설명입니다.
	/// </summary>
	public class MD_DB
	{
		Common_DataBase common_DataBase;

		public MD_DB()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		/// <summary>
		/// 이미 중복되는 이름이 있는지 확인
		/// </summary>
		/// <param name="strName"></param>
		/// <returns></returns>
		public int ISNameSame(string strName)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("SELECT COUNT(*) FROM SingleMeterial Where Name = '{0}'",strName);

			return int.Parse(common_DataBase.ExecuteScalar_Text());
		}

		/// <summary>
		/// 조회 함수
		/// </summary>
		/// <param name="Category"></param>
		/// <param name="IncidenceCondition"></param>
		/// <param name="MaterialType"></param>
		/// <param name="Option"></param>
		/// <param name="Frequency">1,Narrow band 2,Octave 3,1/3 Octav</param>
		public DataSet Search(string Category,string IncidenceCondition,string MaterialType,string Frequency,string strName,
			string strVendor,string strProducing,string strDate,int dMeasured)
		{
			common_DataBase = new Common_DataBase();
			if(MaterialType != "0")
			{
				if(Category == "Single")
				{
					if(strName != "")
					{
						if(Frequency == "0")
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where (Vendor LIKE '%{3}%' OR Vendor IS NULL) AND (Producing LIKE '%{4}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1} AND Name LIKE '%{2}%' ORDER BY SID",IncidenceCondition,MaterialType,strName,strVendor,strProducing,strDate);
						}
						else
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where (Vendor LIKE '%{4}%' OR Vendor IS NULL) AND (Producing LIKE '%{5}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1} AND FreqBand = {2} AND Name LIKE '%{3}%' ORDER BY SID",IncidenceCondition,MaterialType,Frequency,strName,strVendor,strProducing,strDate);
						}
					}
					else
					{
						if(Frequency == "0")
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where (Vendor LIKE '%{2}%' OR Vendor IS NULL) AND (Producing LIKE '%{3}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1} ORDER BY SID",IncidenceCondition,MaterialType,strVendor,strProducing,strDate);
						}
						else
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where (Vendor LIKE '%{3}%' OR Vendor IS NULL) AND (Producing LIKE '%{4}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1} AND FreqBand = {2} ORDER BY SID",IncidenceCondition,MaterialType,Frequency,strVendor,strProducing,strDate);
						}
					}
				}
				else
				{
					if(strName != "")
					{
						if(Frequency == "0")
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1} AND MultiLayer.Name LIKE '%{2}%'",IncidenceCondition,MaterialType,strName);
						}
						else
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1} AND FreqBand = {2} AND MultiLayer.Name LIKE '%{3}%'",IncidenceCondition,MaterialType,Frequency,strName);
						}
					}
					else
					{
						if(Frequency == "0")
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1}",IncidenceCondition,MaterialType);
						}
						else
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1} AND FreqBand = {2} ",IncidenceCondition,MaterialType,Frequency);
						}
					}
				}
			}
			else
			{
				if(Category == "Single")
				{
					if(strName != "")
					{
						if(Frequency == "0")
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where (Vendor LIKE '%{2}%' OR Vendor IS NULL) AND (Producing LIKE '%{3}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND Name LIKE '%{1}%' ORDER BY SID",IncidenceCondition,strName,strVendor,strProducing,strDate);
						}
						else
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where (Vendor LIKE '%{3}%' OR Vendor IS NULL) AND (Producing LIKE '%{4}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND FreqBand = {1} AND Name LIKE '%{2}%' ORDER BY SID",IncidenceCondition,Frequency,strName,strVendor,strProducing,strDate);
						}
					}
					else
					{
						if(Frequency == "0")
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where (Vendor LIKE '%{1}%' OR Vendor IS NULL) AND (Producing LIKE '%{2}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} ORDER BY SID",IncidenceCondition,strVendor,strProducing,strDate);
						}
						else
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where (Vendor LIKE '%{2}%' OR Vendor IS NULL) AND (Producing LIKE '%{3}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND FreqBand = {1} ORDER BY SID",IncidenceCondition,Frequency,strVendor,strProducing,strDate);
						}
					}
				}
				else
				{
					if(strName != "")
					{
						if(Frequency == "0")
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND Name LIKE '%{1}%'",IncidenceCondition,strName);
						}
						else
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND FreqBand = {1} AND Name LIKE '%{2}%'",IncidenceCondition,Frequency,strName);
						}
					}
					else
					{
						if(Frequency == "0")
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0}",IncidenceCondition);
						}
						else
						{
							common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND FreqBand = {1} ",IncidenceCondition,Frequency);
						}
					}
				}
			}

			DataSet ds = common_DataBase.GetDataSet_Text();

			return ds;
		}

		public DataSet Search_Parameter(string Category,string IncidenceCondition,string MaterialType,string Frequency,string strName,
			string strVendor,string strProducing,string strDate,int dMeasured)
		{
			common_DataBase = new Common_DataBase();
			if(MaterialType != "0")
			{
				if(Category == "Single")
				{
					if(strName != "")
					{

						common_DataBase.Query = String.Format("SELECT * FROM SingleMeterial WHERE SID IN(SELECT SID FROM view_SingleGraphInfo Where (Vendor LIKE '%{3}%' OR Vendor IS NULL) AND (Producing LIKE '%{4}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1} AND Name LIKE '%{2}%') ORDER BY SID",IncidenceCondition,MaterialType,strName,strVendor,strProducing,strDate);
						
					}
					else
					{

						common_DataBase.Query = String.Format("SELECT * FROM SingleMeterial WHERE SID IN(SELECT SID FROM view_SingleGraphInfo Where (Vendor LIKE '%{2}%' OR Vendor IS NULL) AND (Producing LIKE '%{3}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1}) ORDER BY SID",IncidenceCondition,MaterialType,strVendor,strProducing,strDate);
						
					}
				}
				else
				{
					if(strName != "")
					{

						common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1} AND MultiLayer.Name LIKE '%{2}%'",IncidenceCondition,MaterialType,strName);
						
					}
					else
					{

						common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND MID = {1}",IncidenceCondition,MaterialType);

						
					}
				}
			}
			else
			{
				if(Category == "Single")
				{
					if(strName != "")
					{

						//common_DataBase.Query = String.Format("SELECT * FROM SingleMeterial WHERE SID IN(SELECT SID FROM view_SingleGraphInfo Where ((Vendor LIKE '%{2}%' OR Vendor IS NULL) AND (Producing LIKE '%{3}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0} AND Name = '%{1}%') OR(Occurred_Date LIKE '%{4}%')) ORDER BY SID",IncidenceCondition,strName,strVendor,strProducing,strDate);
						common_DataBase.Query = String.Format("SELECT * FROM SingleMeterial WHERE SID IN(SELECT SID FROM view_SingleGraphInfo Where (Vendor LIKE '%{1}%' OR Vendor IS NULL) AND (Producing LIKE '%{2}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {3} AND Name LIKE '%{0}%')",strName,strVendor,strProducing,IncidenceCondition);
						
					}
					else
					{

						common_DataBase.Query = String.Format("SELECT * FROM SingleMeterial WHERE SID IN(SELECT SID FROM view_SingleGraphInfo Where (Vendor LIKE '%{1}%' OR Vendor IS NULL) AND (Producing LIKE '%{2}%' OR Producing IS NULL) AND Measured = " + dMeasured + " AND Incidence = {0}) ORDER BY SID",IncidenceCondition,strVendor,strProducing,strDate);
						
					}
				}
				else
				{
					if(strName != "")
					{

						common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0} AND Name LIKE '%{1}%'",IncidenceCondition,strName);
						
					}
					else
					{

						common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where Measured = " + dMeasured + " AND Incidence = {0}",IncidenceCondition);
						
					}
				}
			}

			DataSet ds = common_DataBase.GetDataSet_Text();

			return ds;
		}

//		public DataSet Search_MultiMaterial(string strName,string strTotalThick)
//		{
//			string strQuery = "SELECT * FROM view_MultiLayerMaterialGraph Where Measured <> 1";
//
//			if(strname != "")
//			{
//				strQuery = strQuery + String.Format(" AND Name = '{0}' ",strName);
//			}
//			if(strTotalThick != "")
//			{
//				strQuery = strQuery + String.Format(" AND TotalThick = '{0}' ",strTotalThick);
//			}	 
//					
//			common_DataBase.Query = strQuery;
//
//			DataSet ds = common_DataBase.GetDataSet_Text();
//
//			return ds;
//		}


		/// <summary>
		/// IDs 를 컴마구분으로 주면 다 가져온다
		/// </summary>
		/// <param name="Category"></param>
		/// <param name="strIDs"></param>
		/// <returns></returns>
		public DataSet Search_IDs(string Category,string strIDs)
		{
			if(strIDs != "")
			{
				common_DataBase = new Common_DataBase();
				if(Category == "Single")
				{
					common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where SGID IN({0})",strIDs);
				}
				else
				{
					common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where LGID IN({0})",strIDs);
				}
				DataSet ds = common_DataBase.GetDataSet_Text();

				return ds;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 해당 그래프 ID 를 주면 그것만 가져온다
		/// </summary>
		/// <param name="Category"></param>
		/// <param name="strIDs"></param>
		/// <returns></returns>
		public DataSet Search_ID(bool Category,string strID)
		{
			common_DataBase = new Common_DataBase();
			if(Category == true)
			{
				common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where SGID = {0}",strID);
			}
			else
			{
				common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where LGID = {0}",strID);
			}
			DataSet ds = common_DataBase.GetDataSet_Text();

			return ds;
		}

		public void DeleteMultiMaterial(string strIDs)
		{
			common_DataBase = new Common_DataBase();

			common_DataBase.Query = String.Format("SELECT * FROM MultiLayer Where LID = {0}",strIDs);

			common_DataBase.ExecuteNonQuery_Text();
		}

		public void DeleteSingleMaterial(string strIDs)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("SELECT * FROM SingleMeterial Where SID = {0}",strIDs);

			common_DataBase.ExecuteNonQuery_Text();
		}

		public void ModifySingleMaterial(string strIDs,string Thick,string BulkDens,string FlowRes,string Sfactor,string Prosity,string ViscousCL,string ThermalCL,
			string Ymodulus,string PoissionR,string LossFactor,string strM_ID,string strVendor,string strProducing,string strRemark,string strDate)
		{
			DateTime date = DateTime.Parse(strDate);
			strDate = date.ToString("yyyy-MM-dd");

			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("UPDATE SingleMeterial SET Thick = {1},BulkDens = {2},FlowRes = {3},Sfactor = {4},Prosity = {5},ViscousCL = {6},"
				+ "ThermalCL = {7},Ymodulus = {8},PoissionR = {9},LossFactor = {10},MID = {11} ,Vendor = '{12}',Producing = '{13}',Remark = '{14}',"
				+ "Occurred_Date = '{15}' WHERE SID = {0}",
				strIDs,strEmptyCheck(Thick),strEmptyCheck(BulkDens),strEmptyCheck(FlowRes),strEmptyCheck(Sfactor),strEmptyCheck(Prosity),strEmptyCheck(ViscousCL),
				strEmptyCheck(ThermalCL),strEmptyCheck(Ymodulus),strEmptyCheck(PoissionR),strEmptyCheck(LossFactor),strEmptyCheck(strM_ID),
				strVendor,strProducing,strRemark,strDate);

			common_DataBase.ExecuteNonQuery_Text();
		}

		public int GetMax_ID_SingleMeterial()
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = "SELECT MAX(SID) FROM SingleMeterial";

			string strTemp = common_DataBase.ExecuteScalar_Text();
			if(strTemp == "")
			{
				strTemp = "0";
			}
			return int.Parse(strTemp) + 1;
		}

		public int CreateSingleMeterial(int SID,string Name,string MID,string Thick,string BulkDens,string FlowRes,string Sfactor,string Prosity,string ViscousCL,
			string ThermalCL,string Ymodulus,string PoissionR,string LossFactor,string HP1,string DensityP1,string EmP1,string PRatioP1,string HP2,string DensityP2,
			string EmP2,string PRatioP2,string strVendor,string strProducing,string strRemark,string strDate)
		{
			DateTime date = DateTime.Parse(strDate);
			strDate = date.ToString("yyyy-MM-dd");

			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("INSERT INTO SingleMeterial(SID,Name,MID,Thick,BulkDens,FlowRes,Sfactor,Prosity,ViscousCL,ThermalCL,Ymodulus,"
				+ "PoissionR,LossFactor,HP1,DensityP1,EmP1,PRatioP1,HP2,DensityP2,EmP2,PRatioP2,Vendor,Producing,Remark,Occurred_Date) "
				+ " VALUES({0},'{1}',{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},'{21}','{22}','{23}','{24}')"
				,SID,Name,strEmptyCheck(MID),strEmptyCheck(Thick),strEmptyCheck(BulkDens),strEmptyCheck(FlowRes),strEmptyCheck(Sfactor),strEmptyCheck(Prosity),
				strEmptyCheck(ViscousCL),strEmptyCheck(ThermalCL),strEmptyCheck(Ymodulus),strEmptyCheck(PoissionR),strEmptyCheck(LossFactor),strEmptyCheck(HP1),
				strEmptyCheck(DensityP1),strEmptyCheck(EmP1),strEmptyCheck(PRatioP1),strEmptyCheck(HP2),strEmptyCheck(DensityP2),strEmptyCheck(EmP2),
				strEmptyCheck(PRatioP2),strVendor,strProducing,strRemark,strDate);

			return common_DataBase.ExecuteNonQuery_Text();
		}

		public int IsGraphExist(bool bIsSingle,int dIsMeasured,int dIncidence,int dFreqBand,int dGraphType,int dID)
		{
			common_DataBase = new Common_DataBase();
			
			if(bIsSingle == true)
			{
				common_DataBase.Query = String.Format("SELECT SGID FROM view_SingleGraphInfo Where Measured = {0} AND Incidence = {1} AND FreqBand = {2} AND GraphType = {3} AND SID = {4}",dIsMeasured,dIncidence,dFreqBand,dGraphType,dID);
			}
			else
			{
				common_DataBase.Query = String.Format("SELECT LGID FROM view_MultiLayerMaterialGraph Where Measured = {0} AND Incidence = {1} AND FreqBand = {2} AND GraphType = {3} AND LID = {4}",dIsMeasured,dIncidence,dFreqBand,dGraphType,dID);
			}

			if(common_DataBase.GetDataSet_Text().Tables[0].Rows.Count > 0)
			{
				return int.Parse(common_DataBase.GetDataSet_Text().Tables[0].Rows[0][0].ToString());
			}
			else
			{
				return -1;
			}
		}

		public DataSet GetMultiMaterial(int dID)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where LID = {0}",dID);
			
			return common_DataBase.GetDataSet_Text();
		}

		public int PassWordCheck(string strPass)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("SELECT COUNT(*) FROM tblPass Where Pass = '{0}'",strPass);
			
			return int.Parse(common_DataBase.ExecuteScalar_Text());
		}

		public DataSet GetSingleMaterial(string dID)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("SELECT * FROM SingleMeterial Where SID = {0}",dID);
			
			return common_DataBase.GetDataSet_Text();
		}

		/// <summary>
		/// Single 이면 true
		/// </summary>
		/// <param name="Category"></param>
		/// <param name="str_ID"></param>
		/// <returns></returns>
		public DataSet Search(bool Category,string str_ID)
		{
			common_DataBase = new Common_DataBase();
			if(Category == true)
			{
				common_DataBase.Query = String.Format("SELECT * FROM view_SingleGraphInfo Where SID = {0}",str_ID);
			}
			else
			{
				common_DataBase.Query = String.Format("SELECT * FROM view_MultiLayerMaterialGraph Where LID = {0}",str_ID);
			}
			DataSet ds = common_DataBase.GetDataSet_Text();

			return ds;
		}

		public string strEmptyCheck(string str)
		{
			if(str == null || str == "")
			{
				return "0";
			}
			else
			{
				return str;
			}
		}
	}
}
