using System;

namespace HONUS.Common_Class
{
	/// <summary>
	/// MPAMaterial에 대한 요약 설명입니다.
	/// </summary>
	public class MPAMaterial
	{
		// General Info
		public int SID;
		public string Name;
		public int MID;
		public string MaterTypeName;

		/// <summary>
		/// Material 을 생성할지 말지를 판정(DB에서 로드했으면 안하고 false 사용자 입력일 경우 생성 true)
		/// </summary>
		public bool IsMaterialCreate = false;

		// Material Prop
		public double HP1;
		public double DensityP1;
		public double EmP1;
		public double PRatioP1;
		public double Thick;
		public double BulkDens;
		public double FlowRes;
		public double SFactor;
		public double Porosity;
		public double ViscousCL;
		public double ThermalCL;
		public double Ymodulus;
		public double PoissionR;
		public double LossFactor;
		public double HP2;
		public double DensityP2;
		public double EmP2;
		public double PRatioP2;

		public string strVender;
		public string strDate;
		public string strProducing;

		public MPAMaterial()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			HP1 = 0;
			DensityP1 = 0;
			EmP1 = 0;
			PRatioP1 = 0;
			Thick = 0;
			BulkDens = 0;
			FlowRes = 0;
			SFactor = 0;
			Porosity = 0;
			ViscousCL = 0;
			ThermalCL = 0;
			Ymodulus = 0;
			PoissionR = 0;
			LossFactor = 0;
			HP2 = 0;
			DensityP2 = 0;
			EmP2 = 0;
			PRatioP2 = 0;

			strVender = "";
			strDate = "";
			strProducing = "";
		}

		public bool DBSave_Single(string Measured,string Temperature,string Incidence,string IncAngle,string FreqBand,string Frequency,string Rgraph_RB
			,string Rgraph_AT,string Rgraph_TL)
		{
			bool result = false;

			int dSID = 0;

			HONUS.MaterialPerformanceAnalysis.Component.MPA_DB MPA_DB1 = new HONUS.MaterialPerformanceAnalysis.Component.MPA_DB();
			if(this.IsMaterialCreate == true)
			{
				dSID = MPA_DB1.GetMax_ID_SingleMeterial();
				MPA_DB1.CreateSingleMeterial(dSID,Name,MID.ToString(),Thick.ToString(),BulkDens.ToString(),FlowRes.ToString(),SFactor.ToString(),Porosity.ToString()
					,ViscousCL.ToString(),ThermalCL.ToString(),Ymodulus.ToString(),PoissionR.ToString(),LossFactor.ToString(),"0","0","0","0","0","0","0","0");
			}

			if(dSID == 0)
			{
				dSID = this.SID;
			}
			int dSGID = MPA_DB1.GetMax_ID_SingleMeterialGraph();
			MPA_DB1.CreateSingleMaterialGraph(dSGID,dSID,Name,Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString(),"1"
				,Frequency,Rgraph_RB,"","");

			dSGID = MPA_DB1.GetMax_ID_SingleMeterialGraph();
			MPA_DB1.CreateSingleMaterialGraph(dSGID,dSID,Name,Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString(),"2"
				,Frequency,"",Rgraph_AT,"");

			dSGID = MPA_DB1.GetMax_ID_SingleMeterialGraph();
			MPA_DB1.CreateSingleMaterialGraph(dSGID,dSID,Name,Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString(),"3"
				,Frequency,"","",Rgraph_TL);

			return result;
		}

		public int DBSave_Multi(string Measured,string Temperature,string Incidence,string IncAngle,string FreqBand)
		{
			int dSID = 0;

			HONUS.MaterialPerformanceAnalysis.Component.MPA_DB MPA_DB1 = new HONUS.MaterialPerformanceAnalysis.Component.MPA_DB();
			if(this.IsMaterialCreate == true)
			{
				dSID = MPA_DB1.GetMax_ID_SingleMeterial();
				MPA_DB1.CreateSingleMeterial(dSID,Name,MID.ToString(),Thick.ToString(),BulkDens.ToString(),FlowRes.ToString(),SFactor.ToString(),Porosity.ToString()
					,ViscousCL.ToString(),ThermalCL.ToString(),Ymodulus.ToString(),PoissionR.ToString(),LossFactor.ToString(),"0","0","0","0","0","0","0","0");
			}
			if(dSID == 0)
			{
				dSID = this.SID;
			}

			return dSID;
		}

		public bool DBLoad()
		{
			bool result = false;

			return result;
		}

		public void Copy(MPAMaterial MPAMaterial1)
		{
			MID = MPAMaterial1.MID;
			HP1 = MPAMaterial1.HP1;
			DensityP1 = MPAMaterial1.DensityP1;
			EmP1 = MPAMaterial1.EmP1;
			PRatioP1 = MPAMaterial1.PRatioP1;
			Thick = MPAMaterial1.Thick;
			BulkDens = MPAMaterial1.BulkDens;
			FlowRes = MPAMaterial1.FlowRes;
			SFactor = MPAMaterial1.SFactor;
			Porosity = MPAMaterial1.Porosity;
			ViscousCL = MPAMaterial1.ViscousCL;
			ThermalCL = MPAMaterial1.ThermalCL;
			Ymodulus = MPAMaterial1.Ymodulus;
			PoissionR = MPAMaterial1.PoissionR;
			LossFactor = MPAMaterial1.LossFactor;
			HP2 = MPAMaterial1.HP2;
			DensityP2 = MPAMaterial1.DensityP2;
			EmP2 = MPAMaterial1.EmP2;
			PRatioP2 = MPAMaterial1.PRatioP2;

			MaterTypeName = MPAMaterial1.MaterTypeName;
			Name = MPAMaterial1.Name;
			IsMaterialCreate = MPAMaterial1.IsMaterialCreate;
		}
	}
}
