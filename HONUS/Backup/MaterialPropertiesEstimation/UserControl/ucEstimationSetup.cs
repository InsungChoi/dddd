using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;

using HONUS.MaterialPropertiesEstimation.Component;
using HONUS.Common_Class;

namespace HONUS.MaterialPropertiesEstimation.UserControl
{
	/// <summary>
	/// EstimationSetup에 대한 요약 설명입니다.
	/// </summary>
	public class ucEstimationSetup : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cboMeterialType;
		private System.Windows.Forms.ComboBox cboEstimationOption;
		private System.Windows.Forms.ListView lstFileList;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlFileLoad;
		private System.Windows.Forms.Panel pnlDataBaseLoad;
		private System.Windows.Forms.RadioButton rdoFileLoad;
		private System.Windows.Forms.RadioButton rdoDataBaseLoad;
		private System.Windows.Forms.LinkLabel lnkFileLoad;
		private System.Windows.Forms.LinkLabel lnkDataBaseLoad;
		private System.Windows.Forms.Label lblDataBaseLoadName;
		private System.Windows.Forms.Label lblDataBaseLoad_ID;
		private System.Windows.Forms.TextBox edtTemperature;

		public delegate void MyComboChangeDelegate(string strType,string strOption);
		public event MyComboChangeDelegate MyComboChangeEvent;

		public delegate void ButtonClickedDelegave(string strButtonName,string strAddiftion);
		public event ButtonClickedDelegave ButtonClicked;

		public MPEClass MPEClass1;
		private System.Windows.Forms.Button btnEstimation;
		private System.Windows.Forms.Button btnSaveDatabase;
		DataSet MaterialTypeds;

		public int bIsFileLoad = -1;

