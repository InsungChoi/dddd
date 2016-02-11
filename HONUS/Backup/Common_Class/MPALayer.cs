using System;
using System.Collections;

namespace HONUS.Common_Class
{
	/// <summary>
	/// MPALayer에 대한 요약 설명입니다.
	/// </summary>
	public class MPALayer
	{
		// Layer Info
		public int LID;
		public string Name;
		public int LayerNo;
		private ArrayList MatCollection; // List of MPAMaterial

		/// <summary>
		/// Material 을 생성할지 말지를 판정(DB에서 로드했으면 안하고 false 사용자 입력일 경우 생성 true)
		/// </summary>
		public bool IsMaterialCreate = false;

		// Option
		public int Measured;
		public double Temperature;
		public int Incidence;
		public double IncAngle;
		public int FreqBand;
		public int GraphType;
		double TotalThickness;

		public int limitfreq;
		// Output
		public ClsData Frequency;
		public ClsData RigidBacking;
		public ClsData AnechoicTermination;
		public ClsData TransmissionLoss;
		private TM.TMclassClass TMCalc;

		public MPALayer()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			MatCollection = new ArrayList();

			Frequency = new ClsData();
			RigidBacking = new ClsData();
			AnechoicTermination = new ClsData();
			TransmissionLoss = new ClsData();
			TMCalc = new TM.TMclassClass();
		}

		private void setInitialData()
		{
			TMCalc.c=343.0;
			TMCalc.Densityo=1.21;
			TMCalc.HeatRatio=1.4;
			TMCalc.Npr=0.732;
			TMCalc.ItaAir=1.84*Math.Pow(10,-5);
			TMCalc.P0=101325.0;
		}

		private void setFrequency()
		{
			Frequency.Clear();
			switch (FreqBand)
			{
				case 1:
					for (int i=1;i<101;i++)
					{
						Frequency.AddData(i*100);
					}
					limitfreq = 100;
					break;
				case 2:
					Frequency.AddData(16);
					Frequency.AddData(31.5);
					Frequency.AddData(63);
					Frequency.AddData(125);
					Frequency.AddData(250);
					Frequency.AddData(500);
					Frequency.AddData(1000);
					Frequency.AddData(2000);
					Frequency.AddData(4000);
					Frequency.AddData(8000);
					Frequency.AddData(10000);
					limitfreq = 11;
					break;
				default:
					Frequency.AddData(10);
					Frequency.AddData(12.5);
					Frequency.AddData(16);
					Frequency.AddData(20);
					Frequency.AddData(25);
					Frequency.AddData(31.5);
					Frequency.AddData(40);
					Frequency.AddData(50);
					Frequency.AddData(63);
					Frequency.AddData(80);
					Frequency.AddData(100);
					Frequency.AddData(125);
					Frequency.AddData(160);
					Frequency.AddData(200);
					Frequency.AddData(250);
					Frequency.AddData(315);
					Frequency.AddData(400);
					Frequency.AddData(500);
					Frequency.AddData(630);
					Frequency.AddData(800);
					Frequency.AddData(1000);
					Frequency.AddData(1250);
					Frequency.AddData(1600);
					Frequency.AddData(2000);
					Frequency.AddData(2500);
					Frequency.AddData(3150);
					Frequency.AddData(4000);
					Frequency.AddData(5000);
					Frequency.AddData(6300);
					Frequency.AddData(8000);
					Frequency.AddData(10000);
					limitfreq = 31;
					break;
			}
		}


		public double CalcThickness()
		{
			MPAMaterial Mat;
			double TotalThickness = 0;

			for (int j=0; j<MatCollection.Count; j++)
			{
				Mat = (MPAMaterial)MatCollection[j];
				switch (Mat.MID)
				{
					case 1:
						TotalThickness = TotalThickness + Mat.Thick;
						break;
					case 2:
						TotalThickness = TotalThickness + Mat.Thick;
						break;
					case 3:
						TotalThickness = TotalThickness + Mat.Thick;
						break;
					case 4:
						TotalThickness = TotalThickness + Mat.Thick;
						break;
					case 5:
						TotalThickness = TotalThickness + Mat.Thick;
						break;
					case 6:
						TotalThickness = TotalThickness + Mat.Thick;
						break;
					case 7:
						TotalThickness = TotalThickness + Mat.Thick;
						break;
					case 8:
						TotalThickness = TotalThickness + Mat.HP1 + Mat.Thick;
						break;
					case 9:
						TotalThickness = TotalThickness + Mat.Thick + Mat.HP2;
						break;
					default :
						TotalThickness = TotalThickness + Mat.HP1 + Mat.Thick + Mat.HP2;
						break;
				}

			}

			return TotalThickness;
		}

