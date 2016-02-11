using System;
using System.Collections;

namespace HONUS.Common_Class
{
	/// <summary>
	/// MPEClass에 대한 요약 설명입니다.
	/// </summary>
	public class MPEClass
	{
		// Data
		public ArrayList EstData;  //List of MPEData
		// General Data
		public int SID;
		public int MID;
		public string Name;

		// MPEGraph
		public ClsData Frequency;
		public ClsData MAbsorption;
		public ClsData MRealSurfaceImpedance;
		public ClsData MImagSurfaceImpedance;
		public ClsData CAbsorption;
		public ClsData CRealSurfaceImpedance;
		public ClsData CImagSurfaceImpedance;

		// MAT Param
		public double Thickness;
		public double BulkDensity;
		public double FResist;
		public double SFactor;
		public double Porosity;
		public double ViscousCL;
		public double ThermalCL;

		public double Ymodulus;
		public double PoissonR;
		public double LossFactor;

		public MPEClass()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			EstData = new ArrayList();

			Frequency = new ClsData();
			MAbsorption = new ClsData();
			MRealSurfaceImpedance = new ClsData();
			MImagSurfaceImpedance = new ClsData();
			CAbsorption = new ClsData();
			CRealSurfaceImpedance = new ClsData();
			CImagSurfaceImpedance = new ClsData();

		}

		public bool Calc()
		{
			if (EstData.Count > 0) 
			{
				int DataCount =EstData.Count;
				for (int i=0;i<DataCount;i++)
				{
					((MPEData)EstData[i]).Calc();

					Thickness = Thickness + ((MPEData)EstData[i]).Thickness;
					BulkDensity = BulkDensity + ((MPEData)EstData[i]).BulkDensity;
					FResist = FResist + ((MPEData)EstData[i]).FResist;
					SFactor = SFactor + ((MPEData)EstData[i]).SFactor;
					Porosity = Porosity + ((MPEData)EstData[i]).Porosity;
					ViscousCL = ViscousCL + ((MPEData)EstData[i]).ViscousCL;
					ThermalCL = ThermalCL + ((MPEData)EstData[i]).ThermalCL;
					Ymodulus = Ymodulus + ((MPEData)EstData[i]).Ymodulus;
					PoissonR = PoissonR + ((MPEData)EstData[i]).PoissonR;
					LossFactor = LossFactor + ((MPEData)EstData[i]).LossFactor;

					MAbsorption.Sum(((MPEData)EstData[i]).MAbsorption);
					MRealSurfaceImpedance.Sum(((MPEData)EstData[i]).MRealSurfaceImpedance);
					MImagSurfaceImpedance.Sum(((MPEData)EstData[i]).MImagSurfaceImpedance);
					CAbsorption.Sum(((MPEData)EstData[i]).CAbsorption);
					CRealSurfaceImpedance.Sum(((MPEData)EstData[i]).CRealSurfaceImpedance);
					CImagSurfaceImpedance.Sum(((MPEData)EstData[i]).CImagSurfaceImpedance);


				}

				Thickness = Thickness/DataCount;
				BulkDensity = BulkDensity/DataCount;
				FResist = FResist/DataCount;
				SFactor = SFactor/DataCount;
				Porosity = Porosity/DataCount;
				ViscousCL = ViscousCL*1000000/DataCount;
				ThermalCL = ThermalCL*1000000/DataCount;
				Ymodulus = Ymodulus/DataCount;
				PoissonR = PoissonR/DataCount;
				LossFactor = LossFactor/DataCount;

				Frequency = ((MPEData)EstData[0]).Frequency;
				MAbsorption.Divide(DataCount);
				MRealSurfaceImpedance.Divide(DataCount);
				MImagSurfaceImpedance.Divide(DataCount);
				CAbsorption.Divide(DataCount);
				CRealSurfaceImpedance.Divide(DataCount);
				CImagSurfaceImpedance.Divide(DataCount);


				return true;
			} 
			else
			{
				bool result = false;

				return result;
			}
		}

		public bool DBsave()
		{
			bool result = false;

			return result;
		}

		public bool DBLoad()
		{
			bool result = false;

			return result;
		}

		public MPEData CopyMPEData()
		{
			if (EstData.Count > 0) 
			{
				MPEData MPEData_Entity = ((MPEData)EstData[0]).Copy();
				EstData.Add(MPEData_Entity);

				return MPEData_Entity;
			} 
			else
				return NewMPEData();
		}

		public MPEData NewMPEData()
		{
			MPEData MPEData_Entity = new MPEData();
			EstData.Add(MPEData_Entity);

			return MPEData_Entity;
		}

		public void DeleteMPEData(MPEData obj)
		{
			EstData.Remove(obj);
		}

		public int GetMPEDataCount()
		{
			return EstData.Count;
		}

		public void Temp()
		{
			Frequency = ((MPEData)EstData[0]).Frequency;
			MAbsorption = ((MPEData)EstData[0]).MAbsorption;
			MRealSurfaceImpedance = ((MPEData)EstData[0]).MRealSurfaceImpedance;
			MImagSurfaceImpedance = ((MPEData)EstData[0]).MImagSurfaceImpedance;
			CAbsorption = ((MPEData)EstData[0]).CAbsorption;
			CRealSurfaceImpedance = ((MPEData)EstData[0]).CRealSurfaceImpedance;
			CImagSurfaceImpedance = ((MPEData)EstData[0]).CImagSurfaceImpedance;  
		}
	}
}
