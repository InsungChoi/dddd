using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using HONUS.SensitivityAnalysis.Form;
using HONUS.Common_Class;
using HONUS.MaterialPropertiesEstimation.Component;

namespace HONUS.SensitivityAnalysis.UserControl
{
	/// <summary>
	/// ucAnalysisSetup에 대한 요약 설명입니다.
	/// </summary>
	public class ucAnalysisSetup : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cboMeterialType;
		private System.Windows.Forms.TextBox edtTemperature;
		private System.Windows.Forms.TextBox edtLimitAngle;
		private System.Windows.Forms.RadioButton rdoRandomIncidence;
		private System.Windows.Forms.RadioButton rdoNormalIncidence;
		private System.Windows.Forms.Button btnAnalysis;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string strSelectedMaterialType;
		public string strSelectedMaterialValue;
		public string strSelectedPerformance;
		public int dSelectedPerformance;

		public SAClass SAClass1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rdoAbsorptionCoefficientAnechoicTermination;
		private System.Windows.Forms.RadioButton rdoAbsorptionCoefficientRigidBacking;
		private System.Windows.Forms.RadioButton rdoTransmissionLoss;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDataBaseLoad;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.TextBox edtProsity;
		private System.Windows.Forms.TextBox edtViscousCharLength;
		private System.Windows.Forms.TextBox edtThermalCharLength;
		private System.Windows.Forms.TextBox edtPoissionsRatio;
		private System.Windows.Forms.TextBox edtYoungsModulus;
		private System.Windows.Forms.TextBox edtBulkDensity;
		private System.Windows.Forms.TextBox edtLossFactor;
		private System.Windows.Forms.TextBox edtThickness;
		private System.Windows.Forms.TextBox edtFlowResistivity;
		private System.Windows.Forms.TextBox edtStructureFactor;

		public delegate void MyButtonClickedDelegate(string strName,string strAddition);
		public event MyButtonClickedDelegate MyButtonClicked;

		DataSet MaterialTypeds;
		private System.Windows.Forms.RadioButton rdoTCL;
		private System.Windows.Forms.RadioButton rdoVCL;
		private System.Windows.Forms.RadioButton rdoProsity;
		private System.Windows.Forms.RadioButton rdoFlow;
		private System.Windows.Forms.RadioButton rdoSFactor;
		private System.Windows.Forms.RadioButton rdoPoiss;
		private System.Windows.Forms.RadioButton rdoThick;
		private System.Windows.Forms.RadioButton rdoLoss;
		private System.Windows.Forms.RadioButton rdoYoung;
		private System.Windows.Forms.RadioButton rdoBulk;

		public bool bIsDataBaseLoad = false;

		public ucAnalysisSetup()
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

