using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// frmMD_Main에 대한 요약 설명입니다.
	/// </summary>
	public class frmMD_Main : System.Windows.Forms.Form
	{
		public MainPopup frmMainPopup;

		HONUS.MaterialPropertiesEstimation.Form.frmMPE_Main frmMPE;
		HONUS.MaterialPerformanceAnalysis.Form.frmMPA_Main frmMPA;
		HONUS.SensitivityAnalysis.Form.frmSA_Main frmSA;

		public bool ClosingFlag;

		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblRightTitle;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox picMPE_Off;
		private System.Windows.Forms.PictureBox picMPE_On;
		private System.Windows.Forms.PictureBox picMPA_Off;
		private System.Windows.Forms.PictureBox picSA_Off;
		private System.Windows.Forms.PictureBox picMD_Off;
		private System.Windows.Forms.PictureBox picMD_On;
		private System.Windows.Forms.PictureBox picMPA_On;
		private System.Windows.Forms.PictureBox picSA_On;
		private System.Windows.Forms.Label lblLeftTitle;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox6;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private HONUS.MaterialDatabase.UserControl.ucDatainformation ucDatainformation1;
		private HONUS.MaterialDatabase.UserControl.ucMaterialDatabase_Addition ucMaterialDatabase_Addition1;
		private System.Windows.Forms.PictureBox pictureBox19;
		private HONUS.MaterialDatabase.UserControl.ucMaterialDatabase_Search ucMaterialDatabase_Search1;
		private HONUS.MaterialDatabase.UserControl.ucSearchingCondition ucSearchingCondition1;
		private System.Windows.Forms.Panel pnlLeft;
		private System.Windows.Forms.PictureBox picMinimize;
		private System.Windows.Forms.PictureBox picMaximize;

		public bool bIsSearchPopup;
		public bool bIsSingle;
		public string strSelectedItem_ID;
		public string strSelectedType;

		public frmMD_Main()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			ucDatainformation1.RadioButtonChange += new MySelectedChange(ucDatainformation1_RadioButtonChange);
			ucSearchingCondition1.MyButtonClickedEvent += new HONUS.MaterialDatabase.UserControl.ucSearchingCondition.MyButtonClickedDelegate(ucSearchingCondition1_MyButtonClickedEvent);
			ucMaterialDatabase_Search1.MyListClickedEvent += new HONUS.MaterialDatabase.UserControl.ucMaterialDatabase_Search.MyListClickedDelegate(ucMaterialDatabase_Search1_MyListClickedEvent);
			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
			ucSearchingCondition1.InitForm();

			ClosingFlag = false;
			bIsSearchPopup = false;
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

		private void ucDatainformation1_RadioButtonChange(string strSelectedName)
		{
			if(strSelectedName == "Multi")
			{
				ucMaterialDatabase_Addition1.ModeChange("Multi");
			}
			else
			{
				ucMaterialDatabase_Addition1.ModeChange("Single");
			}
		}

		private void ucSearchingCondition1_MyButtonClickedEvent(string strName,string strAddition)
		{
			switch(strName)
			{
				case "Search" :
					if(ucSearchingCondition1.GetFrequency() == "2")
					{
						ucMaterialDatabase_Search1.Search(ucSearchingCondition1.GetCategory(),ucSearchingCondition1.GetIncidence(),
							ucSearchingCondition1.GetcboMeterialType_ID(),ucSearchingCondition1.GetOption(),ucSearchingCondition1.GetFrequency(),
							ucSearchingCondition1.clsAbsorptionCoefficient_Find_RB,ucSearchingCondition1.clsAbsorptionCoefficient_Find_AT,
							ucSearchingCondition1.clsAbsorptionCoefficient_Find_TL,ucSearchingCondition1.clsParameters1,ucSearchingCondition1.clsMultiLayer_Find1,
							ucSearchingCondition1.ctVendor,ucSearchingCondition1.ctProducing,ucSearchingCondition1.ctDate,ucSearchingCondition1.dMeasured);
					}
					else
					{
						ucMaterialDatabase_Search1.Search(ucSearchingCondition1.GetCategory(),ucSearchingCondition1.GetIncidence(),
							ucSearchingCondition1.GetcboMeterialType_ID(),ucSearchingCondition1.GetOption(),ucSearchingCondition1.GetFrequency(),
							ucSearchingCondition1.clsAbsorptionCoefficient_Find_RBDetail,ucSearchingCondition1.clsAbsorptionCoefficient_Find_ATDetail,
							ucSearchingCondition1.clsAbsorptionCoefficient_Find_TLDetail,ucSearchingCondition1.clsParameters1,ucSearchingCondition1.clsMultiLayer_Find1,
							ucSearchingCondition1.ctVendor,ucSearchingCondition1.ctProducing,ucSearchingCondition1.ctDate,ucSearchingCondition1.dMeasured);
					}
					break;
				case "AfterSearch" :
					ucMaterialDatabase_Search1.AfterSearch(ucSearchingCondition1.GetCategory(),ucSearchingCondition1.ctDate,ucSearchingCondition1.ctDate2);
					break;
				case "ReSearch" :
					ucMaterialDatabase_Search1.ReSearch();
					break;
				case "MaterialTypeChange" :
					ucMaterialDatabase_Search1.MeterialTypeChange(strAddition);
					break;
			}
		}

		private void ucMaterialDatabase_Search1_MyListClickedEvent(string strName,string strAddition,bool bIsSingle)
		{
			switch(strName)
			{
				case "ListClicked" :
					if(bIsSearchPopup == true)
					{
						strSelectedItem_ID = strAddition;
						this.bIsSingle = bIsSingle;
						this.DialogResult = DialogResult.OK;
						this.ClosingFlag = true;
						this.Close();
					}
					break;
			}
		}

		private void MPE_Init()
		{
			frmMPE = new HONUS.MaterialPropertiesEstimation.Form.frmMPE_Main();
			frmMPE.frmMainPopup = frmMainPopup;
			//frmMPE.MdiParent = this;
			
			frmMPE.Show();
			frmMPE.Location = this.Location;
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMD_Main));
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucMaterialDatabase_Search1 = new HONUS.MaterialDatabase.UserControl.ucMaterialDatabase_Search();
            this.ucMaterialDatabase_Addition1 = new HONUS.MaterialDatabase.UserControl.ucMaterialDatabase_Addition();
            this.lblRightTitle = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.ucSearchingCondition1 = new HONUS.MaterialDatabase.UserControl.ucSearchingCondition();
            this.ucDatainformation1 = new HONUS.MaterialDatabase.UserControl.ucDatainformation();
            this.lblLeftTitle = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPE_Off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPE_On)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPA_Off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSA_Off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMD_Off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMD_On)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPA_On)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSA_On)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucMaterialDatabase_Search1);
            this.panel4.Controls.Add(this.ucMaterialDatabase_Addition1);
            this.panel4.Controls.Add(this.lblRightTitle);
            this.panel4.Controls.Add(this.pictureBox18);
            this.panel4.Controls.Add(this.pictureBox17);
            this.panel4.Controls.Add(this.pictureBox16);
            this.panel4.Controls.Add(this.pictureBox15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(294, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 616);
            this.panel4.TabIndex = 15;
            // 
            // ucMaterialDatabase_Search1
            // 
            this.ucMaterialDatabase_Search1.BackColor = System.Drawing.Color.White;
            this.ucMaterialDatabase_Search1.Location = new System.Drawing.Point(392, 64);
            this.ucMaterialDatabase_Search1.Name = "ucMaterialDatabase_Search1";
            this.ucMaterialDatabase_Search1.Size = new System.Drawing.Size(280, 312);
            this.ucMaterialDatabase_Search1.TabIndex = 9;
            // 
            // ucMaterialDatabase_Addition1
            // 
            this.ucMaterialDatabase_Addition1.BackColor = System.Drawing.Color.White;
            this.ucMaterialDatabase_Addition1.Location = new System.Drawing.Point(-200, 576);
            this.ucMaterialDatabase_Addition1.Name = "ucMaterialDatabase_Addition1";
            this.ucMaterialDatabase_Addition1.Size = new System.Drawing.Size(312, 392);
            this.ucMaterialDatabase_Addition1.TabIndex = 8;
            // 
            // lblRightTitle
            // 
            this.lblRightTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.lblRightTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRightTitle.Location = new System.Drawing.Point(312, 8);
            this.lblRightTitle.Name = "lblRightTitle";
            this.lblRightTitle.Size = new System.Drawing.Size(120, 16);
            this.lblRightTitle.TabIndex = 7;
            this.lblRightTitle.Text = "Material Database";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox18.BackgroundImage")));
            this.pictureBox18.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox18.Location = new System.Drawing.Point(1, 0);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(728, 37);
            this.pictureBox18.TabIndex = 3;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.pictureBox17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox17.Location = new System.Drawing.Point(1, 609);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(728, 7);
            this.pictureBox17.TabIndex = 2;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.pictureBox16.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox16.Location = new System.Drawing.Point(729, 0);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(1, 616);
            this.pictureBox16.TabIndex = 1;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.pictureBox15.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox15.Location = new System.Drawing.Point(0, 0);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(1, 616);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
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
            this.panel1.Size = new System.Drawing.Size(1024, 97);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Location = new System.Drawing.Point(105, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(919, 8);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(105, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(919, 29);
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
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.picMaximize);
            this.pnlLeft.Controls.Add(this.picMinimize);
            this.pnlLeft.Controls.Add(this.ucSearchingCondition1);
            this.pnlLeft.Controls.Add(this.ucDatainformation1);
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
            this.pnlLeft.TabIndex = 14;
            // 
            // picMaximize
            // 
            this.picMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picMaximize.Image")));
            this.picMaximize.Location = new System.Drawing.Point(14, 8);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(16, 14);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMaximize.TabIndex = 10;
            this.picMaximize.TabStop = false;
            this.picMaximize.Visible = false;
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(264, 8);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(15, 13);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 9;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // ucSearchingCondition1
            // 
            this.ucSearchingCondition1.BackColor = System.Drawing.Color.White;
            this.ucSearchingCondition1.ctDate = "2014-02-05";
            this.ucSearchingCondition1.ctDate2 = "2014-02-05";
            this.ucSearchingCondition1.ctProducing = "";
            this.ucSearchingCondition1.ctVendor = "";
            this.ucSearchingCondition1.Location = new System.Drawing.Point(152, 288);
            this.ucSearchingCondition1.Name = "ucSearchingCondition1";
            this.ucSearchingCondition1.Size = new System.Drawing.Size(96, 224);
            this.ucSearchingCondition1.TabIndex = 8;
            // 
            // ucDatainformation1
            // 
            this.ucDatainformation1.BackColor = System.Drawing.Color.White;
            this.ucDatainformation1.Location = new System.Drawing.Point(-48, 552);
            this.ucDatainformation1.Name = "ucDatainformation1";
            this.ucDatainformation1.Size = new System.Drawing.Size(128, 232);
            this.ucDatainformation1.TabIndex = 7;
            // 
            // lblLeftTitle
            // 
            this.lblLeftTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.lblLeftTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLeftTitle.Location = new System.Drawing.Point(86, 8);
            this.lblLeftTitle.Name = "lblLeftTitle";
            this.lblLeftTitle.Size = new System.Drawing.Size(186, 16);
            this.lblLeftTitle.TabIndex = 6;
            this.lblLeftTitle.Text = "Data information";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
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
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox13.Location = new System.Drawing.Point(10, 0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(1, 616);
            this.pictureBox13.TabIndex = 4;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox12.Location = new System.Drawing.Point(285, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(1, 616);
            this.pictureBox12.TabIndex = 3;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox10.Location = new System.Drawing.Point(286, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(8, 616);
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 616);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
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
            this.panel2.Size = new System.Drawing.Size(1024, 28);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Location = new System.Drawing.Point(341, 6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(526, 20);
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(867, 6);
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
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1024, 6);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox6.Location = new System.Drawing.Point(0, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1024, 2);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(0, 0);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(100, 50);
            this.pictureBox19.TabIndex = 16;
            this.pictureBox19.TabStop = false;
            // 
            // frmMD_Main
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 741);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmMD_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HONUS Material Database";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMD_Main_Closing);
            this.Load += new System.EventHandler(this.frmMD_Main_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPE_Off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPE_On)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPA_Off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSA_Off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMD_Off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMD_On)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPA_On)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSA_On)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void picMPE_Off_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("창 전환을 하시면 현재 데이터는 사라집니다. 계속 하시겠습니까?","경고",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				PictureInit(picMPE_On,picMPE_Off);
				MPE_Init();
				ClosingFlag = true;
				this.Close();
			}
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
			PictureInit(picMD_On,picMD_Off);
		}

		private void frmMD_Main_Load(object sender, System.EventArgs e)
		{
			PictureInit(picMD_On,picMD_Off);

			SearchInit();
			if(bIsSearchPopup == true)
			{
				picMPE_Off.Enabled = false;
				picMPA_Off.Enabled = false;
				picSA_Off.Enabled = false;
			}
			//TypeSelect();
		}

