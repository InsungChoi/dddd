using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// dgSelected에 대한 요약 설명입니다.
	/// </summary>
	public class dgSelected : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnGO;
		private System.Windows.Forms.RadioButton rdoAddition;
		private System.Windows.Forms.RadioButton rdoSearch;

		public string strSelected;

		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public dgSelected()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();
			strSelected = "";

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
			this.rdoAddition = new System.Windows.Forms.RadioButton();
			this.rdoSearch = new System.Windows.Forms.RadioButton();
			this.btnGO = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rdoAddition
			// 
			this.rdoAddition.Checked = true;
			this.rdoAddition.Location = new System.Drawing.Point(8, 16);
			this.rdoAddition.Name = "rdoAddition";
			this.rdoAddition.Size = new System.Drawing.Size(208, 24);
			this.rdoAddition.TabIndex = 0;
			this.rdoAddition.TabStop = true;
			this.rdoAddition.Text = "Addition Material to database";
			// 
			// rdoSearch
			// 
			this.rdoSearch.Location = new System.Drawing.Point(8, 40);
			this.rdoSearch.Name = "rdoSearch";
			this.rdoSearch.Size = new System.Drawing.Size(192, 24);
			this.rdoSearch.TabIndex = 1;
			this.rdoSearch.Text = "Search material database";
			// 
			// btnGO
			// 
			this.btnGO.BackColor = System.Drawing.SystemColors.Control;
			this.btnGO.Location = new System.Drawing.Point(8, 72);
			this.btnGO.Name = "btnGO";
			this.btnGO.Size = new System.Drawing.Size(192, 23);
			this.btnGO.TabIndex = 2;
			this.btnGO.Text = "GO";
			this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
			// 
			// dgSelected
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(224, 109);
			this.Controls.Add(this.btnGO);
			this.Controls.Add(this.rdoSearch);
			this.Controls.Add(this.rdoAddition);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dgSelected";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "dgSelected";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnGO_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			strSelected = GetSelected();

			this.Close();
		}

		private string GetSelected()
		{
			string strResult = "";

			if(rdoAddition.Checked == true)
			{
				strResult = "Addition";
			}
			else
			{
				strResult = "Search";
			}

			return strResult;
		}
	}
}