		public ucEstimationSetup()
		{
			// 이 호출은 Windows.Forms Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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

		private void FileListInit()
		{
			ColumnHeader col = new ColumnHeader();
			col.Text = "Name";
			col.Width = 245;
			col.TextAlign = HorizontalAlignment.Center;

			lstFileList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "";
			col.Width = 5;
			col.TextAlign = HorizontalAlignment.Center;

			lstFileList.Columns.Add(col);
		}

		public void FileAllParsing(ucMaterialPropertiesEstimation ucMaterialPropertiesEstimation1,string strName)
		{
			bool result;

			for(int i = 0 ; i < lstFileList.Items.Count ; i++)
			{
				MPEClass1 = new MPEClass();
				MPEData MPEData1 = MPEClass1.NewMPEData();

				result = MPEData1.FileLoad(lstFileList.Items[i].SubItems[1].Text);
				if(result == false) // 유효한 화일이 아니면 삭제한다
				{
					MPEClass1.DeleteMPEData(MPEData1);
					
				}
				else
				{
					MPEClass1.Name = strName;
					ParameterInput(MPEData1,ucMaterialPropertiesEstimation1);
					MaterialTypeInput(MPEData1);

					
					//MPEData1.Calc();
				}
			}

			if(MPEClass1 != null)
			{
				frmCalc frmCalc1 = new frmCalc();
				frmCalc1.MPEClass1 = MPEClass1;
				frmCalc1.ShowDialog();
			}
		}

		public void ParameterInput(MPEData MPEData1,ucMaterialPropertiesEstimation ucMaterialPropertiesEstimation1)
		{
			MPEData1.Thickness = double.Parse(ucMaterialPropertiesEstimation1.strThickness);
			MPEData1.BulkDensity = double.Parse(ucMaterialPropertiesEstimation1.strBulkDensity);
			MPEData1.FResist = double.Parse(ucMaterialPropertiesEstimation1.strFlowResistivity);
			MPEData1.SFactor = double.Parse(ucMaterialPropertiesEstimation1.strStructureFactor);
			MPEData1.Porosity = double.Parse(ucMaterialPropertiesEstimation1.strProsity);
			MPEData1.ViscousCL = double.Parse(ucMaterialPropertiesEstimation1.strViscousCharLength)/1000000;
			MPEData1.ThermalCL = double.Parse(ucMaterialPropertiesEstimation1.strThermalCharLength)/1000000;
			MPEData1.Ymodulus = double.Parse(ucMaterialPropertiesEstimation1.strYoungsModulus);
			MPEData1.PoissonR = double.Parse(ucMaterialPropertiesEstimation1.strPoissionsRatio);
			MPEData1.LossFactor = double.Parse(ucMaterialPropertiesEstimation1.strLossFactor);

			//MPEData1.Name = ucMaterialPropertiesEstimation1.e;
			MPEData1.Temperature = double.Parse(this.edtTemperature.Text);
			MPEData1.SID = MPEClass1.SID;

			MPEData1.FResistEst = ! ucMaterialPropertiesEstimation1.IsEnableFlowResistivity;
			MPEData1.SFactorEst = ! ucMaterialPropertiesEstimation1.IsEnableStructureFactor;
			MPEData1.ViscousCLEst = ! ucMaterialPropertiesEstimation1.IsEnableViscousCharLength;
			MPEData1.ThermalCLEst = ! ucMaterialPropertiesEstimation1.IsEnableThermalCharLength;
			MPEData1.PorosityEst = ! ucMaterialPropertiesEstimation1.IsEnableProsity;
			MPEData1.YmodulusEst = ! ucMaterialPropertiesEstimation1.IsEnableYoungsModulus;
			MPEData1.PoissonREst = ! ucMaterialPropertiesEstimation1.IsEnablePoissionsRatio;
			MPEData1.LossFactorEst = ! ucMaterialPropertiesEstimation1.IsEnableLossFactor;
		}

		private void MaterialTypeInput(MPEData MPEData1)
		{
			MPEData1.MID = int.Parse(MaterialTypeds.Tables[0].Rows[cboMeterialType.SelectedIndex]["MID"].ToString());
		}

		/// <summary>
		/// 일단 임시로 계산하지 않고 파일에서 읽어드린값을 복사하는 함수(삭제 요망)
		/// </summary>
		public void Calc()
		{
			if(MPEClass1.GetMPEDataCount() > 0)
			{
				MPEClass1.Calc();
			}
		}

		public void DataBaseLoad(ucMaterialPropertiesEstimation ucMaterialPropertiesEstimation1,string strName)
		{
			MPEClass1 = new MPEClass();
			MPEData MPEData1 = MPEClass1.NewMPEData();
			
			MPEData1.Name = strName;
			DB_Load(MPEData1);
			ParameterInput(MPEData1,ucMaterialPropertiesEstimation1);
			MaterialTypeInput(MPEData1);

			MPEClass1.SID = int.Parse(lblDataBaseLoad_ID.Text);
			MPEClass1.Name  = lblDataBaseLoadName.Text;

			frmCalc frmCalc1 = new frmCalc();
			frmCalc1.MPEClass1 = MPEClass1;
			frmCalc1.ShowDialog();

			//MPEData1.Calc();
			//MPEClass1.Temp();
			//MPEClass1.Calc();
		}

		private void DB_Load(MPEData MPEData1)
		{
			MPE_DB MPE_DB1 = new MPE_DB();
			DataSet ds = MPE_DB1.GetSingleMaterialGraph(lblDataBaseLoad_ID.Text);
			string strGraphType = ds.Tables[0].Rows[0]["GraphType"].ToString();
			string strX_Axis = ds.Tables[0].Rows[0]["X_Axis"].ToString();
			string strY_RigidBacking = ds.Tables[0].Rows[0]["Y_RigidBacking"].ToString();
			string strY_AnechoicTermination = ds.Tables[0].Rows[0]["Y_AnechoicTermination"].ToString();

			if(strX_Axis != "")
			{
				string [] dstrX_Axis = strX_Axis.Split(",".ToCharArray());
				string [] dstrY_RigidBacking = strY_RigidBacking.Split(",".ToCharArray());
				string [] dstrY_AnechoicTermination = strY_AnechoicTermination.Split(",".ToCharArray());
				
				if(strGraphType == "1")
				{
					for(int i = 0 ; i < dstrX_Axis.Length ; i++)
					{
						MPEData1.Frequency.AddData(double.Parse(dstrX_Axis[i].ToString()));
						MPEData1.MAbsorption.AddData(double.Parse(dstrY_RigidBacking[i].ToString()));
					}
					
				}
//				else if(strGraphType == "2")
//				{
//					for(int i = 0 ; i < dstrX_Axis.Length ; i++)
//					{
//						MPEData1.Frequency.AddData(double.Parse(dstrX_Axis[i].ToString()));
//						MPEData1.MSurfaceImpedance.AddData(double.Parse(dstrY_AnechoicTermination[i].ToString()));
//					}
//				}
			}
		}

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.edtTemperature = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboMeterialType = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cboEstimationOption = new System.Windows.Forms.ComboBox();
			this.lstFileList = new System.Windows.Forms.ListView();
			this.lnkFileLoad = new System.Windows.Forms.LinkLabel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pnlFileLoad = new System.Windows.Forms.Panel();
			this.pnlDataBaseLoad = new System.Windows.Forms.Panel();
			this.btnSaveDatabase = new System.Windows.Forms.Button();
			this.btnEstimation = new System.Windows.Forms.Button();
			this.lblDataBaseLoad_ID = new System.Windows.Forms.Label();
			this.lblDataBaseLoadName = new System.Windows.Forms.Label();
			this.lnkDataBaseLoad = new System.Windows.Forms.LinkLabel();
			this.rdoFileLoad = new System.Windows.Forms.RadioButton();
			this.rdoDataBaseLoad = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.pnlFileLoad.SuspendLayout();
			this.pnlDataBaseLoad.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Temperature";
			// 
			// edtTemperature
			// 
			this.edtTemperature.Location = new System.Drawing.Point(120, 11);
			this.edtTemperature.Name = "edtTemperature";
			this.edtTemperature.TabIndex = 1;
			this.edtTemperature.Text = "20";
			this.edtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboMeterialType);
			this.groupBox1.Location = new System.Drawing.Point(8, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 64);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Material  Type";
			// 
			// cboMeterialType
			// 
			this.cboMeterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMeterialType.Location = new System.Drawing.Point(8, 32);
			this.cboMeterialType.Name = "cboMeterialType";
			this.cboMeterialType.Size = new System.Drawing.Size(240, 20);
			this.cboMeterialType.TabIndex = 3;
			this.cboMeterialType.SelectedIndexChanged += new System.EventHandler(this.cboMeterialType_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cboEstimationOption);
			this.groupBox2.Location = new System.Drawing.Point(8, 136);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 64);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Estimation Option";
			// 
			// cboEstimationOption
			// 
			this.cboEstimationOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEstimationOption.Location = new System.Drawing.Point(8, 32);
			this.cboEstimationOption.Name = "cboEstimationOption";
			this.cboEstimationOption.Size = new System.Drawing.Size(240, 20);
			this.cboEstimationOption.TabIndex = 3;
			this.cboEstimationOption.SelectedIndexChanged += new System.EventHandler(this.cboEstimationOption_SelectedIndexChanged);
			// 
			// lstFileList
			// 
			this.lstFileList.GridLines = true;
			this.lstFileList.Location = new System.Drawing.Point(8, 32);
			this.lstFileList.Name = "lstFileList";
			this.lstFileList.Size = new System.Drawing.Size(256, 112);
			this.lstFileList.TabIndex = 7;
			this.lstFileList.View = System.Windows.Forms.View.Details;
			// 
			// lnkFileLoad
			// 
			this.lnkFileLoad.Location = new System.Drawing.Point(8, 8);
			this.lnkFileLoad.Name = "lnkFileLoad";
			this.lnkFileLoad.Size = new System.Drawing.Size(160, 23);
			this.lnkFileLoad.TabIndex = 8;
			this.lnkFileLoad.TabStop = true;
			this.lnkFileLoad.Text = "Measured Data from File";
			this.lnkFileLoad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// pnlFileLoad
			// 
			this.pnlFileLoad.Controls.Add(this.lstFileList);
			this.pnlFileLoad.Controls.Add(this.lnkFileLoad);
			this.pnlFileLoad.Location = new System.Drawing.Point(0, 248);
			this.pnlFileLoad.Name = "pnlFileLoad";
			this.pnlFileLoad.Size = new System.Drawing.Size(272, 152);
			this.pnlFileLoad.TabIndex = 11;
			// 
			// pnlDataBaseLoad
			// 
			this.pnlDataBaseLoad.Controls.Add(this.btnSaveDatabase);
			this.pnlDataBaseLoad.Controls.Add(this.btnEstimation);
			this.pnlDataBaseLoad.Controls.Add(this.lblDataBaseLoad_ID);
			this.pnlDataBaseLoad.Controls.Add(this.lblDataBaseLoadName);
			this.pnlDataBaseLoad.Controls.Add(this.lnkDataBaseLoad);
			this.pnlDataBaseLoad.Location = new System.Drawing.Point(0, 400);
			this.pnlDataBaseLoad.Name = "pnlDataBaseLoad";
			this.pnlDataBaseLoad.Size = new System.Drawing.Size(272, 144);
			this.pnlDataBaseLoad.TabIndex = 12;
			// 
			// btnSaveDatabase
			// 
			this.btnSaveDatabase.BackColor = System.Drawing.SystemColors.Control;
			this.btnSaveDatabase.Enabled = false;
			this.btnSaveDatabase.Location = new System.Drawing.Point(136, 112);
			this.btnSaveDatabase.Name = "btnSaveDatabase";
			this.btnSaveDatabase.Size = new System.Drawing.Size(128, 23);
			this.btnSaveDatabase.TabIndex = 25;
			this.btnSaveDatabase.Text = "Save to database";
			this.btnSaveDatabase.Click += new System.EventHandler(this.btnSaveDatabase_Click);
			// 
			// btnEstimation
			// 
			this.btnEstimation.BackColor = System.Drawing.SystemColors.Control;
			this.btnEstimation.Location = new System.Drawing.Point(16, 112);
			this.btnEstimation.Name = "btnEstimation";
			this.btnEstimation.TabIndex = 24;
			this.btnEstimation.Text = "Estimation";
			this.btnEstimation.Click += new System.EventHandler(this.btnEstimation_Click);
			// 
			// lblDataBaseLoad_ID
			// 
			this.lblDataBaseLoad_ID.Location = new System.Drawing.Point(8, 56);
			this.lblDataBaseLoad_ID.Name = "lblDataBaseLoad_ID";
			this.lblDataBaseLoad_ID.TabIndex = 12;
			this.lblDataBaseLoad_ID.Visible = false;
			// 
			// lblDataBaseLoadName
			// 
			this.lblDataBaseLoadName.Location = new System.Drawing.Point(8, 32);
			this.lblDataBaseLoadName.Name = "lblDataBaseLoadName";
			this.lblDataBaseLoadName.Size = new System.Drawing.Size(256, 23);
			this.lblDataBaseLoadName.TabIndex = 11;
			// 
			// lnkDataBaseLoad
			// 
			this.lnkDataBaseLoad.Enabled = false;
			this.lnkDataBaseLoad.Location = new System.Drawing.Point(8, 8);
			this.lnkDataBaseLoad.Name = "lnkDataBaseLoad";
			this.lnkDataBaseLoad.Size = new System.Drawing.Size(144, 23);
			this.lnkDataBaseLoad.TabIndex = 10;
			this.lnkDataBaseLoad.TabStop = true;
			this.lnkDataBaseLoad.Text = "Measured Data from DB";
			this.lnkDataBaseLoad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDataBaseLoad_LinkClicked);
			// 
			// rdoFileLoad
			// 
			this.rdoFileLoad.Checked = true;
			this.rdoFileLoad.Location = new System.Drawing.Point(8, 208);
			this.rdoFileLoad.Name = "rdoFileLoad";
			this.rdoFileLoad.TabIndex = 13;
			this.rdoFileLoad.TabStop = true;
			this.rdoFileLoad.Text = "File Load";
			// 
			// rdoDataBaseLoad
			// 
			this.rdoDataBaseLoad.Location = new System.Drawing.Point(144, 208);
			this.rdoDataBaseLoad.Name = "rdoDataBaseLoad";
			this.rdoDataBaseLoad.Size = new System.Drawing.Size(112, 24);
			this.rdoDataBaseLoad.TabIndex = 14;
			this.rdoDataBaseLoad.Text = "DataBase Load";
			this.rdoDataBaseLoad.CheckedChanged += new System.EventHandler(this.rdoDataBaseLoad_CheckedChanged);
			// 
			// ucEstimationSetup
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.rdoDataBaseLoad);
			this.Controls.Add(this.rdoFileLoad);
			this.Controls.Add(this.pnlDataBaseLoad);
			this.Controls.Add(this.pnlFileLoad);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.edtTemperature);
			this.Controls.Add(this.label1);
			this.Name = "ucEstimationSetup";
			this.Size = new System.Drawing.Size(274, 572);
			this.Load += new System.EventHandler(this.ucEstimationSetup_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.pnlFileLoad.ResumeLayout(false);
			this.pnlDataBaseLoad.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ucEstimationSetup_Load(object sender, System.EventArgs e)
		{
			FileListInit();
		}

		public void InitPage()
		{
			cboMeterialType_Bind();
			cboEstimationOption_Bind(cboMeterialType.SelectedItem.ToString());
		}

		private void cboMeterialType_Bind()
		{
			cboMeterialType.Items.Clear();

			MPE_DB MPE_DB1 = new MPE_DB();
			MaterialTypeds = MPE_DB1.GetMaterialType(1);

//			cboMeterialType.DataSource = ds;
//			cboMeterialType.DisplayMember = "MatType";
//			cboMeterialType.ValueMember = "MID";

			for(int i = 0 ; i < MaterialTypeds.Tables[0].Rows.Count ; i++)
			{
				MaterialType MaterialType1 = new MaterialType();
				MaterialType1.Name = MaterialTypeds.Tables[0].Rows[i]["MatType"].ToString();
				MaterialType1.ID = MaterialTypeds.Tables[0].Rows[i]["MID"].ToString();

				cboMeterialType.Items.Add(MaterialType1.Name);
			}

			cboMeterialType.SelectedIndex = 0;
		}

		public string GetcboMeterialType_ID()
		{
			return MaterialTypeds.Tables[0].Rows[cboMeterialType.SelectedIndex]["MID"].ToString();
		}

		private void cboEstimationOption_Bind(string strMeterialTypeSelect)
		{
			cboEstimationOption.Items.Clear();

			if(strMeterialTypeSelect == "Limp porous material" || strMeterialTypeSelect == "Rigid porous material")
			{
				cboEstimationOption.Items.Add("4 parameters estimation");
				cboEstimationOption.Items.Add("5 parameters estimation");
				cboEstimationOption.Items.Add("Optional estimation");
			}
			else
			{
				cboEstimationOption.Items.Add("4 parameters estimation");
				cboEstimationOption.Items.Add("5 parameters estimation");
				cboEstimationOption.Items.Add("8 parameters estimation");
				cboEstimationOption.Items.Add("Optional estimation");
			}

			cboEstimationOption.SelectedIndex = 0;
		}

		private void cboMeterialType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cboEstimationOption_Bind(cboMeterialType.SelectedItem.ToString());
			MyComboChangeEvent(cboMeterialType.SelectedItem.ToString(),cboEstimationOption.SelectedItem.ToString());
		}

