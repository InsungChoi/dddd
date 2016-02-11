using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using HONUS.Common_Class;

namespace HONUS.MaterialPerformanceAnalysis.Form
{
	/// <summary>
	/// dgSingleLayer에 대한 요약 설명입니다.
	/// </summary>
	public class dgSingleLayer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtFlowResistivity;
		private System.Windows.Forms.TextBox edtThickness;
		private System.Windows.Forms.TextBox edtLossFactor;
		private System.Windows.Forms.TextBox edtBulkDensity;
		private System.Windows.Forms.TextBox edtYoungsModulus;
		private System.Windows.Forms.TextBox edtPoissionsRatio;
		private System.Windows.Forms.TextBox edtThermalCharLength;
		private System.Windows.Forms.TextBox edtViscousCharLength;
		private System.Windows.Forms.TextBox edtProsity;
		private System.Windows.Forms.TextBox edtStructureFactor;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ComboBox cboType;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox edtEmp1;
		private System.Windows.Forms.TextBox edtPratiop1;
		private System.Windows.Forms.TextBox edthp2;
		private System.Windows.Forms.TextBox edtdensityp2;
		private System.Windows.Forms.TextBox edthp1;
		private System.Windows.Forms.TextBox edtEmp2;
		private System.Windows.Forms.TextBox edtPratiop2;
		private System.Windows.Forms.TextBox edtdensityp1;
		private System.Windows.Forms.Button btnDataBaseLoad;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.Label lblMID;

		public MPALayer MPALayer1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox edtProducing;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox edtVendor;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.DateTimePicker dtDate;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lbldensityp1;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;

		public bool IsDataBaseLoad = false;

		public dgSingleLayer()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
			MPALayer1 = new MPALayer();
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

