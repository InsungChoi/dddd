using System;
using System.IO;
using System.Data;

namespace HONUS.Common_Class
{
	/// <summary>
	/// MPEData에 대한 요약 설명입니다.
	/// </summary>
	public class MPEData
	{
		// MPEGraph
		public ClsData Frequency;
		public ClsData MAbsorption;
		// [Q] MSurfaceImpedance의 Real과 Imagenary의 분리가 필요한가?
		public ClsData MRealSurfaceImpedance;
		public ClsData MImagSurfaceImpedance;
		public ClsData CAbsorption;
		public ClsData CRealSurfaceImpedance;
		public ClsData CImagSurfaceImpedance;

		private MPE.MPEclassClass MeritCalcClass;


		public int[] freq = new int[3];
		public double Resolution;
		public double[] MRealSurfaceImpedanceSampled;
		public double[] MlmagSurfaceImpedanceSampled;
		public double[] TempFrequency = new double[32];
		public double[] TempMAbsorption = new double[32];
		public double[] TempMRealSurfaceImpedance = new double[32];
		public double[] TempMImagSurfaceImpedance = new double[32];
		public double[] ttempMAbsorption = new double[32];		

		// MAT Param
		public double Thickness;
		public double BulkDensity;
		public double FResist;
		public double SFactor;
		public double Porosity;
		public double ViscousCL;
		public double ThermalCL;
		public double c1;
		public double c2;

		public double Ymodulus;
		public double PoissonR;
		public double LossFactor;

		//temporary values of parameters (Limp or Rigid material) 
		public double tFResist;
		public double tSFactor;
		public double tPorosity;
		public double tc1;
		public double tc2;


		//temparary Matrices of parameters
		public double[,] FResistMat;
		public double[,] SFactorMat;
		public double[,] PorosityMat;
		public double[,] c1Mat;
		public double[,] c2Mat;
		public double[] YmodulusMat;
		public double[,] PoissonRMat;
		public double[,] LossFactorMat;

		// estimation Identification
		public int ParaIndenti;
		public double[] PrePara;

		// Common Info Param
		public int SID;
		public string Name;
		public int MID;
		// [Q] Temperature 항목은 DB에 넣는 것인가?
		public double Temperature;

		// Est Param
		public int EstOption;
		public bool FResistEst;
		public bool SFactorEst;
		public bool ViscousCLEst;
		public bool ThermalCLEst;
		public bool PorosityEst;

		public bool YmodulusEst;
		public bool PoissonREst;
		public bool LossFactorEst;


		//Matlab variable  //INSUNG
		public MWArray m_c;
		public MWArray m_Density1;
		public MWArray m_DensityA;
		public MWArray m_Densityo;
		public MWArray m_FlowRes;
		public MWArray m_Porosity;
		public MWArray m_SFactor;
		public MWArray m_Z0;
		public MWArray m_Thickness;
		public MWArray[] m_Frequency;
		public MWArray[] m_MAbsorption;
		public MWArray m_B;
		public MWArray m_Npr;
		public MWArray m_HeatRatio;
		public MWArray m_ItaAir;
		public MWArray m_P0;
		public MWArray m_Merit;
		public MWArray m_Absorption;
		public MWArray[,] m_APFibrous;
		public MWArray[] m_DataFitted;
		public MWArray m_ImagSurfaceImpedance;
		public MWArray m_RealSurfaceImpedance;
		public MWArray m_SolidPara;
		public MWArray m_Out;
		
		
		

		// Local Parameter
		private double HeatRatio;
		private double Npr;
		private double ItaAir;
		private double P0;
		private double Densityo;
		private double C;
		private double Z0;
		private double B;
		public int InitFre;
		public int MaxFre;

		public MPEData()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			Frequency = new ClsData();
			MAbsorption = new ClsData();
			MRealSurfaceImpedance = new ClsData();
			MImagSurfaceImpedance = new ClsData();
			CAbsorption = new ClsData();
			CRealSurfaceImpedance = new ClsData();
			CImagSurfaceImpedance = new ClsData();
			MeritCalcClass = new MPE.MPEclassClass();

			FResistEst = true;
			SFactorEst = true;
			ViscousCLEst = true;
			ThermalCLEst = true;
			PorosityEst = true;
			YmodulusEst = true;
			PoissonREst = true;
			LossFactorEst = true;
		}
		/// <summary>
		/// 동일한 내용을 가지는 MPEData 오브젝트를 생성
		/// </summary>
		/// <returns></returns>
		public MPEData Copy()
		{
			// 변수의 초기값을 복사
			MPEData NewData = new MPEData();
			NewData.Thickness = Thickness;
			NewData.BulkDensity = BulkDensity;
			NewData.FResist = FResist;
			NewData.SFactor = SFactor;
			NewData.Porosity = Porosity;
			NewData.ViscousCL = ViscousCL;
			NewData.ThermalCL = ThermalCL;
			NewData.Ymodulus = Ymodulus;
			NewData.PoissonR = PoissonR;
			NewData.LossFactor = LossFactor;

			NewData.EstOption = EstOption;

			NewData.FResistEst = FResistEst;
			NewData.SFactorEst = SFactorEst;
			NewData.ViscousCLEst = ViscousCLEst;
			NewData.ThermalCLEst = ThermalCLEst;
			NewData.PorosityEst = PorosityEst;
			NewData.YmodulusEst = YmodulusEst;
			NewData.PoissonREst = PoissonREst;
			NewData.LossFactorEst = LossFactorEst;

			// 따로 복사 루틴을 형성해야하는지 테스트할 것.
			//NewData.Frequency = Frequency;
			//NewData.MAbsorption = MAbsorption;
			//NewData.MSurfaceImpedance = MSurfaceImpedance;
			//NewData.CAbsorption = CAbsorption;
			//NewData.CSurfaceImpedance = CSurfaceImpedance;

			NewData.MID = MID;
			NewData.SID = SID;
			NewData.Name = Name;
			NewData.Temperature = Temperature;
				

			return NewData;
		}


		public bool DBLoad(bool IsSingle,int dID)
		{
			// SID에 해당하는 DB로부터 로드
			bool result = false;

			HONUS.MaterialDatabase.Component.MD_DB MD_DB1 = new HONUS.MaterialDatabase.Component.MD_DB();

			DataSet ds = MD_DB1.Search_ID(IsSingle,dID.ToString());

			string str_X = "";
			string str_Y = "";
			string [] dim_X;
			string [] dim_Y;

			str_X = ds.Tables[0].Rows[0]["X_Axis"].ToString();
			if(ds.Tables[0].Rows[0]["Y_RigidBacking"].ToString() != "" && ds.Tables[0].Rows[0]["Y_RigidBacking"].ToString() != "0")
			{
				str_Y = ds.Tables[0].Rows[0]["Y_RigidBacking"].ToString();
			}
			else if(ds.Tables[0].Rows[0]["Y_AnechoicTermination"].ToString() != "" && ds.Tables[0].Rows[0]["Y_AnechoicTermination"].ToString() != "0")
			{
				str_Y = ds.Tables[0].Rows[0]["Y_AnechoicTermination"].ToString();
			}
			else if(ds.Tables[0].Rows[0]["Y_TransmissionLoss"].ToString() != "" && ds.Tables[0].Rows[0]["Y_TransmissionLoss"].ToString() != "")
			{
				str_Y = ds.Tables[0].Rows[0]["Y_TransmissionLoss"].ToString();
			}

			if(str_X != "")
			{
				dim_X = str_X.Split(",".ToCharArray());
				dim_Y = str_Y.Split(",".ToCharArray());

				if(dim_X.Length == dim_Y.Length)
				{
					for(int i = 0 ; i < dim_X.Length ; i++)
					{
						Frequency.AddData(double.Parse(dim_X[i].ToString()));
						MAbsorption.AddData(double.Parse(dim_Y[i].ToString()));

						result = true;
					}
				}
			}

			return result;
		}

