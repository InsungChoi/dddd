using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialPropertiesEstimation.Form
{
	/// <summary>
	/// dgEstimation에 대한 요약 설명입니다.
	/// </summary>
	public class dgEstimation : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label8;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public dgEstimation()
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Num";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label2.Location = new System.Drawing.Point(56, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Thickness";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label3.Location = new System.Drawing.Point(176, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Name";
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(8, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "1";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(55, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(72, 21);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(136, 32);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 21);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(304, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Load";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.Location = new System.Drawing.Point(304, 62);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Load";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(136, 62);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 21);
			this.textBox3.TabIndex = 9;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(55, 62);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(72, 21);
			this.textBox4.TabIndex = 8;
			this.textBox4.Text = "";
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(8, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 24);
			this.label5.TabIndex = 7;
			this.label5.Text = "2";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Control;
			this.button3.Location = new System.Drawing.Point(304, 92);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "Load";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(136, 92);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(160, 21);
			this.textBox5.TabIndex = 13;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(55, 92);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(72, 21);
			this.textBox6.TabIndex = 12;
			this.textBox6.Text = "";
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(8, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 24);
			this.label6.TabIndex = 11;
			this.label6.Text = "3";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.Control;
			this.button4.Location = new System.Drawing.Point(304, 122);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(48, 23);
			this.button4.TabIndex = 18;
			this.button4.Text = "Load";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(136, 122);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(160, 21);
			this.textBox7.TabIndex = 17;
			this.textBox7.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(55, 122);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(72, 21);
			this.textBox8.TabIndex = 16;
			this.textBox8.Text = "";
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(8, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 24);
			this.label7.TabIndex = 15;
			this.label7.Text = "4";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.Control;
			this.button5.Location = new System.Drawing.Point(304, 152);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 23);
			this.button5.TabIndex = 22;
			this.button5.Text = "Load";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(136, 152);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(160, 21);
			this.textBox9.TabIndex = 21;
			this.textBox9.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(55, 152);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(72, 21);
			this.textBox10.TabIndex = 20;
			this.textBox10.Text = "";
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(8, 152);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 24);
			this.label8.TabIndex = 19;
			this.label8.Text = "5";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgEstimation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(354, 186);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dgEstimation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "dgEstimation";
			this.Load += new System.EventHandler(this.dgEstimation_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void dgEstimation_Load(object sender, System.EventArgs e)
		{
			
		}
	}
}
