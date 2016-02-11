using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.SensitivityAnalysis.Form
{
	/// <summary>
	/// dgMaterial에 대한 요약 설명입니다.
	/// </summary>
	public class dgMaterial : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox edtThickness;
		private System.Windows.Forms.TextBox edtBulkDensity;
		private System.Windows.Forms.TextBox edtStructureFactor;
		private System.Windows.Forms.TextBox edtProsity;
		private System.Windows.Forms.TextBox edtFlowResistivity;
		private System.Windows.Forms.TextBox edtPoissionsRatio;
		private System.Windows.Forms.TextBox edtYoungsModulus;
		private System.Windows.Forms.TextBox edtLossFactor;
		private System.Windows.Forms.TextBox edtShapeFactor;
		private System.Windows.Forms.TextBox edtDimensionFactor;
		private System.Windows.Forms.TextBox edtTemperature;
		private System.Windows.Forms.RadioButton rdoThickness;
		private System.Windows.Forms.RadioButton rdoBulkDensity;
		private System.Windows.Forms.RadioButton rdoFlowResistivity;
		private System.Windows.Forms.RadioButton rdoStructureFactor;
		private System.Windows.Forms.RadioButton rdoProsity;
		private System.Windows.Forms.RadioButton rdoShapefactor;
		private System.Windows.Forms.RadioButton rdoDimensionfactor;
		private System.Windows.Forms.RadioButton rdoYoungsModulus;
		private System.Windows.Forms.RadioButton rdoPoissionsRatio;
		private System.Windows.Forms.RadioButton rdoLossFactor;
		private System.Windows.Forms.RadioButton rdoTemperature;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public dgMaterial()
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(dgMaterial));
			this.edtThickness = new System.Windows.Forms.TextBox();
			this.edtBulkDensity = new System.Windows.Forms.TextBox();
			this.edtStructureFactor = new System.Windows.Forms.TextBox();
			this.edtProsity = new System.Windows.Forms.TextBox();
			this.edtFlowResistivity = new System.Windows.Forms.TextBox();
			this.edtPoissionsRatio = new System.Windows.Forms.TextBox();
			this.edtYoungsModulus = new System.Windows.Forms.TextBox();
			this.edtLossFactor = new System.Windows.Forms.TextBox();
			this.edtShapeFactor = new System.Windows.Forms.TextBox();
			this.edtDimensionFactor = new System.Windows.Forms.TextBox();
			this.edtTemperature = new System.Windows.Forms.TextBox();
			this.rdoThickness = new System.Windows.Forms.RadioButton();
			this.rdoBulkDensity = new System.Windows.Forms.RadioButton();
			this.rdoFlowResistivity = new System.Windows.Forms.RadioButton();
			this.rdoStructureFactor = new System.Windows.Forms.RadioButton();
			this.rdoProsity = new System.Windows.Forms.RadioButton();
			this.rdoShapefactor = new System.Windows.Forms.RadioButton();
			this.rdoDimensionfactor = new System.Windows.Forms.RadioButton();
			this.rdoYoungsModulus = new System.Windows.Forms.RadioButton();
			this.rdoPoissionsRatio = new System.Windows.Forms.RadioButton();
			this.rdoLossFactor = new System.Windows.Forms.RadioButton();
			this.rdoTemperature = new System.Windows.Forms.RadioButton();
			this.btnOK = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// edtThickness
			// 
			this.edtThickness.Location = new System.Drawing.Point(144, 8);
			this.edtThickness.Name = "edtThickness";
			this.edtThickness.Size = new System.Drawing.Size(184, 21);
			this.edtThickness.TabIndex = 43;
			this.edtThickness.Text = "";
			// 
			// edtBulkDensity
			// 
			this.edtBulkDensity.Location = new System.Drawing.Point(144, 36);
			this.edtBulkDensity.Name = "edtBulkDensity";
			this.edtBulkDensity.Size = new System.Drawing.Size(184, 21);
			this.edtBulkDensity.TabIndex = 44;
			this.edtBulkDensity.Text = "";
			// 
			// edtStructureFactor
			// 
			this.edtStructureFactor.Location = new System.Drawing.Point(144, 92);
			this.edtStructureFactor.Name = "edtStructureFactor";
			this.edtStructureFactor.Size = new System.Drawing.Size(184, 21);
			this.edtStructureFactor.TabIndex = 34;
			this.edtStructureFactor.Text = "";
			// 
			// edtProsity
			// 
			this.edtProsity.Location = new System.Drawing.Point(144, 120);
			this.edtProsity.Name = "edtProsity";
			this.edtProsity.Size = new System.Drawing.Size(184, 21);
			this.edtProsity.TabIndex = 33;
			this.edtProsity.Text = "";
			// 
			// edtFlowResistivity
			// 
			this.edtFlowResistivity.Location = new System.Drawing.Point(144, 64);
			this.edtFlowResistivity.Name = "edtFlowResistivity";
			this.edtFlowResistivity.Size = new System.Drawing.Size(184, 21);
			this.edtFlowResistivity.TabIndex = 31;
			this.edtFlowResistivity.Text = "";
			// 
			// edtPoissionsRatio
			// 
			this.edtPoissionsRatio.Location = new System.Drawing.Point(144, 232);
			this.edtPoissionsRatio.Name = "edtPoissionsRatio";
			this.edtPoissionsRatio.Size = new System.Drawing.Size(184, 21);
			this.edtPoissionsRatio.TabIndex = 37;
			this.edtPoissionsRatio.Text = "";
			// 
			// edtYoungsModulus
			// 
			this.edtYoungsModulus.Location = new System.Drawing.Point(144, 204);
			this.edtYoungsModulus.Name = "edtYoungsModulus";
			this.edtYoungsModulus.Size = new System.Drawing.Size(184, 21);
			this.edtYoungsModulus.TabIndex = 36;
			this.edtYoungsModulus.Text = "";
			// 
			// edtLossFactor
			// 
			this.edtLossFactor.Location = new System.Drawing.Point(144, 260);
			this.edtLossFactor.Name = "edtLossFactor";
			this.edtLossFactor.Size = new System.Drawing.Size(184, 21);
			this.edtLossFactor.TabIndex = 38;
			this.edtLossFactor.Text = "";
			// 
			// edtShapeFactor
			// 
			this.edtShapeFactor.Location = new System.Drawing.Point(144, 148);
			this.edtShapeFactor.Name = "edtShapeFactor";
			this.edtShapeFactor.Size = new System.Drawing.Size(184, 21);
			this.edtShapeFactor.TabIndex = 46;
			this.edtShapeFactor.Text = "";
			// 
			// edtDimensionFactor
			// 
			this.edtDimensionFactor.Location = new System.Drawing.Point(144, 176);
			this.edtDimensionFactor.Name = "edtDimensionFactor";
			this.edtDimensionFactor.Size = new System.Drawing.Size(184, 21);
			this.edtDimensionFactor.TabIndex = 48;
			this.edtDimensionFactor.Text = "";
			// 
			// edtTemperature
			// 
			this.edtTemperature.Location = new System.Drawing.Point(144, 288);
			this.edtTemperature.Name = "edtTemperature";
			this.edtTemperature.Size = new System.Drawing.Size(184, 21);
			this.edtTemperature.TabIndex = 50;
			this.edtTemperature.Text = "";
			// 
			// rdoThickness
			// 
			this.rdoThickness.Checked = true;
			this.rdoThickness.Location = new System.Drawing.Point(8, 8);
			this.rdoThickness.Name = "rdoThickness";
			this.rdoThickness.TabIndex = 51;
			this.rdoThickness.TabStop = true;
			this.rdoThickness.Text = "Thickness";
			this.rdoThickness.CheckedChanged += new System.EventHandler(this.rdoThickness_CheckedChanged);
			// 
			// rdoBulkDensity
			// 
			this.rdoBulkDensity.Location = new System.Drawing.Point(8, 36);
			this.rdoBulkDensity.Name = "rdoBulkDensity";
			this.rdoBulkDensity.TabIndex = 52;
			this.rdoBulkDensity.Text = "Bulk Density";
			this.rdoBulkDensity.CheckedChanged += new System.EventHandler(this.rdoBulkDensity_CheckedChanged);
			// 
			// rdoFlowResistivity
			// 
			this.rdoFlowResistivity.Location = new System.Drawing.Point(8, 64);
			this.rdoFlowResistivity.Name = "rdoFlowResistivity";
			this.rdoFlowResistivity.Size = new System.Drawing.Size(120, 24);
			this.rdoFlowResistivity.TabIndex = 53;
			this.rdoFlowResistivity.Text = "Flow Resistivity";
			this.rdoFlowResistivity.CheckedChanged += new System.EventHandler(this.rdoFlowResistivity_CheckedChanged);
			// 
			// rdoStructureFactor
			// 
			this.rdoStructureFactor.Location = new System.Drawing.Point(8, 92);
			this.rdoStructureFactor.Name = "rdoStructureFactor";
			this.rdoStructureFactor.Size = new System.Drawing.Size(128, 24);
			this.rdoStructureFactor.TabIndex = 54;
			this.rdoStructureFactor.Text = "Structure Factor";
			this.rdoStructureFactor.CheckedChanged += new System.EventHandler(this.rdoStructureFactor_CheckedChanged);
			// 
			// rdoProsity
			// 
			this.rdoProsity.Location = new System.Drawing.Point(8, 120);
			this.rdoProsity.Name = "rdoProsity";
			this.rdoProsity.TabIndex = 55;
			this.rdoProsity.Text = "Prosity";
			this.rdoProsity.CheckedChanged += new System.EventHandler(this.rdoProsity_CheckedChanged);
			// 
			// rdoShapefactor
			// 
			this.rdoShapefactor.Location = new System.Drawing.Point(8, 148);
			this.rdoShapefactor.Name = "rdoShapefactor";
			this.rdoShapefactor.TabIndex = 56;
			this.rdoShapefactor.Text = "Shape factor";
			this.rdoShapefactor.CheckedChanged += new System.EventHandler(this.rdoShapefactor_CheckedChanged);
			// 
			// rdoDimensionfactor
			// 
			this.rdoDimensionfactor.Location = new System.Drawing.Point(8, 176);
			this.rdoDimensionfactor.Name = "rdoDimensionfactor";
			this.rdoDimensionfactor.Size = new System.Drawing.Size(128, 24);
			this.rdoDimensionfactor.TabIndex = 57;
			this.rdoDimensionfactor.Text = "Dimension factor";
			this.rdoDimensionfactor.CheckedChanged += new System.EventHandler(this.rdoDimensionfactor_CheckedChanged);
			// 
			// rdoYoungsModulus
			// 
			this.rdoYoungsModulus.Location = new System.Drawing.Point(8, 204);
			this.rdoYoungsModulus.Name = "rdoYoungsModulus";
			this.rdoYoungsModulus.Size = new System.Drawing.Size(128, 24);
			this.rdoYoungsModulus.TabIndex = 58;
			this.rdoYoungsModulus.Text = "Young’s Modulus";
			this.rdoYoungsModulus.CheckedChanged += new System.EventHandler(this.rdoYoungsModulus_CheckedChanged);
			// 
			// rdoPoissionsRatio
			// 
			this.rdoPoissionsRatio.Location = new System.Drawing.Point(8, 232);
			this.rdoPoissionsRatio.Name = "rdoPoissionsRatio";
			this.rdoPoissionsRatio.Size = new System.Drawing.Size(120, 24);
			this.rdoPoissionsRatio.TabIndex = 59;
			this.rdoPoissionsRatio.Text = "Poission’s Ratio";
			this.rdoPoissionsRatio.CheckedChanged += new System.EventHandler(this.rdoPoissionsRatio_CheckedChanged);
			// 
			// rdoLossFactor
			// 
			this.rdoLossFactor.Location = new System.Drawing.Point(8, 260);
			this.rdoLossFactor.Name = "rdoLossFactor";
			this.rdoLossFactor.TabIndex = 60;
			this.rdoLossFactor.Text = "Loss Factor";
			this.rdoLossFactor.CheckedChanged += new System.EventHandler(this.rdoLossFactor_CheckedChanged);
			// 
			// rdoTemperature
			// 
			this.rdoTemperature.Location = new System.Drawing.Point(8, 288);
			this.rdoTemperature.Name = "rdoTemperature";
			this.rdoTemperature.TabIndex = 61;
			this.rdoTemperature.Text = "Temperature";
			this.rdoTemperature.CheckedChanged += new System.EventHandler(this.rdoTemperature_CheckedChanged);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(256, 320);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 62;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 320);
			this.button1.Name = "button1";
			this.button1.TabIndex = 64;
			this.button1.Text = "BD Load";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dgMaterial
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(336, 349);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.rdoTemperature);
			this.Controls.Add(this.rdoLossFactor);
			this.Controls.Add(this.rdoPoissionsRatio);
			this.Controls.Add(this.rdoYoungsModulus);
			this.Controls.Add(this.rdoDimensionfactor);
			this.Controls.Add(this.rdoShapefactor);
			this.Controls.Add(this.rdoProsity);
			this.Controls.Add(this.rdoStructureFactor);
			this.Controls.Add(this.rdoFlowResistivity);
			this.Controls.Add(this.rdoBulkDensity);
			this.Controls.Add(this.rdoThickness);
			this.Controls.Add(this.edtTemperature);
			this.Controls.Add(this.edtDimensionFactor);
			this.Controls.Add(this.edtShapeFactor);
			this.Controls.Add(this.edtThickness);
			this.Controls.Add(this.edtBulkDensity);
			this.Controls.Add(this.edtStructureFactor);
			this.Controls.Add(this.edtProsity);
			this.Controls.Add(this.edtFlowResistivity);
			this.Controls.Add(this.edtPoissionsRatio);
			this.Controls.Add(this.edtYoungsModulus);
			this.Controls.Add(this.edtLossFactor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "dgMaterial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Marerial Load";
			this.Load += new System.EventHandler(this.dgMaterial_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void rdoBulkDensity_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoBulkDensity.Checked)
			{
				RadioButtonChange(edtBulkDensity);
			}
		}

		private void rdoThickness_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoThickness.Checked)
			{
				RadioButtonChange(edtThickness);
			}
		}

		private void rdoFlowResistivity_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoFlowResistivity.Checked)
			{
				RadioButtonChange(edtFlowResistivity);
			}
		}

		private void rdoStructureFactor_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoStructureFactor.Checked)
			{
				RadioButtonChange(edtStructureFactor);
			}
		}

		private void rdoProsity_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoProsity.Checked)
			{
				RadioButtonChange(edtProsity);
			}
		}

		private void rdoShapefactor_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoShapefactor.Checked)
			{
				RadioButtonChange(edtShapeFactor);
			}
		}

		private void rdoDimensionfactor_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoDimensionfactor.Checked)
			{
				RadioButtonChange(edtDimensionFactor);
			}
		}

		private void rdoYoungsModulus_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoYoungsModulus.Checked)
			{
				RadioButtonChange(edtYoungsModulus);
			}
		}

		private void rdoPoissionsRatio_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoPoissionsRatio.Checked)
			{
				RadioButtonChange(edtPoissionsRatio);
			}
		}

		private void rdoLossFactor_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoLossFactor.Checked)
			{
				RadioButtonChange(edtLossFactor);
			}
		}

		private void rdoTemperature_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoTemperature.Checked)
			{
				RadioButtonChange(edtTemperature);
			}
		}

		private void RadioButtonChange(TextBox text)
		{
//			edtThickness.Enabled = false;
//			edtBulkDensity.Enabled = false;
//			edtStructureFactor.Enabled = false;
//			edtProsity.Enabled = false;
//			edtFlowResistivity.Enabled = false;
//			edtPoissionsRatio.Enabled = false;
//			edtYoungsModulus.Enabled = false;
//			edtLossFactor.Enabled = false;
//			edtShapeFactor.Enabled = false;
//			edtDimensionFactor.Enabled = false;
//			edtTemperature.Enabled = false;
//
//			text.Enabled = true;
		}

		private void dgMaterial_Load(object sender, System.EventArgs e)
		{
			RadioButtonChange(edtThickness);
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;

			this.Close();
		}

		public string GetSelectedType()
		{
			string strResultName = "";

			foreach(Control co in this.Controls)
			{
				if(co.GetType().FullName == "System.Windows.Forms.RadioButton")
				{
					if(((RadioButton)co).Checked)
					{
						strResultName = ((RadioButton)co).Text;
					}
				}
			}

			return strResultName;
		}

		public string GetSelectedValue()
		{
			string strResultValue = "";

			foreach(Control co in this.Controls)
			{
				if(co.GetType().FullName == "System.Windows.Forms.TextBox")
				{
					if(((TextBox)co).Enabled)
					{
						strResultValue = ((TextBox)co).Text;
					}
				}
			}

			return strResultValue;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			HONUS.MaterialDatabase.Form.frmMD_Main frmMD = new HONUS.MaterialDatabase.Form.frmMD_Main();
			frmMD.bIsSearchPopup = true;
			frmMD.ClosingFlag = true;

			//frmMD.ucSearchingCondition_SingleMulti_Control(true);

			if(frmMD.ShowDialog() == DialogResult.OK)
			{
				string strSelected_ID = frmMD.strSelectedItem_ID;
				//MessageBox.Show("aaa");
			}
			else
			{
				//MessageBox.Show("bbb");
			}
		}
	}
}