		/// <summary>
		/// 측정결과 파일로부터 Measured Absorbtion 데이터와 임피던스 데이터를 읽어들임.
		/// </summary>
		/// <param name="strFileName"></param>
		/// <returns></returns>
		public bool FileLoad(string strFileName)
		{
			// FileName에 해당하는 파일로부터 파일을 읽음
			bool result = false;

			if(File.Exists(strFileName) == true)
			{

				Frequency.Clear();
				MAbsorption.Clear();
				MRealSurfaceImpedance.Clear();
				MImagSurfaceImpedance.Clear();

				if(System.IO.Path.GetExtension(strFileName) == ".txt")
				{
					TextReader textReader = new StreamReader(new FileStream(strFileName,FileMode.Open));
					//Regex regex = new Regex(Environment.NewLine);
					string strin = textReader.ReadToEnd();
					textReader.Close();

					string [] strLine = strin.Split("\r\n".ToCharArray());
					for(int i = 1 ; i < strLine.Length ; i++)
					{
						string [] strWord = strLine[i].Split("\t".ToCharArray());

						if(strWord.Length == 2)
						{
							Frequency.AddData(double.Parse(strWord[0].ToString()));
							MAbsorption.AddData(double.Parse(strWord[1].ToString()));

							result = true;
						}
						else if(strWord.Length == 6)
						{
							Frequency.AddData(double.Parse(strWord[0].ToString()));
							MAbsorption.AddData(double.Parse(strWord[1].ToString()));
					
							//double Temp_4Col = double.Parse(strWord[4].ToString());
							//double Temp_5Col = double.Parse(strWord[5].ToString());
					
							MRealSurfaceImpedance.AddData(double.Parse(strWord[4].ToString()));
							MImagSurfaceImpedance.AddData(double.Parse(strWord[5].ToString()));
							result = true;
						}
					}
				}
				else if(System.IO.Path.GetExtension(strFileName) == ".xls")
				{
					int count = 2;
                    
					Microsoft.Office.Interop.Excel.Application xlApp;
					Microsoft.Office.Interop.Excel.Workbook xlBook;
					Microsoft.Office.Interop.Excel.Worksheet xlSheet;

					xlApp = new Microsoft.Office.Interop.Excel.Application();
					xlApp.Visible = false;

					try
					{
						xlBook = xlApp.Workbooks.Open(strFileName, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, true, 0, true,false,false);
						Microsoft.Office.Interop.Excel.Sheets sheets = xlBook.Worksheets;
						xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(1);

						while(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"A"]).Text.ToString() != "")
						{
							// strWord.Length == 2
							if(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"C"]).Text.ToString() == "")
							{
								Frequency.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"A"]).Text.ToString()));
								MAbsorption.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"B"]).Text.ToString()));

								result = true;
							}
							else if(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"F"]).Text.ToString() != "") // strWord.Length == 6
							{
								Frequency.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"A"]).Text.ToString()));
								MAbsorption.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"B"]).Text.ToString()));
					
								//double Temp_4Col = double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"D"]).Text.ToString());
								//double Temp_5Col = double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"E"]).Text.ToString());
					
								//MSurfaceImpedance.AddData(double.Parse(Math.Sqrt(Math.Pow(Temp_4Col,2) + Math.Pow(Temp_5Col,2)).ToString()));
								MRealSurfaceImpedance.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"E"]).Text.ToString()));
								MImagSurfaceImpedance.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"F"]).Text.ToString()));

								result = true;
							}

							count++;
						}

						System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheet);
						xlSheet = null;

						xlBook.Close(false, strFileName, false);
						System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook);
						xlBook = null;
					}
					finally
					{
						xlApp.Quit();
						System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
						xlApp = null;

						GC.Collect();
						GC.WaitForPendingFinalizers();
					}
				}
			}

			return result;
		}

		public bool FileLoad_2(string strFileName)
		{
			// FileName에 해당하는 파일로부터 파일을 읽음
			bool result = false;

			if(File.Exists(strFileName) == true)
			{

				Frequency.Clear();
				MAbsorption.Clear();
				MRealSurfaceImpedance.Clear();
				MImagSurfaceImpedance.Clear();

				if(System.IO.Path.GetExtension(strFileName) == ".txt")
				{
					TextReader textReader = new StreamReader(new FileStream(strFileName,FileMode.Open));
					//Regex regex = new Regex(Environment.NewLine);
					string strin = textReader.ReadToEnd();
					textReader.Close();

					string [] strLine = strin.Split("\r\n".ToCharArray());
					for(int i = 1 ; i < strLine.Length ; i++)
					{
						string [] strWord = strLine[i].Split("\t".ToCharArray());

						if(strWord.Length == 2)
						{
							Frequency.AddData(double.Parse(strWord[0].ToString()));
							MAbsorption.AddData(double.Parse(strWord[1].ToString()));

							result = true;
						}
						else if(strWord.Length == 6)
						{
							Frequency.AddData(double.Parse(strWord[0].ToString()));
							MAbsorption.AddData(double.Parse(strWord[1].ToString()));
					
							MRealSurfaceImpedance.AddData(double.Parse(strWord[4].ToString()));
							MImagSurfaceImpedance.AddData(double.Parse(strWord[5].ToString()));
							result = true;
						}
					}
				}
				else if(System.IO.Path.GetExtension(strFileName) == ".xls")
				{
					int count = 2;

					Microsoft.Office.Interop.Excel.Application xlApp;
					Microsoft.Office.Interop.Excel.Workbook xlBook;
					Microsoft.Office.Interop.Excel.Worksheet xlSheet;

					xlApp = new Microsoft.Office.Interop.Excel.Application();
					xlApp.Visible = false;

					try
					{
						xlBook = xlApp.Workbooks.Open(strFileName, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, true, 0, true,false,false);
						Microsoft.Office.Interop.Excel.Sheets sheets = xlBook.Worksheets;
						xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(1);

						while(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"A"]).Text.ToString() != "")
						{
							// strWord.Length == 2
							if(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"C"]).Text.ToString() == "")
							{
								Frequency.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"A"]).Text.ToString()));
								MAbsorption.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"B"]).Text.ToString()));

								result = true;
							}
							else if(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"F"]).Text.ToString() != "") // strWord.Length == 6
							{
								Frequency.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"A"]).Text.ToString()));
								MAbsorption.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"B"]).Text.ToString()));
					
								//double Temp_4Col = double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"D"]).Text.ToString());
								//double Temp_5Col = double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"E"]).Text.ToString());
					
								//MSurfaceImpedance.AddData(double.Parse(Math.Sqrt(Math.Pow(Temp_4Col,2) + Math.Pow(Temp_5Col,2)).ToString()));
								MRealSurfaceImpedance.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"E"]).Text.ToString()));
								MImagSurfaceImpedance.AddData(double.Parse(((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[count,"F"]).Text.ToString()));

								result = true;
							}

							count++;
						}

						System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheet);
						xlSheet = null;

						xlBook.Close(false, strFileName, false);
						System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook);
						xlBook = null;
					}
					finally
					{
						xlApp.Quit();
						System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
						xlApp = null;

						GC.Collect();
						GC.WaitForPendingFinalizers();
					}
				}
			}

			return result;
		}


		public bool Calc()
		{
			double[] Errors;
			double[,] OptSolidPara;
			double[] ErrorTemp;
			
			CalcBasicParameters();
			CalcFrequency();
			InitialGuess();

			FillMeritCalc();

			ErrorTemp =new double[2] {1,1000};

			MeritCalcClass.Density1=BulkDensity;

			do 
			{
				Errors = ErrorTemp;
				//string Start1 = System.DateTime.Now.ToLongTimeString();
				PECalc(Errors);
				//string End1 = System.DateTime.Now.ToLongTimeString();
				ErrorTemp = ErrorCalc(tFResist, tSFactor, tPorosity, tc1, tc2);
				System.Windows.Forms.Application.DoEvents();

			} while ( (Errors[0] < ErrorTemp[0]) || (Errors[1] < ErrorTemp[1]) );
            
			if ((MID == 7) && ( YmodulusEst || PoissonREst || LossFactorEst))
			{
				MeritCalcClass.DensityA=Densityo*Porosity*(SFactor-1);

				OptSolidPara=SolidCalc();
				Ymodulus=OptSolidPara[1,1];
				LossFactor=OptSolidPara[1,2];
				PoissonR=OptSolidPara[1,3];

				CalcElasticGraphData();
			}
			else
			{
				CalcFiborousGraphData();
			}
			//
			return true;
		}


		// [Q] Basic Material Property의 값이 바뀔 수도 있나?
		/// <summary>
		/// 기본 파라메터값들의 지정
		/// </summary>
		private void CalcBasicParameters()
		{
			double C0;

			HeatRatio = 1.4;
			Npr = 0.732;
			ItaAir = 1.84 * Math.Pow(10,-5);
			P0 = 101325;
			Densityo = 1.21;

			C0 = 331.5;
			C = C0 * Math.Sqrt(1+Temperature/273);

			Z0=Densityo*C;

			if (MID ==5)
			{
				B=1;
			} 
			else
			{
				B=0;
			}
		}


		/// <summary>
		/// 폴리핏팅을 수행하고 기본 주파수영역을 계산
		/// </summary>
		private void CalcFrequency()
		{
			//double Resolution;
			int MaxPoint = 0;

			// Sampled
			Resolution = (double)Frequency.GetData(4) - (double)Frequency.GetData(3);

			InitFre = (int)Math.Round(300/Resolution);
			MaxFre = (int)Math.Round(6400/Resolution);

			double[] FrequencySampled = new double[(int)(MaxFre-InitFre)];
			double[] MAbsorptionSampled = new double[(int)(MaxFre-InitFre)];
			MRealSurfaceImpedanceSampled = new double[(int)(MaxFre-InitFre)];
			MlmagSurfaceImpedanceSampled = new double[(int)(MaxFre-InitFre)];

			double[] FrequencyFitted = new double[32];
			//			double[] MAbsorptionFitted = new double[32];
			//			double[] MSurfaceImpedanceFitted = new double[32];

			FrequencySampled[0] = 0;
			MAbsorptionSampled[0] = 0;

			for (int i=1;i<(MaxFre-InitFre);i++)
			{
				FrequencySampled[i] = Frequency.GetData(InitFre + i-1);
				MAbsorptionSampled[i] = MAbsorption.GetData(InitFre + i-1);
			}

			
			for (int i=1;i<33;i++)
			{
				FrequencyFitted[i-1] = i*200;
			}

			//MeritCalcClass.polyfitting(FrequencyFitted, FrequencySampled, MAbsorptionSampled, 13);  //INSUNG
			MeritCalcClass.polyfitting(MAbsorptionSampled, FrequencyFitted, FrequencySampled, 13);

			//			MAbsorptionFitted = ((Array)MeritCalcClass.DataFitted).;

			long[] temp = new long[2];
			temp[0] = 1;
			temp[1] = 1;

			for (int i=1;i<33;i++)
			{
				TempFrequency[i-1] = FrequencyFitted[i-1];
				temp[1] = i;
				//TempMAbsorption[i-1] = (double)((Array)MeritCalcClass.DataFitted).GetValue(temp);
				TempMAbsorption[i-1] = (double)((MWNumericArray)m_DataFitted).ToVector(MWArrayComponent.Real).GetValue(temp);//INSUNG
			}


			if (MRealSurfaceImpedance.GetCount()>0)
			{
				MRealSurfaceImpedanceSampled[0] = 0;
				for (int i=1;i<(MaxFre-InitFre);i++)
				{
					MRealSurfaceImpedanceSampled[i] = MRealSurfaceImpedance.GetData(InitFre + i-1);
				}

				//MeritCalcClass.polyfitting(FrequencyFitted, FrequencySampled, MRealSurfaceImpedanceSampled, 13); //INSUNG
				MeritCalcClass.polyfitting(MRealSurfaceImpedanceSampled, FrequencyFitted, FrequencySampled, 13);
				//				MSurfaceImpedanceFitted = (double[])MeritCalcClass.DataFitted;
				
				for (int i=1;i<33;i++)
				{
					temp[1] = i;
					//TempMRealSurfaceImpedance[i-1] = (double)((Array)MeritCalcClass.DataFitted).GetValue(temp);
					TempMRealSurfaceImpedance[i-1] = (double)((MWNumericArray)m_DataFitted).ToVector(MWArrayComponent.Real).GetValue(temp);//INSUNG
				}
			}

			if (MImagSurfaceImpedance.GetCount()>0)
			{
				MlmagSurfaceImpedanceSampled[0] = 0;
				for (int i=1;i<(MaxFre-InitFre);i++)
				{
					MlmagSurfaceImpedanceSampled[i] = MImagSurfaceImpedance.GetData(InitFre + i-1);
				}

				//MeritCalcClass.polyfitting(FrequencyFitted, FrequencySampled, MlmagSurfaceImpedanceSampled, 13);  //INSUNG
				MeritCalcClass.polyfitting(MlmagSurfaceImpedanceSampled, FrequencyFitted, FrequencySampled, 13);
				//				MSurfaceImpedanceFitted = (double[])MeritCalcClass.DataFitted;
				
				for (int i=1;i<33;i++)
				{
					temp[1] = i;
					//TempMImagSurfaceImpedance[i-1] = (double)((Array)MeritCalcClass.DataFitted).GetValue(temp);
					TempMImagSurfaceImpedance[i-1] = (double)((MWNumericArray)m_DataFitted).ToVector(MWArrayComponent.Real).GetValue(temp);//INSUNG
				}
			}




			MaxPoint = GetMaxPoint(TempMAbsorption) + 1;

			SetFreq(1, MaxPoint, 32);
		}
		

		/// <summary>
		/// freq 변수를 셋팅함.
		/// </summary>
		/// <param name="Freq0"></param>
		/// <param name="Freq1"></param>
		/// <param name="Freq2"></param>
		/// <param name="Freq3"></param>
		/// <param name="Freq4"></param>
		/// <param name="Freq5"></param>
		/// <param name="Freq6"></param>
		/// <param name="Freq7"></param>
		/// <param name="Freq8"></param>
		/// <returns></returns>
		public void SetFreq(int Freq0, int Freq1, int Freq2)
		{
			freq[0] = Freq0;
			freq[1] = Freq1;
			freq[2] = Freq2;
		}

		/// <summary>
		/// 데이터의 최고값을 지나는 변곡점을 계산하는 서브루틴
		/// </summary>
		/// <param name="Data">데이터값</param>
		/// <returns></returns>
		private int GetMaxPoint(double[] Data)
		{
			int MaxIndex = 0;
			for (int i=0; i<Data.GetUpperBound(0); i++)
			{
				if (Data[i] < Data[i+1])
				{
					MaxIndex = i+1;
				} 
				else
				{
					break;
				}
			}
			return MaxIndex;
		}

		/// <summary>
		/// 초기 파라메터 추측값
		/// </summary>
		private void InitialGuess()
		{
			if (FResistEst) tFResist=10;
			if (SFactorEst) tSFactor=1.0;
			if (PorosityEst) tPorosity=0.99;
			if (ViscousCLEst) 
			{
				tc1=1;
				//ViscousCL = Math.Sqrt(8*SFactor*ItaAir/(Porosity*FResist));
			}
			if (ThermalCLEst) 
			{
				tc2=1;
				//ThermalCL = Math.Sqrt(8*SFactor*ItaAir/(Porosity*FResist));
			}
		}
		
		
		private void FillMeritCalc()
		{
			MeritCalcClass.c = C;
			MeritCalcClass.HeatRatio = HeatRatio;
			MeritCalcClass.Npr = Npr;
			MeritCalcClass.ItaAir = ItaAir;
			MeritCalcClass.P0 = P0;
			MeritCalcClass.Densityo = Densityo;

			MeritCalcClass.Z0 = Z0;
			MeritCalcClass.B = B;

			MeritCalcClass.freq = freq;
			MeritCalcClass.MAbsorption = TempMAbsorption;
			MeritCalcClass.Frequency = TempFrequency;

			//MeritCalcClass.BulkDensity = BulkDensity;  //INSUNG
			MeritCalcClass.Thickness = Thickness;
			MeritCalcClass.FlowRes = FResist;
			MeritCalcClass.SFactor = SFactor;
			MeritCalcClass.Porosity = Porosity;
			MeritCalcClass.ViscousCL = ViscousCL;
			MeritCalcClass.ThermalCL = ThermalCL;

			MeritCalcClass.FlowResEst = FResistEst;
			MeritCalcClass.SFactorEst = SFactorEst;
			MeritCalcClass.PorosityEst = PorosityEst;
			MeritCalcClass.ViscousCLEst = ViscousCLEst;
			MeritCalcClass.ThermalCLEst = ThermalCLEst;

		}



		/// <summary>
		/// PE Fibrous Calc
		/// </summary>
		/// <param name="PrevError"></param>
		/// <returns></returns>
		
		public double[] PECalc(double[] PrevError)
		{

			double OptFResist;
			double[] OptSFactorAndPorosity;
			double[] OptShapeFactor;

			double[] Errors;

			// FEFibourous 루틴
			//c1 = Math.Sqrt(8*tSFactor*ItaAir/(tPorosity*tFResist))/ViscousCL;
			//c2 = Math.Sqrt(8*tSFactor*ItaAir/(tPorosity*tFResist))/ThermalCL;
            

			if(FResistEst)
			{
				OptFResist=FindFResist(Thickness, tFResist, tSFactor, tPorosity, tc1, tc2);
				tFResist=OptFResist;
			}
			else if(!FResistEst)
			{
				tFResist=FResist;
			}
		
			if(SFactorEst && PorosityEst)
			{
				OptSFactorAndPorosity = new double[2];	
				OptSFactorAndPorosity=FindSFactorAndPorosity(Thickness, tFResist, tSFactor, tPorosity, tc1, tc2);
				tSFactor=OptSFactorAndPorosity[0];
				tPorosity=OptSFactorAndPorosity[1];
			}
			else if(!SFactorEst && PorosityEst)
			{
		        tSFactor=SFactor;
				OptSFactorAndPorosity = new double[2];	
				OptSFactorAndPorosity=FindSFactorAndPorosity(Thickness, tFResist, tSFactor, tPorosity, tc1, tc2);
				tPorosity=OptSFactorAndPorosity[1];
			}
			else if(SFactorEst && !PorosityEst)
			{
				tPorosity=Porosity;
				OptSFactorAndPorosity = new double[2];	
				OptSFactorAndPorosity=FindSFactorAndPorosity(Thickness, tFResist, tSFactor, tPorosity, tc1, tc2);
				tSFactor=OptSFactorAndPorosity[0];
			}
						
			if(ViscousCLEst && ThermalCLEst)
			{
				OptShapeFactor = new double[2];	
				OptShapeFactor=FindShapeFactors(Thickness, tFResist, tSFactor, tPorosity, tc1, tc2);
				tc1=OptShapeFactor[0];
				tc2=OptShapeFactor[1];
			}
			else if(!ViscousCLEst && ThermalCLEst)
			{
				tc1=c1;
				OptShapeFactor = new double[2];	
				OptShapeFactor=FindShapeFactors(Thickness, tFResist, tSFactor, tPorosity, tc1, tc2);
				tc2=OptShapeFactor[1];
			}
			else if(ViscousCLEst && !ThermalCLEst)
			{
				tc2=c2;
				OptShapeFactor = new double[2];	
				OptShapeFactor=FindShapeFactors(Thickness, tFResist, tSFactor, tPorosity, tc1, tc2);
				tc1=OptShapeFactor[0];
			}
			
			//Overall Error Rigid 루틴
			Errors = ErrorCalc(tFResist, tSFactor, tPorosity, tc1, tc2);

			// 에러가 줄었으면 값을 저장
			if (Errors[0] < PrevError[0] || Errors[1] < PrevError[1])
			{
				FResist = tFResist;
				SFactor = tSFactor;
				Porosity = tPorosity;
				c1=tc1;
				c2=tc2;

				ViscousCL = Math.Sqrt(8*SFactor*ItaAir/(Porosity*FResist))/c1;
				ThermalCL = Math.Sqrt(8*SFactor*ItaAir/(Porosity*FResist))/c2;
			}

			return Errors;
		}
		
		public double FindFResist(double Thickness,double tFResist, double tSFactor, double tProsity, double tc1, double tc2)
		{
			double OptFResist=tFResist;
			int[] FreRegion=new int[2];
			
			if (freq[1]+10 < 32)
			{
				FreRegion=new int[2] {freq[0], freq[1]};
			}
			else if (freq[1]+10 >= 32)
			{
				FreRegion=new int[2] {freq[0], 32} ;
			}
			if(FResistEst)
			{
				double[,] FResistMat= new double[1,600];
				double[] ValueIndex=new double[3];

				int LoopNum=1;
				int Incre=500;
				
				ParaIndenti=1;
 
				for(int i=0;i<FResistMat.GetLength(1);i++) 
				{
					FResistMat[0,i]=Incre*(i+1);
				}
				
				ValueIndex=CalOptValuesIndexFind(Thickness, BulkDensity, FResistMat, tSFactor, tPorosity, tc1, tc2, FreRegion,ParaIndenti,LoopNum);
				OptFResist=FResistMat[(int)ValueIndex[0],(int)ValueIndex[1]];

				double[] PrePara=new double[] {OptFResist};

				LoopNum=2;				

				FResistMat= new double[1,100];
				Incre=10;
				for(int i=0;i<FResistMat.GetLength(1);i++)
				{
					FResistMat[0,i]=i*Incre+PrePara[0]-500;
				}

				ValueIndex=CalOptValuesIndexFind(Thickness, BulkDensity, FResistMat, tSFactor, tPorosity, tc1, tc2, FreRegion,ParaIndenti,LoopNum);
				OptFResist=FResistMat[(int)ValueIndex[0],(int)ValueIndex[1]];
				
				PrePara=new double[] {OptFResist};
	
			}            
			return OptFResist;
			
		}
		
		public double[] FindSFactorAndPorosity(double Thickness, double tFResist, double tSFactor, double tProsity, double tc1, double tc2)
		{
			double[] ValueIndex=new double[3];
			int[] FreRegion=new int[2];
			double[] PrePara=new double[2];
			
			if ( (freq[1]+10 < 32) && (freq[1]-10 > 0) )
			{
				FreRegion=new int[2] {freq[1]-10, freq[2]};
			}
			else if ( (freq[1]+10 < 32) && (freq[1]-10 <= 0) )
			{
                FreRegion=new int[2] {freq[0], freq[2]};
			}
			else if (freq[1]+10 >= 32)
			{
				FreRegion=new int[2] {freq[1]-10, freq[2]};
			}

			double Incre=0.1;

			int LoopNum=1;
                         			
			if(SFactorEst & (!PorosityEst) )
			{
				SFactorMat=new double[1,90];
				PorosityMat=new double[1,1] {{tPorosity}};
				ParaIndenti=2;
				for(int i=0;i<90;i++) 
				{
					SFactorMat[0,i]=i*Incre+1;
				}
			}
			else if((!SFactorEst) & PorosityEst)
			{
				SFactorMat=new double[1,1] {{tSFactor}};
				PorosityMat=new double[9,1];
				ParaIndenti=3;
				for(int i=0;i<9;i++)
				{
					PorosityMat[i,0]=(i+1)*Incre-0.01;
				}
			}
			else if(SFactorEst & PorosityEst)
			{
				SFactorMat=new double[10,90];
				PorosityMat=new double[10,90];
				ParaIndenti=4;

				for(int i=0;i<SFactorMat.GetLength(1);i++)
				{
					SFactorMat[0,i]=i*Incre+1;
				}    
				for(int i=0;i<PorosityMat.GetLength(0);i++)
				{
					PorosityMat[i,0]=(i+1)*Incre-0.001;
				}
				for(int i=0;i<SFactorMat.GetLength(1);i++)
				{
					for(int j=0;j<PorosityMat.GetLength(0);j++)
					{
						SFactorMat[j,i]=SFactorMat[0,i];
						PorosityMat[j,i]=PorosityMat[j,0]; 
					}
				}
			}

			ValueIndex=CalOptValuesIndexFind(Thickness, BulkDensity,tFResist, SFactorMat, PorosityMat, tc1, tc2, FreRegion,ParaIndenti,LoopNum);
			PrePara[0]=SFactorMat[(int)ValueIndex[0],(int)ValueIndex[1]];
			PrePara[1]=PorosityMat[(int)ValueIndex[0],(int)ValueIndex[1]];
            
			Incre=0.01;

			if(SFactorEst & (!PorosityEst) )
			{
				SFactorMat=new double[1,20];
				PorosityMat=new double[1,1] {{tPorosity}};
				ParaIndenti=2;
				for(int i=0;i<20;i++) 
				{
					SFactorMat[0,i]=i*Incre+PrePara[0]-0.1+1;
				}
			}
			else if((!SFactorEst) & PorosityEst)
			{
				SFactorMat=new double[1,1] {{tSFactor}};
				PorosityMat=new double[20,1];
				ParaIndenti=3;
				for(int i=0;i<20;i++)
				{
					PorosityMat[i,0]=i*Incre+PrePara[1]-0.1;
				}
			}
			else if(SFactorEst & PorosityEst)
			{
				SFactorMat=new double[20,20];
				PorosityMat=new double[20,20];
				ParaIndenti=4;

				double PorosityMem=0;
				for(int i=0;i<SFactorMat.GetLength(1);i++)
				{
					if (PrePara[0]-0.1 >= 1)
					{
						SFactorMat[0,i]=i*Incre+PrePara[0]-0.1;
					}
					else if (PrePara[0]-0.1 < 1)
					{
						SFactorMat[0,i]=i*Incre+1;
					}
				}    
				for(int i=0;i<PorosityMat.GetLength(0);i++)
				{
					PorosityMem=i*Incre+PrePara[1]-0.1;
					if (PorosityMem < 0.999)
					{
						PorosityMat[i,0]=i*Incre+PrePara[1]-0.1;
					}
					else if (PorosityMem >= 0.999)
					{
						PorosityMat[i,0]=0.999;
					}
				}
				for(int i=0;i<SFactorMat.GetLength(1);i++)
				{
					for(int j=0;j<PorosityMat.GetLength(0);j++)
					{
						SFactorMat[j,i]=SFactorMat[0,i];
						PorosityMat[j,i]=PorosityMat[j,0]; 
					}
				}
			}
			LoopNum=2;
			ValueIndex=CalOptValuesIndexFind(Thickness, BulkDensity, tFResist, SFactorMat, PorosityMat, tc1, tc2, FreRegion,ParaIndenti,LoopNum);
			double OptSFactor=SFactorMat[(int)ValueIndex[0],(int)ValueIndex[1]];
			double OptPorosity=PorosityMat[(int)ValueIndex[0],(int)ValueIndex[1]];
			
			double[] OptSFactorAndPorosity=new double[2] {OptSFactor,OptPorosity};
			
			return OptSFactorAndPorosity;
		}

		public double[] FindShapeFactors(double Thickness, double tFResist, double tSFactor, double tProsity, double tc1, double tc2)
		{
			int[] FreRegion=new int[2] {freq[0], freq[2]};
			double[] ValueIndex=new double[3];
			double Incre=0.1;

			int LoopNum=1;
            			
			if (ViscousCLEst & (!ThermalCLEst) )
			{
				c1Mat=new double[1,100];
				c2Mat=new double[1,1] {{tc2}};
				ParaIndenti=5;
				for(int i=0;i<100;i++) 
				{
					c1Mat[0,i]=(i+1)*Incre;
				}
			}
			else if((!ViscousCLEst) & ThermalCLEst)
			{
				c1Mat=new double[1,1] {{tc1}};
				c2Mat=new double[100,1];
				ParaIndenti=6;

				for(int i=0;i<100;i++)
				{
					c2Mat[i,0]=(i+1)*Incre;
				}
			}
			else if(ViscousCLEst & ThermalCLEst)
			{
				c1Mat=new double[100,100];
				c2Mat=new double[100,100];
				ParaIndenti=7;
				for(int i=0;i<c1Mat.GetLength(1);i++)
				{
					for(int j=0;j<c2Mat.GetLength(0);j++)
					{
						c1Mat[j,i]=(i+1)*Incre;
						c2Mat[j,i]=(j+1)*Incre; 
					}
				}
			}

			ValueIndex=CalOptValuesIndexFind(Thickness, BulkDensity, tFResist, tSFactor, tPorosity, c1Mat, c2Mat, FreRegion, ParaIndenti, LoopNum);
			double[] PrePara=new double[2];
			PrePara[0]=c1Mat[(int)ValueIndex[0],(int)ValueIndex[1]];
			PrePara[1]=c2Mat[(int)ValueIndex[0],(int)ValueIndex[1]];

			Incre=0.01;

			if(ViscousCLEst & (!ThermalCLEst) )
			{
				c1Mat=new double[1,20];
				c2Mat=new double[1,1] {{tc2}};
				ParaIndenti=5;

				if( (PrePara[0]-0.1) > 0)
				{
					for(int i=0;i<100;i++) 
					{
						c1Mat[0,i]=i*Incre+PrePara[0]-0.1;
					}
				}
				else if ((PrePara[0]-0.1) <= 0)
				{
					for(int i=0;i<100;i++) 
					{
						c1Mat[0,i]=i*Incre+0.1;
					}
				}
			}
			else if((!ViscousCLEst) & ThermalCLEst)
			{
				c1Mat=new double[1,1] {{tc1}};
				c2Mat=new double[20,1];
				ParaIndenti=6;

				for(int i=0;i<100;i++)
				{
					c2Mat[i,0]=i*Incre+PrePara[1]-0.1;
				}
				if( (PrePara[1]-0.1) > 0)
				{
					for(int i=0;i<100;i++) 
					{
						c1Mat[0,i]=i*Incre+PrePara[1]-0.1;
					}
				}
				else if ((PrePara[1]-0.1) <= 0)
				{
					for(int i=0;i<100;i++) 
					{
						c1Mat[0,i]=i*Incre+0.1;
					}
				}
			}
			else if(ViscousCLEst & ThermalCLEst)
			{
				c1Mat=new double[20,20];
				c2Mat=new double[20,20];
				ParaIndenti=7;

				for(int i=0;i<c1Mat.GetLength(1);i++)
				{
					if ((PrePara[0]-0.1)>0)
					{
						c1Mat[0,i]=(i+1)*Incre+PrePara[0]-0.1;
					}
					else if (((PrePara[0]-0.1)<=0))
					{
						c1Mat[0,i]=i*Incre+0.1;
					}
				}    
				for(int i=0;i<c2Mat.GetLength(0);i++)
				{
					if ((PrePara[1]-0.1)>0)
					{
						c2Mat[i,0]=i*Incre+PrePara[1]-0.1;
					}
					else if (((PrePara[1]-0.1)<=0))
					{
						c2Mat[i,0]=i*Incre+0.1;
					}
				}
				for(int i=0;i<c1Mat.GetLength(1);i++)
				{
					for(int j=0;j<c2Mat.GetLength(0);j++)
					{
						c1Mat[j,i]=c1Mat[0,i];
						c2Mat[j,i]=c2Mat[j,0]; 
					}
				}
			}

			LoopNum=2;
			ValueIndex=CalOptValuesIndexFind(Thickness, BulkDensity, tFResist, tSFactor, tPorosity, c1Mat, c2Mat, FreRegion, ParaIndenti,LoopNum);
			double Optc1=c1Mat[(int)ValueIndex[0],(int)ValueIndex[1]];
			double Optc2=c2Mat[(int)ValueIndex[0],(int)ValueIndex[1]];

			double[] Optc1AndOptc2=new double[3] {Optc1,Optc2,ValueIndex[1]};

			return Optc1AndOptc2;
		}
		public double[] CalOptValuesIndexFind(double Thickness, double BulkDensity, double[,] FResistMat, double tSFactor, double tPorosity, double tc1, double tc2, int[] FreRegion, int ParaIndenti,int LoopNum)
		{
			int RowSizeOfPara=0;
			int ColumSizeOfPara=0;
			int SizeOfPEFre=FreRegion[1]-FreRegion[0];
            double TempMaxError=0.0;
			double fre;
			double[] ValueIndex=new double[3];
			int[] CalOptValues=new int[2];

			RowSizeOfPara=FResistMat.GetLength(0);
			ColumSizeOfPara=FResistMat.GetLength(1);
			
			double[,,] MAbsorptionMat=new double[RowSizeOfPara,ColumSizeOfPara,SizeOfPEFre];
			double[,,] PDAbsorption=new double[RowSizeOfPara,ColumSizeOfPara,SizeOfPEFre];
			double[,,] CharFreError=new double[RowSizeOfPara,ColumSizeOfPara,SizeOfPEFre];
			double[,] CharFreErrorSum=new double[RowSizeOfPara,ColumSizeOfPara];
			double[,] APDAbsorption=new double[RowSizeOfPara,ColumSizeOfPara]; 
			double[,] MaxError=new double[RowSizeOfPara,ColumSizeOfPara];

			ttempMAbsorption=TempMAbsorption;

			for (int ff=0;ff<SizeOfPEFre;ff++)
			{
				fre=(ff+1)*200;
				//MeritCalcClass.apfibrous5para(Thickness, FResistMat, tSFactor, tPorosity, tc1, tc2,fre);   //INSUNG				
				m_APFibrous = MeritCalcClass.apfibrous5para(m_B,tc1,tc2,m_Density1,Densityo,FResistMat,fre,tPorosity,m_HeatRatio,m_ItaAir,Thickness,m_Npr,M_P0,tSFactor,m_Z0); //INSUNG
				APDAbsorption=(double[,])MeritCalcClass.APFibrous;
				
				for (int i=0;i<RowSizeOfPara;i++)
				{
					for (int j=0; j<ColumSizeOfPara;j++)
					{
						MAbsorptionMat[i,j,ff]=ttempMAbsorption[ff];
						PDAbsorption[i,j,ff]=APDAbsorption[i+1,j+1];
						CharFreError[i,j,ff]=Math.Abs(MAbsorptionMat[i,j,ff]-PDAbsorption[i,j,ff]);
					}
				}
			}

			for (int i=0;i<RowSizeOfPara;i++)
			{
				TempMaxError=0;
				for(int j=0;j<ColumSizeOfPara;j++)
				{
					TempMaxError=0;
    				for(int ff=0;ff<(SizeOfPEFre-1);ff++)
					{
						if (TempMaxError < CharFreError[i,j,ff])
						{
						   TempMaxError=CharFreError[i,j,ff];
                           MaxError[i,j]=TempMaxError;
						}
						//CharFreErrorSum[i,j]+= CharFreError[i,j,ff];
					}
				} 
			}		
		
			ValueIndex=FindMin(MaxError, RowSizeOfPara, ColumSizeOfPara);
			//ValueIndex=FindMin(CharFreErrorSum, RowSizeOfPara, ColumSizeOfPara);
			
			return ValueIndex;
		}

		public double[] CalOptValuesIndexFind(double Thickness, double BulkDensity, double tFResist, double[,] SFactorMat, double[,] PorosityMat, double tc1, double tc2, int[] FreRegion, int ParaIndenti,int LoopNum)
		{
			int RowSizeOfPara=0;
			int ColumSizeOfPara=0;
			int SizeOfPEFre=FreRegion[1]-FreRegion[0];

			double fre;
			double[] ValueIndex=new double[3];
			int[] CalOptValues=new int[2];

			if (ParaIndenti==2)
			{
				RowSizeOfPara=SFactorMat.GetLength(0);;
				ColumSizeOfPara=SFactorMat.GetLength(1);
			}
			  
			else if (ParaIndenti==3)
			{
				RowSizeOfPara=PorosityMat.GetLength(0);;
				ColumSizeOfPara=PorosityMat.GetLength(1);
			}
			else if (ParaIndenti==4)
			{  
				RowSizeOfPara=SFactorMat.GetLength(0);;
				ColumSizeOfPara=SFactorMat.GetLength(1);
			}

			double[,,] MAbsorptionMat=new double[RowSizeOfPara,ColumSizeOfPara,SizeOfPEFre];
			double[,,] PDAbsorption=new double[RowSizeOfPara,ColumSizeOfPara,SizeOfPEFre];
			double[,,] CharFreError=new double[RowSizeOfPara,ColumSizeOfPara,SizeOfPEFre];
			double[,] CharFreErrorSum=new double[RowSizeOfPara,ColumSizeOfPara];
			double[,] APDAbsorption=new double[RowSizeOfPara,ColumSizeOfPara]; 


			ttempMAbsorption=TempMAbsorption;
			APDAbsorption.Initialize();

			for (int ff=0;ff<SizeOfPEFre;ff++)
			{
				fre=(ff+FreRegion[0])*200;
				//MeritCalcClass.apfibrous5para(Thickness, tFResist, SFactorMat, PorosityMat, tc1, tc2,fre);  //INSUNG
				m_APFibrous = MeritCalcClass.apfibrous5para(m_B,tc1,tc2,m_Density1,m_Densityo,tFResist,fre,PorosityMat,m_HeatRatio,m_ItaAir,Thickness,m_Npr,M_P0,SFactorMat,m_Z0); //INSUNG
				APDAbsorption=(double[,])MeritCalcClass.APFibrous;
				for (int i=0;i<RowSizeOfPara;i++)
				{
					for (int j=0; j<ColumSizeOfPara;j++)
					{
						MAbsorptionMat[i,j,ff]=ttempMAbsorption[ff+FreRegion[0]];
						PDAbsorption[i,j,ff]=APDAbsorption[i+1,j+1];
						CharFreError[i,j,ff]=Math.Abs(MAbsorptionMat[i,j,ff]-PDAbsorption[i,j,ff]);
					}
				}
			}
            
			for (int i=0;i<RowSizeOfPara;i++)
			{
				for(int j=0;j<ColumSizeOfPara;j++)
				{
					for(int ff=0;ff<(SizeOfPEFre-1);ff++)
					{
						CharFreErrorSum[i,j] += CharFreError[i,j,ff];
					}
				} 
			}		
		
			if (ParaIndenti==2)
			{
				ValueIndex=FindMin(CharFreErrorSum, RowSizeOfPara, ColumSizeOfPara);
			}
			else if (ParaIndenti==3)    
			{
				ValueIndex=FindMin(CharFreErrorSum, RowSizeOfPara, ColumSizeOfPara);
			}
			else if (ParaIndenti==4)
			{
				ValueIndex=FindMin(CharFreErrorSum, RowSizeOfPara, ColumSizeOfPara);
			}

			return ValueIndex;
		}

		public double[] CalOptValuesIndexFind(double Thickness, double BulkDensity, double tFResist, double tSFactor, double Porosity, double[,] c1Mat, double[,] c2Mat, int[] FreRegion, int ParaIndenti,int LoopNum)
		{
			int RowSizeOfPara= 0;
			int ColumSizeOfPara= 0;
			int SizeOfPEFre=32;
       //     double TempMaxError=0.0;

			double fre;
			double[] ValueIndex=new double[3];
			int[] CalOptValues=new int[2];

			if (ParaIndenti==5)
			{
				RowSizeOfPara=c1Mat.GetLength(0);;
				ColumSizeOfPara=c1Mat.GetLength(1);
			}
			else if (ParaIndenti==6)
			{
				RowSizeOfPara=c2Mat.GetLength(0);;
				ColumSizeOfPara=c2Mat.GetLength(1);
			}
			else if (ParaIndenti==7)
			{
				RowSizeOfPara=c1Mat.GetLength(0);;
				ColumSizeOfPara=c1Mat.GetLength(1);
			}
		
			double[,,] MAbsorptionMat=new double[RowSizeOfPara,ColumSizeOfPara,SizeOfPEFre];
			double[,,] PDAbsorption=new double[RowSizeOfPara,ColumSizeOfPara,SizeOfPEFre];
			double[,,] CharFreError=new double[RowSizeOfPara,ColumSizeOfPara,SizeOfPEFre];
			double[,] CharFreErrorSum=new double[RowSizeOfPara,ColumSizeOfPara];
			double[,] APDAbsorption=new double[RowSizeOfPara,ColumSizeOfPara]; 
			double[,] MaxError=new double[RowSizeOfPara,ColumSizeOfPara];
			ttempMAbsorption=TempMAbsorption;

			for (int ff=0;ff<SizeOfPEFre;ff++)
			{
				fre=(ff+1)*200;

				//MeritCalcClass.apfibrous5para(Thickness, tFResist, tSFactor, tPorosity, c1Mat, c2Mat,fre);  //INSUNG
				m_APFibrous = MeritCalcClass.apfibrous5para(m_B,c1Mat,c2Mat,m_Density1,m_Densityo,tFResist,fre,tPorosity,m_HeatRatio,m_ItaAir,Thickness,m_Npr,M_P0,tSFactor,m_Z0); //INSUNG
				APDAbsorption=(double[,])MeritCalcClass.APFibrous;

				for (int i=0;i<RowSizeOfPara;i++)
				{
					for (int j=0;j<ColumSizeOfPara;j++)
					{
						MAbsorptionMat[i,j,ff]=ttempMAbsorption[ff];
						PDAbsorption[i,j,ff]=APDAbsorption[i+1,j+1];
						CharFreError[i,j,ff]=Math.Abs(MAbsorptionMat[i,j,ff]-PDAbsorption[i,j,ff]);
					}
				}
			}
            
			for (int i=0;i<RowSizeOfPara;i++)
			{
				for(int j=0;j<ColumSizeOfPara;j++)
				{
					for(int ff=0;ff<SizeOfPEFre;ff++)
					{
						CharFreErrorSum[i,j] += CharFreError[i,j,ff];
					}
				} 
			}		
//			for (int i=0;i<RowSizeOfPara;i++)
//			{
//				TempMaxError=0;
//				for(int j=0;j<ColumSizeOfPara;j++)
//				{
//					TempMaxError=0;
//					for(int ff=0;ff<(SizeOfPEFre-1);ff++)
//					{
//						if (TempMaxError < CharFreError[i,j,ff])
//						{
//							TempMaxError=CharFreError[i,j,ff];
//							MaxError[i,j]=TempMaxError;
//						}
//						CharFreErrorSum[i,j]+= CharFreError[i,j,ff];
//					}
//				} 
//			}	
		
			if (ParaIndenti==5)
			{
				ValueIndex=FindMin(CharFreErrorSum, RowSizeOfPara, ColumSizeOfPara);
			}
			else if (ParaIndenti==6)
			{
				ValueIndex=FindMin(CharFreErrorSum, RowSizeOfPara, ColumSizeOfPara);
			}
			else if (ParaIndenti==7)
			{
				double FirstError=10000;
				double tempc1=0;
				double tempc2=0;
				//double Optc1=tc1;
				//double Optc2=tc2;
                
				for (int i=0;i<RowSizeOfPara;i++)
				{
					for (int j=0;j<ColumSizeOfPara;j++)
					{
						tempc1= c1Mat[i,j];
						tempc2= c2Mat[i,j];
	                    //if ( (MinMaxtError >= MaxError[i,j]) && (tempc1 >= tempc2) )
						if ( (FirstError >= CharFreErrorSum[i,j]) && (tempc1 >= tempc2) )
						{
							ValueIndex[0]=i;
							ValueIndex[1]=j;
							//ValueIndex[2]=CharFreErrorSum[i,j];
							//MinMaxError=MaxError[i,j];
							FirstError= CharFreErrorSum[i,j];
						}
					}
				}
			}
			
			return ValueIndex;
		}


		public double[] FindMin(double[,] CharFreErrorSum, int RowSizeOfPara, int ColumSizeOfPara )
		{
			double MinValue=CharFreErrorSum[0,0];
			int RowIndex=0;
			int ColumnIndex=0;
			double[] Indeces=new double[3];

			for (int i=0;i<RowSizeOfPara;i++)
			{
				
				for (int j=0;j<ColumSizeOfPara;j++)
				{
					if (CharFreErrorSum[i,j]<= MinValue)
					{
						MinValue=CharFreErrorSum[i,j];
						RowIndex=i;
						ColumnIndex=j;
						Indeces=new double[3] {RowIndex,ColumnIndex,MinValue};
					}

				}
			}
			return Indeces;
		}

		public double[] MeritCalc(double Freq1,double Freq2,double tFResist,double tSFactor,double tPorosity,double tc1,double tc2)
		{
			double Merit=0;
			double MaxError=0;
			double freq;
			double tempError;
			double[] Errors=new double[2];
			 
			for (int ff=(int)Freq1;ff<=(int)Freq2;ff++)
			{
				freq=TempFrequency[ff-1];
				//MeritCalcClass.meritcalc(freq, (double)TempMAbsorption[ff-1],BulkDensity, tFResist, tSFactor, tPorosity, tc1, tc2, Thickness);//INSUNG
				m_Out = MeritCalcClass.meritcalc(BulkDensity,m_B,tc1,tc2,m_Densityo,tFResist,freq,tPorosity,m_HeatRatio,m_ItaAir,Thickness,(double)TempMAbsorption[ff-1],m_Npr,m_P0,tSFactor,m_Z0);//INSUNG
				m_Merit = m_Out[1];
				m_Absorption= m_Out[2];
				m_RealSurfaceImpedance= m_Out[3];
				m_ImagSurfaceImpedance= m_Out[4];
				
				MeritCalcClass.Desity1 = BulkDensity;//INSUNG
				Merit=Merit+(double)(MeritCalcClass.Merit);
				tempError=(double)(MeritCalcClass.Merit);
				if(MaxError>tempError)
				{
					MaxError=tempError;
				}

				//System.Windows.Forms.Application.DoEvents();
			}
			Errors=new double[2] {MaxError,Merit};

			return Errors;
		}

		public double[] ErrorCalc(double tFResist,double tSFactor,double tPorosity,double tc1,double tc2)
		{
			return MeritCalc(1, 32, tFResist, tSFactor, tPorosity, tc1, tc2);
		}

	
		public double CalcFiborousGraphData()
		{
			double Merit=0;
			double freq;
            
			double c1 = Math.Sqrt(8*SFactor*ItaAir/(Porosity*FResist))/ViscousCL;
			double c2 = Math.Sqrt(8*SFactor*ItaAir/(Porosity*FResist))/ThermalCL;

			//			H = (Math.Pow(FResist*ViscousCL*Porosity,2))/(4*(Math.Pow(SFactor,2))*ItaAir*Densityo);
			//			HP = 16*ItaAir/((Math.Pow(Npr*ThermalCL,2))*Densityo);

			CAbsorption.Clear();
			CRealSurfaceImpedance.Clear();
			CImagSurfaceImpedance.Clear();

			CAbsorption.AddData(0);
			CRealSurfaceImpedance.AddData(0);
			CImagSurfaceImpedance.AddData(0);

			for (int ff=1;ff<=MaxFre;ff++)
			{
				freq=Frequency.GetData(ff);
				//MeritCalcClass.meritcalc(freq, (double)MAbsorption.GetData(ff),BulkDensity, FResist, SFactor, Porosity, c1, c2, Thickness);//INSUNG
				m_Out = MeritCalcClass.meritcalc(BulkDensity,m_B,c1,c2,m_Densityo,FResist,freq,Porosity,m_HeatRatio,m_ItaAir,Thickness,(double)MAbsorption.GetData(ff),m_Npr,m_P0,SFactor,m_Z0);//INSUNG
				m_Merit = m_Out[1];
				m_Absorption= m_Out[2];
				m_RealSurfaceImpedance= m_Out[3];
				m_ImagSurfaceImpedance= m_Out[4];
				MeritCalcClass.Desity1 = BulkDensity;//INSUNG
				
				CAbsorption.AddData((double)MeritCalcClass.Absorption);
				CRealSurfaceImpedance.AddData((double)MeritCalcClass.RealSurfaceImpedance);
				CImagSurfaceImpedance.AddData((double)MeritCalcClass.ImagSurfaceImpedance);
				Merit=Merit+(double)MeritCalcClass.Merit;
			}
            

			return Merit;

		}

		public double CalcElasticGraphData()
		{
			double Merit=0;

			double freq;

			//double c1 = Math.Sqrt(8*SFactor*ItaAir/(Porosity*FResist))/ViscousCL;
			//double c2 = Math.Sqrt(8*SFactor*ItaAir/(Porosity*FResist))/ThermalCL;

			CAbsorption.Clear();
			CRealSurfaceImpedance.Clear();
			CImagSurfaceImpedance.Clear();
			
			CAbsorption.AddData(0);
			CRealSurfaceImpedance.AddData(0);
			CImagSurfaceImpedance.AddData(0);

			for (int ff=1;ff<=MaxFre;ff++)
			{
				freq=Frequency.GetData(ff);
				//MeritCalcClass.elasticmeritcalc(freq, (double)MAbsorption.GetData(ff),FResist, SFactor, Porosity, c1, c2, Ymodulus, LossFactor, PoissonR, Thickness);  //INSUNG
				m_out = MeritCalcClass.elasticmeritcalc(m_c,c1,c2,m_Density1,m_DensityA,m_Densityo,Ymodulus,FResist,freq,Porosity,m_HeatRatio,Thickness,LossFactor,(double)MAbsorption.GetData(ff),m_Npr,PoissonR,SFactor);  //INSUNG
				m_Merit = m_Out[1];
				m_Absorption= m_Out[2];
				m_RealSurfaceImpedance= m_Out[3];
				m_ImagSurfaceImpedance= m_Out[4];
				

				CAbsorption.AddData((double)MeritCalcClass.Absorption);
				CRealSurfaceImpedance.AddData((double)MeritCalcClass.RealSurfaceImpedance);
				CImagSurfaceImpedance.AddData((double)MeritCalcClass.ImagSurfaceImpedance);

				Merit=Merit+(double)MeritCalcClass.Merit;

			}

			return Merit;

		}
		

		public double[,] SolidCalc()
		{
			double[,]  OptSolidPara=new double[1,3];
			double Slope1;
			double Slope2;
			double Slope3;
			double Slope4;
			double ResonanceFrequency=0;
			double freq;
			double Merit=0;
			double tLossFactor=0;
			double OptLossFactor=0;
			
			int ResonFreIndex=0;

			for (int i=2;i<MaxFre-InitFre-2;i++)
			{
				Slope1=(MRealSurfaceImpedanceSampled[i-1]*415-MRealSurfaceImpedanceSampled[i-2]*415)/Resolution;
				Slope2=(MRealSurfaceImpedanceSampled[i]*415-MRealSurfaceImpedanceSampled[i-1]*415)/Resolution;
				
				Slope3=(MRealSurfaceImpedanceSampled[i+1]*415-MRealSurfaceImpedanceSampled[i]*415)/Resolution;
				Slope4=(MRealSurfaceImpedanceSampled[i+2]*415-MRealSurfaceImpedanceSampled[i+1]*415)/Resolution;
				
				if ( (Slope1/(Math.Abs(Slope1)) < 0) && (Slope2/(Math.Abs(Slope2)) < 0) && (Slope3/(Math.Abs(Slope3)) > 0) && (Slope4/(Math.Abs(Slope4)) > 0))
				{
					ResonanceFrequency=(double)i*Resolution+300;
					break;
				}
						    
			}
			ResonFreIndex=(int)Math.Round(ResonanceFrequency/Resolution);

			//MeritCalcClass.peelasticsolid(Thickness, BulkDensity, ResonanceFrequency);
			m_SolidPara = MeritCalcClass.peelasticsolid(BulkDensity, Thickness, ResonanceFrequency); //INSUNG
			OptSolidPara=(double[,])((MWNumericArray)m_SolidPara).ToArray(MWArrayComponent.Real);;
			
			Ymodulus=(double)OptSolidPara[1,1];
			PoissonR=(double)OptSolidPara[1,3];
		
			double Merittemp=100000;
			for (int i=1;i<99;i++)
			{
			
				tLossFactor=i*0.01;
				freq=ResonFreIndex*Resolution;
							
				//MeritCalcClass.elasticmeritcalc(freq, (double)MAbsorption.GetData(ResonFreIndex),FResist, SFactor, Porosity, c1, c2, Ymodulus, tLossFactor, PoissonR, Thickness);  //INSUNG
				MeritCalcClass.elasticmeritcalc(m_c,c1,c2,m_Density1,m_DensityA,m_Densityo,Ymodulus,FResist,freq,Porosity,m_HeatRatio,Thickness,tLossFactor,(double)MAbsorption.GetData(ResonFreIndex),m_Npr,PoissonR,SFactor);  //INSUNG
				m_Merit = m_Out[1];
				m_Absorption= m_Out[2];
				m_RealSurfaceImpedance= m_Out[3];
				m_ImagSurfaceImpedance= m_Out[4];

				
				Merit=(double)MeritCalcClass.Merit;
						
				if(Merit<Merittemp)
				{
					OptLossFactor=tLossFactor;
			        Merittemp=Merit;
			    }
			}                
			OptSolidPara[1,2]=OptLossFactor;
					
			return OptSolidPara;

		}
	}
}
