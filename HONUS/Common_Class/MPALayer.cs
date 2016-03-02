using System;
using System.Collections;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

namespace HONUS.Common_Class
{
	/// <summary>
	/// MPALayer�� ���� ��� �����Դϴ�.
	/// </summary>
	public class MPALayer
	{
		// Layer Info
		public int LID;
		public string Name;
		public int LayerNo;
		private ArrayList MatCollection; // List of MPAMaterial

		/// <summary>
		/// Material �� �������� ������ ����(DB���� �ε������� ���ϰ� false ����� �Է��� ��� ���� true)
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
        private MWArray m_c;
        private MWArray m_Densityo;
        private MWArray m_HeatRatio;
        private MWArray m_Npr;
        private MWArray m_ItaAir;
        private MWArray m_P0;
        private MWArray m_TM;
        private MWArray m_Result;
        private MWArray m_Out;
        private MWArray m_tempOut;

		public MPALayer()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
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
            m_c = 343.0;
			m_Densityo=1.21;
            m_HeatRatio = 1.4;
            m_Npr = 0.732;
            m_ItaAir = 1.84 * Math.Pow(10, -5);
            m_P0 = 101325.0;
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
                    m_tempOut = TMCalc.TMInit();
                    m_TM = m_tempOut[1];
                    m_Result = m_tempOut[2];
                    // �ӽ� ��ƾ.
                    //m_TM = TMCalc.TMCheck();
					double theta=IncAngleTemp*Math.PI/180;

					for (int jj=0; jj<MatCollection.Count;jj++)
					{
						Mat = (MPAMaterial)MatCollection[jj];
						switch (Mat.MID)
						{
							case 1:
                                m_TM = TMCalc.TMAir(m_c,m_Densityo,freq,Mat.Thick,theta);
                                break;
							case 2:
                                m_TM = TMCalc.TMPanel(m_c,Mat.BulkDens,Mat.Ymodulus,freq,Mat.Thick,Mat.PoissionR,theta);
                                break;
							case 3:
                                m_TM = TMCalc.TMImperMemb(m_c,Mat.BulkDens,freq,Mat.Thick,theta);
								break;
							case 4:
                                m_TM = TMCalc.TMImperMemb(m_c, Mat.BulkDens, freq, Mat.Thick, theta);
								break;
							case 5:
                                m_TM = TMCalc.TMLimp(Mat.BulkDens, m_c, m_Densityo, Mat.FlowRes, freq, Mat.Porosity, m_HeatRatio, m_ItaAir, Mat.Thick, m_Npr, m_P0, Mat.SFactor, Mat.ThermalCL / 1000000, theta, Mat.ViscousCL / 1000000);
                                break;
							case 6:
                                m_TM = TMCalc.TMRigid(Mat.BulkDens, m_c, m_Densityo, Mat.FlowRes, freq, Mat.Porosity, m_HeatRatio, m_ItaAir, Mat.Thick, m_Npr, m_P0, Mat.SFactor, Mat.ThermalCL / 1000000, theta, Mat.ViscousCL / 1000000);
                                break;
							case 7:
                                m_TM = TMCalc.TMElastic(Mat.BulkDens, m_c, m_Densityo, Mat.Ymodulus, Mat.FlowRes, freq, Mat.Porosity, m_HeatRatio, m_ItaAir, Mat.Thick, Mat.LossFactor, m_Npr, Mat.PoissionR, Mat.SFactor, Mat.ThermalCL / 1000000, theta, Mat.ViscousCL / 1000000);
                                break;
							case 8:
                                m_TM = TMCalc.TMPanelElastic(Mat.BulkDens, m_c, m_Densityo, Mat.DensityP1, Mat.Ymodulus, Mat.EmP1, Mat.FlowRes, freq, Mat.Porosity, m_HeatRatio, Mat.HP1, m_ItaAir, Mat.Thick, Mat.LossFactor, m_Npr, Mat.PoissionR,Mat.PRatioP1,Mat.SFactor,Mat.ThermalCL/1000000,theta,Mat.ViscousCL/1000000);
                                break;
                            case 9:
                                m_TM = TMCalc.TMElasticPanel(Mat.BulkDens, m_c, m_Densityo, Mat.DensityP2, Mat.Ymodulus, Mat.EmP2, Mat.FlowRes, freq, Mat.Porosity, m_HeatRatio, Mat.HP2 / 1000, Mat.Thick, Mat.LossFactor, m_Npr, Mat.PoissionR, Mat.PRatioP2, Mat.SFactor, Mat.ThermalCL/1000000, theta, Mat.ViscousCL/1000000);
								break;
                            default :
                                m_TM = TMCalc.TMPanelElasticPanel(Mat.BulkDens, m_c, m_Densityo, Mat.DensityP1, Mat.DensityP2, Mat.Ymodulus, Mat.EmP1, Mat.EmP2, Mat.FlowRes, freq, Mat.Porosity, m_HeatRatio, Mat.HP1, Mat.HP2,m_ItaAir,Mat.Thick, Mat.LossFactor,m_Npr, Mat.PoissionR, Mat.PRatioP1, Mat.PRatioP2, Mat.SFactor, Mat.ThermalCL / 1000000, theta,Mat.ViscousCL / 1000000);
                                break;
						}
						// �ӽ� ��ƾ.
						//TMCalc.TMCheck();
                        m_Result = TMCalc.TMMul(m_TM, m_Result);
						// �ӽ� ��ƾ.
						//TMCalc.TMCheck();
					}
                    m_Out = TMCalc.TMCalc(freq, theta, TotalThickness);
					// �ӽ� ��ƾ.
					//TMCalc.TMCheck();

					if (Incidence == 1)
					{
                        RigidBacking.AddData(double.Parse(m_Out[1].ToString()));
                        AnechoicTermination.AddData(double.Parse(m_Out[2].ToString()));
                        TransmissionLoss.AddData(10 * Math.Log10(1 / double.Parse(m_Out[3].ToString())));
					} 
					else
					{
                        Rigid[i, k] = 2 * double.Parse(m_Out[1].ToString()) * Math.Sin(theta) * Math.Cos(theta);
                        Anechoic[i, k] = 2 * double.Parse(m_Out[2].ToString()) * Math.Sin(theta) * Math.Cos(theta);
                        TL[i, k] = 2 * double.Parse(m_Out[3].ToString()) * Math.Sin(theta) * Math.Cos(theta);
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

			IsMaterialCreateCheck(); // �ϳ��� ������ true  ->> ��� �ٽ� �����Ͽ��� ��

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
		/// �ϳ��� ������ true ��� �ٽ� �����Ͽ��� ��
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