		private void cboType_Bind()
		{
			cboType.Items.Add("Air");
			cboType.Items.Add("Panel");
			cboType.Items.Add("Impermeable membrane");
			cboType.Items.Add("Permeable membrane");
            cboType.Items.Add("Limp porous material");
			cboType.Items.Add("Rigid porous material");
			cboType.Items.Add("Elastic porous material");
			cboType.Items.Add("Panel-elastic (BU)");
			cboType.Items.Add("Elastic-panel (UB)");
			cboType.Items.Add("Panel-elastic-panel (BB)");

			cboType.SelectedIndex = 0;
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(dgSingleLayer));
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.edtFlowResistivity = new System.Windows.Forms.TextBox();
			this.edtThickness = new System.Windows.Forms.TextBox();
			this.edtLossFactor = new System.Windows.Forms.TextBox();
			this.edtBulkDensity = new System.Windows.Forms.TextBox();
			this.edtYoungsModulus = new System.Windows.Forms.TextBox();
			this.edtPoissionsRatio = new System.Windows.Forms.TextBox();
			this.edtThermalCharLength = new System.Windows.Forms.TextBox();
			this.edtViscousCharLength = new System.Windows.Forms.TextBox();
			this.edtProsity = new System.Windows.Forms.TextBox();
			this.edtStructureFactor = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.cboType = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.edtEmp1 = new System.Windows.Forms.TextBox();
			this.edtPratiop1 = new System.Windows.Forms.TextBox();
			this.edthp2 = new System.Windows.Forms.TextBox();
			this.edtdensityp2 = new System.Windows.Forms.TextBox();
			this.edthp1 = new System.Windows.Forms.TextBox();
			this.edtdensityp1 = new System.Windows.Forms.TextBox();
			this.edtEmp2 = new System.Windows.Forms.TextBox();
			this.edtPratiop2 = new System.Windows.Forms.TextBox();
			this.btnDataBaseLoad = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label17 = new System.Windows.Forms.Label();
			this.edtName = new System.Windows.Forms.TextBox();
			this.lblMID = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.edtProducing = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.edtVendor = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lbldensityp1 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 40);
			this.label9.Name = "label9";
			this.label9.TabIndex = 28;
			this.label9.Text = "Bulk Density";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 16);
			this.label11.Name = "label11";
			this.label11.TabIndex = 29;
			this.label11.Text = "Thickness";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 232);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 23);
			this.label6.TabIndex = 25;
			this.label6.Text = "Thermal Char. Length";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 23);
			this.label5.TabIndex = 24;
			this.label5.Text = "Viscous Char. Length";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 184);
			this.label4.Name = "label4";
			this.label4.TabIndex = 23;
			this.label4.Text = "Prosity";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 160);
			this.label2.Name = "label2";
			this.label2.TabIndex = 21;
			this.label2.Text = "Structure Factor";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 136);
			this.label1.Name = "label1";
			this.label1.TabIndex = 20;
			this.label1.Text = "Flow Resistivity";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 112);
			this.label3.Name = "label3";
			this.label3.TabIndex = 22;
			this.label3.Text = "Loss Factor";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 23);
			this.label8.TabIndex = 27;
			this.label8.Text = "Young’s Modulus";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 88);
			this.label7.Name = "label7";
			this.label7.TabIndex = 26;
			this.label7.Text = "Poission’s Ratio";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtFlowResistivity
			// 
			this.edtFlowResistivity.Location = new System.Drawing.Point(144, 136);
			this.edtFlowResistivity.Name = "edtFlowResistivity";
			this.edtFlowResistivity.Size = new System.Drawing.Size(80, 21);
			this.edtFlowResistivity.TabIndex = 12;
			this.edtFlowResistivity.Text = "0";
			this.edtFlowResistivity.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtThickness
			// 
			this.edtThickness.Location = new System.Drawing.Point(144, 16);
			this.edtThickness.Name = "edtThickness";
			this.edtThickness.Size = new System.Drawing.Size(80, 21);
			this.edtThickness.TabIndex = 7;
			this.edtThickness.Text = "0";
			this.edtThickness.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtLossFactor
			// 
			this.edtLossFactor.Location = new System.Drawing.Point(144, 112);
			this.edtLossFactor.Name = "edtLossFactor";
			this.edtLossFactor.Size = new System.Drawing.Size(80, 21);
			this.edtLossFactor.TabIndex = 11;
			this.edtLossFactor.Text = "0";
			this.edtLossFactor.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtBulkDensity
			// 
			this.edtBulkDensity.Location = new System.Drawing.Point(144, 40);
			this.edtBulkDensity.Name = "edtBulkDensity";
			this.edtBulkDensity.Size = new System.Drawing.Size(80, 21);
			this.edtBulkDensity.TabIndex = 8;
			this.edtBulkDensity.Text = "0";
			this.edtBulkDensity.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtYoungsModulus
			// 
			this.edtYoungsModulus.Location = new System.Drawing.Point(144, 64);
			this.edtYoungsModulus.Name = "edtYoungsModulus";
			this.edtYoungsModulus.Size = new System.Drawing.Size(80, 21);
			this.edtYoungsModulus.TabIndex = 9;
			this.edtYoungsModulus.Text = "0";
			this.edtYoungsModulus.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtPoissionsRatio
			// 
			this.edtPoissionsRatio.Location = new System.Drawing.Point(144, 88);
			this.edtPoissionsRatio.Name = "edtPoissionsRatio";
			this.edtPoissionsRatio.Size = new System.Drawing.Size(80, 21);
			this.edtPoissionsRatio.TabIndex = 10;
			this.edtPoissionsRatio.Text = "0";
			this.edtPoissionsRatio.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtThermalCharLength
			// 
			this.edtThermalCharLength.Location = new System.Drawing.Point(144, 232);
			this.edtThermalCharLength.Name = "edtThermalCharLength";
			this.edtThermalCharLength.Size = new System.Drawing.Size(80, 21);
			this.edtThermalCharLength.TabIndex = 16;
			this.edtThermalCharLength.Text = "0";
			this.edtThermalCharLength.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtViscousCharLength
			// 
			this.edtViscousCharLength.Location = new System.Drawing.Point(144, 208);
			this.edtViscousCharLength.Name = "edtViscousCharLength";
			this.edtViscousCharLength.Size = new System.Drawing.Size(80, 21);
			this.edtViscousCharLength.TabIndex = 15;
			this.edtViscousCharLength.Text = "0";
			this.edtViscousCharLength.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtProsity
			// 
			this.edtProsity.Location = new System.Drawing.Point(144, 184);
			this.edtProsity.Name = "edtProsity";
			this.edtProsity.Size = new System.Drawing.Size(80, 21);
			this.edtProsity.TabIndex = 14;
			this.edtProsity.Text = "0";
			this.edtProsity.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtStructureFactor
			// 
			this.edtStructureFactor.Location = new System.Drawing.Point(144, 160);
			this.edtStructureFactor.Name = "edtStructureFactor";
			this.edtStructureFactor.Size = new System.Drawing.Size(80, 21);
			this.edtStructureFactor.TabIndex = 13;
			this.edtStructureFactor.Text = "0";
			this.edtStructureFactor.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(256, 728);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 44;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// cboType
			// 
			this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboType.Location = new System.Drawing.Point(48, 8);
			this.cboType.Name = "cboType";
			this.cboType.Size = new System.Drawing.Size(200, 20);
			this.cboType.TabIndex = 1;
			this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 23);
			this.label12.TabIndex = 46;
			this.label12.Text = "Type";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtEmp1
			// 
			this.edtEmp1.Location = new System.Drawing.Point(136, 72);
			this.edtEmp1.Name = "edtEmp1";
			this.edtEmp1.Size = new System.Drawing.Size(88, 21);
			this.edtEmp1.TabIndex = 5;
			this.edtEmp1.Text = "0";
			this.edtEmp1.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtPratiop1
			// 
			this.edtPratiop1.Location = new System.Drawing.Point(136, 96);
			this.edtPratiop1.Name = "edtPratiop1";
			this.edtPratiop1.Size = new System.Drawing.Size(88, 21);
			this.edtPratiop1.TabIndex = 6;
			this.edtPratiop1.Text = "0";
			this.edtPratiop1.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edthp2
			// 
			this.edthp2.Location = new System.Drawing.Point(136, 24);
			this.edthp2.Name = "edthp2";
			this.edthp2.Size = new System.Drawing.Size(88, 21);
			this.edthp2.TabIndex = 17;
			this.edthp2.Text = "0";
			this.edthp2.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtdensityp2
			// 
			this.edtdensityp2.Location = new System.Drawing.Point(136, 48);
			this.edtdensityp2.Name = "edtdensityp2";
			this.edtdensityp2.Size = new System.Drawing.Size(88, 21);
			this.edtdensityp2.TabIndex = 18;
			this.edtdensityp2.Text = "0";
			this.edtdensityp2.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edthp1
			// 
			this.edthp1.Location = new System.Drawing.Point(136, 24);
			this.edthp1.Name = "edthp1";
			this.edthp1.Size = new System.Drawing.Size(88, 21);
			this.edthp1.TabIndex = 3;
			this.edthp1.Text = "0";
			this.edthp1.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtdensityp1
			// 
			this.edtdensityp1.Location = new System.Drawing.Point(136, 48);
			this.edtdensityp1.Name = "edtdensityp1";
			this.edtdensityp1.Size = new System.Drawing.Size(88, 21);
			this.edtdensityp1.TabIndex = 4;
			this.edtdensityp1.Text = "0";
			this.edtdensityp1.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtEmp2
			// 
			this.edtEmp2.Location = new System.Drawing.Point(136, 72);
			this.edtEmp2.Name = "edtEmp2";
			this.edtEmp2.Size = new System.Drawing.Size(88, 21);
			this.edtEmp2.TabIndex = 19;
			this.edtEmp2.Text = "0";
			this.edtEmp2.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// edtPratiop2
			// 
			this.edtPratiop2.Location = new System.Drawing.Point(136, 96);
			this.edtPratiop2.Name = "edtPratiop2";
			this.edtPratiop2.Size = new System.Drawing.Size(88, 21);
			this.edtPratiop2.TabIndex = 20;
			this.edtPratiop2.Text = "0";
			this.edtPratiop2.TextChanged += new System.EventHandler(this.edthp1_TextChanged);
			// 
			// btnDataBaseLoad
			// 
			this.btnDataBaseLoad.Location = new System.Drawing.Point(16, 728);
			this.btnDataBaseLoad.Name = "btnDataBaseLoad";
			this.btnDataBaseLoad.Size = new System.Drawing.Size(120, 23);
			this.btnDataBaseLoad.TabIndex = 65;
			this.btnDataBaseLoad.Text = "DataBaseLoad";
			this.btnDataBaseLoad.Click += new System.EventHandler(this.btnDataBaseLoad_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.lbldensityp1);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label30);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.label32);
			this.groupBox1.Controls.Add(this.edthp1);
			this.groupBox1.Controls.Add(this.edtdensityp1);
			this.groupBox1.Controls.Add(this.edtEmp1);
			this.groupBox1.Controls.Add(this.edtPratiop1);
			this.groupBox1.Location = new System.Drawing.Point(8, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 128);
			this.groupBox1.TabIndex = 66;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Front Panel";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label29);
			this.groupBox2.Controls.Add(this.label28);
			this.groupBox2.Controls.Add(this.label27);
			this.groupBox2.Controls.Add(this.label26);
			this.groupBox2.Controls.Add(this.label25);
			this.groupBox2.Controls.Add(this.label24);
			this.groupBox2.Controls.Add(this.edtProsity);
			this.groupBox2.Controls.Add(this.edtViscousCharLength);
			this.groupBox2.Controls.Add(this.edtThermalCharLength);
			this.groupBox2.Controls.Add(this.edtPoissionsRatio);
			this.groupBox2.Controls.Add(this.edtYoungsModulus);
			this.groupBox2.Controls.Add(this.edtBulkDensity);
			this.groupBox2.Controls.Add(this.edtLossFactor);
			this.groupBox2.Controls.Add(this.edtThickness);
			this.groupBox2.Controls.Add(this.edtFlowResistivity);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.edtStructureFactor);
			this.groupBox2.Location = new System.Drawing.Point(8, 200);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(328, 264);
			this.groupBox2.TabIndex = 67;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Porous Material";
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label29.Location = new System.Drawing.Point(232, 232);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(32, 23);
			this.label29.TabIndex = 94;
			this.label29.Text = "㎛";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label28.Location = new System.Drawing.Point(232, 208);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(32, 23);
			this.label28.TabIndex = 93;
			this.label28.Text = "㎛";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(232, 136);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(88, 23);
			this.label27.TabIndex = 92;
			this.label27.Text = "MKS Rayls/m";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(232, 64);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(32, 23);
			this.label26.TabIndex = 91;
			this.label26.Text = "Pa";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(232, 40);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(40, 23);
			this.label25.TabIndex = 90;
			this.label25.Text = "Kg/㎥";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(232, 16);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(32, 23);
			this.label24.TabIndex = 89;
			this.label24.Text = "[m]";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.label21);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label33);
			this.groupBox3.Controls.Add(this.label34);
			this.groupBox3.Controls.Add(this.edtdensityp2);
			this.groupBox3.Controls.Add(this.edtEmp2);
			this.groupBox3.Controls.Add(this.edtPratiop2);
			this.groupBox3.Controls.Add(this.edthp2);
			this.groupBox3.Location = new System.Drawing.Point(8, 472);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(328, 136);
			this.groupBox3.TabIndex = 68;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Rear Panel";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(8, 40);
			this.label17.Name = "label17";
			this.label17.TabIndex = 69;
			this.label17.Text = "Name";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(120, 40);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(128, 21);
			this.edtName.TabIndex = 2;
			this.edtName.Text = "";
			// 
			// lblMID
			// 
			this.lblMID.Location = new System.Drawing.Point(0, 760);
			this.lblMID.Name = "lblMID";
			this.lblMID.TabIndex = 70;
			this.lblMID.Visible = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.edtProducing);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.edtVendor);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.label23);
			this.groupBox4.Controls.Add(this.dtDate);
			this.groupBox4.Location = new System.Drawing.Point(8, 616);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(328, 104);
			this.groupBox4.TabIndex = 122;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Reference";
			// 
			// edtProducing
			// 
			this.edtProducing.Location = new System.Drawing.Point(104, 72);
			this.edtProducing.Name = "edtProducing";
			this.edtProducing.Size = new System.Drawing.Size(144, 21);
			this.edtProducing.TabIndex = 136;
			this.edtProducing.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 72);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(72, 23);
			this.label19.TabIndex = 135;
			this.label19.Text = "Producing :";
			// 
			// edtVendor
			// 
			this.edtVendor.Location = new System.Drawing.Point(104, 48);
			this.edtVendor.Name = "edtVendor";
			this.edtVendor.Size = new System.Drawing.Size(144, 21);
			this.edtVendor.TabIndex = 134;
			this.edtVendor.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(8, 48);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(56, 23);
			this.label22.TabIndex = 133;
			this.label22.Text = "Vendor : ";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(8, 16);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(40, 23);
			this.label23.TabIndex = 132;
			this.label23.Text = "Date :";
			// 
			// dtDate
			// 
			this.dtDate.Location = new System.Drawing.Point(64, 16);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(184, 21);
			this.dtDate.TabIndex = 131;
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(232, 72);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(32, 23);
			this.label30.TabIndex = 100;
			this.label30.Text = "Pa";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(232, 48);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(40, 23);
			this.label31.TabIndex = 99;
			this.label31.Text = "Kg/㎥";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(232, 24);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(32, 23);
			this.label32.TabIndex = 98;
			this.label32.Text = "[m]";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(232, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 23);
			this.label10.TabIndex = 100;
			this.label10.Text = "Pa";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(232, 48);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(40, 23);
			this.label33.TabIndex = 99;
			this.label33.Text = "Kg/㎥";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(232, 24);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(32, 23);
			this.label34.TabIndex = 98;
			this.label34.Text = "[m]";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(8, 96);
			this.label15.Name = "label15";
			this.label15.TabIndex = 104;
			this.label15.Text = "Poission\'s Ratio";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 72);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(112, 23);
			this.label16.TabIndex = 102;
			this.label16.Text = "Young\'s Modulus";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbldensityp1
			// 
			this.lbldensityp1.Location = new System.Drawing.Point(8, 48);
			this.lbldensityp1.Name = "lbldensityp1";
			this.lbldensityp1.TabIndex = 101;
			this.lbldensityp1.Text = "Density";
			this.lbldensityp1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 24);
			this.label18.Name = "label18";
			this.label18.TabIndex = 103;
			this.label18.Text = "Thickness";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 96);
			this.label13.Name = "label13";
			this.label13.TabIndex = 104;
			this.label13.Text = "Poission\'s Ratio";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 72);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(112, 23);
			this.label14.TabIndex = 102;
			this.label14.Text = "Young\'s Modulus";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(8, 48);
			this.label20.Name = "label20";
			this.label20.TabIndex = 101;
			this.label20.Text = "Density";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 24);
			this.label21.Name = "label21";
			this.label21.TabIndex = 103;
			this.label21.Text = "Thickness";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgSingleLayer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(346, 762);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.lblMID);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnDataBaseLoad);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.cboType);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "dgSingleLayer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Single Layer";
			this.Load += new System.EventHandler(this.dgSingleLayer_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if(edtName.Text != "")
			{
				if(DataBaseLoadCheck() == true)
				{
					this.DialogResult = DialogResult.OK;

					MPAMaterial MPAMaterial1 = new MPAMaterial();

					MPAMaterial1.IsMaterialCreate = !this.IsDataBaseLoad;

					switch (cboType.SelectedItem.ToString())
					{
						case "Air":
							MPAMaterial1.MID = 1;
							break;
						case "Panel":
							MPAMaterial1.MID = 2;
							break;
						case "Impermeable membrane":
							MPAMaterial1.MID = 3;
							break;
						case "Permeable membrane":
							MPAMaterial1.MID = 4;
							break;
						case "Limp porous material":
							MPAMaterial1.MID = 5;
							break;
						case "Rigid porous material":
							MPAMaterial1.MID = 6;
							break;
						case "Elastic porous material":
							MPAMaterial1.MID = 7;
							break;
						case "Panel-elastic (BU)":
							MPAMaterial1.MID = 8;
							break;
						case "Elastic-panel (UB)":
							MPAMaterial1.MID = 9;
							break;
						case "Panel-elastic-panel (BB)":
							MPAMaterial1.MID = 10;
							break;
					}
					MPAMaterial1.MaterTypeName = cboType.SelectedItem.ToString();

					MPAMaterial1.FlowRes = long.Parse(edtFlowResistivity.Text);
					MPAMaterial1.Thick = double.Parse(edtThickness.Text);
					MPAMaterial1.LossFactor = double.Parse(edtLossFactor.Text);
					MPAMaterial1.BulkDens = double.Parse(edtBulkDensity.Text);
					MPAMaterial1.Ymodulus = long.Parse(edtYoungsModulus.Text);
					MPAMaterial1.PoissionR = double.Parse(edtPoissionsRatio.Text);
					MPAMaterial1.ThermalCL = double.Parse(edtThermalCharLength.Text);
					MPAMaterial1.ViscousCL = double.Parse(edtViscousCharLength.Text);
					MPAMaterial1.Porosity = double.Parse(edtProsity.Text);
					MPAMaterial1.SFactor = double.Parse(edtStructureFactor.Text);
					MPAMaterial1.EmP1 = double.Parse(edtEmp1.Text);
					MPAMaterial1.PRatioP1 = double.Parse(edtPratiop1.Text);
					MPAMaterial1.HP2 = double.Parse(edthp2.Text);
					MPAMaterial1.DensityP2 = double.Parse(edtdensityp2.Text);
					MPAMaterial1.HP1 = double.Parse(edthp1.Text);
					MPAMaterial1.DensityP1 = double.Parse(edtdensityp1.Text);
					MPAMaterial1.EmP2 = double.Parse(edtEmp2.Text);
					MPAMaterial1.PRatioP2 = double.Parse(edtPratiop2.Text);
					MPAMaterial1.Name = edtName.Text;

					MPAMaterial1.strDate = dtDate.Value.ToString("yyyy-MM-dd");
					MPAMaterial1.strVender = edtVendor.Text;
					MPAMaterial1.strProducing = edtProducing.Text;

					MPALayer1.LayerDeleteAll(); // Single 이기 때문에 하나만 존재하기 위해서 모두 지운다
					MPALayer1.LayerAdd(MPAMaterial1);
					//MPALayer1.Calc();

					this.Close();
				}				
			}
			else
			{
				MessageBox.Show("Name 을 입력하여 주십시오.");
			}
		}

		/// <summary>
		/// 데이터 베이스 에서 로드한것인지 사용자가 입력한것인지 체크한다 (이 함수 실행후 진행하려면 true 를 리턴하고 진행하면 안될경우 false 리턴)
		/// </summary>
		/// <returns></returns>
		private bool DataBaseLoadCheck()
		{
			bool bResult = false;

			if(IsDataBaseLoad == true)
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

		private void dgSingleLayer_Load(object sender, System.EventArgs e)
		{
			cboType_Bind();

			if(MPALayer1 != null)
			{
				if(MPALayer1.GetCount() > 0)
				{
					MPAMaterial MPAMaterial1 = MPALayer1.GetMPAMaterial(0);

					cboType_Select(MPAMaterial1.MaterTypeName);
					edtName.Text = MPAMaterial1.Name;
					lblMID.Text = MPAMaterial1.MID.ToString();
					edtFlowResistivity.Text = MPAMaterial1.FlowRes.ToString();
					edtThickness.Text = MPAMaterial1.Thick.ToString();
					edtLossFactor.Text = MPAMaterial1.LossFactor.ToString();
					edtBulkDensity.Text = MPAMaterial1.BulkDens.ToString();
					edtYoungsModulus.Text = MPAMaterial1.Ymodulus.ToString();
					edtPoissionsRatio.Text = MPAMaterial1.PoissionR.ToString();
					edtThermalCharLength.Text = MPAMaterial1.ThermalCL.ToString();
					edtViscousCharLength.Text = MPAMaterial1.ViscousCL.ToString();
					edtProsity.Text = MPAMaterial1.Porosity.ToString();
					edtStructureFactor.Text = MPAMaterial1.SFactor.ToString();
					edtEmp1.Text = MPAMaterial1.EmP1.ToString();
					edtPratiop1.Text = MPAMaterial1.PRatioP1.ToString();
					edthp2.Text = MPAMaterial1.HP2.ToString();
					edtdensityp2.Text = MPAMaterial1.DensityP2.ToString();
					edthp1.Text = MPAMaterial1.HP1.ToString();
					edtdensityp1.Text = MPAMaterial1.DensityP1.ToString();
					edtEmp2.Text = MPAMaterial1.EmP2.ToString();
					edtPratiop2.Text = MPAMaterial1.PRatioP2.ToString();
				}
			}
		}

		private void cboType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
//			edtMeasuredAbsorption.Enabled = false;
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
			edtEmp1.Enabled = false;
			edtPratiop1.Enabled = false;
			edthp2.Enabled = false;
			edtdensityp2.Enabled = false;
			edthp1.Enabled = false;
			edtdensityp1.Enabled = false;
			edtEmp2.Enabled = false;
			edtPratiop2.Enabled = false;

			switch(cboType.SelectedItem.ToString())
			{
				case "Air" :
					edtThickness.Enabled = true;
					break;
				case "Panel" :
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtYoungsModulus.Enabled = true;
					edtPoissionsRatio.Enabled = true;
					break;
				case "Impermeable membrane" :
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					break;
				case "Permeable membrane" :
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;
					break;
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
				case "Panel-elastic (BU)" :
					edtThickness.Enabled = true;
					edthp1.Enabled = true;
					edtdensityp1.Enabled = true;
					edtEmp1.Enabled = true;
					edtPratiop1.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtStructureFactor.Enabled = true;
					edtProsity.Enabled = true;
					edtThermalCharLength.Enabled = true;
					edtViscousCharLength.Enabled = true;
					break;
				case "Elastic-panel (UB)" :
					edtThickness.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtStructureFactor.Enabled = true;
					edtProsity.Enabled = true;
					edtThermalCharLength.Enabled = true;
					edtViscousCharLength.Enabled = true;
					edthp2.Enabled = true;
					edtdensityp2.Enabled = true;
					edtEmp2.Enabled = true;
					edtPratiop2.Enabled = true;
					break;
				case "Panel-elastic-panel (BB)" :
					edtThickness.Enabled = true;
					edthp1.Enabled = true;
					edtdensityp1.Enabled = true;
					edtEmp1.Enabled = true;
					edtPratiop1.Enabled = true;
					edtBulkDensity.Enabled = true;
					edtFlowResistivity.Enabled = true;
					edtStructureFactor.Enabled = true;
					edtProsity.Enabled = true;
					edtThermalCharLength.Enabled = true;
					edtViscousCharLength.Enabled = true;
					edthp2.Enabled = true;
					edtdensityp2.Enabled = true;
					edtEmp2.Enabled = true;
					edtPratiop2.Enabled = true;
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
				edtThermalCharLength.Text = dsSearchResult.Tables[0].Rows[0]["ThermalCL"].ToString();
				edtViscousCharLength.Text = dsSearchResult.Tables[0].Rows[0]["ViscousCL"].ToString();
				edtProsity.Text = dsSearchResult.Tables[0].Rows[0]["Prosity"].ToString();
				edtStructureFactor.Text = dsSearchResult.Tables[0].Rows[0]["Sfactor"].ToString();
				edtEmp1.Text = dsSearchResult.Tables[0].Rows[0]["EmP1"].ToString();
				edtPratiop1.Text = dsSearchResult.Tables[0].Rows[0]["PRatioP1"].ToString();
				edthp2.Text = dsSearchResult.Tables[0].Rows[0]["HP2"].ToString();
				edtdensityp2.Text = dsSearchResult.Tables[0].Rows[0]["DensityP2"].ToString();
				edthp1.Text = dsSearchResult.Tables[0].Rows[0]["HP1"].ToString();
				edtdensityp1.Text = dsSearchResult.Tables[0].Rows[0]["DensityP1"].ToString();
				edtEmp2.Text = dsSearchResult.Tables[0].Rows[0]["EmP2"].ToString();
				edtPratiop2.Text = dsSearchResult.Tables[0].Rows[0]["PRatioP2"].ToString();

				lblMID.Text = dsSearchResult.Tables[0].Rows[0]["MID"].ToString();

				IsDataBaseLoad = true;
			}
			else
			{
			}
		}

		public void cboType_Select(string str_Name)
		{
			for(int i = 0 ; i < cboType.Items.Count ; i++)
			{
				if(cboType.Items[i].ToString() == str_Name)
				{
					cboType.SelectedIndex = i;
				}
			}
		}

		private void edthp1_TextChanged(object sender, System.EventArgs e)
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

			IsDataBaseLoad = false;
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

		#region 접근자

//		public string strMeasuredAbsorption
//		{
//			get
//			{
//				return edtMeasuredAbsorption.Text;
//			}
//		}

		public string strFlowResistivity
		{
			get
			{
				return edtFlowResistivity.Text;
			}
		}

		public string strThickness
		{
			get
			{
				return edtThickness.Text;
			}
		}

		public string strLossFactor
		{
			get
			{
				return edtLossFactor.Text;
			}
		}

		public string strBulkDensity
		{
			get
			{
				return edtBulkDensity.Text;
			}
		}

		public string strYoungsModulus
		{
			get
			{
				return edtYoungsModulus.Text;
			}
		}

		public string strPoissionsRatio
		{
			get
			{
				return edtPoissionsRatio.Text;
			}
		}

		public string strThermalCharLength
		{
			get
			{
				return edtThermalCharLength.Text;
			}
		}

		public string strViscousCharLength
		{
			get
			{
				return edtViscousCharLength.Text;
			}
		}

		public string strtProsity
		{
			get
			{
				return edtProsity.Text;
			}
		}

		public string strStructureFactor
		{
			get
			{
				return edtStructureFactor.Text;
			}
		}

		#endregion
	}
}
