using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// OneThirdOctaveFind에 대한 요약 설명입니다.
	/// </summary>
	public class OneThirdOctaveFind : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbAll;
		private System.Windows.Forms.TextBox edtAlpha;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox edt2000;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox edt4000;
		private System.Windows.Forms.Button btnCANCEL;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox edt1000;
		private System.Windows.Forms.TextBox edt400;
		private System.Windows.Forms.TextBox edt500;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox edt800;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox edt630;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox edt1250;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox edt1600;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox edt3150;
		private System.Windows.Forms.TextBox edt6300;
		private System.Windows.Forms.TextBox edt5000;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox edt8000;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox edt10000;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public clsAbsorptionCoefficient_FindDetail clsAbsorptionCoefficient_Find1;

		public OneThirdOctaveFind()
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
			this.gbAll = new System.Windows.Forms.GroupBox();
			this.edtAlpha = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.edtName = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.edt10000 = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.edt8000 = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.edt3150 = new System.Windows.Forms.TextBox();
			this.edt1250 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.edt1600 = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.edt800 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.edt630 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.edt500 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.edt6300 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.edt5000 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.edt1000 = new System.Windows.Forms.TextBox();
			this.edt400 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.edt2000 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.edt4000 = new System.Windows.Forms.TextBox();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.gbAll.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbAll
			// 
			this.gbAll.Controls.Add(this.edtAlpha);
			this.gbAll.Controls.Add(this.checkBox1);
			this.gbAll.Enabled = false;
			this.gbAll.Location = new System.Drawing.Point(8, 40);
			this.gbAll.Name = "gbAll";
			this.gbAll.Size = new System.Drawing.Size(168, 56);
			this.gbAll.TabIndex = 49;
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
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(56, 8);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(120, 21);
			this.edtName.TabIndex = 44;
			this.edtName.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 11);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(48, 23);
			this.label19.TabIndex = 48;
			this.label19.Text = "Name : ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label30);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.edt10000);
			this.groupBox1.Controls.Add(this.label28);
			this.groupBox1.Controls.Add(this.label29);
			this.groupBox1.Controls.Add(this.edt8000);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.label27);
			this.groupBox1.Controls.Add(this.edt3150);
			this.groupBox1.Controls.Add(this.edt1250);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.edt1600);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.edt800);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.edt630);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.edt500);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.edt6300);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.edt5000);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.edt1000);
			this.groupBox1.Controls.Add(this.edt400);
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
			this.groupBox1.Location = new System.Drawing.Point(8, 88);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 392);
			this.groupBox1.TabIndex = 47;
			this.groupBox1.TabStop = false;
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(8, 360);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(40, 23);
			this.label30.TabIndex = 58;
			this.label30.Text = "10000";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label31.Location = new System.Drawing.Point(56, 360);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(24, 24);
			this.label31.TabIndex = 59;
			this.label31.Text = ">";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt10000
			// 
			this.edt10000.Location = new System.Drawing.Point(96, 360);
			this.edt10000.Name = "edt10000";
			this.edt10000.Size = new System.Drawing.Size(64, 21);
			this.edt10000.TabIndex = 57;
			this.edt10000.Text = "";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(8, 336);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(40, 23);
			this.label28.TabIndex = 55;
			this.label28.Text = "8000";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label29.Location = new System.Drawing.Point(56, 336);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(24, 24);
			this.label29.TabIndex = 56;
			this.label29.Text = ">";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt8000
			// 
			this.edt8000.Location = new System.Drawing.Point(96, 336);
			this.edt8000.Name = "edt8000";
			this.edt8000.Size = new System.Drawing.Size(64, 21);
			this.edt8000.TabIndex = 54;
			this.edt8000.Text = "";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(8, 240);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(40, 23);
			this.label26.TabIndex = 52;
			this.label26.Text = "3150";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label27.Location = new System.Drawing.Point(56, 240);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(24, 24);
			this.label27.TabIndex = 53;
			this.label27.Text = ">";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt3150
			// 
			this.edt3150.Location = new System.Drawing.Point(96, 240);
			this.edt3150.Name = "edt3150";
			this.edt3150.Size = new System.Drawing.Size(64, 21);
			this.edt3150.TabIndex = 51;
			this.edt3150.Text = "";
			// 
			// edt1250
			// 
			this.edt1250.Location = new System.Drawing.Point(96, 168);
			this.edt1250.Name = "edt1250";
			this.edt1250.Size = new System.Drawing.Size(64, 21);
			this.edt1250.TabIndex = 49;
			this.edt1250.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(8, 168);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(40, 23);
			this.label22.TabIndex = 48;
			this.label22.Text = "1250";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label23.Location = new System.Drawing.Point(56, 168);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(24, 24);
			this.label23.TabIndex = 50;
			this.label23.Text = ">";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(8, 192);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(40, 23);
			this.label24.TabIndex = 46;
			this.label24.Text = "1600";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt1600
			// 
			this.edt1600.Location = new System.Drawing.Point(96, 192);
			this.edt1600.Name = "edt1600";
			this.edt1600.Size = new System.Drawing.Size(64, 21);
			this.edt1600.TabIndex = 45;
			this.edt1600.Text = "";
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label25.Location = new System.Drawing.Point(56, 192);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(24, 24);
			this.label25.TabIndex = 47;
			this.label25.Text = ">";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt800
			// 
			this.edt800.Location = new System.Drawing.Point(96, 120);
			this.edt800.Name = "edt800";
			this.edt800.Size = new System.Drawing.Size(64, 21);
			this.edt800.TabIndex = 43;
			this.edt800.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 120);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 23);
			this.label12.TabIndex = 42;
			this.label12.Text = "800";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label13.Location = new System.Drawing.Point(56, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(24, 24);
			this.label13.TabIndex = 44;
			this.label13.Text = ">";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt630
			// 
			this.edt630.Location = new System.Drawing.Point(96, 96);
			this.edt630.Name = "edt630";
			this.edt630.Size = new System.Drawing.Size(64, 21);
			this.edt630.TabIndex = 39;
			this.edt630.Text = "";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 96);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(40, 23);
			this.label18.TabIndex = 40;
			this.label18.Text = "630";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label20.Location = new System.Drawing.Point(56, 96);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(24, 24);
			this.label20.TabIndex = 41;
			this.label20.Text = ">";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt500
			// 
			this.edt500.Location = new System.Drawing.Point(96, 72);
			this.edt500.Name = "edt500";
			this.edt500.Size = new System.Drawing.Size(64, 21);
			this.edt500.TabIndex = 37;
			this.edt500.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 36;
			this.label8.Text = "500";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label9.Location = new System.Drawing.Point(56, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(24, 24);
			this.label9.TabIndex = 38;
			this.label9.Text = ">";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 312);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 34;
			this.label5.Text = "6300";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label7.Location = new System.Drawing.Point(56, 312);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 24);
			this.label7.TabIndex = 35;
			this.label7.Text = ">";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt6300
			// 
			this.edt6300.Location = new System.Drawing.Point(96, 312);
			this.edt6300.Name = "edt6300";
			this.edt6300.Size = new System.Drawing.Size(64, 21);
			this.edt6300.TabIndex = 33;
			this.edt6300.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 288);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 31;
			this.label3.Text = "5000";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label4.Location = new System.Drawing.Point(56, 288);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 24);
			this.label4.TabIndex = 32;
			this.label4.Text = ">";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt5000
			// 
			this.edt5000.Location = new System.Drawing.Point(96, 288);
			this.edt5000.Name = "edt5000";
			this.edt5000.Size = new System.Drawing.Size(64, 21);
			this.edt5000.TabIndex = 30;
			this.edt5000.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 144);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(40, 23);
			this.label21.TabIndex = 21;
			this.label21.Text = "1000";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt1000
			// 
			this.edt1000.Location = new System.Drawing.Point(96, 144);
			this.edt1000.Name = "edt1000";
			this.edt1000.Size = new System.Drawing.Size(64, 21);
			this.edt1000.TabIndex = 7;
			this.edt1000.Text = "";
			// 
			// edt400
			// 
			this.edt400.Location = new System.Drawing.Point(96, 48);
			this.edt400.Name = "edt400";
			this.edt400.Size = new System.Drawing.Size(64, 21);
			this.edt400.TabIndex = 6;
			this.edt400.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "400";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 216);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 23);
			this.label10.TabIndex = 10;
			this.label10.Text = "2000";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label15.Location = new System.Drawing.Point(56, 144);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(24, 24);
			this.label15.TabIndex = 27;
			this.label15.Text = ">";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(104, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Level";
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
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Frequency";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 264);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 23);
			this.label11.TabIndex = 11;
			this.label11.Text = "4000";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt2000
			// 
			this.edt2000.Location = new System.Drawing.Point(96, 216);
			this.edt2000.Name = "edt2000";
			this.edt2000.Size = new System.Drawing.Size(64, 21);
			this.edt2000.TabIndex = 8;
			this.edt2000.Text = "";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label16.Location = new System.Drawing.Point(56, 216);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(24, 24);
			this.label16.TabIndex = 28;
			this.label16.Text = ">";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label17.Location = new System.Drawing.Point(56, 264);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(24, 24);
			this.label17.TabIndex = 29;
			this.label17.Text = ">";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edt4000
			// 
			this.edt4000.Location = new System.Drawing.Point(96, 264);
			this.edt4000.Name = "edt4000";
			this.edt4000.Size = new System.Drawing.Size(64, 21);
			this.edt4000.TabIndex = 9;
			this.edt4000.Text = "";
			// 
			// btnCANCEL
			// 
			this.btnCANCEL.Location = new System.Drawing.Point(104, 488);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.TabIndex = 46;
			this.btnCANCEL.Text = "Cancel";
			this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(48, 488);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(48, 23);
			this.btnOK.TabIndex = 45;
			this.btnOK.Text = "Ok";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// OneThirdOctaveFind
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(184, 517);
			this.Controls.Add(this.gbAll);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCANCEL);
			this.Controls.Add(this.btnOK);
			this.Name = "OneThirdOctaveFind";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OneThirdOctaveFind";
			this.Load += new System.EventHandler(this.OneThirdOctaveFind_Load);
			this.gbAll.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

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

		public void gbAll_Enable(bool bEnable)
		{
			gbAll.Enabled = bEnable;

			edt400.Enabled = false;
			edt500.Enabled = false;
			edt630.Enabled = false;
			edt800.Enabled = false;
			edt1000.Enabled = false;
			edt1250.Enabled = false;
			edt1600.Enabled = false;
			edt2000.Enabled = false;
			edt3150.Enabled = false;
			edt4000.Enabled = false;
			edt5000.Enabled = false;
			edt6300.Enabled = false;
			edt8000.Enabled = false;
			edt10000.Enabled = false;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked == true)
			{
				edt400.Enabled = false;
				edt500.Enabled = false;
				edt630.Enabled = false;
				edt800.Enabled = false;
				edt1000.Enabled = false;
				edt1250.Enabled = false;
				edt1600.Enabled = false;
				edt2000.Enabled = false;
				edt3150.Enabled = false;
				edt4000.Enabled = false;
				edt5000.Enabled = false;
				edt6300.Enabled = false;
				edt8000.Enabled = false;
				edt10000.Enabled = false;
			}
			else
			{
				edtAlpha.Text = "";

				edt400.Enabled = true;
				edt500.Enabled = true;
				edt630.Enabled = true;
				edt800.Enabled = true;
				edt1000.Enabled = true;
				edt1250.Enabled = true;
				edt1600.Enabled = true;
				edt2000.Enabled = true;
				edt3150.Enabled = true;
				edt4000.Enabled = true;
				edt5000.Enabled = true;
				edt6300.Enabled = true;
				edt8000.Enabled = true;
				edt10000.Enabled = true;
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;

			clsAbsorptionCoefficient_Find1 = new clsAbsorptionCoefficient_FindDetail();

			clsAbsorptionCoefficient_Find1.strName = edtName.Text;

			clsAbsorptionCoefficient_Find1.strAlpha = edtAlpha.Text;

			clsAbsorptionCoefficient_Find1.str400 = edt400.Text;
			clsAbsorptionCoefficient_Find1.str500 = edt500.Text;
			clsAbsorptionCoefficient_Find1.str630 = edt630.Text;
			clsAbsorptionCoefficient_Find1.str800 = edt800.Text;
			clsAbsorptionCoefficient_Find1.str1000 = edt1000.Text; 
			clsAbsorptionCoefficient_Find1.str1250 = edt1250.Text;
			clsAbsorptionCoefficient_Find1.str1600 = edt1600.Text;
			clsAbsorptionCoefficient_Find1.str2000 = edt2000.Text;
			clsAbsorptionCoefficient_Find1.str3150 = edt3150.Text;
			clsAbsorptionCoefficient_Find1.str4000 = edt4000.Text;
			clsAbsorptionCoefficient_Find1.str5000 = edt5000.Text;
			clsAbsorptionCoefficient_Find1.str6300 = edt6300.Text;
			clsAbsorptionCoefficient_Find1.str8000 = edt8000.Text;
			clsAbsorptionCoefficient_Find1.str10000 = edt10000.Text;
				
			this.Close();
		}

		private void btnCANCEL_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
		}

		private void OneThirdOctaveFind_Load(object sender, System.EventArgs e)
		{
			if(clsAbsorptionCoefficient_Find1 != null)
			{
				edtName.Text = clsAbsorptionCoefficient_Find1.strName;

				edt400.Text = clsAbsorptionCoefficient_Find1.str400;
				edt500.Text = clsAbsorptionCoefficient_Find1.str500;
				edt630.Text = clsAbsorptionCoefficient_Find1.str630;
				edt800.Text = clsAbsorptionCoefficient_Find1.str800;
				edt1000.Text = clsAbsorptionCoefficient_Find1.str1000;
				edt1250.Text = clsAbsorptionCoefficient_Find1.str1250;
				edt1600.Text = clsAbsorptionCoefficient_Find1.str1600;
				edt2000.Text = clsAbsorptionCoefficient_Find1.str2000;
				edt3150.Text = clsAbsorptionCoefficient_Find1.str3150;
				edt4000.Text = clsAbsorptionCoefficient_Find1.str4000;
				edt5000.Text = clsAbsorptionCoefficient_Find1.str5000;
				edt6300.Text = clsAbsorptionCoefficient_Find1.str6300;
				edt8000.Text = clsAbsorptionCoefficient_Find1.str8000;
				edt10000.Text = clsAbsorptionCoefficient_Find1.str10000;

			}
		}
	}

	public class clsAbsorptionCoefficient_FindDetail
	{
		public string strName;

		public string strAlpha;

		public string str400;
		public string str500;
		public string str630;
		public string str800;
		public string str1000;
		public string str1250;
		public string str1600;
		public string str2000;
		public string str3150;
		public string str4000;
		public string str5000;
		public string str6300;
		public string str8000;
		public string str10000;

		public clsAbsorptionCoefficient_FindDetail()
		{
			strName = "";

			strAlpha = "";
			
			str400 = "";
			str500 = "";
			str630 = "";
			str800 = "";
			str1000 = "";
			str1250 = "";
			str1600 = "";
			str2000 = "";
			str3150 = "";
			str4000 = "";
			str5000 = "";
			str6300 = "";
			str8000 = "";
			str10000 = "";
		}
	}
}
