using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.UserControl
{
	/// <summary>
	/// ucDatainformation에 대한 요약 설명입니다.
	/// </summary>
	public class ucDatainformation : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton rdoSingle;
		private System.Windows.Forms.RadioButton rdoMulti;
		private System.Windows.Forms.Panel pnSingle;
		private System.Windows.Forms.Panel pnMulti;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Button button2;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public event MySelectedChange RadioButtonChange;

		public ucDatainformation()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoSingle = new System.Windows.Forms.RadioButton();
			this.rdoMulti = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pnSingle = new System.Windows.Forms.Panel();
			this.pnMulti = new System.Windows.Forms.Panel();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.pnSingle.SuspendLayout();
			this.pnMulti.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoMulti);
			this.groupBox1.Controls.Add(this.rdoSingle);
			this.groupBox1.Location = new System.Drawing.Point(8, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 58);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "System Category";
			// 
			// rdoSingle
			// 
			this.rdoSingle.Checked = true;
			this.rdoSingle.Location = new System.Drawing.Point(8, 24);
			this.rdoSingle.Name = "rdoSingle";
			this.rdoSingle.TabIndex = 0;
			this.rdoSingle.TabStop = true;
			this.rdoSingle.Text = "Single layer";
			this.rdoSingle.CheckedChanged += new System.EventHandler(this.rdoSingle_CheckedChanged);
			// 
			// rdoMulti
			// 
			this.rdoMulti.Location = new System.Drawing.Point(144, 24);
			this.rdoMulti.Name = "rdoMulti";
			this.rdoMulti.TabIndex = 1;
			this.rdoMulti.Text = "Multi-layer";
			this.rdoMulti.CheckedChanged += new System.EventHandler(this.rdoMulti_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 56);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Incidence Condition";
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(8, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 0;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Normal";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(144, 24);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 1;
			this.radioButton4.Text = "Random";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radioButton7);
			this.groupBox3.Controls.Add(this.radioButton6);
			this.groupBox3.Controls.Add(this.radioButton5);
			this.groupBox3.Location = new System.Drawing.Point(8, 72);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(256, 104);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Measured  Frequency";
			// 
			// radioButton5
			// 
			this.radioButton5.Location = new System.Drawing.Point(8, 48);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.TabIndex = 0;
			this.radioButton5.Text = "Octave";
			// 
			// radioButton6
			// 
			this.radioButton6.Location = new System.Drawing.Point(8, 72);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.TabIndex = 1;
			this.radioButton6.Text = "1/3 Octave";
			// 
			// radioButton7
			// 
			this.radioButton7.Checked = true;
			this.radioButton7.Location = new System.Drawing.Point(8, 24);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.TabIndex = 2;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "Narrow band";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Location = new System.Drawing.Point(8, 184);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(256, 56);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Material name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(240, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.comboBox1);
			this.groupBox5.Location = new System.Drawing.Point(8, 248);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(256, 56);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Material Type";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.comboBox2);
			this.groupBox6.Location = new System.Drawing.Point(8, 312);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(256, 56);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Acoustical performance";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(8, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(240, 20);
			this.comboBox1.TabIndex = 0;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Location = new System.Drawing.Point(8, 24);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(240, 20);
			this.comboBox2.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(8, 376);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(256, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Open the measured data";
			// 
			// pnSingle
			// 
			this.pnSingle.Controls.Add(this.groupBox2);
			this.pnSingle.Controls.Add(this.groupBox5);
			this.pnSingle.Controls.Add(this.groupBox6);
			this.pnSingle.Controls.Add(this.groupBox3);
			this.pnSingle.Controls.Add(this.groupBox4);
			this.pnSingle.Controls.Add(this.button1);
			this.pnSingle.Location = new System.Drawing.Point(0, 80);
			this.pnSingle.Name = "pnSingle";
			this.pnSingle.Size = new System.Drawing.Size(272, 408);
			this.pnSingle.TabIndex = 7;
			// 
			// pnMulti
			// 
			this.pnMulti.Controls.Add(this.groupBox9);
			this.pnMulti.Controls.Add(this.groupBox8);
			this.pnMulti.Controls.Add(this.groupBox7);
			this.pnMulti.Location = new System.Drawing.Point(0, 80);
			this.pnMulti.Name = "pnMulti";
			this.pnMulti.Size = new System.Drawing.Size(272, 408);
			this.pnMulti.TabIndex = 8;
			this.pnMulti.Visible = false;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.textBox2);
			this.groupBox7.Location = new System.Drawing.Point(8, 8);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(256, 56);
			this.groupBox7.TabIndex = 0;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "System Name";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(8, 24);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(240, 21);
			this.textBox2.TabIndex = 0;
			this.textBox2.Text = "";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.textBox3);
			this.groupBox8.Location = new System.Drawing.Point(8, 72);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(256, 56);
			this.groupBox8.TabIndex = 1;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Total thickness";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(8, 24);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(240, 21);
			this.textBox3.TabIndex = 0;
			this.textBox3.Text = "";
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.button2);
			this.groupBox9.Controls.Add(this.groupBox12);
			this.groupBox9.Controls.Add(this.groupBox11);
			this.groupBox9.Controls.Add(this.groupBox10);
			this.groupBox9.Location = new System.Drawing.Point(8, 136);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(256, 264);
			this.groupBox9.TabIndex = 2;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Layer info";
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.textBox4);
			this.groupBox10.Location = new System.Drawing.Point(8, 24);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(240, 56);
			this.groupBox10.TabIndex = 0;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Material Name";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(8, 24);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(224, 21);
			this.textBox4.TabIndex = 0;
			this.textBox4.Text = "";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.comboBox3);
			this.groupBox11.Location = new System.Drawing.Point(8, 88);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(240, 56);
			this.groupBox11.TabIndex = 1;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Material Type";
			// 
			// comboBox3
			// 
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.Location = new System.Drawing.Point(8, 24);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(224, 20);
			this.comboBox3.TabIndex = 0;
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.comboBox4);
			this.groupBox12.Location = new System.Drawing.Point(8, 152);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(240, 48);
			this.groupBox12.TabIndex = 2;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Density";
			// 
			// comboBox4
			// 
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.Location = new System.Drawing.Point(8, 22);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(224, 20);
			this.comboBox4.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.Location = new System.Drawing.Point(88, 208);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "Add";
			// 
			// ucDatainformation
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pnSingle);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pnMulti);
			this.Name = "ucDatainformation";
			this.Size = new System.Drawing.Size(274, 572);
			this.Load += new System.EventHandler(this.ucDatainformation_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.pnSingle.ResumeLayout(false);
			this.pnMulti.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ucDatainformation_Load(object sender, System.EventArgs e)
		{
		
		}

		private void rdoMulti_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoMulti.Checked)
			{
				pnSingle.Visible = false;
				pnMulti.Visible = true;

				RadioButtonChange("Multi");
			}
		}

		private void rdoSingle_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoSingle.Checked)
			{
				pnSingle.Visible = true;
				pnMulti.Visible = false;

				RadioButtonChange("Single");
			}
		}
	}
}