		public bool Calc()
		{
			MPAMaterial Mat;
			double IncAngleStart;
			double IncAngleEnd;
			int IncAngleCount;
			int k;

			RigidBacking.Clear();
			AnechoicTermination.Clear();
			TransmissionLoss.Clear();

			TotalThickness = this.CalcThickness();

			if (Incidence == 1)
			{
				IncAngleStart = 0.1*Math.Pow(10,-10);
				IncAngleEnd = IncAngleStart;
				IncAngleCount = 1;
			} 
			else
			{
				IncAngleStart = 2;
				IncAngleEnd = IncAngle;
				IncAngleCount = (int)(IncAngle / IncAngleStart);
			}

			setInitialData();
			setFrequency();

			double[,] Rigid= new double[limitfreq, IncAngleCount];
			double[,] Anechoic= new double[limitfreq, IncAngleCount];
			double[,] TL= new double[limitfreq, IncAngleCount];

			for (int i=0; i<limitfreq;i++)
			{
				double freq=Frequency.GetData(i);
				k = 0;

				for (double IncAngleTemp = IncAngleStart;IncAngleTemp <= IncAngleEnd; IncAngleTemp = IncAngleTemp + IncAngleStart)
				{
					TMCalc.tminit();
					// 임시 루틴.
					TMCalc.tmcheck();
					double theta=IncAngleTemp*Math.PI/180;

					for (int jj=0; jj<MatCollection.Count;jj++)
					{
						Mat = (MPAMaterial)MatCollection[jj];
						switch (Mat.MID)
						{
							case 1:
								TMCalc.tmair(freq, theta, Mat.Thick);
								break;
							case 2:
								TMCalc.tmpanel(freq, theta, Mat.Thick, Mat.BulkDens, Mat.Ymodulus, Mat.PoissionR);
								break;
							case 3:
								TMCalc.tmimpermemb(freq, theta, Mat.Thick, Mat.BulkDens);
								break;
							case 4:
								TMCalc.tmpermemb(freq, theta, Mat.Thick, Mat.BulkDens, Mat.FlowRes);
								break;
							case 5:
								TMCalc.tmlimp(freq, theta, Mat.Thick,  Mat.BulkDens, Mat.FlowRes, Mat.SFactor, Mat.Porosity, Mat.ViscousCL/1000000, Mat.ThermalCL/1000000);
								break;
							case 6:
								TMCalc.tmrigid(freq, theta, Mat.Thick,  Mat.BulkDens, Mat.FlowRes, Mat.SFactor, Mat.Porosity, Mat.ViscousCL/1000000, Mat.ThermalCL/1000000);
								break;
							case 7:
								TMCalc.tmelastic(freq, theta, Mat.Thick,  Mat.BulkDens, Mat.FlowRes, Mat.SFactor, Mat.Porosity, Mat.ViscousCL/1000000, Mat.ThermalCL/1000000, Mat.Ymodulus, Mat.LossFactor, Mat.PoissionR);
								break;
							case 8:
								TMCalc.tmpanelelastic(freq, theta, Mat.HP1, Mat.DensityP1, Mat.EmP1, Mat.PRatioP1, Mat.Thick,  Mat.BulkDens, Mat.FlowRes, Mat.SFactor, Mat.Porosity, Mat.ViscousCL/1000000, Mat.ThermalCL/1000000, Mat.Ymodulus, Mat.LossFactor, Mat.PoissionR);
								break;
							case 9:
								TMCalc.tmelasticpanel(freq, theta, Mat.Thick,  Mat.BulkDens, Mat.FlowRes, Mat.SFactor, Mat.Porosity, Mat.ViscousCL/1000000, Mat.ThermalCL/1000000, Mat.Ymodulus, Mat.LossFactor, Mat.PoissionR , Mat.HP2/1000, Mat.DensityP2, Mat.EmP2, Mat.PRatioP2);
								break;
							default :
								TMCalc.tmpanelelasticpanel(freq, theta,Mat.HP1, Mat.DensityP1, Mat.EmP1, Mat.PRatioP1, Mat.Thick,  Mat.BulkDens, Mat.FlowRes, Mat.SFactor, Mat.Porosity, Mat.ViscousCL/1000000, Mat.ThermalCL/1000000, Mat.Ymodulus, Mat.LossFactor, Mat.PoissionR , Mat.HP2, Mat.DensityP2, Mat.EmP2, Mat.PRatioP2);
								break;
						}
						// 임시 루틴.
						TMCalc.tmcheck();
						TMCalc.tmmul();
						// 임시 루틴.
						TMCalc.tmcheck();
					}
					TMCalc.tmcalc(freq, theta, TotalThickness);
					// 임시 루틴.
					TMCalc.tmcheck();

					if (Incidence == 1)
					{
						RigidBacking.AddData((double)TMCalc.Rigid);
						AnechoicTermination.AddData((double)TMCalc.Anechoic);
						TransmissionLoss.AddData(10*Math.Log10(1/(double)TMCalc.TL));
					} 
					else
					{
						Rigid[i,k] = 2*(double)TMCalc.Rigid*Math.Sin(theta)*Math.Cos(theta);
						Anechoic[i,k] = 2*(double)TMCalc.Anechoic*Math.Sin(theta)*Math.Cos(theta);
						TL[i,k] = 2*(double)TMCalc.TL*Math.Sin(theta)*Math.Cos(theta);
					}
					k = k+1;
				}
			}

			if (Incidence != 1)
			{
				double width = IncAngleStart*Math.PI/180;

				for (int i=0; i<limitfreq;i++)
				{
					double freq=Frequency.GetData(i);

					double RigidLast = 0;
					double AnechoicLast = 0;
					double TLLast = 0;

					for (int j=0;j<(IncAngleCount-2);j=j+2)
					{
						RigidLast = RigidLast + (width/3)*(Rigid[i,j]+4*Rigid[i,j+1]+Rigid[i,j+2]);
						AnechoicLast = AnechoicLast + (width/3)*(Anechoic[i,j]+4*Anechoic[i,j+1]+Anechoic[i,j+2]);
						TLLast = TLLast + (width/3)*(TL[i,j]+4*TL[i,j+1]+TL[i,j+2]);
					}

					RigidBacking.AddData(RigidLast);
					AnechoicTermination.AddData(AnechoicLast);
					TransmissionLoss.AddData(10*Math.Log10(1/TLLast));
				}
			}

			return true;
		}

