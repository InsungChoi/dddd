using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using HONUS.MaterialPerformanceAnalysis.Form;
using HONUS.Common_Class;

namespace HONUS.MaterialPerformanceAnalysis.UserControl
{
	/// <summary>
	/// ucAnalysisSetup에 대한 요약 설명입니다.
	/// </summary>
	public class ucAnalysisSetup : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAnalysis;
		private System.Windows.Forms.LinkLabel lnkLayerInformation;
		private System.Windows.Forms.RadioButton rdoSingle;
		private System.Windows.Forms.RadioButton rdoMulti;
		private System.Windows.Forms.TextBox edtTemperature;
		private System.Windows.Forms.TextBox edtLimitAngle;
		private System.Windows.Forms.RadioButton rdoRandomIncidence;
		private System.Windows.Forms.RadioButton rdoNormalIncidence;
		private System.Windows.Forms.RadioButton rdoOctave3_1;
		private System.Windows.Forms.RadioButton rdoOctave;
		private System.Windows.Forms.RadioButton rdoNarrow_band;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button btnSave;

		public delegate void MyButtonClickedDelegate(string strName,string strAddition);
		public event MyButtonClickedDelegate MyButtonClickedEvent;

		public MPALayer MPALayer1_Single;
		public MPALayer MPALayer1_Multi;

