using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialPropertiesEstimation.Form
{
	/// <summary>
	/// MPE_Main에 대한 요약 설명입니다.
	/// </summary>
	public class frmMPE_Main : System.Windows.Forms.Form
	{
		public MainPopup frmMainPopup;

		HONUS.MaterialPerformanceAnalysis.Form.frmMPA_Main frmMPA;
		HONUS.SensitivityAnalysis.Form.frmSA_Main frmSA;
		HONUS.MaterialDatabase.Form.frmMD_Main frmMD;

		public bool ClosingFlag;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox picMPE_On;
		private System.Windows.Forms.PictureBox picSA_On;
		private System.Windows.Forms.PictureBox picMD_On;
		private System.Windows.Forms.PictureBox picMPE_Off;
		private System.Windows.Forms.PictureBox picMD_Off;
		private System.Windows.Forms.PictureBox picSA_Off;
		private System.Windows.Forms.PictureBox picMPA_On;
		private System.Windows.Forms.PictureBox picMPA_Off;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.Label lblLeftTitle;
		private System.Windows.Forms.Label lblRightTitle;
		private HONUS.MaterialPropertiesEstimation.UserControl.ucEstimationSetup ucEstimationSetup1;
		private HONUS.MaterialPropertiesEstimation.UserControl.ucMaterialPropertiesEstimation ucMaterialPropertiesEstimation1;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox picMaximize;
		private System.Windows.Forms.PictureBox picMinimize;
		private System.Windows.Forms.Panel pnlLeft;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMPE_Main()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
			ClosingFlag = false;

			ucEstimationSetup1.ButtonClicked += new HONUS.MaterialPropertiesEstimation.UserControl.ucEstimationSetup.ButtonClickedDelegave(ucMaterialPropertiesEstimation1_ButtonClicked);
			ucEstimationSetup1.MyComboChangeEvent += new HONUS.MaterialPropertiesEstimation.UserControl.ucEstimationSetup.MyComboChangeDelegate(ucEstimationSetup1_MyComboChangeEvent);
			ucEstimationSetup1.InitPage();
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

		private void MPA_Init()
		{
			frmMPA = new HONUS.MaterialPerformanceAnalysis.Form.frmMPA_Main();
			frmMPA.frmMainPopup = frmMainPopup;
			//frmMPA.MdiParent = this;
			frmMPA.Show();
			frmMPA.Location = this.Location;
		}

		private void SA_Init()
		{
			frmSA = new HONUS.SensitivityAnalysis.Form.frmSA_Main();
			frmSA.frmMainPopup = frmMainPopup;
			//frmSA.MdiParent = this;
			frmSA.Show();
			frmSA.Location = this.Location;
		}

		private void MD_Init()
		{
			frmMD = new HONUS.MaterialDatabase.Form.frmMD_Main();
			frmMD.frmMainPopup = frmMainPopup;
			//frmMD.MdiParent = this;
			frmMD.Show();
			frmMD.Location = this.Location;
		}

		public void ucEstimationSetup1_MyComboChangeEvent(string strType,string strOption)
		{
			ucMaterialPropertiesEstimation1.EdtBoxInit(strType,strOption);
		}

		public void ucMaterialPropertiesEstimation1_ButtonClicked(string strButtonCLikedName,string Addtroin)
		{
			switch(strButtonCLikedName)
			{
				case "Estimation" :
					Estimation();
					break;
				case "Save" :
					ucMaterialPropertiesEstimation1.Save(ucEstimationSetup1.GetcboMeterialType_ID(),"1",ucEstimationSetup1.strTemperature,"1","0","1");
					
					break;
			}
		}

		private void Estimation()
		{
			if(ucEstimationSetup1.bIsFileLoad == 1)
			{
				if(ucMaterialPropertiesEstimation1.InputCheck() == true)
				{
					ucEstimationSetup1.FileAllParsing(ucMaterialPropertiesEstimation1,ucMaterialPropertiesEstimation1.strName);
					if(ucEstimationSetup1.MPEClass1 != null)
					{
						ucMaterialPropertiesEstimation1.TextBoxFill(ucEstimationSetup1.MPEClass1);
						ucMaterialPropertiesEstimation1.GraphDraw(ucEstimationSetup1.MPEClass1);
						ucEstimationSetup1.SaveButtonEmable();
					}
				}
				else
				{
					MessageBox.Show("활성된 모든란에 입력값을 입력하여 주세요.");
				}
			}
			else if(ucEstimationSetup1.bIsFileLoad == 0)
			{
				if(ucMaterialPropertiesEstimation1.InputCheck() == true)
				{
					ucEstimationSetup1.DataBaseLoad(ucMaterialPropertiesEstimation1,ucMaterialPropertiesEstimation1.strName);
					if(ucEstimationSetup1.MPEClass1 != null)
					{
						ucMaterialPropertiesEstimation1.TextBoxFill(ucEstimationSetup1.MPEClass1);
						ucMaterialPropertiesEstimation1.GraphDraw(ucEstimationSetup1.MPEClass1);
						ucEstimationSetup1.SaveButtonEmable();
					}
				}
				else
				{
					MessageBox.Show("활성된 모든란에 입력값을 입력하여 주세요.");
				}
			}
			else
			{
				MessageBox.Show("File 또는 DataBase 를 로드하여 주십시오.");
			}
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMPE_Main));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.picMPE_Off = new System.Windows.Forms.PictureBox();
			this.picMPE_On = new System.Windows.Forms.PictureBox();
			this.picMPA_Off = new System.Windows.Forms.PictureBox();
			this.picSA_Off = new System.Windows.Forms.PictureBox();
			this.picMD_Off = new System.Windows.Forms.PictureBox();
			this.picMD_On = new System.Windows.Forms.PictureBox();
			this.picMPA_On = new System.Windows.Forms.PictureBox();
			this.picSA_On = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pnlLeft = new System.Windows.Forms.Panel();
			this.picMinimize = new System.Windows.Forms.PictureBox();
			this.ucEstimationSetup1 = new HONUS.MaterialPropertiesEstimation.UserControl.ucEstimationSetup();
			this.lblLeftTitle = new System.Windows.Forms.Label();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.ucMaterialPropertiesEstimation1 = new HONUS.MaterialPropertiesEstimation.UserControl.ucMaterialPropertiesEstimation();
			this.lblRightTitle = new System.Windows.Forms.Label();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.picMaximize = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlLeft.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(225)), ((System.Byte)(225)), ((System.Byte)(225)));
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.picMPE_Off);
			this.panel1.Controls.Add(this.picMPE_On);
			this.panel1.Controls.Add(this.picMPA_Off);
			this.panel1.Controls.Add(this.picSA_Off);
			this.panel1.Controls.Add(this.picMD_Off);
			this.panel1.Controls.Add(this.picMD_On);
			this.panel1.Controls.Add(this.picMPA_On);
			this.panel1.Controls.Add(this.picSA_On);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1006, 97);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(204)));
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox3.Location = new System.Drawing.Point(105, 60);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(901, 8);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(225)), ((System.Byte)(225)), ((System.Byte)(225)));
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox2.Location = new System.Drawing.Point(105, 68);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(901, 29);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(105, 97);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// picMPE_Off
			// 
			this.picMPE_Off.Image = ((System.Drawing.Image)(resources.GetObject("picMPE_Off.Image")));
			this.picMPE_Off.Location = new System.Drawing.Point(112, 16);
			this.picMPE_Off.Name = "picMPE_Off";
			this.picMPE_Off.Size = new System.Drawing.Size(199, 25);
			this.picMPE_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMPE_Off.TabIndex = 16;
			this.picMPE_Off.TabStop = false;
			this.picMPE_Off.Click += new System.EventHandler(this.picMPE_Off_Click);
			// 
			// picMPE_On
			// 
			this.picMPE_On.Image = ((System.Drawing.Image)(resources.GetObject("picMPE_On.Image")));
			this.picMPE_On.Location = new System.Drawing.Point(112, 16);
			this.picMPE_On.Name = "picMPE_On";
			this.picMPE_On.Size = new System.Drawing.Size(199, 25);
			this.picMPE_On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMPE_On.TabIndex = 19;
			this.picMPE_On.TabStop = false;
			// 
			// picMPA_Off
			// 
			this.picMPA_Off.Image = ((System.Drawing.Image)(resources.GetObject("picMPA_Off.Image")));
			this.picMPA_Off.Location = new System.Drawing.Point(328, 16);
			this.picMPA_Off.Name = "picMPA_Off";
			this.picMPA_Off.Size = new System.Drawing.Size(199, 25);
			this.picMPA_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMPA_Off.TabIndex = 15;
			this.picMPA_Off.TabStop = false;
			this.picMPA_Off.Click += new System.EventHandler(this.picMPA_Off_Click);
			// 
			// picSA_Off
			// 
			this.picSA_Off.Image = ((System.Drawing.Image)(resources.GetObject("picSA_Off.Image")));
			this.picSA_Off.Location = new System.Drawing.Point(544, 16);
			this.picSA_Off.Name = "picSA_Off";
			this.picSA_Off.Size = new System.Drawing.Size(126, 25);
			this.picSA_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picSA_Off.TabIndex = 13;
			this.picSA_Off.TabStop = false;
			this.picSA_Off.Click += new System.EventHandler(this.picSA_Off_Click);
			// 
			// picMD_Off
			// 
			this.picMD_Off.Image = ((System.Drawing.Image)(resources.GetObject("picMD_Off.Image")));
			this.picMD_Off.Location = new System.Drawing.Point(688, 16);
			this.picMD_Off.Name = "picMD_Off";
			this.picMD_Off.Size = new System.Drawing.Size(126, 25);
			this.picMD_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMD_Off.TabIndex = 14;
			this.picMD_Off.TabStop = false;
			this.picMD_Off.Click += new System.EventHandler(this.picMD_Off_Click);
			// 
			// picMD_On
			// 
			this.picMD_On.Image = ((System.Drawing.Image)(resources.GetObject("picMD_On.Image")));
			this.picMD_On.Location = new System.Drawing.Point(688, 16);
			this.picMD_On.Name = "picMD_On";
			this.picMD_On.Size = new System.Drawing.Size(126, 25);
			this.picMD_On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMD_On.TabIndex = 17;
			this.picMD_On.TabStop = false;
			// 
			// picMPA_On
			// 
			this.picMPA_On.Image = ((System.Drawing.Image)(resources.GetObject("picMPA_On.Image")));
			this.picMPA_On.Location = new System.Drawing.Point(328, 16);
			this.picMPA_On.Name = "picMPA_On";
			this.picMPA_On.Size = new System.Drawing.Size(199, 25);
			this.picMPA_On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMPA_On.TabIndex = 12;
			this.picMPA_On.TabStop = false;
			// 
			// picSA_On
			// 
			this.picSA_On.Image = ((System.Drawing.Image)(resources.GetObject("picSA_On.Image")));
			this.picSA_On.Location = new System.Drawing.Point(544, 16);
			this.picSA_On.Name = "picSA_On";
			this.picSA_On.Size = new System.Drawing.Size(126, 25);
			this.picSA_On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picSA_On.TabIndex = 18;
			this.picSA_On.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.pictureBox6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 713);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1006, 28);
			this.panel2.TabIndex = 1;
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
			this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox8.Location = new System.Drawing.Point(341, 6);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(508, 20);
			this.pictureBox8.TabIndex = 2;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(849, 6);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(157, 20);
			this.pictureBox5.TabIndex = 1;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 6);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(341, 20);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(225)), ((System.Byte)(225)), ((System.Byte)(225)));
			this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox7.Location = new System.Drawing.Point(0, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(1006, 6);
			this.pictureBox7.TabIndex = 1;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(225)), ((System.Byte)(225)), ((System.Byte)(225)));
			this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox6.Location = new System.Drawing.Point(0, 26);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(1006, 2);
			this.pictureBox6.TabIndex = 0;
			this.pictureBox6.TabStop = false;
			// 
			// pnlLeft
			// 
			this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
			this.pnlLeft.Controls.Add(this.picMinimize);
			this.pnlLeft.Controls.Add(this.ucEstimationSetup1);
			this.pnlLeft.Controls.Add(this.lblLeftTitle);
			this.pnlLeft.Controls.Add(this.pictureBox14);
			this.pnlLeft.Controls.Add(this.pictureBox11);
			this.pnlLeft.Controls.Add(this.pictureBox13);
			this.pnlLeft.Controls.Add(this.pictureBox12);
			this.pnlLeft.Controls.Add(this.pictureBox10);
			this.pnlLeft.Controls.Add(this.pictureBox9);
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.Location = new System.Drawing.Point(0, 97);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(294, 616);
			this.pnlLeft.TabIndex = 2;
			// 
			// picMinimize
			// 
			this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
			this.picMinimize.Location = new System.Drawing.Point(264, 8);
			this.picMinimize.Name = "picMinimize";
			this.picMinimize.Size = new System.Drawing.Size(15, 13);
			this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMinimize.TabIndex = 11;
			this.picMinimize.TabStop = false;
			this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
			// 
			// ucEstimationSetup1
			// 
			this.ucEstimationSetup1.BackColor = System.Drawing.Color.White;
			this.ucEstimationSetup1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucEstimationSetup1.Location = new System.Drawing.Point(11, 37);
			this.ucEstimationSetup1.Name = "ucEstimationSetup1";
			this.ucEstimationSetup1.Size = new System.Drawing.Size(274, 572);
			this.ucEstimationSetup1.TabIndex = 7;
			// 
			// lblLeftTitle
			// 
			this.lblLeftTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(218)), ((System.Byte)(221)));
			this.lblLeftTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblLeftTitle.Location = new System.Drawing.Point(86, 8);
			this.lblLeftTitle.Name = "lblLeftTitle";
			this.lblLeftTitle.Size = new System.Drawing.Size(186, 16);
			this.lblLeftTitle.TabIndex = 6;
			this.lblLeftTitle.Text = "Estimation Set-up";
			// 
			// pictureBox14
			// 
			this.pictureBox14.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(157)), ((System.Byte)(193)), ((System.Byte)(197)));
			this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox14.Location = new System.Drawing.Point(11, 609);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(274, 7);
			this.pictureBox14.TabIndex = 5;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
			this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox11.Location = new System.Drawing.Point(11, 0);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(274, 37);
			this.pictureBox11.TabIndex = 2;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(157)), ((System.Byte)(193)), ((System.Byte)(197)));
			this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox13.Location = new System.Drawing.Point(10, 0);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(1, 616);
			this.pictureBox13.TabIndex = 4;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(157)), ((System.Byte)(193)), ((System.Byte)(197)));
			this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox12.Location = new System.Drawing.Point(285, 0);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(1, 616);
			this.pictureBox12.TabIndex = 3;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(225)), ((System.Byte)(225)), ((System.Byte)(225)));
			this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox10.Location = new System.Drawing.Point(286, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(8, 616);
			this.pictureBox10.TabIndex = 1;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(225)), ((System.Byte)(225)), ((System.Byte)(225)));
			this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox9.Location = new System.Drawing.Point(0, 0);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(10, 616);
			this.pictureBox9.TabIndex = 0;
			this.pictureBox9.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.ucMaterialPropertiesEstimation1);
			this.panel4.Controls.Add(this.lblRightTitle);
			this.panel4.Controls.Add(this.pictureBox18);
			this.panel4.Controls.Add(this.pictureBox17);
			this.panel4.Controls.Add(this.pictureBox16);
			this.panel4.Controls.Add(this.pictureBox15);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(294, 97);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(712, 616);
			this.panel4.TabIndex = 3;
			// 
			// ucMaterialPropertiesEstimation1
			// 
			this.ucMaterialPropertiesEstimation1.BackColor = System.Drawing.Color.White;
			this.ucMaterialPropertiesEstimation1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucMaterialPropertiesEstimation1.Location = new System.Drawing.Point(1, 37);
			this.ucMaterialPropertiesEstimation1.Name = "ucMaterialPropertiesEstimation1";
			this.ucMaterialPropertiesEstimation1.Size = new System.Drawing.Size(710, 572);
			this.ucMaterialPropertiesEstimation1.TabIndex = 8;
			// 
			// lblRightTitle
			// 
			this.lblRightTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(218)), ((System.Byte)(221)));
			this.lblRightTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblRightTitle.Location = new System.Drawing.Point(288, 8);
			this.lblRightTitle.Name = "lblRightTitle";
			this.lblRightTitle.Size = new System.Drawing.Size(272, 16);
			this.lblRightTitle.TabIndex = 7;
			this.lblRightTitle.Text = "Material Properties Estimation";
			this.lblRightTitle.Click += new System.EventHandler(this.lblRightTitle_Click);
			// 
			// pictureBox18
			// 
			this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox18.BackgroundImage")));
			this.pictureBox18.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox18.Location = new System.Drawing.Point(1, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(710, 37);
			this.pictureBox18.TabIndex = 3;
			this.pictureBox18.TabStop = false;
			// 
			// pictureBox17
			// 
			this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(157)), ((System.Byte)(193)), ((System.Byte)(197)));
			this.pictureBox17.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox17.Location = new System.Drawing.Point(1, 609);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(710, 7);
			this.pictureBox17.TabIndex = 2;
			this.pictureBox17.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(157)), ((System.Byte)(193)), ((System.Byte)(197)));
			this.pictureBox16.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox16.Location = new System.Drawing.Point(711, 0);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(1, 616);
			this.pictureBox16.TabIndex = 1;
			this.pictureBox16.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(157)), ((System.Byte)(193)), ((System.Byte)(197)));
			this.pictureBox15.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox15.Location = new System.Drawing.Point(0, 0);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(1, 616);
			this.pictureBox15.TabIndex = 0;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(225)), ((System.Byte)(225)), ((System.Byte)(225)));
			this.pictureBox19.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox19.Location = new System.Drawing.Point(1006, 0);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(10, 741);
			this.pictureBox19.TabIndex = 4;
			this.pictureBox19.TabStop = false;
			// 
			// picMaximize
			// 
			this.picMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picMaximize.Image")));
			this.picMaximize.Location = new System.Drawing.Point(16, 104);
			this.picMaximize.Name = "picMaximize";
			this.picMaximize.Size = new System.Drawing.Size(16, 14);
			this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMaximize.TabIndex = 12;
			this.picMaximize.TabStop = false;
			this.picMaximize.Visible = false;
			this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
			// 
			// frmMPE_Main
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.picMaximize);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnlLeft);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox19);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1024, 768);
			this.Name = "frmMPE_Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HONUS MPE";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMPE_Main_Closing);
			this.Load += new System.EventHandler(this.frmMPE_Main_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnlLeft.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void picMPE_Off_Click(object sender, System.EventArgs e)
		{
			PictureInit(picMPE_On,picMPE_Off);
		}

		private void picMPA_Off_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("창 전환을 하시면 현재 데이터는 사라집니다. 계속 하시겠습니까?","경고",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				PictureInit(picMPA_On,picMPA_Off);
				MPA_Init();
				ClosingFlag = true;
				this.Close();
			}
		}

		private void picSA_Off_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("창 전환을 하시면 현재 데이터는 사라집니다. 계속 하시겠습니까?","경고",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				PictureInit(picSA_On,picSA_Off);
				SA_Init();
				ClosingFlag = true;
				this.Close();
			}
		}

		private void picMD_Off_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("창 전환을 하시면 현재 데이터는 사라집니다. 계속 하시겠습니까?","경고",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				PictureInit(picMD_On,picMD_Off);
				MD_Init();
				ClosingFlag = true;
				this.Close();
			}
		}

		private void frmMPE_Main_Load(object sender, System.EventArgs e)
		{
			PictureInit(picMPE_On,picMPE_Off);
		}

		private void frmMPE_Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(ClosingFlag == false)
			{
				frmMainPopup.Close();
			}
		}

		private void picMinimize_Click(object sender, System.EventArgs e)
		{
			pnlLeft.Width = 50;
			picMaximize.Visible = true;
		}

		private void picMaximize_Click(object sender, System.EventArgs e)
		{
			pnlLeft.Width = 294;
			picMaximize.Visible = false;
		}


		private void lblRightTitle_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
