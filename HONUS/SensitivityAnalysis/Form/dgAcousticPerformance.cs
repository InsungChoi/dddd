using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.SensitivityAnalysis.Form
{
	/// <summary>
	/// dgAcousticPerformance에 대한 요약 설명입니다.
	/// </summary>
	public class dgAcousticPerformance : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.RadioButton rdoTransmissionLoss;
		private System.Windows.Forms.RadioButton rdoAbsorptionCoefficientRigidBacking;
		private System.Windows.Forms.RadioButton rdoAbsorptionCoefficientAnechoicTermination;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public dgAcousticPerformance()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(dgAcousticPerformance));
			this.rdoTransmissionLoss = new System.Windows.Forms.RadioButton();
			this.rdoAbsorptionCoefficientRigidBacking = new System.Windows.Forms.RadioButton();
			this.rdoAbsorptionCoefficientAnechoicTermination = new System.Windows.Forms.RadioButton();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rdoTransmissionLoss
			// 
			this.rdoTransmissionLoss.Checked = true;
			this.rdoTransmissionLoss.Location = new System.Drawing.Point(8, 8);
			this.rdoTransmissionLoss.Name = "rdoTransmissionLoss";
			this.rdoTransmissionLoss.Size = new System.Drawing.Size(136, 24);
			this.rdoTransmissionLoss.TabIndex = 0;
			this.rdoTransmissionLoss.TabStop = true;
			this.rdoTransmissionLoss.Text = "Transmission Loss";
			// 
			// rdoAbsorptionCoefficientRigidBacking
			// 
			this.rdoAbsorptionCoefficientRigidBacking.Location = new System.Drawing.Point(8, 32);
			this.rdoAbsorptionCoefficientRigidBacking.Name = "rdoAbsorptionCoefficientRigidBacking";
			this.rdoAbsorptionCoefficientRigidBacking.Size = new System.Drawing.Size(264, 24);
			this.rdoAbsorptionCoefficientRigidBacking.TabIndex = 1;
			this.rdoAbsorptionCoefficientRigidBacking.Text = "Absorption coefficient for rigid backing";
			// 
			// rdoAbsorptionCoefficientAnechoicTermination
			// 
			this.rdoAbsorptionCoefficientAnechoicTermination.Location = new System.Drawing.Point(8, 56);
			this.rdoAbsorptionCoefficientAnechoicTermination.Name = "rdoAbsorptionCoefficientAnechoicTermination";
			this.rdoAbsorptionCoefficientAnechoicTermination.Size = new System.Drawing.Size(296, 24);
			this.rdoAbsorptionCoefficientAnechoicTermination.TabIndex = 2;
			this.rdoAbsorptionCoefficientAnechoicTermination.Text = "Absorption coefficient for anechoic termination";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(232, 88);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// dgAcousticPerformance
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(314, 114);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.rdoAbsorptionCoefficientAnechoicTermination);
			this.Controls.Add(this.rdoAbsorptionCoefficientRigidBacking);
			this.Controls.Add(this.rdoTransmissionLoss);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "dgAcousticPerformance";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acoustic Performance";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;

			this.Close();
		}

		public string GetSelectedPerformance()
		{
			string strResult = "";

			if(rdoTransmissionLoss.Checked)
			{
				strResult = rdoTransmissionLoss.Text;
			}
			else if(rdoAbsorptionCoefficientRigidBacking.Checked)
			{
				strResult = rdoAbsorptionCoefficientRigidBacking.Text;
			}
			else if(rdoAbsorptionCoefficientAnechoicTermination.Checked)
			{
				strResult = rdoAbsorptionCoefficientAnechoicTermination.Text;
			}

			return strResult;
		}

		public int GetSelectedPerformance_int()
		{
			int strResult = 0;

			if(rdoTransmissionLoss.Checked)
			{
				strResult = 1;
			}
			else if(rdoAbsorptionCoefficientRigidBacking.Checked)
			{
				strResult = 2;
			}
			else if(rdoAbsorptionCoefficientAnechoicTermination.Checked)
			{
				strResult = 3;
			}

			return strResult;
		}
	}
}
