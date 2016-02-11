using System;
using System.Collections;

namespace HONUS.Common_Class
{
	/// <summary>
	/// SAClass에 대한 요약 설명입니다.
	/// </summary>
	public class SAClass
	{
		// General Info
		public int SID;
		public string Name;
		public int MID;

		/// <summary>
		/// Material 을 생성할지 말지를 판정(DB에서 로드했으면 안하고 false 사용자 입력일 경우 생성 true)
		/// </summary>
		public bool IsMaterialCreate = false;

		//Material Prop
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

		// Option
		public int Measured;
		public double Temperature;
		public int Incidence;
		public double IncAngle;
		public int FreqBand = 1;
		public int GraphType;

		// Sensitivity
		public int VarID;
		public double StartValue;
		public double EndValue;
		public double StepValue;
		public ClsData Z_Data;

		public double SelectedValue;
		public double OriginalValue;

		public string Remark;

		// Graph
		public ClsData Frequency;
		public ClsData Igraph;
		public ArrayList Sgraph; // List of ClsData
		public ClsData Rgraph_TL;
		public ClsData Rgraph_RB;
		public ClsData Rgraph_AT;

		private TM.TMclassClass TMCalc;
		private int limitfreq;

		public SAClass()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			Frequency = new ClsData();

			Sgraph = new ArrayList(); // List of ClsData
			TMCalc = new TM.TMclassClass();
		}

		public void Cal_Z_Data()
		{
			Z_Data = new ClsData();

			for(double i = StartValue ; i <= EndValue ; i = i + StepValue)
			{
				Z_Data.AddData(i);
			}
		}

