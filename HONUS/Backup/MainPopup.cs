using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS
{
	/// <summary>
	/// MainPopup에 대한 요약 설명입니다.
	/// </summary>
	public class MainPopup : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RadioButton rdoMPE;
		private System.Windows.Forms.RadioButton rdoMPA;
		private System.Windows.Forms.RadioButton rdoSA;
		private System.Windows.Forms.RadioButton rdoMD;
		private System.Windows.Forms.PictureBox picMPA_On;
		private System.Windows.Forms.PictureBox picSA_Off;
		private System.Windows.Forms.PictureBox picMD_Off;
		private System.Windows.Forms.PictureBox picMPA_Off;
		private System.Windows.Forms.PictureBox picMPE_Off;
		private System.Windows.Forms.PictureBox picMD_On;
		private System.Windows.Forms.PictureBox picSA_On;
		private System.Windows.Forms.PictureBox picMPE_On;
		private System.Windows.Forms.PictureBox picStart;

		public string strSelectedItem;

		HONUS.MaterialPropertiesEstimation.Form.frmMPE_Main frmMPE;
		HONUS.MaterialPerformanceAnalysis.Form.frmMPA_Main frmMPA;
		HONUS.SensitivityAnalysis.Form.frmSA_Main frmSA;
		private System.Windows.Forms.PictureBox pictureBox1;
		HONUS.MaterialDatabase.Form.frmMD_Main frmMD;

		public MainPopup()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
			strSelectedItem = "";
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
			frmMPE.frmMainPopup = this;this.ControlBox = true;
			//frmMPE.MdiParent = this;
			frmMPE.Show();
		}

		private void MPA_Init(string strSelectedItem)
		{
			frmMPA = new HONUS.MaterialPerformanceAnalysis.Form.frmMPA_Main();
			frmMPA.frmMainPopup = this;
			//frmMPA.MdiParent = this;
			frmMPA.Show();
		}

		private void SA_Init(string strSelectedItem)
		{
			frmSA = new HONUS.SensitivityAnalysis.Form.frmSA_Main();
			frmSA.frmMainPopup = this;
			//frmSA.MdiParent = this;
			frmSA.Show();
		}

		private void MD_Init(string strSelectedItem)
		{
			frmMD = new HONUS.MaterialDatabase.Form.frmMD_Main();
			frmMD.frmMainPopup = this;
			//frmMD.MdiParent = this;
			frmMD.Show();
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainPopup));
			this.rdoMPE = new System.Windows.Forms.RadioButton();
			this.rdoMPA = new System.Windows.Forms.RadioButton();
			this.rdoSA = new System.Windows.Forms.RadioButton();
			this.rdoMD = new System.Windows.Forms.RadioButton();
			this.picMPA_On = new System.Windows.Forms.PictureBox();
			this.picSA_Off = new System.Windows.Forms.PictureBox();
			this.picMD_Off = new System.Windows.Forms.PictureBox();
			this.picMPA_Off = new System.Windows.Forms.PictureBox();
			this.picMPE_Off = new System.Windows.Forms.PictureBox();
			this.picMD_On = new System.Windows.Forms.PictureBox();
			this.picSA_On = new System.Windows.Forms.PictureBox();
			this.picMPE_On = new System.Windows.Forms.PictureBox();
			this.picStart = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// rdoMPE
			// 
			this.rdoMPE.BackColor = System.Drawing.Color.Transparent;
			this.rdoMPE.Location = new System.Drawing.Point(24, 88);
			this.rdoMPE.Name = "rdoMPE";
			this.rdoMPE.Size = new System.Drawing.Size(16, 24);
			this.rdoMPE.TabIndex = 0;
			this.rdoMPE.CheckedChanged += new System.EventHandler(this.rdoMPE_CheckedChanged);
			// 
			// rdoMPA
			// 
			this.rdoMPA.BackColor = System.Drawing.Color.Transparent;
			this.rdoMPA.Location = new System.Drawing.Point(24, 128);
			this.rdoMPA.Name = "rdoMPA";
			this.rdoMPA.Size = new System.Drawing.Size(16, 24);
			this.rdoMPA.TabIndex = 1;
			this.rdoMPA.CheckedChanged += new System.EventHandler(this.rdoMPA_CheckedChanged);
			// 
			// rdoSA
			// 
			this.rdoSA.BackColor = System.Drawing.Color.Transparent;
			this.rdoSA.Location = new System.Drawing.Point(24, 176);
			this.rdoSA.Name = "rdoSA";
			this.rdoSA.Size = new System.Drawing.Size(16, 24);
			this.rdoSA.TabIndex = 2;
			this.rdoSA.CheckedChanged += new System.EventHandler(this.rdoSA_CheckedChanged);
			// 
			// rdoMD
			// 
			this.rdoMD.BackColor = System.Drawing.Color.Transparent;
			this.rdoMD.Location = new System.Drawing.Point(24, 216);
			this.rdoMD.Name = "rdoMD";
			this.rdoMD.Size = new System.Drawing.Size(16, 24);
			this.rdoMD.TabIndex = 3;
			this.rdoMD.CheckedChanged += new System.EventHandler(this.rdoMD_CheckedChanged);
			// 
			// picMPA_On
			// 
			this.picMPA_On.Image = ((System.Drawing.Image)(resources.GetObject("picMPA_On.Image")));
			this.picMPA_On.Location = new System.Drawing.Point(48, 128);
			this.picMPA_On.Name = "picMPA_On";
			this.picMPA_On.Size = new System.Drawing.Size(199, 25);
			this.picMPA_On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMPA_On.TabIndex = 4;
			this.picMPA_On.TabStop = false;
			// 
			// picSA_Off
			// 
			this.picSA_Off.Image = ((System.Drawing.Image)(resources.GetObject("picSA_Off.Image")));
			this.picSA_Off.Location = new System.Drawing.Point(48, 175);
			this.picSA_Off.Name = "picSA_Off";
			this.picSA_Off.Size = new System.Drawing.Size(126, 25);
			this.picSA_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picSA_Off.TabIndex = 5;
			this.picSA_Off.TabStop = false;
			this.picSA_Off.Click += new System.EventHandler(this.picSA_Off_Click);
			// 
			// picMD_Off
			// 
			this.picMD_Off.Image = ((System.Drawing.Image)(resources.GetObject("picMD_Off.Image")));
			this.picMD_Off.Location = new System.Drawing.Point(48, 216);
			this.picMD_Off.Name = "picMD_Off";
			this.picMD_Off.Size = new System.Drawing.Size(126, 25);
			this.picMD_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMD_Off.TabIndex = 6;
			this.picMD_Off.TabStop = false;
			this.picMD_Off.Click += new System.EventHandler(this.picMD_Off_Click);
			// 
			// picMPA_Off
			// 
			this.picMPA_Off.Image = ((System.Drawing.Image)(resources.GetObject("picMPA_Off.Image")));
			this.picMPA_Off.Location = new System.Drawing.Point(48, 128);
			this.picMPA_Off.Name = "picMPA_Off";
			this.picMPA_Off.Size = new System.Drawing.Size(199, 25);
			this.picMPA_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMPA_Off.TabIndex = 7;
			this.picMPA_Off.TabStop = false;
			this.picMPA_Off.Click += new System.EventHandler(this.picMPA_Off_Click);
			// 
			// picMPE_Off
			// 
			this.picMPE_Off.Image = ((System.Drawing.Image)(resources.GetObject("picMPE_Off.Image")));
			this.picMPE_Off.Location = new System.Drawing.Point(48, 88);
			this.picMPE_Off.Name = "picMPE_Off";
			this.picMPE_Off.Size = new System.Drawing.Size(199, 25);
			this.picMPE_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMPE_Off.TabIndex = 8;
			this.picMPE_Off.TabStop = false;
			this.picMPE_Off.Click += new System.EventHandler(this.picMPE_Off_Click);
			// 
			// picMD_On
			// 
			this.picMD_On.Image = ((System.Drawing.Image)(resources.GetObject("picMD_On.Image")));
			this.picMD_On.Location = new System.Drawing.Point(48, 216);
			this.picMD_On.Name = "picMD_On";
			this.picMD_On.Size = new System.Drawing.Size(126, 25);
			this.picMD_On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMD_On.TabIndex = 9;
			this.picMD_On.TabStop = false;
			// 
			// picSA_On
			// 
			this.picSA_On.Image = ((System.Drawing.Image)(resources.GetObject("picSA_On.Image")));
			this.picSA_On.Location = new System.Drawing.Point(48, 176);
			this.picSA_On.Name = "picSA_On";
			this.picSA_On.Size = new System.Drawing.Size(126, 25);
			this.picSA_On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picSA_On.TabIndex = 10;
			this.picSA_On.TabStop = false;
			// 
			// picMPE_On
			// 
			this.picMPE_On.Image = ((System.Drawing.Image)(resources.GetObject("picMPE_On.Image")));
			this.picMPE_On.Location = new System.Drawing.Point(48, 88);
			this.picMPE_On.Name = "picMPE_On";
			this.picMPE_On.Size = new System.Drawing.Size(199, 25);
			this.picMPE_On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMPE_On.TabIndex = 11;
			this.picMPE_On.TabStop = false;
			// 
			// picStart
			// 
			this.picStart.Image = ((System.Drawing.Image)(resources.GetObject("picStart.Image")));
			this.picStart.Location = new System.Drawing.Point(280, 296);
			this.picStart.Name = "picStart";
			this.picStart.Size = new System.Drawing.Size(126, 25);
			this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picStart.TabIndex = 12;
			this.picStart.TabStop = false;
			this.picStart.Click += new System.EventHandler(this.picStart_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 344);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// MainPopup
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(493, 374);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.picStart);
			this.Controls.Add(this.picMPE_On);
			this.Controls.Add(this.picSA_On);
			this.Controls.Add(this.picMD_On);
			this.Controls.Add(this.picMPE_Off);
			this.Controls.Add(this.picMD_Off);
			this.Controls.Add(this.picSA_Off);
			this.Controls.Add(this.picMPA_On);
			this.Controls.Add(this.rdoMD);
			this.Controls.Add(this.rdoSA);
			this.Controls.Add(this.rdoMPA);
			this.Controls.Add(this.rdoMPE);
			this.Controls.Add(this.picMPA_Off);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainPopup";
			this.Load += new System.EventHandler(this.MainPopup_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainPopup());
		}

		private void MainPopup_Load(object sender, System.EventArgs e)
		{
			RadioButtonInit(rdoMPE);
			PictureInit(picMPE_On,picMPE_Off);
		}

		private void RadioButtonInit(RadioButton rdo)
		{
			rdoMPE.Checked = false;
			rdoMPA.Checked = false;
			rdoSA.Checked = false;
			rdoMD.Checked = false;

			rdo.Checked = true;
		}

		private string GetSelectedRadioButton()
		{
			string strResult = "";

			if(rdoMPE.Checked)
			{
				strResult = "MPE";
			}
			else if(rdoMPA.Checked)
			{
				strResult = "MPA";
			}
			else if(rdoSA.Checked)
			{
				strResult = "SA";
			}
			else if(rdoMD.Checked)
			{
				strResult = "MD";
			}

			return strResult;
		}

		private void PictureInit(PictureBox pic,PictureBox pic2)
		{
			picMPA_On.Visible = false;
			picSA_Off.Visible = true;
			picMD_Off.Visible = true;
			picMPA_Off.Visible = true;
			picMPE_Off.Visible = true;
			picMD_On.Visible = false;
			picSA_On.Visible = false;
			picMPE_On.Visible = false;

			pic.Visible = true;
			pic2.Visible = false;
		}

		private void rdoMPE_CheckedChanged(object sender, System.EventArgs e)
		{
			PictureInit(picMPE_On,picMPE_Off);
		}

		private void rdoMPA_CheckedChanged(object sender, System.EventArgs e)
		{
			PictureInit(picMPA_On,picMPA_Off);
		}

		private void rdoSA_CheckedChanged(object sender, System.EventArgs e)
		{
			PictureInit(picSA_On,picSA_Off);
		}

		private void rdoMD_CheckedChanged(object sender, System.EventArgs e)
		{
			PictureInit(picMD_On,picMD_Off);
		}

		private void picStart_Click(object sender, System.EventArgs e)
		{
//			HONUS_Main frmHONUS_Main = new HONUS_Main(GetSelectedRadioButton());
//
//			//frmHONUS_Main.strSelectedItem = GetSelectedRadioButton();
//			frmHONUS_Main.frmMainPopup = this;
//			frmHONUS_Main.Show();
//
//			this.Hide();

			switch(GetSelectedRadioButton())
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

			this.Hide();
		}

		private void picMPE_Off_Click(object sender, System.EventArgs e)
		{
			PictureInit(picMPE_On,picMPE_Off);
			RadioButtonInit(rdoMPE);
		}

		private void picMPA_Off_Click(object sender, System.EventArgs e)
		{
			PictureInit(picMPA_On,picMPA_Off);
			RadioButtonInit(rdoMPA);
		}

		private void picSA_Off_Click(object sender, System.EventArgs e)
		{
			PictureInit(picSA_On,picSA_Off);
			RadioButtonInit(rdoSA);
		}

		private void picMD_Off_Click(object sender, System.EventArgs e)
		{
			PictureInit(picMD_On,picMD_Off);
			RadioButtonInit(rdoMD);
		}

	}

	public class MaterialType
	{
		public string Name;
		public string ID;

		public MaterialType()
		{
			Name = "";
			ID = "";
		}
	}
}
