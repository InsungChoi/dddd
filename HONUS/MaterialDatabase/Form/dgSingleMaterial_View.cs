using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// dgSingleMaterial_View에 대한 요약 설명입니다.
	/// </summary>
	public class dgSingleMaterial_View : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox edtFlowResistivity_High;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtThickness_High;
		private System.Windows.Forms.TextBox edtPoissionsRatio_High;
		private System.Windows.Forms.TextBox edtYoungsModulus_High;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtLossFactor_High;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox edtBulkDensity_High;
		private System.Windows.Forms.TextBox edtThermalCharLength_High;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtStructureFactor_High;
		private System.Windows.Forms.TextBox edtProsity_High;
		private System.Windows.Forms.TextBox edtViscousCharLength_High;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbl_ID;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Button btnDelete;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cboMaterialType;

		public clsParameter clsParameter1;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox edtVendor;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox edtProducing;
		private System.Windows.Forms.TextBox edtRemark;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DateTimePicker dtDate;
		private DataSet MaterialTypeds;

		public dgSingleMaterial_View()
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

		private void cboMaterialType_Bind(string str_ID)
		{
			cboMaterialType.Items.Clear();

			HONUS.MaterialPropertiesEstimation.Component.MPE_DB MPE_DB1 = new HONUS.MaterialPropertiesEstimation.Component.MPE_DB();
			MaterialTypeds = MPE_DB1.GetMaterialType(0);

			for(int i = 0 ; i < MaterialTypeds.Tables[0].Rows.Count ; i++)
			{
				MaterialType MaterialType1 = new MaterialType();
				MaterialType1.Name = MaterialTypeds.Tables[0].Rows[i]["MatType"].ToString();
				MaterialType1.ID = MaterialTypeds.Tables[0].Rows[i]["MID"].ToString();

				cboMaterialType.Items.Add(MaterialType1.Name);

				if(str_ID == MaterialTypeds.Tables[0].Rows[i]["MID"].ToString())
				{
					cboMaterialType.SelectedIndex = i;
				}
			}

			if(str_ID == "")
			{
				cboMaterialType.SelectedIndex = 0;
			}
		}

		public string GetcboMeterialType_ID()
		{
			return MaterialTypeds.Tables[0].Rows[cboMaterialType.SelectedIndex]["MID"].ToString();
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.edtFlowResistivity_High = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.edtThickness_High = new System.Windows.Forms.TextBox();
			this.edtPoissionsRatio_High = new System.Windows.Forms.TextBox();
			this.edtYoungsModulus_High = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.edtLossFactor_High = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.edtBulkDensity_High = new System.Windows.Forms.TextBox();
			this.edtThermalCharLength_High = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.edtStructureFactor_High = new System.Windows.Forms.TextBox();
			this.edtProsity_High = new System.Windows.Forms.TextBox();
			this.edtViscousCharLength_High = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lbl_ID = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnModify = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.edtName = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cboMaterialType = new System.Windows.Forms.ComboBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.label12 = new System.Windows.Forms.Label();
			this.edtVendor = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.edtProducing = new System.Windows.Forms.TextBox();
			this.edtRemark = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 23);
			this.label5.TabIndex = 103;
			this.label5.Text = "Viscous Char. Length";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 48);
			this.label9.Name = "label9";
			this.label9.TabIndex = 107;
			this.label9.Text = "Bulk Density";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtFlowResistivity_High
			// 
			this.edtFlowResistivity_High.Location = new System.Drawing.Point(152, 144);
			this.edtFlowResistivity_High.Name = "edtFlowResistivity_High";
			this.edtFlowResistivity_High.Size = new System.Drawing.Size(72, 21);
			this.edtFlowResistivity_High.TabIndex = 94;
			this.edtFlowResistivity_High.Text = "";
			this.edtFlowResistivity_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 192);
			this.label4.Name = "label4";
			this.label4.TabIndex = 102;
			this.label4.Text = "Prosity";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 168);
			this.label2.Name = "label2";
			this.label2.TabIndex = 100;
			this.label2.Text = "Structure Factor";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtThickness_High
			// 
			this.edtThickness_High.Location = new System.Drawing.Point(152, 24);
			this.edtThickness_High.Name = "edtThickness_High";
			this.edtThickness_High.Size = new System.Drawing.Size(72, 21);
			this.edtThickness_High.TabIndex = 89;
			this.edtThickness_High.Text = "";
			this.edtThickness_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// edtPoissionsRatio_High
			// 
			this.edtPoissionsRatio_High.Location = new System.Drawing.Point(152, 96);
			this.edtPoissionsRatio_High.Name = "edtPoissionsRatio_High";
			this.edtPoissionsRatio_High.Size = new System.Drawing.Size(72, 21);
			this.edtPoissionsRatio_High.TabIndex = 92;
			this.edtPoissionsRatio_High.Text = "";
			this.edtPoissionsRatio_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// edtYoungsModulus_High
			// 
			this.edtYoungsModulus_High.Location = new System.Drawing.Point(152, 72);
			this.edtYoungsModulus_High.Name = "edtYoungsModulus_High";
			this.edtYoungsModulus_High.Size = new System.Drawing.Size(72, 21);
			this.edtYoungsModulus_High.TabIndex = 91;
			this.edtYoungsModulus_High.Text = "";
			this.edtYoungsModulus_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 144);
			this.label1.Name = "label1";
			this.label1.TabIndex = 99;
			this.label1.Text = "Flow Resistivity";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 24);
			this.label11.Name = "label11";
			this.label11.TabIndex = 108;
			this.label11.Text = "Thickness";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 120);
			this.label3.Name = "label3";
			this.label3.TabIndex = 101;
			this.label3.Text = "Loss Factor";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 96);
			this.label7.Name = "label7";
			this.label7.TabIndex = 105;
			this.label7.Text = "Poission’s Ratio";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtLossFactor_High
			// 
			this.edtLossFactor_High.Location = new System.Drawing.Point(152, 120);
			this.edtLossFactor_High.Name = "edtLossFactor_High";
			this.edtLossFactor_High.Size = new System.Drawing.Size(72, 21);
			this.edtLossFactor_High.TabIndex = 93;
			this.edtLossFactor_High.Text = "";
			this.edtLossFactor_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 23);
			this.label8.TabIndex = 106;
			this.label8.Text = "Young’s Modulus";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtBulkDensity_High
			// 
			this.edtBulkDensity_High.Location = new System.Drawing.Point(152, 48);
			this.edtBulkDensity_High.Name = "edtBulkDensity_High";
			this.edtBulkDensity_High.Size = new System.Drawing.Size(72, 21);
			this.edtBulkDensity_High.TabIndex = 90;
			this.edtBulkDensity_High.Text = "";
			this.edtBulkDensity_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// edtThermalCharLength_High
			// 
			this.edtThermalCharLength_High.Location = new System.Drawing.Point(152, 240);
			this.edtThermalCharLength_High.Name = "edtThermalCharLength_High";
			this.edtThermalCharLength_High.Size = new System.Drawing.Size(72, 21);
			this.edtThermalCharLength_High.TabIndex = 98;
			this.edtThermalCharLength_High.Text = "";
			this.edtThermalCharLength_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 23);
			this.label6.TabIndex = 104;
			this.label6.Text = "Thermal Char. Length";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtStructureFactor_High
			// 
			this.edtStructureFactor_High.Location = new System.Drawing.Point(152, 168);
			this.edtStructureFactor_High.Name = "edtStructureFactor_High";
			this.edtStructureFactor_High.Size = new System.Drawing.Size(72, 21);
			this.edtStructureFactor_High.TabIndex = 95;
			this.edtStructureFactor_High.Text = "";
			this.edtStructureFactor_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// edtProsity_High
			// 
			this.edtProsity_High.Location = new System.Drawing.Point(152, 192);
			this.edtProsity_High.Name = "edtProsity_High";
			this.edtProsity_High.Size = new System.Drawing.Size(72, 21);
			this.edtProsity_High.TabIndex = 96;
			this.edtProsity_High.Text = "";
			this.edtProsity_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// edtViscousCharLength_High
			// 
			this.edtViscousCharLength_High.Location = new System.Drawing.Point(152, 216);
			this.edtViscousCharLength_High.Name = "edtViscousCharLength_High";
			this.edtViscousCharLength_High.Size = new System.Drawing.Size(72, 21);
			this.edtViscousCharLength_High.TabIndex = 97;
			this.edtViscousCharLength_High.Text = "";
			this.edtViscousCharLength_High.TextChanged += new System.EventHandler(this.AllTextChanged_Event);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.edtFlowResistivity_High);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.edtThickness_High);
			this.groupBox1.Controls.Add(this.edtPoissionsRatio_High);
			this.groupBox1.Controls.Add(this.edtYoungsModulus_High);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.edtLossFactor_High);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.edtBulkDensity_High);
			this.groupBox1.Controls.Add(this.edtThermalCharLength_High);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.edtStructureFactor_High);
			this.groupBox1.Controls.Add(this.edtProsity_High);
			this.groupBox1.Controls.Add(this.edtViscousCharLength_High);
			this.groupBox1.Location = new System.Drawing.Point(8, 192);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 270);
			this.groupBox1.TabIndex = 109;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Parameter";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 23);
			this.label10.TabIndex = 110;
			this.label10.Text = "Name : ";
			// 
			// lbl_ID
			// 
			this.lbl_ID.Location = new System.Drawing.Point(232, 8);
			this.lbl_ID.Name = "lbl_ID";
			this.lbl_ID.TabIndex = 112;
			this.lbl_ID.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(72, 552);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 113;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnModify
			// 
			this.btnModify.Location = new System.Drawing.Point(152, 552);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(40, 23);
			this.btnModify.TabIndex = 114;
			this.btnModify.Text = "수정";
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(200, 552);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(40, 23);
			this.btnDelete.TabIndex = 115;
			this.btnDelete.Text = "삭제";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(57, 4);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(183, 21);
			this.edtName.TabIndex = 116;
			this.edtName.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cboMaterialType);
			this.groupBox3.Location = new System.Drawing.Point(8, 40);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(232, 56);
			this.groupBox3.TabIndex = 117;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Material Type";
			// 
			// cboMaterialType
			// 
			this.cboMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaterialType.Location = new System.Drawing.Point(8, 24);
			this.cboMaterialType.Name = "cboMaterialType";
			this.cboMaterialType.Size = new System.Drawing.Size(216, 20);
			this.cboMaterialType.TabIndex = 0;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(200, 552);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(40, 23);
			this.btnCreate.TabIndex = 118;
			this.btnCreate.Text = "생성";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// dtDate
			// 
			this.dtDate.Location = new System.Drawing.Point(56, 104);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(184, 21);
			this.dtDate.TabIndex = 119;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 107);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 23);
			this.label12.TabIndex = 120;
			this.label12.Text = "Date :";
			// 
			// edtVendor
			// 
			this.edtVendor.Location = new System.Drawing.Point(88, 133);
			this.edtVendor.Name = "edtVendor";
			this.edtVendor.Size = new System.Drawing.Size(144, 21);
			this.edtVendor.TabIndex = 122;
			this.edtVendor.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 136);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 23);
			this.label13.TabIndex = 121;
			this.label13.Text = "Vendor : ";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 160);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 23);
			this.label14.TabIndex = 123;
			this.label14.Text = "Producing :";
			// 
			// edtProducing
			// 
			this.edtProducing.Location = new System.Drawing.Point(88, 160);
			this.edtProducing.Name = "edtProducing";
			this.edtProducing.Size = new System.Drawing.Size(144, 21);
			this.edtProducing.TabIndex = 124;
			this.edtProducing.Text = "";
			// 
			// edtRemark
			// 
			this.edtRemark.Location = new System.Drawing.Point(88, 472);
			this.edtRemark.Multiline = true;
			this.edtRemark.Name = "edtRemark";
			this.edtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.edtRemark.Size = new System.Drawing.Size(144, 72);
			this.edtRemark.TabIndex = 126;
			this.edtRemark.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(8, 472);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 23);
			this.label15.TabIndex = 125;
			this.label15.Text = "Remark :";
			// 
			// dgSingleMaterial_View
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(250, 586);
			this.Controls.Add(this.edtRemark);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.edtProducing);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.edtVendor);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dtDate);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnModify);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.lbl_ID);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dgSingleMaterial_View";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SingleMaterial View";
			this.Load += new System.EventHandler(this.dgSingleMaterial_View_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
		}

		private void dgSingleMaterial_View_Load(object sender, System.EventArgs e)
		{
			cboMaterialType_Bind(clsParameter1.strM_ID);

			lbl_ID.Text = clsParameter1.str_ID;
			edtName.Text = clsParameter1.strName;

			edtFlowResistivity_High.Text = clsParameter1.strFlowResistivity;
			edtThickness_High.Text = clsParameter1.strThickness;
			edtPoissionsRatio_High.Text = clsParameter1.strPoissionsRatio;
			edtYoungsModulus_High.Text = clsParameter1.strYoungsModulus;
			edtLossFactor_High.Text = clsParameter1.strLossFactor;
			edtBulkDensity_High.Text = clsParameter1.strBulkDensity;
			edtThermalCharLength_High.Text = clsParameter1.strThermalCharLength;
			edtStructureFactor_High.Text = clsParameter1.strStructureFactor;
			edtProsity_High.Text = clsParameter1.strProsity;
			edtViscousCharLength_High.Text = clsParameter1.strViscousCharLength;
			edtVendor.Text = clsParameter1.strVendor;
			edtProducing.Text = clsParameter1.strProducing;

			dgPassWord dgPassWord1 = new dgPassWord();
			if(dgPassWord1.ShowDialog() == DialogResult.OK)
			{
				edtRemark.Text = clsParameter1.strRemark;
			}
			else
			{
				edtRemark.Text = "권한이 없습니다";
			}
			if(clsParameter1.strDate != "" && clsParameter1.strDate != null)
			{
				dtDate.Value = DateTime.Parse(clsParameter1.strDate);
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("정말로 삭제 하시겠습니까?","삭제",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				HONUS.MaterialDatabase.Component.MD_DB MD_DB1 = new HONUS.MaterialDatabase.Component.MD_DB();

				MD_DB1.DeleteSingleMaterial(lbl_ID.Text);

				MessageBox.Show("삭제 되었습니다");
				this.Close();
			}
		}

		private void btnModify_Click(object sender, System.EventArgs e)
		{
			HONUS.MaterialDatabase.Component.MD_DB MD_DB1 = new HONUS.MaterialDatabase.Component.MD_DB();

			//MD_DB
			MD_DB1.ModifySingleMaterial(lbl_ID.Text,edtThickness_High.Text,edtBulkDensity_High.Text,edtFlowResistivity_High.Text,edtStructureFactor_High.Text,
				edtProsity_High.Text,edtViscousCharLength_High.Text,edtThermalCharLength_High.Text,edtYoungsModulus_High.Text,edtPoissionsRatio_High.Text,
				edtLossFactor_High.Text,GetcboMeterialType_ID(),edtVendor.Text,edtProducing.Text,edtRemark.Text,dtDate.Value.ToString());

			clsParameter1.strFlowResistivity = edtFlowResistivity_High.Text;
			clsParameter1.strThickness = edtThickness_High.Text;
			clsParameter1.strPoissionsRatio = edtPoissionsRatio_High.Text;
			clsParameter1.strYoungsModulus = edtYoungsModulus_High.Text;
			clsParameter1.strLossFactor = edtLossFactor_High.Text;
			clsParameter1.strBulkDensity = edtBulkDensity_High.Text;
			clsParameter1.strThermalCharLength = edtThermalCharLength_High.Text;
			clsParameter1.strStructureFactor = edtStructureFactor_High.Text;
			clsParameter1.strProsity = edtProsity_High.Text;
			clsParameter1.strViscousCharLength = edtViscousCharLength_High.Text;
			clsParameter1.strM_ID = GetcboMeterialType_ID();

			MessageBox.Show("수정 되었습니다");

			this.Close();
		}

		public void IsCreate(bool bIsCreate)
		{
			if(bIsCreate == true)
			{
				edtName.Enabled = true;

				btnModify.Visible = false;
				btnDelete.Visible = false;

				btnCreate.Visible = true;
			}
			else
			{
				edtName.Enabled = false;

				btnModify.Visible = true;
				btnDelete.Visible = true;

				btnCreate.Visible = false;
			}
		}

		private void btnCreate_Click(object sender, System.EventArgs e)
		{
			HONUS.MaterialDatabase.Component.MD_DB MD_DB1 = new HONUS.MaterialDatabase.Component.MD_DB();

			if(edtName.Text != "")
			{
				if(MD_DB1.ISNameSame(edtName.Text) == 0)
				{
					int dSID = MD_DB1.GetMax_ID_SingleMeterial();
					MD_DB1.CreateSingleMeterial(dSID,edtName.Text,GetcboMeterialType_ID(),edtThickness_High.Text,edtBulkDensity_High.Text,edtFlowResistivity_High.Text,
						edtStructureFactor_High.Text,edtProsity_High.Text,edtViscousCharLength_High.Text,edtThermalCharLength_High.Text,edtYoungsModulus_High.Text,
						edtPoissionsRatio_High.Text,edtLossFactor_High.Text,"","","","","","","","",edtVendor.Text,edtProducing.Text,edtRemark.Text,dtDate.Value.ToString());
				
					clsParameter1.str_ID = dSID.ToString();
					clsParameter1.strName = edtName.Text;
					clsParameter1.strFlowResistivity = strEmptyCheck(edtFlowResistivity_High.Text);
					clsParameter1.strThickness = strEmptyCheck(edtThickness_High.Text);
					clsParameter1.strPoissionsRatio = strEmptyCheck(edtPoissionsRatio_High.Text);
					clsParameter1.strYoungsModulus = strEmptyCheck(edtYoungsModulus_High.Text);
					clsParameter1.strLossFactor = strEmptyCheck(edtLossFactor_High.Text);
					clsParameter1.strBulkDensity = strEmptyCheck(edtBulkDensity_High.Text);
					clsParameter1.strThermalCharLength = strEmptyCheck(edtThermalCharLength_High.Text);
					clsParameter1.strStructureFactor = strEmptyCheck(edtStructureFactor_High.Text);
					clsParameter1.strProsity = strEmptyCheck(edtProsity_High.Text);
					clsParameter1.strViscousCharLength = strEmptyCheck(edtViscousCharLength_High.Text);
					clsParameter1.strM_ID = GetcboMeterialType_ID();
					clsParameter1.strVendor = edtVendor.Text;
					clsParameter1.strProducing = edtProducing.Text;
					clsParameter1.strRemark = edtRemark.Text;
					clsParameter1.strDate = dtDate.Value.ToString();

					MessageBox.Show("생성 되었습니다");

					this.Close();
				}
				else
				{
					int dSID = MD_DB1.GetMax_ID_SingleMeterial();
					MD_DB1.CreateSingleMeterial(dSID,edtName.Text,GetcboMeterialType_ID(),edtThickness_High.Text,edtBulkDensity_High.Text,edtFlowResistivity_High.Text,
						edtStructureFactor_High.Text,edtProsity_High.Text,edtViscousCharLength_High.Text,edtThermalCharLength_High.Text,edtYoungsModulus_High.Text,
						edtPoissionsRatio_High.Text,edtLossFactor_High.Text,"","","","","","","","",edtVendor.Text,edtProducing.Text,edtRemark.Text,dtDate.Value.ToString());
				
					clsParameter1.str_ID = dSID.ToString();
					clsParameter1.strName = edtName.Text;
					clsParameter1.strFlowResistivity = strEmptyCheck(edtFlowResistivity_High.Text);
					clsParameter1.strThickness = strEmptyCheck(edtThickness_High.Text);
					clsParameter1.strPoissionsRatio = strEmptyCheck(edtPoissionsRatio_High.Text);
					clsParameter1.strYoungsModulus = strEmptyCheck(edtYoungsModulus_High.Text);
					clsParameter1.strLossFactor = strEmptyCheck(edtLossFactor_High.Text);
					clsParameter1.strBulkDensity = strEmptyCheck(edtBulkDensity_High.Text);
					clsParameter1.strThermalCharLength = strEmptyCheck(edtThermalCharLength_High.Text);
					clsParameter1.strStructureFactor = strEmptyCheck(edtStructureFactor_High.Text);
					clsParameter1.strProsity = strEmptyCheck(edtProsity_High.Text);
					clsParameter1.strViscousCharLength = strEmptyCheck(edtViscousCharLength_High.Text);
					clsParameter1.strM_ID = GetcboMeterialType_ID();
					clsParameter1.strVendor = edtVendor.Text;
					clsParameter1.strProducing = edtProducing.Text;
					clsParameter1.strRemark = edtRemark.Text;
					clsParameter1.strDate = dtDate.Value.ToString();

					MessageBox.Show("이미 같은 이름이 존재합니다.");
				}
			}
			else
			{
				MessageBox.Show("이름을 입력하여 주십시오.");
			}
		}

		public string strEmptyCheck(string str)
		{
			if(str == null || str == "")
			{
				return "0";
			}
			else
			{
				return str;
			}
		}
	}

	public class clsParameter
	{
		public string str_ID;
		public string strName;

		public string strM_ID;
		public string strFlowResistivity;
		public string strThickness;
		public string strPoissionsRatio;
		public string strYoungsModulus;
		public string strLossFactor;
		public string strBulkDensity;
		public string strThermalCharLength;
		public string strStructureFactor;
		public string strProsity;
		public string strViscousCharLength;
		public string strVendor;
		public string strProducing;
		public string strRemark;
		public string strDate;

		public clsParameter()
		{
			str_ID = "";
			strName = "";

			strM_ID = "";
			strFlowResistivity = "";
			strThickness = "";
			strPoissionsRatio = "";
			strYoungsModulus = "";
			strLossFactor = "";
			strBulkDensity = "";
			strThermalCharLength = "";
			strStructureFactor = "";
			strProsity = "";
			strViscousCharLength = "";
			strVendor = "";
			strProducing = "";
			strRemark = "";
			strDate = "";
		}
	}
}