		public bool DBSave_Multi()
		{
			HONUS.MaterialPerformanceAnalysis.Component.MPA_DB MPA_DB1 = new HONUS.MaterialPerformanceAnalysis.Component.MPA_DB();

			bool result = false;

			int dLID = 0;

			IsMaterialCreateCheck(); // 하나라도 있으면 true  ->> 고로 다시 생성하여야 함

			if(this.IsMaterialCreate == true)
			{
				dLID = DBSave_MultiMaterial(this.Name,this.TotalThickness.ToString());
			}

			if(dLID == 0)
			{
				dLID = this.LID;
			}

			for(int i = 0 ; i < MatCollection.Count ; i++)
			{
				int SID = ((MPAMaterial)MatCollection[i]).DBSave_Multi(Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString());
				DBSave_LayerDetail(dLID,SID,i);
			}

			DBSave_MultiGraph(dLID);

			return result;
		}

		/// <summary>
		/// 하나라도 있으면 true 고로 다시 생성하여야 함
		/// </summary>
		/// <returns></returns>
		private void IsMaterialCreateCheck()
		{
			for(int i = 0 ; i < MatCollection.Count ; i++)
			{
				if(((MPAMaterial)MatCollection[i]).IsMaterialCreate == true)
				{
					IsMaterialCreate = true;
				}
			}
		}