//		private void TypeSelect()
//		{
//			dgSelected dgSelected1 = new dgSelected();
//			if(dgSelected1.ShowDialog() == DialogResult.OK)
//			{
//				strSelectedType = dgSelected1.strSelected;
//
//				if(strSelectedType == "Addition")
//				{
//					AdditionInit();
//				}
//				else
//				{
//					SearchInit();
//				}
//			}
//			else
//			{
//				this.Close();
//			}
//		}

//		private void AdditionInit()
//		{
//			ucDatainformation1.Visible = true;
//			ucDatainformation1.Dock = DockStyle.Fill;
//			ucSearchingCondition1.Visible = false;
//
//			ucMaterialDatabase_Addition1.Visible = true;
//			ucMaterialDatabase_Addition1.Dock = DockStyle.Fill;
//			ucMaterialDatabase_Search1.Visible = false;
//		}

		private void SearchInit()
		{
			ucDatainformation1.Visible = false;
			ucSearchingCondition1.Dock = DockStyle.Fill;
			ucSearchingCondition1.Visible = true;

			ucMaterialDatabase_Addition1.Visible = false;
			ucMaterialDatabase_Search1.Dock = DockStyle.Fill;
			ucMaterialDatabase_Search1.Visible = true;
		}

		private void frmMD_Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
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

		/// <summary>
		/// Single 면 true
		/// </summary>
		/// <param name="bControl"></param>
		public void ucSearchingCondition_SingleMulti_Control(bool bControl)
		{
			if(bControl == true)
			{
				ucSearchingCondition1.rdoSingleLayer.Checked = true;
				ucSearchingCondition1.rdoSingleLayer.Enabled = false;

				ucSearchingCondition1.rdoMultiLayer.Checked = false;
				ucSearchingCondition1.rdoMultiLayer.Enabled = false;
			}
			else
			{
				ucSearchingCondition1.rdoSingleLayer.Checked = false;
				ucSearchingCondition1.rdoSingleLayer.Enabled = false;

				ucSearchingCondition1.rdoMultiLayer.Checked = true;
				ucSearchingCondition1.rdoMultiLayer.Enabled = false;
			}
		}
	}
}