		public ucAnalysisSetup()
		{
			// 이 호출은 Windows.Forms Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			//MPALayer1 = new MPALayer();
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

		public void SaveButtonEnable(bool bEnable)
		{
			btnSave.Enabled = bEnable;
		}

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.edtTemperature = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rdoSingle = new System.Windows.Forms.RadioButton();
			this.rdoMulti = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.edtLimitAngle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rdoRandomIncidence = new System.Windows.Forms.RadioButton();
			this.rdoNormalIncidence = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdoOctave3_1 = new System.Windows.Forms.RadioButton();
			this.rdoOctave = new System.Windows.Forms.RadioButton();
			this.rdoNarrow_band = new System.Windows.Forms.RadioButton();
			this.btnAnalysis = new System.Windows.Forms.Button();
			this.lnkLayerInformation = new System.Windows.Forms.LinkLabel();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// edtTemperature
			// 
			this.edtTemperature.Location = new System.Drawing.Point(128, 19);
			this.edtTemperature.Name = "edtTemperature";
			this.edtTemperature.TabIndex = 3;
			this.edtTemperature.Text = "20";
			this.edtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Temperature";
			// 
			// rdoSingle
			// 
			this.rdoSingle.Checked = true;
			this.rdoSingle.Location = new System.Drawing.Point(8, 56);
			this.rdoSingle.Name = "rdoSingle";
			this.rdoSingle.TabIndex = 4;
			this.rdoSingle.TabStop = true;
			this.rdoSingle.Text = "Single Layer";
			// 
			// rdoMulti
			// 
			this.rdoMulti.Location = new System.Drawing.Point(160, 56);
			this.rdoMulti.Name = "rdoMulti";
			this.rdoMulti.TabIndex = 5;
			this.rdoMulti.Text = "Multi-Layer";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.edtLimitAngle);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rdoRandomIncidence);
			this.groupBox1.Controls.Add(this.rdoNormalIncidence);
			this.groupBox1.Location = new System.Drawing.Point(7, 96);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 104);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Incident Condition";
			// 
			// edtLimitAngle
			// 
			this.edtLimitAngle.Enabled = false;
			this.edtLimitAngle.Location = new System.Drawing.Point(136, 75);
			this.edtLimitAngle.Name = "edtLimitAngle";
			this.edtLimitAngle.TabIndex = 3;
			this.edtLimitAngle.Text = "72.5";
			this.edtLimitAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Limit angle";
			// 
			// rdoRandomIncidence
			// 
			this.rdoRandomIncidence.Location = new System.Drawing.Point(8, 48);
			this.rdoRandomIncidence.Name = "rdoRandomIncidence";
			this.rdoRandomIncidence.Size = new System.Drawing.Size(136, 24);
			this.rdoRandomIncidence.TabIndex = 1;
			this.rdoRandomIncidence.Text = "Random Incidence";
			// 
			// rdoNormalIncidence
			// 
			this.rdoNormalIncidence.Checked = true;
			this.rdoNormalIncidence.Location = new System.Drawing.Point(8, 24);
			this.rdoNormalIncidence.Name = "rdoNormalIncidence";
			this.rdoNormalIncidence.Size = new System.Drawing.Size(128, 24);
			this.rdoNormalIncidence.TabIndex = 0;
			this.rdoNormalIncidence.TabStop = true;
			this.rdoNormalIncidence.Text = "Normal Incidence";
			this.rdoNormalIncidence.CheckedChanged += new System.EventHandler(this.rdoNormalIncidence_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdoOctave3_1);
			this.groupBox2.Controls.Add(this.rdoOctave);
			this.groupBox2.Controls.Add(this.rdoNarrow_band);
			this.groupBox2.Location = new System.Drawing.Point(8, 208);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 100);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Analysis frequency";
			// 
			// rdoOctave3_1
			// 
			this.rdoOctave3_1.Location = new System.Drawing.Point(8, 72);
			this.rdoOctave3_1.Name = "rdoOctave3_1";
			this.rdoOctave3_1.TabIndex = 2;
			this.rdoOctave3_1.Text = "1/3 Octave";
			// 
			// rdoOctave
			// 
			this.rdoOctave.Location = new System.Drawing.Point(8, 48);
			this.rdoOctave.Name = "rdoOctave";
			this.rdoOctave.TabIndex = 1;
			this.rdoOctave.Text = "Octave";
			// 
			// rdoNarrow_band
			// 
			this.rdoNarrow_band.Checked = true;
			this.rdoNarrow_band.Location = new System.Drawing.Point(8, 24);
			this.rdoNarrow_band.Name = "rdoNarrow_band";
			this.rdoNarrow_band.TabIndex = 0;
			this.rdoNarrow_band.TabStop = true;
			this.rdoNarrow_band.Text = "Narrow-band";
			// 
			// btnAnalysis
			// 
			this.btnAnalysis.BackColor = System.Drawing.SystemColors.Control;
			this.btnAnalysis.Location = new System.Drawing.Point(24, 512);
			this.btnAnalysis.Name = "btnAnalysis";
			this.btnAnalysis.TabIndex = 9;
			this.btnAnalysis.Text = "Analysis";
			this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
			// 
			// lnkLayerInformation
			// 
			this.lnkLayerInformation.Location = new System.Drawing.Point(8, 320);
			this.lnkLayerInformation.Name = "lnkLayerInformation";
			this.lnkLayerInformation.Size = new System.Drawing.Size(136, 23);
			this.lnkLayerInformation.TabIndex = 10;
			this.lnkLayerInformation.TabStop = true;
			this.lnkLayerInformation.Text = "Layer Information";
			this.lnkLayerInformation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLayerInformation_LinkClicked);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.SystemColors.Control;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(136, 512);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "DataBase Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// ucAnalysisSetup
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lnkLayerInformation);
			this.Controls.Add(this.btnAnalysis);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.rdoMulti);
			this.Controls.Add(this.rdoSingle);
			this.Controls.Add(this.edtTemperature);
			this.Controls.Add(this.label1);
			this.Name = "ucAnalysisSetup";
			this.Size = new System.Drawing.Size(274, 572);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void lnkLayerInformation_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(rdoSingle.Checked)
			{
				dgSingleLayer dgSingleLayerDialog = new dgSingleLayer();

				if(MPALayer1_Single != null)
				{
					dgSingleLayerDialog.MPALayer1 = MPALayer1_Single;
				}

				if(DialogResult.OK == dgSingleLayerDialog.ShowDialog())
				{
					MPALayer1_Single = new MPALayer();
					MPALayer1_Single.Copy(dgSingleLayerDialog.MPALayer1);
				}
			}
			else
			{
				dgMultiLayer dgMultiLayerDialog = new dgMultiLayer();

				if(MPALayer1_Multi != null)
				{
					dgMultiLayerDialog.MPALayer1 = MPALayer1_Multi;
				}

				if(DialogResult.OK == dgMultiLayerDialog.ShowDialog())
				{
					MPALayer1_Multi = new MPALayer();
					MPALayer1_Multi.Copy(dgMultiLayerDialog.MPALayer1);
				}
			}
		}

		private void btnAnalysis_Click(object sender, System.EventArgs e)
		{
			// 증복되는 데이터일 경우 Analysis 안함 (소스 추가 요망)

			//MPALayer1.Measured;
			//MPALayer1.Temperature;
			if(rdoNormalIncidence.Checked == true)
			{
				if(MPALayer1_Single != null)
				{
					MPALayer1_Single.Incidence = 1;
					MPALayer1_Single.IncAngle = 0.0;
				}

				if(MPALayer1_Multi != null)
				{
					MPALayer1_Multi.Incidence = 1;
					MPALayer1_Multi.IncAngle = 0.0;
				}
			}
			else
			{
				if(MPALayer1_Single != null)
				{
					MPALayer1_Single.Incidence = 2;
					MPALayer1_Single.IncAngle = double.Parse(edtLimitAngle.Text);
				}

				if(MPALayer1_Multi != null)
				{
					MPALayer1_Multi.Incidence = 2;
					MPALayer1_Multi.IncAngle = double.Parse(edtLimitAngle.Text);
				}
			}
			
			if(rdoNarrow_band.Checked == true)
			{
				if(MPALayer1_Single != null)
				{
					MPALayer1_Single.FreqBand = 1;
				}

				if(MPALayer1_Multi != null)
				{

					MPALayer1_Multi.FreqBand = 1;
				}
			}
			else if(rdoOctave.Checked == true)
			{
				if(MPALayer1_Single != null)
				{
					MPALayer1_Single.FreqBand = 2;
				}

				if(MPALayer1_Multi != null)
				{


					MPALayer1_Multi.FreqBand = 2;
				}
			}
			else
			{
				if(MPALayer1_Single != null)
				{
					MPALayer1_Single.FreqBand = 3;
				}

				if(MPALayer1_Multi != null)
				{
					MPALayer1_Multi.FreqBand = 3;
				}
			}

			if(MPALayer1_Single != null)
			{
				MPALayer1_Single.Temperature = double.Parse(edtTemperature.Text);
			}
			if(MPALayer1_Multi != null)
			{
				MPALayer1_Multi.Temperature = double.Parse(edtTemperature.Text);
			}
			
			//MPALayer1.GraphType;
			//MPALayer1.limitfreq;
			
			MyButtonClickedEvent("Analysis","");
		}

		public int GetFreqBand()
		{
			if(rdoNarrow_band.Checked == true)
			{
				return 0;
			}
			else if(rdoOctave.Checked == true)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}

		private void rdoNormalIncidence_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoNormalIncidence.Checked == true)
			{
				edtLimitAngle.Enabled = false;
			}
			else
			{
				edtLimitAngle.Enabled = true;
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(rdoSingle.Checked)
			{
				if(MPALayer1_Single != null)
				{
					MPALayer1_Single.DBSave_Single();
				}
			}
			else
			{
				if(MPALayer1_Multi != null)
				{
					MPALayer1_Multi.DBSave_Multi();
				}
			}

			MessageBox.Show("저장되었습니다.","저장");
		}

		public bool IsSingle()
		{
			if(rdoSingle.Checked)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