		public double Get_Z_Data(int dIndex)
		{
			return Z_Data.GetData(dIndex);
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

		
		public bool BackUpValue()
		{
			switch (VarID)
			{
				case 0:
					OriginalValue = Thick;
					break;
				case 1:
					OriginalValue = BulkDens;
					break;
				case 2:
					OriginalValue = Ymodulus;
					break;
				case 3:
					OriginalValue = PoissionR;
					break;
				case 4:
					OriginalValue = LossFactor;
					break;
				case 5:
					OriginalValue = FlowRes;
					break;
				case 6:
					OriginalValue = SFactor;
					break;
				case 7:
					OriginalValue = Porosity;
					break;
				case 8:
					OriginalValue = ViscousCL;
					break;
				default:
					OriginalValue = ThermalCL;
					break;
			}
			return true;
		}
		
		public bool ReplaceValue(double Value)
		{
			switch (VarID)
			{
				case 0:
					Thick = Value;
					break;
				case 1:
					BulkDens = Value;
					break;
				case 2:
					Ymodulus = Value;
					break;
				case 3:
					PoissionR = Value;
					break;
				case 4:
					LossFactor = Value;
					break;
				case 5:
					FlowRes = Value;
					break;
				case 6:
					SFactor = Value;
					break;
				case 7:
					Porosity = Value;
					break;
				case 8:
					ViscousCL = Value;
					break;
				default:
					ThermalCL = Value;
					break;
			}
			return true;
		}

		public bool InitCalc()
		{
			setInitialData();
			setFrequency();
			Calc();

			switch (GraphType)
			{
				case 1:
					Igraph = Rgraph_TL;
					break;
				case 2:
					Igraph = Rgraph_RB;
					break;
				default:
					Igraph = Rgraph_AT;
					break;
			}
			return true;
		}

		public bool SensCalc()
		{
			setInitialData();
			setFrequency();

			BackUpValue();

			Sgraph.Clear(); // 정기리가 수정한 부분

			for (double VarValue = StartValue; VarValue<=EndValue; VarValue = VarValue+StepValue)
			{
				ReplaceValue(VarValue);
				Calc();

				switch (GraphType)
				{
					case 1:
						Sgraph.Add(Rgraph_TL);
						break;
					case 2:
						Sgraph.Add(Rgraph_RB);
						break;
					default:
						Sgraph.Add(Rgraph_AT);
						break;
				}
			}

			ReplaceValue(OriginalValue);

			return true;
		}

		public bool ResultingCalc()
		{
			setInitialData();
			setFrequency();

			ReplaceValue(SelectedValue);

			Calc();

			return true;
		}

		public bool DBSave()
		{
			bool result = false;

			int dSID = 0;

			HONUS.SensitivityAnalysis.Component.SA_DB SADB1 = new HONUS.SensitivityAnalysis.Component.SA_DB();
			if(this.IsMaterialCreate == true)
			{
				dSID = SADB1.GetMax_ID_SingleMeterial();
				SADB1.CreateSingleMeterial(dSID,Name,MID.ToString(),Thick.ToString(),BulkDens.ToString(),FlowRes.ToString(),SFactor.ToString(),Porosity.ToString()
					,ViscousCL.ToString(),ThermalCL.ToString(),Ymodulus.ToString(),PoissionR.ToString(),LossFactor.ToString(),"0","0","0","0","0","0","0","0"
					,this.Remark);
			}

			if(dSID == 0)
			{
				dSID = this.SID;
			}
			int dSGID = SADB1.GetMax_ID_SingleMeterialGraph();
			SADB1.CreateSingleMaterialGraph(dSGID,dSID,Name,Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString(),"1"
				,Frequency.GetString(),Rgraph_RB.GetString(),"","");

			dSGID = SADB1.GetMax_ID_SingleMeterialGraph();
			SADB1.CreateSingleMaterialGraph(dSGID,dSID,Name,Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString(),"2"
				,Frequency.GetString(),"",Rgraph_AT.GetString(),"");

			dSGID = SADB1.GetMax_ID_SingleMeterialGraph();
			SADB1.CreateSingleMaterialGraph(dSGID,dSID,Name,Measured.ToString(),Temperature.ToString(),Incidence.ToString(),IncAngle.ToString(),FreqBand.ToString(),"3"
				,Frequency.GetString(),"","",Rgraph_TL.GetString());

			return result;
		}

		public bool DBLoad()
		{
			bool result = false;

			return result;
		}
		
		public bool Calc()
		{
			double IncAngleStart;
			double IncAngleEnd;
			int IncAngleCount;
			int k;

			Rgraph_RB = new ClsData();
			Rgraph_AT = new ClsData();
			Rgraph_TL = new ClsData();

			if (Incidence == 1)
			{
				IncAngleStart = 0.1*Math.Pow(10,-10);
				IncAngleEnd = IncAngleStart;
				IncAngleCount = 1;
			} 
			else
			{
				IncAngleStart = 0.5;
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
					double theta=IncAngleTemp*Math.PI/180;

					switch (MID)
					{
						case 5:
							TMCalc.tmlimp(freq, theta, Thick,  BulkDens, FlowRes, SFactor, Porosity, ViscousCL*0.000001, ThermalCL*0.000001);
							break;
						case 6:
							TMCalc.tmrigid(freq, theta, Thick,  BulkDens, FlowRes, SFactor, Porosity, ViscousCL*0.000001, ThermalCL*0.000001);
							break;
						case 7:
							TMCalc.tmelastic(freq, theta, Thick,  BulkDens, FlowRes, SFactor, Porosity, ViscousCL*0.000001, ThermalCL*0.000001, Ymodulus, LossFactor, PoissionR);
							break;
					}

					TMCalc.tmmul();
					TMCalc.tmcalc(freq, theta, Thick);

					if (Incidence == 1)
					{
						Rgraph_RB.AddData((double)TMCalc.Rigid);
						Rgraph_AT.AddData((double)TMCalc.Anechoic);
						Rgraph_TL.AddData(10*Math.Log10(1/(double)TMCalc.TL));
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

					Rgraph_RB.AddData(RigidLast);
					Rgraph_AT.AddData(AnechoicLast);
					Rgraph_TL.AddData(10*Math.Log10(1/TLLast));
				}
			}

			return true;
		}

	}
}
