using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS
{
	/// <summary>
	/// HONUS_Main에 대한 요약 설명입니다.
	/// </summary>
	/// 
	public delegate void MySelectedChange(string strSelectedName);

	public class HONUS_Main : System.Windows.Forms.Form
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//public string strSelectedItem;
		public MainPopup frmMainPopup;
		
		HONUS.MaterialPropertiesEstimation.Form.frmMPE_Main frmMPE;
		HONUS.MaterialPerformanceAnalysis.Form.frmMPA_Main frmMPA;
		HONUS.SensitivityAnalysis.Form.frmSA_Main frmSA;
		HONUS.MaterialDatabase.Form.frmMD_Main frmMD;

		public HONUS_Main(string strSelectedItem)
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			switch(strSelectedItem)
			{
				case "MPE" :
					MPE_Init(strSelectedItem);
					break;
				case "MPA" :
					MPA_Init(strSelectedItem);
					break;
				case "SA" :
					SA_Init(strSelectedItem);
					break;
				case "MD" :
					MD_Init(strSelectedItem);
					break;
			}

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

		private void MPE_Init(string strSelectedItem)
		{
			frmMPE = new HONUS.MaterialPropertiesEstimation.Form.frmMPE_Main();
			frmMPE.MdiParent = this;
			frmMPE.Show();
		}

		private void MPA_Init(string strSelectedItem)
		{
			frmMPA = new HONUS.MaterialPerformanceAnalysis.Form.frmMPA_Main();
			frmMPA.MdiParent = this;
			frmMPA.Show();
		}

		private void SA_Init(string strSelectedItem)
		{
			frmSA = new HONUS.SensitivityAnalysis.Form.frmSA_Main();
			frmSA.MdiParent = this;
			frmSA.Show();
		}

		private void MD_Init(string strSelectedItem)
		{
			frmMD = new HONUS.MaterialDatabase.Form.frmMD_Main();
			frmMD.MdiParent = this;
			frmMD.Show();
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HONUS_Main));
            this.SuspendLayout();
            // 
            // HONUS_Main
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "HONUS_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HONUS 2.0";
            this.Closed += new System.EventHandler(this.HONUS_Main_Closed);
            this.Load += new System.EventHandler(this.HONUS_Main_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void HONUS_Main_Load(object sender, System.EventArgs e)
		{
		}

		private void HONUS_Main_Closed(object sender, System.EventArgs e)
		{
			frmMainPopup.Close();
		}
	}
}
