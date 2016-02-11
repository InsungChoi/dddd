using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// AbsorptionCoefficient_Find에 대한 요약 설명입니다.
	/// </summary>
	public class AbsorptionCoefficient_Find : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox edt2000;
		private System.Windows.Forms.TextBox edt4000;
		private System.Windows.Forms.TextBox edt1000;
		private System.Windows.Forms.TextBox edt500;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCANCEL;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.GroupBox gbAll;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox edtAlpha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edt8000;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edt10000;

		public clsAbsorptionCoefficient_Find clsAbsorptionCoefficient_Find1;

		public AbsorptionCoefficient_Find()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.edt2000 = new System.Windows.Forms.TextBox();
			this.edt4000 = new System.Windows.Forms.TextBox();
			this.edt1000 = new System.Windows.Forms.TextBox();
			this.edt500 = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.edtName = new System.Windows.Forms.TextBox();
			this.gbAll = new System.Windows.Forms.GroupBox();
			this.edtAlpha = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.edt8000 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.edt10000 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.gbAll.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Frequency";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(104, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Level";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "500";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 23);
			this.label10.TabIndex = 10;
			this.label10.Text = "2000";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 120);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 23);
			this.label11.TabIndex = 11;
			this.label11.Text = "4000";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 72);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(40, 23);
			this.label21.TabIndex = 21;
			this.label21.Text = "1000";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label14.Location = new System.Drawing.Point(56, 48);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(24, 24);
			this.label14.TabIndex = 26;
			this.label14.Text = ">";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label15.Location = new System.Drawing.Point(56, 72);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(24, 24);
			this.label15.TabIndex = 27;
			this.label15.Text = ">";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label16.Location = new System.Drawing.Point(56, 96);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(24, 24);
			this.label16.TabIndex = 28;
			this.label16.Text = ">";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label17.Location = new System.Drawing.Point(56, 120);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(24, 24);
			this.label17.TabIndex = 29;
			this.label17.Text = ">";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt2000
			// 
			this.edt2000.Location = new System.Drawing.Point(96, 96);
			this.edt2000.Name = "edt2000";
			this.edt2000.Size = new System.Drawing.Size(64, 21);
			this.edt2000.TabIndex = 8;
			this.edt2000.Text = "";
			this.edt2000.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edt4000
			// 
			this.edt4000.Location = new System.Drawing.Point(96, 120);
			this.edt4000.Name = "edt4000";
			this.edt4000.Size = new System.Drawing.Size(64, 21);
			this.edt4000.TabIndex = 9;
			this.edt4000.Text = "";
			this.edt4000.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edt1000
			// 
			this.edt1000.Location = new System.Drawing.Point(96, 72);
			this.edt1000.Name = "edt1000";
			this.edt1000.Size = new System.Drawing.Size(64, 21);
			this.edt1000.TabIndex = 7;
			this.edt1000.Text = "";
			this.edt1000.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// edt500
			// 
			this.edt500.Location = new System.Drawing.Point(96, 48);
			this.edt500.Name = "edt500";
			this.edt500.Size = new System.Drawing.Size(64, 21);
			this.edt500.TabIndex = 6;
			this.edt500.Text = "";
			this.edt500.TextChanged += new System.EventHandler(this.DoubleCheck);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(40, 288);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(48, 23);
			this.btnOK.TabIndex = 39;
			this.btnOK.Text = "Ok";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCANCEL
			// 
			this.btnCANCEL.Location = new System.Drawing.Point(96, 288);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.TabIndex = 40;
			this.btnCANCEL.Text = "Cancel";
			this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.edt10000);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.edt8000);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.edt1000);
			this.groupBox1.Controls.Add(this.edt500);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.edt2000);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.edt4000);
			this.groupBox1.Location = new System.Drawing.Point(8, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 200);
			this.groupBox1.TabIndex = 41;
			this.groupBox1.TabStop = false;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 8);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(48, 23);
			this.label19.TabIndex = 42;
			this.label19.Text = "Name : ";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(56, 5);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(120, 21);
			this.edtName.TabIndex = 0;
			this.edtName.Text = "";
			// 
			// gbAll
			// 
			this.gbAll.Controls.Add(this.edtAlpha);
			this.gbAll.Controls.Add(this.checkBox1);
			this.gbAll.Enabled = false;
			this.gbAll.Location = new System.Drawing.Point(8, 32);
			this.gbAll.Name = "gbAll";
			this.gbAll.Size = new System.Drawing.Size(168, 56);
			this.gbAll.TabIndex = 43;
			this.gbAll.TabStop = false;
			// 
			// edtAlpha
			// 
			this.edtAlpha.Location = new System.Drawing.Point(48, 24);
			this.edtAlpha.Name = "edtAlpha";
			this.edtAlpha.TabIndex = 1;
			this.edtAlpha.Text = "";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(40, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "All";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 31;
			this.label3.Text = "8000";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label4.Location = new System.Drawing.Point(56, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 24);
			this.label4.TabIndex = 32;
			this.label4.Text = ">";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt8000
			// 
			this.edt8000.Location = new System.Drawing.Point(96, 144);
			this.edt8000.Name = "edt8000";
			this.edt8000.Size = new System.Drawing.Size(64, 21);
			this.edt8000.TabIndex = 30;
			this.edt8000.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 34;
			this.label5.Text = "10000";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label7.Location = new System.Drawing.Point(56, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 24);
			this.label7.TabIndex = 35;
			this.label7.Text = ">";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt10000
			// 
			this.edt10000.Location = new System.Drawing.Point(96, 168);
			this.edt10000.Name = "edt10000";
			this.edt10000.Size = new System.Drawing.Size(64, 21);
			this.edt10000.TabIndex = 33;
			this.edt10000.Text = "";
			// 
			// AbsorptionCoefficient_Find
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(178, 314);
			this.Controls.Add(this.gbAll);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCANCEL);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AbsorptionCoefficient_Find";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "상세 검색창";
			this.Load += new System.EventHandler(this.AbsorptionCoefficient_Find_Load);
			this.groupBox1.ResumeLayout(false);
			this.gbAll.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void AbsorptionCoefficient_Find_Load(object sender, System.EventArgs e)
		{
			if(clsAbsorptionCoefficient_Find1 != null)
			{
				edtName.Text = clsAbsorptionCoefficient_Find1.strName;

				edt1000.Text = clsAbsorptionCoefficient_Find1.str1000;
				//edt125.Text = clsAbsorptionCoefficient_Find1.str125;
				//edt16.Text = clsAbsorptionCoefficient_Find1.str16;
				edt2000.Text = clsAbsorptionCoefficient_Find1.str2000;
				//edt250.Text = clsAbsorptionCoefficient_Find1.str250;
				//edt31_5.Text = clsAbsorptionCoefficient_Find1.str31_5;
				edt4000.Text = clsAbsorptionCoefficient_Find1.str4000;
				edt500.Text = clsAbsorptionCoefficient_Find1.str500;
				//edt63.Text = clsAbsorptionCoefficient_Find1.str63;
				edt8000.Text = clsAbsorptionCoefficient_Find1.str8000;
				edt10000.Text = clsAbsorptionCoefficient_Find1.str10000;

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

		private void btnCANCEL_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;

			clsAbsorptionCoefficient_Find1 = new clsAbsorptionCoefficient_Find();

			clsAbsorptionCoefficient_Find1.strName = edtName.Text;

			clsAbsorptionCoefficient_Find1.strAlpha = edtAlpha.Text;
			//clsAbsorptionCoefficient_Find1.str16 = edt16.Text;
			clsAbsorptionCoefficient_Find1.str2000 = edt2000.Text;
			clsAbsorptionCoefficient_Find1.str4000 = edt4000.Text;
			clsAbsorptionCoefficient_Find1.str1000 = edt1000.Text;
			clsAbsorptionCoefficient_Find1.str500 = edt500.Text;
			//clsAbsorptionCoefficient_Find1.str250 = edt250.Text;
			//clsAbsorptionCoefficient_Find1.str125 = edt125.Text;
			//clsAbsorptionCoefficient_Find1.str63 = edt63.Text;
			//clsAbsorptionCoefficient_Find1.str31_5 = edt31_5.Text;
			clsAbsorptionCoefficient_Find1.str8000 = edt8000.Text;
			clsAbsorptionCoefficient_Find1.str10000 = edt10000.Text;
				
			this.Close();
		}

		public void gbAll_Enable(bool bEnable)
		{
			gbAll.Enabled = bEnable;

			//edt16.Enabled = false;
			edt2000.Enabled = false;
			edt4000.Enabled = false;
			edt1000.Enabled = false;
			edt500.Enabled = false;
//			edt250.Enabled = false;
//			edt125.Enabled = false;
//			edt63.Enabled = false;
//			edt31_5.Enabled = false;
			edt8000.Enabled = false;
			edt10000.Enabled = false;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked == true)
			{
				//edt16.Enabled = false;
				edt2000.Enabled = false;
				edt4000.Enabled = false;
				edt1000.Enabled = false;
				edt500.Enabled = false;
//				edt250.Enabled = false;
//				edt125.Enabled = false;
//				edt63.Enabled = false;
//				edt31_5.Enabled = false;
				edt8000.Enabled = false;
				edt10000.Enabled = false;
			}
			else
			{
				edtAlpha.Text = "";

				//edt16.Enabled = true;
				edt2000.Enabled = true;
				edt4000.Enabled = true;
				edt1000.Enabled = true;
				edt500.Enabled = true;
//				edt250.Enabled = true;
//				edt125.Enabled = true;
//				edt63.Enabled = true;
//				edt31_5.Enabled = true;
				edt8000.Enabled = true;
				edt10000.Enabled = true;
			}
		}
	}

	public class clsAbsorptionCoefficient_Find
	{
		public string strName;

		public string strAlpha;
		//public string str16;
		public string str2000;
		public string str4000;
		public string str1000;
		public string str500;
//		public string str250;
//		public string str125;
//		public string str63;
//		public string str31_5;
		public string str8000;
		public string str10000;

		public clsAbsorptionCoefficient_Find()
		{
			strName = "";

			strAlpha = "";
			//str16 = "";
			str2000 = "";
			str4000 = "";
			str1000 = "";
			str500 = "";
//			str250 = "";
//			str125 = "";
//			str63 = "";
//			str31_5 = "";
			str8000 = "";
			str10000 = "";
		}
	}
}

