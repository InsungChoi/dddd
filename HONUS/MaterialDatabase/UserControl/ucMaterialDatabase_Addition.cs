using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.UserControl
{
	/// <summary>
	/// ucMaterialDatabase_Addition에 대한 요약 설명입니다.
	/// </summary>
	public class ucMaterialDatabase_Addition : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.Panel pnTop_Single;
		private System.Windows.Forms.Panel pnButtom_Multi;
		private System.Windows.Forms.Panel pnTop_Multi;
		private System.Windows.Forms.Panel pnButtom_Single;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button button3;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ucMaterialDatabase_Addition()
		{
			// 이 호출은 Windows.Forms Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

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

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnTop_Single = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.pnButtom_Multi = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.pnTop_Multi = new System.Windows.Forms.Panel();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.pnButtom_Single = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.textBox22 = new System.Windows.Forms.TextBox();
			this.textBox23 = new System.Windows.Forms.TextBox();
			this.textBox24 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.pnTop_Single.SuspendLayout();
			this.pnButtom_Multi.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.pnTop_Multi.SuspendLayout();
			this.pnButtom_Single.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnTop_Single
			// 
			this.pnTop_Single.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnTop_Single.Controls.Add(this.textBox4);
			this.pnTop_Single.Controls.Add(this.textBox3);
			this.pnTop_Single.Controls.Add(this.textBox2);
			this.pnTop_Single.Controls.Add(this.textBox1);
			this.pnTop_Single.Controls.Add(this.label5);
			this.pnTop_Single.Controls.Add(this.label4);
			this.pnTop_Single.Controls.Add(this.label3);
			this.pnTop_Single.Controls.Add(this.label2);
			this.pnTop_Single.Controls.Add(this.label1);
			this.pnTop_Single.Location = new System.Drawing.Point(8, 8);
			this.pnTop_Single.Name = "pnTop_Single";
			this.pnTop_Single.Size = new System.Drawing.Size(688, 144);
			this.pnTop_Single.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(672, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Geometric information (for single layer)";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 56);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(160, 56);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Type";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(320, 56);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Thickness";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(528, 56);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Density";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 104);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(117, 104);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(152, 21);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(278, 104);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 21);
			this.textBox3.TabIndex = 7;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(447, 104);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(232, 21);
			this.textBox4.TabIndex = 8;
			this.textBox4.Text = "";
			// 
			// pnButtom_Multi
			// 
			this.pnButtom_Multi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnButtom_Multi.Controls.Add(this.groupBox3);
			this.pnButtom_Multi.Controls.Add(this.groupBox2);
			this.pnButtom_Multi.Controls.Add(this.button2);
			this.pnButtom_Multi.Controls.Add(this.button1);
			this.pnButtom_Multi.Controls.Add(this.groupBox1);
			this.pnButtom_Multi.Controls.Add(this.label6);
			this.pnButtom_Multi.Location = new System.Drawing.Point(8, 160);
			this.pnButtom_Multi.Name = "pnButtom_Multi";
			this.pnButtom_Multi.Size = new System.Drawing.Size(688, 328);
			this.pnButtom_Multi.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(224, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "Acoustic performance acquisition";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(16, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 104);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Measured  Frequency";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(8, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "Narrow band";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(8, 48);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Octave";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(8, 72);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "1/3 Octave";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(304, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(368, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Open the measured data";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.Location = new System.Drawing.Point(232, 272);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "OK! save";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton5);
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Location = new System.Drawing.Point(304, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(368, 64);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Incidence Condition";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(24, 24);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 0;
			this.radioButton4.Text = "Normal";
			// 
			// radioButton5
			// 
			this.radioButton5.Location = new System.Drawing.Point(248, 24);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.TabIndex = 1;
			this.radioButton5.Text = "Random";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBox1);
			this.groupBox3.Location = new System.Drawing.Point(304, 176);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(368, 56);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Acoustical performance";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(8, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(352, 20);
			this.comboBox1.TabIndex = 0;
			// 
			// pnTop_Multi
			// 
			this.pnTop_Multi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnTop_Multi.Controls.Add(this.textBox13);
			this.pnTop_Multi.Controls.Add(this.textBox14);
			this.pnTop_Multi.Controls.Add(this.textBox15);
			this.pnTop_Multi.Controls.Add(this.textBox16);
			this.pnTop_Multi.Controls.Add(this.textBox9);
			this.pnTop_Multi.Controls.Add(this.textBox10);
			this.pnTop_Multi.Controls.Add(this.textBox11);
			this.pnTop_Multi.Controls.Add(this.textBox12);
			this.pnTop_Multi.Controls.Add(this.textBox5);
			this.pnTop_Multi.Controls.Add(this.textBox6);
			this.pnTop_Multi.Controls.Add(this.textBox7);
			this.pnTop_Multi.Controls.Add(this.textBox8);
			this.pnTop_Multi.Controls.Add(this.label7);
			this.pnTop_Multi.Controls.Add(this.label8);
			this.pnTop_Multi.Controls.Add(this.label9);
			this.pnTop_Multi.Controls.Add(this.label10);
			this.pnTop_Multi.Controls.Add(this.label11);
			this.pnTop_Multi.Location = new System.Drawing.Point(8, 8);
			this.pnTop_Multi.Name = "pnTop_Multi";
			this.pnTop_Multi.Size = new System.Drawing.Size(688, 144);
			this.pnTop_Multi.TabIndex = 2;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(447, 64);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(232, 21);
			this.textBox5.TabIndex = 8;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(278, 64);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(160, 21);
			this.textBox6.TabIndex = 7;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(117, 64);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(152, 21);
			this.textBox7.TabIndex = 6;
			this.textBox7.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(8, 64);
			this.textBox8.Name = "textBox8";
			this.textBox8.TabIndex = 5;
			this.textBox8.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(528, 40);
			this.label7.Name = "label7";
			this.label7.TabIndex = 4;
			this.label7.Text = "Density";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(320, 40);
			this.label8.Name = "label8";
			this.label8.TabIndex = 3;
			this.label8.Text = "Thickness";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(160, 40);
			this.label9.Name = "label9";
			this.label9.TabIndex = 2;
			this.label9.Text = "Type";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(32, 40);
			this.label10.Name = "label10";
			this.label10.TabIndex = 1;
			this.label10.Text = "Name";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label11.Location = new System.Drawing.Point(8, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(672, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = "Geometric information (for Multi layer)";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(446, 88);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(232, 21);
			this.textBox9.TabIndex = 12;
			this.textBox9.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(277, 88);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(160, 21);
			this.textBox10.TabIndex = 11;
			this.textBox10.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(116, 88);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(152, 21);
			this.textBox11.TabIndex = 10;
			this.textBox11.Text = "";
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(7, 88);
			this.textBox12.Name = "textBox12";
			this.textBox12.TabIndex = 9;
			this.textBox12.Text = "";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(446, 112);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(232, 21);
			this.textBox13.TabIndex = 16;
			this.textBox13.Text = "";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(277, 112);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(160, 21);
			this.textBox14.TabIndex = 15;
			this.textBox14.Text = "";
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(116, 112);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(152, 21);
			this.textBox15.TabIndex = 14;
			this.textBox15.Text = "";
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(7, 112);
			this.textBox16.Name = "textBox16";
			this.textBox16.TabIndex = 13;
			this.textBox16.Text = "";
			// 
			// pnButtom_Single
			// 
			this.pnButtom_Single.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnButtom_Single.Controls.Add(this.button3);
			this.pnButtom_Single.Controls.Add(this.textBox22);
			this.pnButtom_Single.Controls.Add(this.textBox23);
			this.pnButtom_Single.Controls.Add(this.textBox24);
			this.pnButtom_Single.Controls.Add(this.label18);
			this.pnButtom_Single.Controls.Add(this.label19);
			this.pnButtom_Single.Controls.Add(this.label20);
			this.pnButtom_Single.Controls.Add(this.textBox21);
			this.pnButtom_Single.Controls.Add(this.textBox20);
			this.pnButtom_Single.Controls.Add(this.textBox19);
			this.pnButtom_Single.Controls.Add(this.textBox18);
			this.pnButtom_Single.Controls.Add(this.textBox17);
			this.pnButtom_Single.Controls.Add(this.label17);
			this.pnButtom_Single.Controls.Add(this.label16);
			this.pnButtom_Single.Controls.Add(this.label15);
			this.pnButtom_Single.Controls.Add(this.label14);
			this.pnButtom_Single.Controls.Add(this.label13);
			this.pnButtom_Single.Controls.Add(this.label12);
			this.pnButtom_Single.Location = new System.Drawing.Point(8, 160);
			this.pnButtom_Single.Name = "pnButtom_Single";
			this.pnButtom_Single.Size = new System.Drawing.Size(688, 328);
			this.pnButtom_Single.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(288, 23);
			this.label12.TabIndex = 0;
			this.label12.Text = "Properties information (for single layer)";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(16, 48);
			this.label13.Name = "label13";
			this.label13.TabIndex = 1;
			this.label13.Text = "Flow Resistivity";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(16, 88);
			this.label14.Name = "label14";
			this.label14.TabIndex = 2;
			this.label14.Text = "Structure Factor";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(16, 128);
			this.label15.Name = "label15";
			this.label15.TabIndex = 3;
			this.label15.Text = "Porosity";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(16, 168);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(136, 23);
			this.label16.TabIndex = 4;
			this.label16.Text = "Viscous Char. Length";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(16, 208);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(144, 23);
			this.label17.TabIndex = 5;
			this.label17.Text = "Thermal Char. Length";
			// 
			// textBox17
			// 
			this.textBox17.Location = new System.Drawing.Point(168, 40);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(152, 21);
			this.textBox17.TabIndex = 6;
			this.textBox17.Text = "";
			// 
			// textBox18
			// 
			this.textBox18.Location = new System.Drawing.Point(168, 80);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(152, 21);
			this.textBox18.TabIndex = 7;
			this.textBox18.Text = "";
			// 
			// textBox19
			// 
			this.textBox19.Location = new System.Drawing.Point(168, 120);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(152, 21);
			this.textBox19.TabIndex = 8;
			this.textBox19.Text = "";
			// 
			// textBox20
			// 
			this.textBox20.Location = new System.Drawing.Point(168, 160);
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new System.Drawing.Size(152, 21);
			this.textBox20.TabIndex = 9;
			this.textBox20.Text = "";
			// 
			// textBox21
			// 
			this.textBox21.Location = new System.Drawing.Point(168, 200);
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new System.Drawing.Size(152, 21);
			this.textBox21.TabIndex = 10;
			this.textBox21.Text = "";
			this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
			// 
			// textBox22
			// 
			this.textBox22.Location = new System.Drawing.Point(488, 120);
			this.textBox22.Name = "textBox22";
			this.textBox22.Size = new System.Drawing.Size(184, 21);
			this.textBox22.TabIndex = 16;
			this.textBox22.Text = "";
			// 
			// textBox23
			// 
			this.textBox23.Location = new System.Drawing.Point(488, 80);
			this.textBox23.Name = "textBox23";
			this.textBox23.Size = new System.Drawing.Size(184, 21);
			this.textBox23.TabIndex = 15;
			this.textBox23.Text = "";
			// 
			// textBox24
			// 
			this.textBox24.Location = new System.Drawing.Point(488, 40);
			this.textBox24.Name = "textBox24";
			this.textBox24.Size = new System.Drawing.Size(184, 21);
			this.textBox24.TabIndex = 14;
			this.textBox24.Text = "";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(344, 128);
			this.label18.Name = "label18";
			this.label18.TabIndex = 13;
			this.label18.Text = "Loss Factor";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(344, 88);
			this.label19.Name = "label19";
			this.label19.TabIndex = 12;
			this.label19.Text = "Poission’s Ratio";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(344, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(128, 23);
			this.label20.TabIndex = 11;
			this.label20.Text = "Young’s Modulus";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Control;
			this.button3.Location = new System.Drawing.Point(296, 272);
			this.button3.Name = "button3";
			this.button3.TabIndex = 17;
			this.button3.Text = "Ok! save";
			// 
			// ucMaterialDatabase_Addition
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pnButtom_Single);
			this.Controls.Add(this.pnTop_Single);
			this.Controls.Add(this.pnTop_Multi);
			this.Controls.Add(this.pnButtom_Multi);
			this.Name = "ucMaterialDatabase_Addition";
			this.Size = new System.Drawing.Size(710, 572);
			this.pnTop_Single.ResumeLayout(false);
			this.pnButtom_Multi.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.pnTop_Multi.ResumeLayout(false);
			this.pnButtom_Single.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public void ModeChange(string strSingle_Multi)
		{
			if(strSingle_Multi == "Single")
			{
				pnTop_Single.Visible = true;
				pnButtom_Single.Visible = true;

				pnTop_Multi.Visible = false;
				pnButtom_Multi.Visible = false;
			}
			else
			{
				pnTop_Multi.Visible = true;
				pnButtom_Multi.Visible = true;

				pnTop_Single.Visible = false;
				pnButtom_Single.Visible = false;				
			}
		}

		private void textBox21_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
