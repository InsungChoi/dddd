using System;
using HONUS.Common_Class;
using System.Data;

namespace HONUS.MaterialPerformanceAnalysis.Component
{
	/// <summary>
	/// MPA_DB에 대한 요약 설명입니다.
	/// </summary>
	public class MPA_DB
	{
		Common_DataBase common_DataBase;

		public MPA_DB()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		/// <summary>
		/// 이미 같은 이름이 존재하는지 체크한다 (있으면 true)
		/// </summary>
		/// <param name="bIsSingle">Single 면 true</param>
		/// <param name="strName">Name</param>
		/// <returns></returns>
		public bool IsExist(bool bIsSingle,string strName)
		{
			common_DataBase = new Common_DataBase();
			if(bIsSingle == true)
			{
				common_DataBase.Query = String.Format("SELECT COUNT(*) FROM view_SingleGraphInfo Where Name = '{0}'",strName);
			}
			else
			{
				common_DataBase.Query = String.Format("SELECT COUNT(*) FROM view_MultiLayerMaterialGraph Where SingleMeterial.Name = '{0}'",strName);
			}
			int dCount = int.Parse(common_DataBase.ExecuteScalar_Text());

			if(dCount > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
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

		public int GetMax_ID_MultiMeterial()
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = "SELECT MAX(LID) FROM MultiLayer";

			string strTemp = common_DataBase.ExecuteScalar_Text();
			if(strTemp == "")
			{
				strTemp = "0";
			}
			return int.Parse(strTemp) + 1;
		}

		public int GetMax_ID_LayerDetail()
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = "SELECT MAX(DID) FROM LayerDetail";

			string strTemp = common_DataBase.ExecuteScalar_Text();
			if(strTemp == "")
			{
				strTemp = "0";
			}
			return int.Parse(strTemp) + 1;
		}

		public int GetMax_ID_MultiLayerMaterialGraph()
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = "SELECT MAX(LGID) FROM MultiLayerMaterialGraph";

			string strTemp = common_DataBase.ExecuteScalar_Text();
			if(strTemp == "")
			{
				strTemp = "0";
			}
			return int.Parse(strTemp) + 1;
		}

		public int CreateSingleMeterial(int SID,string Name,string MID,string Thick,string BulkDens,string FlowRes,string Sfactor,string Prosity,string ViscousCL,
			string ThermalCL,string Ymodulus,string PoissionR,string LossFactor,string HP1,string DensityP1,string EmP1,string PRatioP1,string HP2,string DensityP2,
			string EmP2,string PRatioP2)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("INSERT INTO SingleMeterial(SID,Name,MID,Thick,BulkDens,FlowRes,Sfactor,Prosity,ViscousCL,ThermalCL,Ymodulus,"
				+ "PoissionR,LossFactor,HP1,DensityP1,EmP1,PRatioP1,HP2,DensityP2,EmP2,PRatioP2) "
				+ " VALUES({0},'{1}',{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20})"
				,SID,Name,strEmptyCheck(MID),strEmptyCheck(Thick),strEmptyCheck(BulkDens),strEmptyCheck(FlowRes),strEmptyCheck(Sfactor),strEmptyCheck(Prosity),
				strEmptyCheck(ViscousCL),strEmptyCheck(ThermalCL),strEmptyCheck(Ymodulus),strEmptyCheck(PoissionR),strEmptyCheck(LossFactor),strEmptyCheck(HP1),
				strEmptyCheck(DensityP1),strEmptyCheck(EmP1),strEmptyCheck(PRatioP1),strEmptyCheck(HP2),strEmptyCheck(DensityP2),strEmptyCheck(EmP2),
				strEmptyCheck(PRatioP2));

			return common_DataBase.ExecuteNonQuery_Text();
		}

		public int CreateSingleMaterialGraph(int SGID,int SID,string Name,string Measured,string Temperature,string Incidence,string IncAngle,string FreqBand,
			string GraphType,string X_Axis,string Y_RigidBacking,string Y_AnechoicTermination,string Y_TransmissionLoss)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("INSERT INTO SingleMeterialGraph(SGID,SID,Name,Measured,Temperature,Incidence,IncAngle,FreqBand,GraphType,X_Axis,"
				+ " Y_RigidBacking,Y_AnechoicTermination,Y_TransmissionLoss)"
				+ " VALUES({0},{1},'{2}',{3},{4},{5},{6},{7},{8},'{9}','{10}','{11}','{12}')"
				,SGID,SID,strEmptyCheck(Name),strEmptyCheck(Measured),strEmptyCheck(Temperature),strEmptyCheck(Incidence),
				strEmptyCheck(IncAngle),strEmptyCheck(FreqBand),strEmptyCheck(GraphType),strEmptyCheck(X_Axis),strEmptyCheck(Y_RigidBacking),
				strEmptyCheck(Y_AnechoicTermination),strEmptyCheck(Y_TransmissionLoss));

			return common_DataBase.ExecuteNonQuery_Text();
		}

		public int CreateMultiMaterialGraph(int LGID,int LID,string Name,string Measured,string Temperature,string Incidence,string IncAngle,string FreqBand,
			string GraphType,string X_Axis,string Y_RigidBacking,string Y_AnechoicTermination,string Y_TransmissionLoss)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("INSERT INTO MultiLayerMaterialGraph(LGID,LID,Name,Measured,Temperature,Incidence,IncAngle,FreqBand,GraphType,X_Axis,"
				+ " Y_RigidBacking,Y_AnechoicTermination,Y_TransmissionLoss)"
				+ " VALUES({0},{1},'{2}',{3},{4},{5},{6},{7},{8},'{9}','{10}','{11}','{12}')"
				,LGID,LID,strEmptyCheck(Name),strEmptyCheck(Measured),strEmptyCheck(Temperature),strEmptyCheck(Incidence),
				strEmptyCheck(IncAngle),strEmptyCheck(FreqBand),strEmptyCheck(GraphType),strEmptyCheck(X_Axis),strEmptyCheck(Y_RigidBacking),
				strEmptyCheck(Y_AnechoicTermination),strEmptyCheck(Y_TransmissionLoss));

			return common_DataBase.ExecuteNonQuery_Text();
		}

		public int CreateMultiMeterial(int LID,string Name,string TotalThick)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("INSERT INTO MultiLayer([LID],Name,TotalThick) VALUES({0},'{1}',{2})",LID,strEmptyCheck(Name),
				strEmptyCheck(TotalThick));

			return common_DataBase.ExecuteNonQuery_Text();
		}

		public int CreateLayerDetail(int dDID,int dLID,int dSID,int dOrder)
		{
			common_DataBase = new Common_DataBase();
			common_DataBase.Query = String.Format("INSERT INTO LayerDetail VALUES({0},{1},{2},{3})",dDID,dLID,dSID,dOrder);

			return common_DataBase.ExecuteNonQuery_Text();
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
