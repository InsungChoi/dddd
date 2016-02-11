using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// dgParameters_Find에 대한 요약 설명입니다.
	/// </summary>
	public class dgParameters_Find : System.Windows.Forms.Form
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
		private System.Windows.Forms.TextBox edtThickness_High;
		private System.Windows.Forms.TextBox edtBulkDensity_High;
		private System.Windows.Forms.TextBox edtStructureFactor_High;
		private System.Windows.Forms.TextBox edtFlowResistivity_High;
		private System.Windows.Forms.TextBox edtPoissionsRatio_High;
		private System.Windows.Forms.TextBox edtYoungsModulus_High;
		private System.Windows.Forms.TextBox edtLossFactor_High;
		private System.Windows.Forms.TextBox edtThickness_Low;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCANCEL;
		private System.Windows.Forms.TextBox edtThermalCharLength_High;
		private System.Windows.Forms.TextBox edtProsity_High;
		private System.Windows.Forms.TextBox edtViscousCharLength_High;
		private System.Windows.Forms.TextBox edtBulkDensity_Low;
		private System.Windows.Forms.TextBox edtStructureFactor_Low;
		private System.Windows.Forms.TextBox edtProsity_Low;
		private System.Windows.Forms.TextBox edtFlowResistivity_Low;
		private System.Windows.Forms.TextBox edtPoissionsRatio_Low;
		private System.Windows.Forms.TextBox edtYoungsModulus_Low;
		private System.Windows.Forms.TextBox edtLossFactor_Low;
		private System.Windows.Forms.TextBox edtThermalCharLength_Low;
		private System.Windows.Forms.TextBox edtViscousCharLength_Low;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox edtName;

		public clsParameters clsParameters1;

		public dgParameters_Find()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
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

		private void DoubleCheck(object sender, System.EventArgs e)
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.edtThickness_High = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.edtBulkDensity_High = new System.Windows.Forms.TextBox();
			this.edtThermalCharLength_High = new System.Windows.Forms.TextBox();
			this.edtStructureFactor_High = new System.Windows.Forms.TextBox();
			this.edtProsity_High = new System.Windows.Forms.TextBox();
			this.edtViscousCharLength_High = new System.Windows.Forms.TextBox();
			this.edtFlowResistivity_High = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.edtPoissionsRatio_High = new System.Windows.Forms.TextBox();
			this.edtYoungsModulus_High = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.edtLossFactor_High = new System.Windows.Forms.TextBox();
			this.edtThickness_Low = new System.Windows.Forms.TextBox();
			this.edtBulkDensity_Low = new System.Windows.Forms.TextBox();
			this.edtThermalCharLength_Low = new System.Windows.Forms.TextBox();
			this.edtStructureFactor_Low = new System.Windows.Forms.TextBox();
			this.edtProsity_Low = new System.Windows.Forms.TextBox();
			this.edtViscousCharLength_Low = new System.Windows.Forms.TextBox();
			this.edtFlowResistivity_Low = new System.Windows.Forms.TextBox();
			this.edtPoissionsRatio_Low = new System.Windows.Forms.TextBox();
			this.edtYoungsModulus_Low = new System.Windows.Forms.TextBox();
			this.edtLossFactor_Low = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.edtName = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// edtThickness_High
			// 
			this.edtThickness_High.Location = new System.Drawing.Point(304, 24);
			this.edtThickness_High.Name = "edtThickness_High";
			this.edtThickness_High.Size = new System.Drawing.Size(72, 21);
			this.edtThickness_High.TabIndex = 2;
			this.edtThickness_High.Text = "";
			this.edtThickness_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(128, 48);
			this.label9.Name = "label9";
			this.label9.TabIndex = 47;
			this.label9.Text = "Bulk Density";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(128, 24);
			this.label11.Name = "label11";
			this.label11.TabIndex = 48;
			this.label11.Text = "Thickness";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtBulkDensity_High
			// 
			this.edtBulkDensity_High.Location = new System.Drawing.Point(304, 48);
			this.edtBulkDensity_High.Name = "edtBulkDensity_High";
			this.edtBulkDensity_High.Size = new System.Drawing.Size(72, 21);
			this.edtBulkDensity_High.TabIndex = 4;
			this.edtBulkDensity_High.Text = "";
			this.edtBulkDensity_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtThermalCharLength_High
			// 
			this.edtThermalCharLength_High.Location = new System.Drawing.Point(304, 240);
			this.edtThermalCharLength_High.Name = "edtThermalCharLength_High";
			this.edtThermalCharLength_High.Size = new System.Drawing.Size(72, 21);
			this.edtThermalCharLength_High.TabIndex = 20;
			this.edtThermalCharLength_High.Text = "";
			this.edtThermalCharLength_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtStructureFactor_High
			// 
			this.edtStructureFactor_High.Location = new System.Drawing.Point(304, 168);
			this.edtStructureFactor_High.Name = "edtStructureFactor_High";
			this.edtStructureFactor_High.Size = new System.Drawing.Size(72, 21);
			this.edtStructureFactor_High.TabIndex = 14;
			this.edtStructureFactor_High.Text = "";
			this.edtStructureFactor_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtProsity_High
			// 
			this.edtProsity_High.Location = new System.Drawing.Point(304, 192);
			this.edtProsity_High.Name = "edtProsity_High";
			this.edtProsity_High.Size = new System.Drawing.Size(72, 21);
			this.edtProsity_High.TabIndex = 16;
			this.edtProsity_High.Text = "";
			this.edtProsity_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtViscousCharLength_High
			// 
			this.edtViscousCharLength_High.Location = new System.Drawing.Point(304, 216);
			this.edtViscousCharLength_High.Name = "edtViscousCharLength_High";
			this.edtViscousCharLength_High.Size = new System.Drawing.Size(72, 21);
			this.edtViscousCharLength_High.TabIndex = 18;
			this.edtViscousCharLength_High.Text = "";
			this.edtViscousCharLength_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtFlowResistivity_High
			// 
			this.edtFlowResistivity_High.Location = new System.Drawing.Point(304, 144);
			this.edtFlowResistivity_High.Name = "edtFlowResistivity_High";
			this.edtFlowResistivity_High.Size = new System.Drawing.Size(72, 21);
			this.edtFlowResistivity_High.TabIndex = 12;
			this.edtFlowResistivity_High.Text = "";
			this.edtFlowResistivity_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(128, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 23);
			this.label6.TabIndex = 38;
			this.label6.Text = "Thermal Char. Length";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(128, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 23);
			this.label5.TabIndex = 36;
			this.label5.Text = "Viscous Char. Length";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(128, 192);
			this.label4.Name = "label4";
			this.label4.TabIndex = 33;
			this.label4.Text = "Prosity";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(128, 168);
			this.label2.Name = "label2";
			this.label2.TabIndex = 30;
			this.label2.Text = "Structure Factor";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(128, 144);
			this.label1.Name = "label1";
			this.label1.TabIndex = 29;
			this.label1.Text = "Flow Resistivity";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtPoissionsRatio_High
			// 
			this.edtPoissionsRatio_High.Location = new System.Drawing.Point(304, 96);
			this.edtPoissionsRatio_High.Name = "edtPoissionsRatio_High";
			this.edtPoissionsRatio_High.Size = new System.Drawing.Size(72, 21);
			this.edtPoissionsRatio_High.TabIndex = 8;
			this.edtPoissionsRatio_High.Text = "";
			this.edtPoissionsRatio_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtYoungsModulus_High
			// 
			this.edtYoungsModulus_High.Location = new System.Drawing.Point(304, 72);
			this.edtYoungsModulus_High.Name = "edtYoungsModulus_High";
			this.edtYoungsModulus_High.Size = new System.Drawing.Size(72, 21);
			this.edtYoungsModulus_High.TabIndex = 6;
			this.edtYoungsModulus_High.Text = "";
			this.edtYoungsModulus_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(128, 120);
			this.label3.Name = "label3";
			this.label3.TabIndex = 32;
			this.label3.Text = "Loss Factor";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(128, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 23);
			this.label8.TabIndex = 42;
			this.label8.Text = "Young’s Modulus";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(128, 96);
			this.label7.Name = "label7";
			this.label7.TabIndex = 40;
			this.label7.Text = "Poission’s Ratio";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtLossFactor_High
			// 
			this.edtLossFactor_High.Location = new System.Drawing.Point(304, 120);
			this.edtLossFactor_High.Name = "edtLossFactor_High";
			this.edtLossFactor_High.Size = new System.Drawing.Size(72, 21);
			this.edtLossFactor_High.TabIndex = 10;
			this.edtLossFactor_High.Text = "";
			this.edtLossFactor_High.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtThickness_Low
			// 
			this.edtThickness_Low.Location = new System.Drawing.Point(16, 24);
			this.edtThickness_Low.Name = "edtThickness_Low";
			this.edtThickness_Low.Size = new System.Drawing.Size(72, 21);
			this.edtThickness_Low.TabIndex = 1;
			this.edtThickness_Low.Text = "";
			this.edtThickness_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtBulkDensity_Low
			// 
			this.edtBulkDensity_Low.Location = new System.Drawing.Point(16, 48);
			this.edtBulkDensity_Low.Name = "edtBulkDensity_Low";
			this.edtBulkDensity_Low.Size = new System.Drawing.Size(72, 21);
			this.edtBulkDensity_Low.TabIndex = 3;
			this.edtBulkDensity_Low.Text = "";
			this.edtBulkDensity_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtThermalCharLength_Low
			// 
			this.edtThermalCharLength_Low.Location = new System.Drawing.Point(16, 240);
			this.edtThermalCharLength_Low.Name = "edtThermalCharLength_Low";
			this.edtThermalCharLength_Low.Size = new System.Drawing.Size(72, 21);
			this.edtThermalCharLength_Low.TabIndex = 19;
			this.edtThermalCharLength_Low.Text = "";
			this.edtThermalCharLength_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtStructureFactor_Low
			// 
			this.edtStructureFactor_Low.Location = new System.Drawing.Point(16, 168);
			this.edtStructureFactor_Low.Name = "edtStructureFactor_Low";
			this.edtStructureFactor_Low.Size = new System.Drawing.Size(72, 21);
			this.edtStructureFactor_Low.TabIndex = 13;
			this.edtStructureFactor_Low.Text = "";
			this.edtStructureFactor_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtProsity_Low
			// 
			this.edtProsity_Low.Location = new System.Drawing.Point(16, 192);
			this.edtProsity_Low.Name = "edtProsity_Low";
			this.edtProsity_Low.Size = new System.Drawing.Size(72, 21);
			this.edtProsity_Low.TabIndex = 15;
			this.edtProsity_Low.Text = "";
			this.edtProsity_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtViscousCharLength_Low
			// 
			this.edtViscousCharLength_Low.Location = new System.Drawing.Point(16, 216);
			this.edtViscousCharLength_Low.Name = "edtViscousCharLength_Low";
			this.edtViscousCharLength_Low.Size = new System.Drawing.Size(72, 21);
			this.edtViscousCharLength_Low.TabIndex = 17;
			this.edtViscousCharLength_Low.Text = "";
			this.edtViscousCharLength_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtFlowResistivity_Low
			// 
			this.edtFlowResistivity_Low.Location = new System.Drawing.Point(16, 144);
			this.edtFlowResistivity_Low.Name = "edtFlowResistivity_Low";
			this.edtFlowResistivity_Low.Size = new System.Drawing.Size(72, 21);
			this.edtFlowResistivity_Low.TabIndex = 11;
			this.edtFlowResistivity_Low.Text = "";
			this.edtFlowResistivity_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtPoissionsRatio_Low
			// 
			this.edtPoissionsRatio_Low.Location = new System.Drawing.Point(16, 96);
			this.edtPoissionsRatio_Low.Name = "edtPoissionsRatio_Low";
			this.edtPoissionsRatio_Low.Size = new System.Drawing.Size(72, 21);
			this.edtPoissionsRatio_Low.TabIndex = 7;
			this.edtPoissionsRatio_Low.Text = "";
			this.edtPoissionsRatio_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtYoungsModulus_Low
			// 
			this.edtYoungsModulus_Low.Location = new System.Drawing.Point(16, 72);
			this.edtYoungsModulus_Low.Name = "edtYoungsModulus_Low";
			this.edtYoungsModulus_Low.Size = new System.Drawing.Size(72, 21);
			this.edtYoungsModulus_Low.TabIndex = 5;
			this.edtYoungsModulus_Low.Text = "";
			this.edtYoungsModulus_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edtLossFactor_Low
			// 
			this.edtLossFactor_Low.Location = new System.Drawing.Point(16, 120);
			this.edtLossFactor_Low.Name = "edtLossFactor_Low";
			this.edtLossFactor_Low.Size = new System.Drawing.Size(72, 21);
			this.edtLossFactor_Low.TabIndex = 9;
			this.edtLossFactor_Low.Text = "";
			this.edtLossFactor_Low.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label10.Location = new System.Drawing.Point(88, 29);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 23);
			this.label10.TabIndex = 59;
			this.label10.Text = "<=";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label12.Location = new System.Drawing.Point(88, 53);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 23);
			this.label12.TabIndex = 60;
			this.label12.Text = "<=";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label15.Location = new System.Drawing.Point(88, 101);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(32, 23);
			this.label15.TabIndex = 63;
			this.label15.Text = "<=";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label17.Location = new System.Drawing.Point(88, 77);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(32, 23);
			this.label17.TabIndex = 65;
			this.label17.Text = "<=";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label18.Location = new System.Drawing.Point(88, 125);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(32, 23);
			this.label18.TabIndex = 66;
			this.label18.Text = "<=";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label19.Location = new System.Drawing.Point(88, 150);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(32, 23);
			this.label19.TabIndex = 67;
			this.label19.Text = "<=";
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label21.Location = new System.Drawing.Point(88, 197);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(32, 23);
			this.label21.TabIndex = 69;
			this.label21.Text = "<=";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label22.Location = new System.Drawing.Point(88, 173);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(32, 23);
			this.label22.TabIndex = 70;
			this.label22.Text = "<=";
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label23.Location = new System.Drawing.Point(88, 221);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(32, 23);
			this.label23.TabIndex = 71;
			this.label23.Text = "<=";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label26.Location = new System.Drawing.Point(88, 248);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(32, 17);
			this.label26.TabIndex = 74;
			this.label26.Text = "<=";
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label31.Location = new System.Drawing.Point(264, 245);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(32, 17);
			this.label31.TabIndex = 88;
			this.label31.Text = "<=";
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label32.Location = new System.Drawing.Point(264, 220);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(32, 23);
			this.label32.TabIndex = 87;
			this.label32.Text = "<=";
			// 
			// label33
			// 
			this.label33.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label33.Location = new System.Drawing.Point(264, 173);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(32, 23);
			this.label33.TabIndex = 86;
			this.label33.Text = "<=";
			// 
			// label34
			// 
			this.label34.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label34.Location = new System.Drawing.Point(264, 196);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(32, 23);
			this.label34.TabIndex = 85;
			this.label34.Text = "<=";
			// 
			// label35
			// 
			this.label35.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label35.Location = new System.Drawing.Point(264, 148);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(32, 23);
			this.label35.TabIndex = 84;
			this.label35.Text = "<=";
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label36.Location = new System.Drawing.Point(264, 125);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(32, 23);
			this.label36.TabIndex = 83;
			this.label36.Text = "<=";
			// 
			// label37
			// 
			this.label37.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label37.Location = new System.Drawing.Point(264, 76);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(32, 23);
			this.label37.TabIndex = 82;
			this.label37.Text = "<=";
			// 
			// label38
			// 
			this.label38.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label38.Location = new System.Drawing.Point(264, 101);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(32, 23);
			this.label38.TabIndex = 81;
			this.label38.Text = "<=";
			// 
			// label39
			// 
			this.label39.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label39.Location = new System.Drawing.Point(264, 53);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(32, 23);
			this.label39.TabIndex = 80;
			this.label39.Text = "<=";
			// 
			// label40
			// 
			this.label40.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label40.Location = new System.Drawing.Point(264, 28);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(32, 23);
			this.label40.TabIndex = 79;
			this.label40.Text = "<=";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(318, 312);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 89;
			this.btnOK.Text = "Ok";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCANCEL
			// 
			this.btnCANCEL.Location = new System.Drawing.Point(238, 312);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.TabIndex = 90;
			this.btnCANCEL.Text = "Cancel";
			this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.edtFlowResistivity_Low);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.edtYoungsModulus_Low);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.edtFlowResistivity_High);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.edtThickness_High);
			this.groupBox1.Controls.Add(this.edtPoissionsRatio_High);
			this.groupBox1.Controls.Add(this.edtYoungsModulus_High);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label37);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.edtLossFactor_High);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label35);
			this.groupBox1.Controls.Add(this.edtBulkDensity_High);
			this.groupBox1.Controls.Add(this.label36);
			this.groupBox1.Controls.Add(this.edtThermalCharLength_High);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.edtLossFactor_Low);
			this.groupBox1.Controls.Add(this.label39);
			this.groupBox1.Controls.Add(this.label40);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.edtBulkDensity_Low);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.edtStructureFactor_High);
			this.groupBox1.Controls.Add(this.label32);
			this.groupBox1.Controls.Add(this.edtThickness_Low);
			this.groupBox1.Controls.Add(this.label33);
			this.groupBox1.Controls.Add(this.edtProsity_High);
			this.groupBox1.Controls.Add(this.edtViscousCharLength_Low);
			this.groupBox1.Controls.Add(this.edtViscousCharLength_High);
			this.groupBox1.Controls.Add(this.edtPoissionsRatio_Low);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.label34);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.edtThermalCharLength_Low);
			this.groupBox1.Controls.Add(this.edtStructureFactor_Low);
			this.groupBox1.Controls.Add(this.edtProsity_Low);
			this.groupBox1.Controls.Add(this.label38);
			this.groupBox1.Location = new System.Drawing.Point(8, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 272);
			this.groupBox1.TabIndex = 91;
			this.groupBox1.TabStop = false;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 23);
			this.label13.TabIndex = 92;
			this.label13.Text = "Name : ";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(60, 4);
			this.edtName.Name = "edtName";
			this.edtName.TabIndex = 0;
			this.edtName.Text = "";
			// 
			// dgParameters_Find
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 338);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCANCEL);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dgParameters_Find";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Parameters 검색창";
			this.Load += new System.EventHandler(this.dgParameters_Find_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			clsParameters1 = new clsParameters();

			 clsParameters1.strName = edtName.Text;

			clsParameters1.strThickness_High = edtThickness_High.Text;
			clsParameters1.strBulkDensity_High = edtBulkDensity_High.Text;
			clsParameters1.strStructureFactor_High = edtStructureFactor_High.Text;
			clsParameters1.strFlowResistivity_High = edtFlowResistivity_High.Text;
			clsParameters1.strPoissionsRatio_High = edtPoissionsRatio_High.Text;
			clsParameters1.strYoungsModulus_High = edtYoungsModulus_High.Text;
			clsParameters1.strLossFactor_High = edtLossFactor_High.Text;
			clsParameters1.strThickness_Low = edtThickness_Low.Text;
			clsParameters1.strThermalCharLength_High = edtThermalCharLength_High.Text;
			clsParameters1.strProsity_High = edtProsity_High.Text;
			clsParameters1.strViscousCharLength_High = edtViscousCharLength_High.Text;
			clsParameters1.strBulkDensity_Low = edtBulkDensity_Low.Text;
			clsParameters1.strStructureFactor_Low = edtStructureFactor_Low.Text;
			clsParameters1.strProsity_Low = edtProsity_Low.Text;
			clsParameters1.strFlowResistivity_Low = edtFlowResistivity_Low.Text;
			clsParameters1.strPoissionsRatio_Low = edtPoissionsRatio_Low.Text;
			clsParameters1.strYoungsModulus_Low = edtYoungsModulus_Low.Text;
			clsParameters1.strLossFactor_Low = edtLossFactor_Low.Text;
			clsParameters1.strThermalCharLength_Low = edtThermalCharLength_Low.Text;
			clsParameters1.strViscousCharLength_Low = edtViscousCharLength_Low.Text;

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCANCEL_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void dgParameters_Find_Load(object sender, System.EventArgs e)
		{
			if(clsParameters1 != null)
			{
				edtName.Text = clsParameters1.strName;

				edtBulkDensity_High.Text = clsParameters1.strBulkDensity_High;
				edtBulkDensity_Low.Text = clsParameters1.strBulkDensity_Low;
				edtFlowResistivity_High.Text = clsParameters1.strFlowResistivity_High;
				edtFlowResistivity_Low.Text = clsParameters1.strFlowResistivity_Low;
				edtLossFactor_High.Text = clsParameters1.strLossFactor_High;
				edtLossFactor_Low.Text = clsParameters1.strLossFactor_Low;
				edtPoissionsRatio_High.Text = clsParameters1.strPoissionsRatio_High;
				edtPoissionsRatio_Low.Text = clsParameters1.strPoissionsRatio_Low;
				edtProsity_High.Text = clsParameters1.strProsity_High;
				edtProsity_Low.Text = clsParameters1.strProsity_Low;
				edtStructureFactor_High.Text = clsParameters1.strStructureFactor_High;
				edtStructureFactor_Low.Text = clsParameters1.strStructureFactor_Low;
				edtThermalCharLength_High.Text = clsParameters1.strThermalCharLength_High;
				edtThermalCharLength_Low.Text = clsParameters1.strThermalCharLength_Low;
				edtThickness_High.Text = clsParameters1.strThickness_High;
				edtThickness_Low.Text = clsParameters1.strThickness_Low;
				edtViscousCharLength_High.Text = clsParameters1.strViscousCharLength_High;
				edtViscousCharLength_Low.Text = clsParameters1.strViscousCharLength_Low;
				edtYoungsModulus_High.Text = clsParameters1.strYoungsModulus_High;
				edtYoungsModulus_Low.Text = clsParameters1.strYoungsModulus_Low;
			}
		}

		private void label13_Click(object sender, System.EventArgs e)
		{
		
		}
	}

	public class clsParameters
	{
		public string strName;

		public string strThickness_High;
		public string strBulkDensity_High;
		public string strStructureFactor_High;
		public string strFlowResistivity_High;
		public string strPoissionsRatio_High;
		public string strYoungsModulus_High;
		public string strLossFactor_High;
		public string strThickness_Low;
		public string strThermalCharLength_High;
		public string strProsity_High;
		public string strViscousCharLength_High;
		public string strBulkDensity_Low;
		public string strStructureFactor_Low;
		public string strProsity_Low;
		public string strFlowResistivity_Low;
		public string strPoissionsRatio_Low;
		public string strYoungsModulus_Low;
		public string strLossFactor_Low;
		public string strThermalCharLength_Low;
		public string strViscousCharLength_Low;

		public clsParameters()
		{
			strName = "";

			strThickness_High = "";
			strBulkDensity_High = "";
			strStructureFactor_High = "";
			strFlowResistivity_High = "";
			strPoissionsRatio_High = "";
			strYoungsModulus_High = "";
			strLossFactor_High = "";
			strThickness_Low = "";
			strThermalCharLength_High = "";
			strProsity_High = "";
			strViscousCharLength_High = "";
			strBulkDensity_Low = "";
			strStructureFactor_Low = "";
			strProsity_Low = "";
			strFlowResistivity_Low = "";
			strPoissionsRatio_Low = "";
			strYoungsModulus_Low = "";
			strLossFactor_Low = "";
			strThermalCharLength_Low = "";
			strViscousCharLength_Low = "";
		}
	}
}