//		private void btnEstimation_Click(object sender, System.EventArgs e)
//		{
//			HONUS.MaterialPropertiesEstimation.Form.dgEstimation dgEstimation_ = new HONUS.MaterialPropertiesEstimation.Form.dgEstimation();
//			dgEstimation_.ShowDialog();
//		}

		private void cboEstimationOption_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyComboChangeEvent(cboMeterialType.SelectedItem.ToString(),cboEstimationOption.SelectedItem.ToString());
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(DialogResult.OK == openFileDialog1.ShowDialog())
			{
				bool result = FileSameChaek(openFileDialog1.FileName);
				if(result == false)
				{
					string strFileName = Path.GetFileName(openFileDialog1.FileName);
					ListViewItem list = new ListViewItem();
					list.Text = strFileName;

					list.SubItems.Add(openFileDialog1.FileName);
					lstFileList.Items.Add(list);
				}

				bIsFileLoad = 1;
			}
		}

		/// <summary>
		/// 파일 중복 체크(중복되는게 있으면 true
		/// </summary>
		/// <param name="strFileFullName"></param>
		/// <returns></returns>
		private bool FileSameChaek(string strFileFullName)
		{
			bool result = false;

			foreach(ListViewItem item in lstFileList.Items)
			{
				if(item.SubItems[1].Text == strFileFullName)
				{
					result = true;
				}
			}

			return result;
		}

		private void rdoDataBaseLoad_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoDataBaseLoad.Checked == true)
			{
				lnkFileLoad.Enabled = false;
				lstFileList.Enabled = false;

				lnkDataBaseLoad.Enabled = true;
			}
			else
			{
				lnkFileLoad.Enabled = true;
				lstFileList.Enabled = true;

				lnkDataBaseLoad.Enabled = false;
			}
		}

		/// <summary>
		/// 파일을 로드했는지 DataBase 를 로드 했는지 파별하는 함수
		/// </summary>
		/// <returns></returns>
		public bool IsFileLoad()
		{
			bool result = false;

			if(rdoDataBaseLoad.Checked == true)
			{
				result = false;
			}
			else
			{
				result = true;
			}

			return result;
		}

		private void lnkDataBaseLoad_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			HONUS.MaterialPropertiesEstimation.Form.dgDataBaseLoad dgDataBaseLoad1 = new HONUS.MaterialPropertiesEstimation.Form.dgDataBaseLoad();
			if(DialogResult.OK == dgDataBaseLoad1.ShowDialog())
			{
				lblDataBaseLoadName.Text = dgDataBaseLoad1.strSelectedDataBase_Name;
				lblDataBaseLoad_ID.Text = dgDataBaseLoad1.strSelectedDataBase_ID;

				// TODO : 
				//ucMaterialPropertiesEstimation1. = dgDataBaseLoad1.strSelectedDataBase_Name;

				bIsFileLoad = 0;
			}
		}

		private void btnEstimation_Click(object sender, System.EventArgs e)
		{
			ButtonClicked("Estimation","");
		}

		private void btnSaveDatabase_Click(object sender, System.EventArgs e)
		{
			//HONUS.MaterialPerformanceAnalysis.Form.dgName dgName1 = new HONUS.MaterialPerformanceAnalysis.Form.dgName();
			
			//if(dgName1.ShowDialog() == DialogResult.OK)
			//{
				ButtonClicked("Save","");
			//}
		}

		public void SaveButtonEmable()
		{
			btnSaveDatabase.Enabled = true;
		}

		#region 접근자

		public string strTemperature
		{
			get
			{
				return edtTemperature.Text;
			}
		}

		#endregion
	}
}
