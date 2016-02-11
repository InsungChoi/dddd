using System;
using System.Data;
using HONUS.Common_Class;

namespace HONUS.SensitivityAnalysis.Component
{
	/// <summary>
	/// SA_DB에 대한 요약 설명입니다.
	/// </summary>
	public class SA_DB
	{
		Common_DataBase common_DataBase;

		public SA_DB()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		public DataSet GetSingleMaterialGraph(string strID)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("SELECT * FROM SingleMeterialGraph Where SGID = {0}",strID);

			DataSet ds = common_DataBase.GetDataSet_Text();

			return ds;
		}

		public int GetMax_ID_SingleMeterialGraph()
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = "SELECT MAX(SGID) FROM SingleMeterialGraph";

			string strTemp = common_DataBase.ExecuteScalar_Text();
			if(strTemp == "")
			{
				strTemp = "0";
			}
			
			return int.Parse(strTemp) + 1;
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
			string EmP2,string PRatioP2,string strRemark)
		{
//			DateTime date = DateTime.Parse(strDate);
//			strDate = date.ToString("yyyy-MM-dd");

			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("INSERT INTO SingleMeterial(SID,Name,MID,Thick,BulkDens,FlowRes,Sfactor,Prosity,ViscousCL,ThermalCL,Ymodulus,"
				+ "PoissionR,LossFactor,HP1,DensityP1,EmP1,PRatioP1,HP2,DensityP2,EmP2,PRatioP2,Remark) "
				+ " VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}')"
				,SID,Name,MID,Thick,BulkDens,FlowRes,Sfactor,Prosity,ViscousCL,ThermalCL,Ymodulus,PoissionR,LossFactor,
				HP1,DensityP1,EmP1,PRatioP1,HP2,DensityP2,EmP2,PRatioP2,strRemark);

			return common_DataBase.ExecuteNonQuery_Text();
		}

		public int CreateSingleMaterialGraph(int SGID,int SID,string Name,string Measured,string Temperature,string Incidence,string IncAngle,string FreqBand,
			string GraphType,string X_Axis,string Y_RigidBacking,string Y_AnechoicTermination,string Y_TransmissionLoss)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("INSERT INTO SingleMeterialGraph(SGID,SID,Name,Measured,Temperature,Incidence,IncAngle,FreqBand,GraphType,X_Axis,"
				+ " Y_RigidBacking,Y_AnechoicTermination,Y_TransmissionLoss)"
				+ " VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')"
				,SGID,SID,Name,Measured,Temperature,Incidence,IncAngle,FreqBand,GraphType,X_Axis,Y_RigidBacking,Y_AnechoicTermination,Y_TransmissionLoss);

			return common_DataBase.ExecuteNonQuery_Text();
		}
	}
}