		private void cboMeterialType_Bind()
		{
			//			cboMeterialType.Items.Add("Limp porous material");
			//			cboMeterialType.Items.Add("Rigid porous material");
			//			cboMeterialType.Items.Add("Elastic porous material");
			//
			//			cboMeterialType.SelectedIndex = 0;

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

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.edtTemperature = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.edtLimitAngle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rdoRandomIncidence = new System.Windows.Forms.RadioButton();
			this.rdoNormalIncidence = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cboMeterialType = new System.Windows.Forms.ComboBox();
			this.btnAnalysis = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rdoTCL = new System.Windows.Forms.RadioButton();
			this.rdoVCL = new System.Windows.Forms.RadioButton();
			this.rdoProsity = new System.Windows.Forms.RadioButton();
			this.rdoFlow = new System.Windows.Forms.RadioButton();
			this.rdoSFactor = new System.Windows.Forms.RadioButton();
			this.rdoPoiss = new System.Windows.Forms.RadioButton();
			this.rdoThick = new System.Windows.Forms.RadioButton();
			this.rdoLoss = new System.Windows.Forms.RadioButton();
			this.rdoYoung = new System.Windows.Forms.RadioButton();
			this.rdoBulk = new System.Windows.Forms.RadioButton();
			this.edtProsity = new System.Windows.Forms.TextBox();
			this.edtViscousCharLength = new System.Windows.Forms.TextBox();
			this.edtThermalCharLength = new System.Windows.Forms.TextBox();
			this.edtPoissionsRatio = new System.Windows.Forms.TextBox();
			this.edtYoungsModulus = new System.Windows.Forms.TextBox();
			this.edtBulkDensity = new System.Windows.Forms.TextBox();
			this.edtLossFactor = new System.Windows.Forms.TextBox();
			this.edtThickness = new System.Windows.Forms.TextBox();
			this.edtFlowResistivity = new System.Windows.Forms.TextBox();
			this.edtStructureFactor = new System.Windows.Forms.TextBox();
			this.btnDataBaseLoad = new System.Windows.Forms.Button();
			this.edtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rdoAbsorptionCoefficientAnechoicTermination = new System.Windows.Forms.RadioButton();
			this.rdoAbsorptionCoefficientRigidBacking = new System.Windows.Forms.RadioButton();
			this.rdoTransmissionLoss = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// edtTemperature
			// 
			this.edtTemperature.Location = new System.Drawing.Point(136, 16);
			this.edtTemperature.Name = "edtTemperature";
			this.edtTemperature.TabIndex = 5;
			this.edtTemperature.Text = "20";
			this.edtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Temperature";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.edtLimitAngle);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rdoRandomIncidence);
			this.groupBox1.Controls.Add(this.rdoNormalIncidence);
			this.groupBox1.Location = new System.Drawing.Point(5, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(275, 104);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Incident Condition";
			// 
			// edtLimitAngle
			// 
			this.edtLimitAngle.Enabled = false;
			this.edtLimitAngle.Location = new System.Drawing.Point(136, 75);
			this.edtLimitAngle.Name = "edtLimitAngle";
			this.edtLimitAngle.TabIndex = 3;
			this.edtLimitAngle.Text = "72.5";
			this.edtLimitAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Limit angle";
			// 
			// rdoRandomIncidence
			// 
			this.rdoRandomIncidence.Location = new System.Drawing.Point(8, 48);
			this.rdoRandomIncidence.Name = "rdoRandomIncidence";
			this.rdoRandomIncidence.Size = new System.Drawing.Size(136, 24);
			this.rdoRandomIncidence.TabIndex = 1;
			this.rdoRandomIncidence.Text = "Random Incidence";
			// 
			// rdoNormalIncidence
			// 
			this.rdoNormalIncidence.Checked = true;
			this.rdoNormalIncidence.Location = new System.Drawing.Point(8, 24);
			this.rdoNormalIncidence.Name = "rdoNormalIncidence";
			this.rdoNormalIncidence.Size = new System.Drawing.Size(128, 24);
			this.rdoNormalIncidence.TabIndex = 0;
			this.rdoNormalIncidence.TabStop = true;
			this.rdoNormalIncidence.Text = "Normal Incidence";
			this.rdoNormalIncidence.CheckedChanged += new System.EventHandler(this.rdoNormalIncidence_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cboMeterialType);
			this.groupBox2.Location = new System.Drawing.Point(8, 160);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(272, 64);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Material  Type";
			// 
			// cboMeterialType
			// 
			this.cboMeterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMeterialType.Location = new System.Drawing.Point(8, 32);
			this.cboMeterialType.Name = "cboMeterialType";
			this.cboMeterialType.Size = new System.Drawing.Size(256, 20);
			this.cboMeterialType.TabIndex = 0;
			this.cboMeterialType.SelectedIndexChanged += new System.EventHandler(this.cboMeterialType_SelectedIndexChanged);
			// 
			// btnAnalysis
			// 
			this.btnAnalysis.BackColor = System.Drawing.SystemColors.Control;
			this.btnAnalysis.Location = new System.Drawing.Point(104, 688);
			this.btnAnalysis.Name = "btnAnalysis";
			this.btnAnalysis.TabIndex = 11;
			this.btnAnalysis.Text = "Analysis";
			this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rdoTCL);
			this.groupBox3.Controls.Add(this.rdoVCL);
			this.groupBox3.Controls.Add(this.rdoProsity);
			this.groupBox3.Controls.Add(this.rdoFlow);
			this.groupBox3.Controls.Add(this.rdoSFactor);
			this.groupBox3.Controls.Add(this.rdoPoiss);
			this.groupBox3.Controls.Add(this.rdoThick);
			this.groupBox3.Controls.Add(this.rdoLoss);
			this.groupBox3.Controls.Add(this.rdoYoung);
			this.groupBox3.Controls.Add(this.rdoBulk);
			this.groupBox3.Controls.Add(this.edtProsity);
			this.groupBox3.Controls.Add(this.edtViscousCharLength);
			this.groupBox3.Controls.Add(this.edtThermalCharLength);
			this.groupBox3.Controls.Add(this.edtPoissionsRatio);
			this.groupBox3.Controls.Add(this.edtYoungsModulus);
			this.groupBox3.Controls.Add(this.edtBulkDensity);
			this.groupBox3.Controls.Add(this.edtLossFactor);
			this.groupBox3.Controls.Add(this.edtThickness);
			this.groupBox3.Controls.Add(this.edtFlowResistivity);
			this.groupBox3.Controls.Add(this.edtStructureFactor);
			this.groupBox3.Controls.Add(this.btnDataBaseLoad);
			this.groupBox3.Controls.Add(this.edtName);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(8, 232);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(272, 328);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Material Information";
			// 
			// rdoTCL
			// 
			this.rdoTCL.Location = new System.Drawing.Point(16, 264);
			this.rdoTCL.Name = "rdoTCL";
			this.rdoTCL.Size = new System.Drawing.Size(152, 24);
			this.rdoTCL.TabIndex = 116;
			this.rdoTCL.Text = "Thermal Char. Length";
			// 
			// rdoVCL
			// 
			this.rdoVCL.Location = new System.Drawing.Point(16, 240);
			this.rdoVCL.Name = "rdoVCL";
			this.rdoVCL.Size = new System.Drawing.Size(152, 24);
			this.rdoVCL.TabIndex = 115;
			this.rdoVCL.Text = "Viscous Char. Length";
			// 
			// rdoProsity
			// 
			this.rdoProsity.Location = new System.Drawing.Point(16, 216);
			this.rdoProsity.Name = "rdoProsity";
			this.rdoProsity.TabIndex = 114;
			this.rdoProsity.Text = "Porosity";
			// 
			// rdoFlow
			// 
			this.rdoFlow.Location = new System.Drawing.Point(16, 168);
			this.rdoFlow.Name = "rdoFlow";
			this.rdoFlow.Size = new System.Drawing.Size(112, 24);
			this.rdoFlow.TabIndex = 113;
			this.rdoFlow.Text = "Flow Resistivity";
			// 
			// rdoSFactor
			// 
			this.rdoSFactor.Location = new System.Drawing.Point(16, 192);
			this.rdoSFactor.Name = "rdoSFactor";
			this.rdoSFactor.Size = new System.Drawing.Size(120, 24);
			this.rdoSFactor.TabIndex = 112;
			this.rdoSFactor.Text = "Structure Factor";
			// 
			// rdoPoiss
			// 
			this.rdoPoiss.Location = new System.Drawing.Point(16, 120);
			this.rdoPoiss.Name = "rdoPoiss";
			this.rdoPoiss.Size = new System.Drawing.Size(120, 24);
			this.rdoPoiss.TabIndex = 111;
			this.rdoPoiss.Text = "Poission’s Ratio";
			// 
			// rdoThick
			// 
			this.rdoThick.Checked = true;
			this.rdoThick.Location = new System.Drawing.Point(16, 48);
			this.rdoThick.Name = "rdoThick";
			this.rdoThick.TabIndex = 110;
			this.rdoThick.TabStop = true;
			this.rdoThick.Text = "Thickness";
			// 
			// rdoLoss
			// 
			this.rdoLoss.Location = new System.Drawing.Point(16, 144);
			this.rdoLoss.Name = "rdoLoss";
			this.rdoLoss.TabIndex = 109;
			this.rdoLoss.Text = "Loss Factor";
			// 
			// rdoYoung
			// 
			this.rdoYoung.Location = new System.Drawing.Point(16, 96);
			this.rdoYoung.Name = "rdoYoung";
			this.rdoYoung.Size = new System.Drawing.Size(128, 24);
			this.rdoYoung.TabIndex = 108;
			this.rdoYoung.Text = "Young’s Modulus";
			// 
			// rdoBulk
			// 
			this.rdoBulk.Location = new System.Drawing.Point(16, 72);
			this.rdoBulk.Name = "rdoBulk";
			this.rdoBulk.TabIndex = 107;
			this.rdoBulk.Text = "Bulk Density";
			// 
			// edtProsity
			// 
			this.edtProsity.Location = new System.Drawing.Point(168, 216);
			this.edtProsity.Name = "edtProsity";
			this.edtProsity.Size = new System.Drawing.Size(96, 21);
			this.edtProsity.TabIndex = 9;
			this.edtProsity.Text = "0";
			this.edtProsity.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtViscousCharLength
			// 
			this.edtViscousCharLength.Location = new System.Drawing.Point(168, 240);
			this.edtViscousCharLength.Name = "edtViscousCharLength";
			this.edtViscousCharLength.Size = new System.Drawing.Size(96, 21);
			this.edtViscousCharLength.TabIndex = 10;
			this.edtViscousCharLength.Text = "0";
			this.edtViscousCharLength.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtThermalCharLength
			// 
			this.edtThermalCharLength.Location = new System.Drawing.Point(168, 264);
			this.edtThermalCharLength.Name = "edtThermalCharLength";
			this.edtThermalCharLength.Size = new System.Drawing.Size(96, 21);
			this.edtThermalCharLength.TabIndex = 11;
			this.edtThermalCharLength.Text = "0";
			this.edtThermalCharLength.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtPoissionsRatio
			// 
			this.edtPoissionsRatio.Location = new System.Drawing.Point(168, 120);
			this.edtPoissionsRatio.Name = "edtPoissionsRatio";
			this.edtPoissionsRatio.Size = new System.Drawing.Size(96, 21);
			this.edtPoissionsRatio.TabIndex = 5;
			this.edtPoissionsRatio.Text = "0";
			this.edtPoissionsRatio.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtYoungsModulus
			// 
			this.edtYoungsModulus.Location = new System.Drawing.Point(168, 96);
			this.edtYoungsModulus.Name = "edtYoungsModulus";
			this.edtYoungsModulus.Size = new System.Drawing.Size(96, 21);
			this.edtYoungsModulus.TabIndex = 4;
			this.edtYoungsModulus.Text = "0";
			this.edtYoungsModulus.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtBulkDensity
			// 
			this.edtBulkDensity.Location = new System.Drawing.Point(168, 72);
			this.edtBulkDensity.Name = "edtBulkDensity";
			this.edtBulkDensity.Size = new System.Drawing.Size(96, 21);
			this.edtBulkDensity.TabIndex = 3;
			this.edtBulkDensity.Text = "0";
			this.edtBulkDensity.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtLossFactor
			// 
			this.edtLossFactor.Location = new System.Drawing.Point(168, 144);
			this.edtLossFactor.Name = "edtLossFactor";
			this.edtLossFactor.Size = new System.Drawing.Size(96, 21);
			this.edtLossFactor.TabIndex = 6;
			this.edtLossFactor.Text = "0";
			this.edtLossFactor.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtThickness
			// 
			this.edtThickness.Location = new System.Drawing.Point(168, 48);
			this.edtThickness.Name = "edtThickness";
			this.edtThickness.Size = new System.Drawing.Size(96, 21);
			this.edtThickness.TabIndex = 2;
			this.edtThickness.Text = "0";
			this.edtThickness.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtFlowResistivity
			// 
			this.edtFlowResistivity.Location = new System.Drawing.Point(168, 168);
			this.edtFlowResistivity.Name = "edtFlowResistivity";
			this.edtFlowResistivity.Size = new System.Drawing.Size(96, 21);
			this.edtFlowResistivity.TabIndex = 7;
			this.edtFlowResistivity.Text = "0";
			this.edtFlowResistivity.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// edtStructureFactor
			// 
			this.edtStructureFactor.Location = new System.Drawing.Point(168, 192);
			this.edtStructureFactor.Name = "edtStructureFactor";
			this.edtStructureFactor.Size = new System.Drawing.Size(96, 21);
			this.edtStructureFactor.TabIndex = 8;
			this.edtStructureFactor.Text = "0";
			this.edtStructureFactor.TextChanged += new System.EventHandler(this.edtThickness_TextChanged);
			// 
			// btnDataBaseLoad
			// 
			this.btnDataBaseLoad.BackColor = System.Drawing.SystemColors.Control;
			this.btnDataBaseLoad.Location = new System.Drawing.Point(152, 19);
			this.btnDataBaseLoad.Name = "btnDataBaseLoad";
			this.btnDataBaseLoad.Size = new System.Drawing.Size(112, 23);
			this.btnDataBaseLoad.TabIndex = 86;
			this.btnDataBaseLoad.Text = "DataBase Load";
			this.btnDataBaseLoad.Click += new System.EventHandler(this.btnDataBaseLoad_Click);
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(51, 20);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(99, 21);
			this.edtName.TabIndex = 1;
			this.edtName.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 84;
			this.label3.Text = "Name";
			// 
			// rdoAbsorptionCoefficientAnechoicTermination
			// 
			this.rdoAbsorptionCoefficientAnechoicTermination.Location = new System.Drawing.Point(8, 72);
			this.rdoAbsorptionCoefficientAnechoicTermination.Name = "rdoAbsorptionCoefficientAnechoicTermination";
			this.rdoAbsorptionCoefficientAnechoicTermination.Size = new System.Drawing.Size(232, 32);
			this.rdoAbsorptionCoefficientAnechoicTermination.TabIndex = 17;
			this.rdoAbsorptionCoefficientAnechoicTermination.Text = "Absorption coefficient for anechoic termination";
			this.rdoAbsorptionCoefficientAnechoicTermination.CheckedChanged += new System.EventHandler(this.rdoAbsorptionCoefficientAnechoicTermination_CheckedChanged);
			// 
			// rdoAbsorptionCoefficientRigidBacking
			// 
			this.rdoAbsorptionCoefficientRigidBacking.Location = new System.Drawing.Point(8, 48);
			this.rdoAbsorptionCoefficientRigidBacking.Name = "rdoAbsorptionCoefficientRigidBacking";
			this.rdoAbsorptionCoefficientRigidBacking.Size = new System.Drawing.Size(256, 24);
			this.rdoAbsorptionCoefficientRigidBacking.TabIndex = 16;
			this.rdoAbsorptionCoefficientRigidBacking.Text = "Absorption coefficient for rigid backing";
			this.rdoAbsorptionCoefficientRigidBacking.CheckedChanged += new System.EventHandler(this.rdoAbsorptionCoefficientRigidBacking_CheckedChanged);
			// 
			// rdoTransmissionLoss
			// 
			this.rdoTransmissionLoss.Checked = true;
			this.rdoTransmissionLoss.Location = new System.Drawing.Point(8, 24);
			this.rdoTransmissionLoss.Name = "rdoTransmissionLoss";
			this.rdoTransmissionLoss.Size = new System.Drawing.Size(136, 24);
			this.rdoTransmissionLoss.TabIndex = 15;
			this.rdoTransmissionLoss.TabStop = true;
			this.rdoTransmissionLoss.Text = "Transmission Loss";
			this.rdoTransmissionLoss.CheckedChanged += new System.EventHandler(this.rdoTransmissionLoss_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rdoAbsorptionCoefficientAnechoicTermination);
			this.groupBox4.Controls.Add(this.rdoAbsorptionCoefficientRigidBacking);
			this.groupBox4.Controls.Add(this.rdoTransmissionLoss);
			this.groupBox4.Location = new System.Drawing.Point(8, 568);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(272, 112);
			this.groupBox4.TabIndex = 18;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Acoustic Performance";
			// 
			// ucAnalysisSetup
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnAnalysis);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.edtTemperature);
			this.Controls.Add(this.label1);
			this.Name = "ucAnalysisSetup";
			this.Size = new System.Drawing.Size(280, 728);
			this.Load += new System.EventHandler(this.ucAnalysisSetup_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ucAnalysisSetup_Load(object sender, System.EventArgs e)
		{
//			cboMeterialType_Bind();
		}

		public void InitForm()
		{
			cboMeterialType_Bind();
		}

//		private void lnkMaterialInformation_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
//		{
//			dgMaterial dgMaterial1 = new dgMaterial();
//
//			if(dgMaterial1.ShowDialog() == DialogResult.OK)
//			{
//				strSelectedMaterialType = dgMaterial1.GetSelectedType();
//				//strSelectedMaterialValue = dgMaterial1.GetSelectedValue();
//			}
//		}
//
//		private void lnkAcousticPerformance_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
//		{
//			dgAcousticPerformance dgAcousticPerformance1 = new dgAcousticPerformance();
//
//			if(dgAcousticPerformance1.ShowDialog() == DialogResult.OK)
//			{
//				strSelectedPerformance = dgAcousticPerformance1.GetSelectedPerformance();
//				dSelectedPerformance = dgAcousticPerformance1.GetSelectedPerformance_int();
//			}
//		}

		/// <summary>
		/// 데이터 베이스 에서 로드한것인지 사용자가 입력한것인지 체크한다 (이 함수 실행후 진행하려면 true 를 리턴하고 진행하면 안될경우 false 리턴)
		/// </summary>
		/// <returns></returns>
		private bool DataBaseLoadCheck()
		{
			bool bResult = false;

			if(bIsDataBaseLoad == true)
			{
				bResult = true;
			}
			else
			{
				HONUS.MaterialPerformanceAnalysis.Component.MPA_DB MPA_DB1 = new HONUS.MaterialPerformanceAnalysis.Component.MPA_DB();
				if(MPA_DB1.IsExist(true,edtName.Text) == true)
				{
					MessageBox.Show("이미 같은 이름이 존재합니다.");

					bResult = true;
				}
				else
				{
					bResult = true;
				}
			}

			return bResult;
		}

		private void btnAnalysis_Click(object sender, System.EventArgs e)
		{
			if(edtName.Text != "")
			{
				if(DataBaseLoadCheck() == true)
				{
					SAClass1 = new SAClass();
			
					///////////////////////////////////////////
					SAClass1.Temperature = double.Parse(edtTemperature.Text);
					///////////////////////////////////////////
					if(rdoNormalIncidence.Checked == true)
					{
						SAClass1.Incidence = 1;
						SAClass1.IncAngle = 0.0;				
					}
					else
					{
						SAClass1.Incidence = 2;
						SAClass1.IncAngle = double.Parse(edtLimitAngle.Text);
					}
					///////////////////////////////////////////
					if(rdoTransmissionLoss.Checked == true)
					{
						dSelectedPerformance = 1;
					}
					else if(rdoAbsorptionCoefficientRigidBacking.Checked == true)
					{
						dSelectedPerformance = 2;
					}
					else if(rdoAbsorptionCoefficientAnechoicTermination.Checked == true)
					{
						dSelectedPerformance = 3;
					}
					SAClass1.GraphType = dSelectedPerformance;
					///////////////////////////////////////////

					switch (cboMeterialType.SelectedItem.ToString())
					{
						case "Air":
							SAClass1.MID = 1;
							break;
						case "Panel":
							SAClass1.MID = 2;
							break;
						case "Impermeable membrane":
							SAClass1.MID = 3;
							break;
						case "Permeable membrane":
							SAClass1.MID = 4;
							break;
						case "Limp porous material":
							SAClass1.MID = 5;
							break;
						case "Rigid porous material":
							SAClass1.MID = 6;
							break;
						case "Elastic porous material":
							SAClass1.MID = 7;
							break;
						case "Panel-elastic (BU)":
							SAClass1.MID = 8;
							break;
						case "Elastic-panel (UB)":
							SAClass1.MID = 9;
							break;
						case "Panel-elastic-panel (BB)":
							SAClass1.MID = 10;
							break;
					}
					///////////////////////////////////////////
					SAClass1.Name = edtName.Text;
					///////////////////////////////////////////
					SAClass1.FlowRes = double.Parse(edtFlowResistivity.Text);
					SAClass1.Thick = double.Parse(edtThickness.Text);
					SAClass1.LossFactor = double.Parse(edtLossFactor.Text);
					SAClass1.BulkDens = double.Parse(edtBulkDensity.Text);
					SAClass1.Ymodulus = double.Parse(edtYoungsModulus.Text);
					SAClass1.PoissionR = double.Parse(edtPoissionsRatio.Text);
					SAClass1.ThermalCL = double.Parse(edtThermalCharLength.Text);
					SAClass1.ViscousCL = double.Parse(edtViscousCharLength.Text);
					SAClass1.Porosity = double.Parse(edtProsity.Text);
					SAClass1.SFactor = double.Parse(edtStructureFactor.Text);
					///////////////////////////////////////////

					SAClass1.VarID = GetVar();

					frmCalc frmCalc1 = new frmCalc();
					frmCalc1.SAClass1 = SAClass1;
					frmCalc1.SAClass_Mode = 1;
					frmCalc1.ShowDialog();

					//SAClass1.InitCalc();

					MyButtonClicked("Analysis","");
				}
			}
			else
			{
				MessageBox.Show("Name 을 입력하여 주십시오.");
			}
		}

		private int GetVar()
		{
			int dResult = 0;

			if(rdoThick.Checked == true)
			{
				dResult = 0;
			}
			else if(rdoBulk.Checked == true)
			{
				dResult = 1;
			}
			else if(rdoYoung.Checked == true)
			{
				dResult = 2;
			}
			else if(rdoPoiss.Checked == true)
			{
				dResult = 3;
			}
			else if(rdoLoss.Checked == true)
			{
				dResult = 4;
			}
			else if(rdoFlow.Checked == true)
			{
				dResult = 5;
			}
			else if(rdoSFactor.Checked == true)
			{
				dResult = 6;
			}
			else if(rdoProsity.Checked == true)
			{
				dResult = 7;
			}
			else if(rdoVCL.Checked == true)
			{
				dResult = 8;
			}
			else if(rdoTCL.Checked == true)
			{
				dResult = 9;
			}

			return dResult;
		}

		public string GetcboMeterialType_ID()
		{
			return MaterialTypeds.Tables[0].Rows[cboMeterialType.SelectedIndex]["MID"].ToString();
		}

		private void cboMeterialType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			edtFlowResistivity.Enabled = false;
			edtThickness.Enabled = false;
			edtLossFactor.Enabled = false;
			edtBulkDensity.Enabled = false;
			edtYoungsModulus.Enabled = false;
			edtPoissionsRatio.Enabled = false;
			edtThermalCharLength.Enabled = false;
			edtViscousCharLength.Enabled = false;
			edtProsity.Enabled = false;
			edtStructureFactor.Enabled = false;

			switch(cboMeterialType.SelectedItem.ToString())
			{
				case "Limp porous material" :
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtStructureFactor.Enabled = true;
					edtProsity.Enabled = true;
					edtThermalCharLength.Enabled = true;
					edtViscousCharLength.Enabled = true;
					break;
				case "Rigid porous material" :
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtStructureFactor.Enabled = true;
					edtProsity.Enabled = true;
					edtThermalCharLength.Enabled = true;
					edtViscousCharLength.Enabled = true;
					break;
				case "Elastic porous material" :
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtStructureFactor.Enabled = true;
					edtProsity.Enabled = true;
					edtThermalCharLength.Enabled = true;
					edtViscousCharLength.Enabled = true;
					edtYoungsModulus.Enabled = true;
					edtLossFactor.Enabled = true;
					edtPoissionsRatio.Enabled = true;
					break;
			}
		}

		private void btnDataBaseLoad_Click(object sender, System.EventArgs e)
		{
			HONUS.MaterialDatabase.Form.frmMD_Main2 frmMD = new HONUS.MaterialDatabase.Form.frmMD_Main2();
			frmMD.bIsSearchPopup = true;
			frmMD.ClosingFlag = true;

			frmMD.ucSearchingCondition_SingleMulti_Control(true);
			
			if(frmMD.ShowDialog() == DialogResult.OK)
			{
				string strSelected_ID = frmMD.strSelectedItem_ID;

				HONUS.MaterialDatabase.Component.MD_DB MD_DB1 = new HONUS.MaterialDatabase.Component.MD_DB();
				DataSet dsSearchResult = MD_DB1.Search(frmMD.bIsSingle,strSelected_ID);

				edtName.Text = dsSearchResult.Tables[0].Rows[0]["Name"].ToString();
				cboType_Select(dsSearchResult.Tables[0].Rows[0]["MatType"].ToString());

				edtFlowResistivity.Text = dsSearchResult.Tables[0].Rows[0]["FlowRes"].ToString();
				edtThickness.Text = dsSearchResult.Tables[0].Rows[0]["Thick"].ToString();
				edtLossFactor.Text = dsSearchResult.Tables[0].Rows[0]["LossFactor"].ToString();
				edtBulkDensity.Text = dsSearchResult.Tables[0].Rows[0]["BulkDens"].ToString();
				edtYoungsModulus.Text = dsSearchResult.Tables[0].Rows[0]["Ymodulus"].ToString();
				edtPoissionsRatio.Text = dsSearchResult.Tables[0].Rows[0]["PoissionR"].ToString();
				edtProsity.Text = dsSearchResult.Tables[0].Rows[0]["Prosity"].ToString();
				edtStructureFactor.Text = dsSearchResult.Tables[0].Rows[0]["Sfactor"].ToString();
                edtViscousCharLength.Text = dsSearchResult.Tables[0].Rows[0]["ViscousCL"].ToString();
				edtThermalCharLength.Text = dsSearchResult.Tables[0].Rows[0]["ThermalCL"].ToString();
				bIsDataBaseLoad = true;
			}
			else
			{
			}
		}

		public void cboType_Select(string str_Name)
		{
			for(int i = 0 ; i < cboMeterialType.Items.Count ; i++)
			{
				if(cboMeterialType.Items[i].ToString() == str_Name)
				{
					cboMeterialType.SelectedIndex = i;
				}
			}
		}

		private void AllTextChanged_Event(object sender, System.EventArgs e)
		{
			string str = ((TextBox)sender).Text;
			// 숫자형이 아니면
			if(str != "")
			{
				if(IsNumber(str) == false)
				{
					((TextBox)sender).Text = str.Substring(0,str.Length - 1);
				}
			}
		}

		private bool IsNumber(string str)
		{
			try
			{
				double a = double.Parse(str);
				
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void rdoNormalIncidence_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoNormalIncidence.Checked == true)
			{
				edtLimitAngle.Enabled = false;
			}
			else
			{
				edtLimitAngle.Enabled = true;
			}
		}

		private void edtThickness_TextChanged(object sender, System.EventArgs e)
		{
			string str = ((TextBox)sender).Text;
			// 숫자형이 아니면
			if(str != "")
			{
				if(IsNumber(str) == false)
				{
					((TextBox)sender).Text = str.Substring(0,str.Length - 1);
				}
			}

			bIsDataBaseLoad = false;
		}

		private void SetPerformance()
		{
			if(rdoTransmissionLoss.Checked == true)
			{
				strSelectedPerformance = "Transmission Loss";
			}
			else if(rdoAbsorptionCoefficientRigidBacking.Checked == true)
			{
				strSelectedPerformance = "Absorption coefficient for rigid backing";
			}
			else if(rdoAbsorptionCoefficientAnechoicTermination.Checked == true)
			{
				strSelectedPerformance = "Absorption coefficient for anechoic termination";
			}
		}

		private void rdoTransmissionLoss_CheckedChanged(object sender, System.EventArgs e)
		{
			SetPerformance();
		}

		private void rdoAbsorptionCoefficientRigidBacking_CheckedChanged(object sender, System.EventArgs e)
		{
			SetPerformance();
		}

		private void rdoAbsorptionCoefficientAnechoicTermination_CheckedChanged(object sender, System.EventArgs e)
		{
			SetPerformance();
		}
	}
}