		public int DBSave_MultiMaterial(string strName,string strTotalThick)
		{
			HONUS.MaterialPerformanceAnalysis.Component.MPA_DB MPA_DB1 = new HONUS.MaterialPerformanceAnalysis.Component.MPA_DB();

			int dLID = MPA_DB1.GetMax_ID_MultiMeterial();
			MPA_DB1.CreateMultiMeterial(dLID,Name,strTotalThick);

			return dLID;
		}

		public int DBSave_LayerDetail(int dLID,int dSID,int dOrder)
		{
			HONUS.MaterialPerformanceAnalysis.Component.MPA_DB MPA_DB1 = new HONUS.MaterialPerformanceAnalysis.Component.MPA_DB();

			int dDID = MPA_DB1.GetMax_ID_LayerDetail();
			MPA_DB1.CreateLayerDetail(dDID,dLID,dSID,dOrder);

			return dLID;
		}

		public int DBSave_MultiGraph(int dLID)
		{
			HONUS.MaterialPerformanceAnalysis.Component.MPA_DB MPA_DB1 = new HONUS.MaterialPerformanceAnalysis.Component.MPA_DB();

			int LGID = MPA_DB1.GetMax_ID_MultiLayerMaterialGraph();
			MPA_DB1.CreateMultiMaterialGraph(LGID,dLID,Name,Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString(),"1"
				,Frequency.GetString(),RigidBacking.GetString(),"","");

			LGID = MPA_DB1.GetMax_ID_MultiLayerMaterialGraph();
			MPA_DB1.CreateMultiMaterialGraph(LGID,dLID,Name,Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString(),"2"
				,Frequency.GetString(),"",AnechoicTermination.GetString(),"");

			LGID = MPA_DB1.GetMax_ID_MultiLayerMaterialGraph();
			MPA_DB1.CreateMultiMaterialGraph(LGID,dLID,Name,Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString(),"3"
				,Frequency.GetString(),"","",TransmissionLoss.GetString());

			return LGID;
		}

		public bool DBSave_Single()
		{
			bool result = false;

			if(MatCollection.Count > 0)
			{
				((MPAMaterial)MatCollection[0]).DBSave_Single(Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString()
					,Frequency.GetString(),RigidBacking.GetString(),AnechoicTermination.GetString(),TransmissionLoss.GetString());
			}

			return result;
		}

		public bool DBLoad()
		{
			bool result = false;

			return result;
		}

		public void LayerAdd(MPAMaterial Layer)
		{
			MatCollection.Add(Layer);
		}

		public void LayerDeleteAll()
		{
			MatCollection.Clear();
		}

		public void LayerAdd()
		{
			MPAMaterial Layer;

			Layer = new MPAMaterial();
			Layer.Copy(GetMPAMaterial(GetCount()-1));
			MatCollection.Add(Layer);
		}

		public void LayerDelete(string strName)
		{
			for(int i = 0 ; i < MatCollection.Count ; i++)
			{
				MPAMaterial MPAMaterial1 = GetMPAMaterial(i);

				if(MPAMaterial1.Name == strName)
				{
					MatCollection.RemoveAt(i);
				}
			}
		}

		public int GetCount()
		{
			return MatCollection.Count;
		}

		public MPAMaterial GetMPAMaterial(int Index)
		{
			return (MPAMaterial)MatCollection[Index];
		}

//		public MPALayer GetMPALayer()
//		{
//			return this;
//		}

		public void Copy(MPALayer MPALayer1)
		{
			if(MPALayer1 != null)
			{
				this.Name = MPALayer1.Name;
				for(int i = 0 ; i < MPALayer1.GetCount() ; i++)
				{
					MPAMaterial MPAMaterial1 = new MPAMaterial();
					MatCollection.Add(MPAMaterial1);
					this.GetMPAMaterial(i).Copy(MPALayer1.GetMPAMaterial(i));
				}
			}
		}
	}
}
