using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using HONUS.MaterialPropertiesEstimation.Component;
using HONUS.MaterialDatabase.Component;

namespace HONUS.MaterialDatabase.UserControl
{
	/// <summary>
	/// ucSearchingCondition에 대한 요약 설명입니다.
	/// </summary>
	public class ucSearchingCondition : System.Windows.Forms.UserControl
	{
		public int dMeasured = 1;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		public System.Windows.Forms.RadioButton rdoMultiLayer;
		public System.Windows.Forms.RadioButton rdoSingleLayer;
		private System.Windows.Forms.RadioButton rdoRandom;
		private System.Windows.Forms.RadioButton rdoNormal;
		private System.Windows.Forms.ComboBox cboMaterialType;
		private System.Windows.Forms.ComboBox cboSearchingOption;
		private System.Windows.Forms.RadioButton rdoOctave_3_1;
		private System.Windows.Forms.RadioButton rdoOctave;
		private System.Windows.Forms.Button btnSearch;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public delegate void MyButtonClickedDelegate(string strName,string strAddition);
		public event MyButtonClickedDelegate MyButtonClickedEvent;

		DataSet MaterialTypeds;

		public HONUS.MaterialDatabase.Form.clsAbsorptionCoefficient_Find clsAbsorptionCoefficient_Find_RB;
		public HONUS.MaterialDatabase.Form.clsAbsorptionCoefficient_Find clsAbsorptionCoefficient_Find_AT;
		public HONUS.MaterialDatabase.Form.clsAbsorptionCoefficient_Find clsAbsorptionCoefficient_Find_TL;
		public HONUS.MaterialDatabase.Form.clsAbsorptionCoefficient_FindDetail clsAbsorptionCoefficient_Find_RBDetail;
		public HONUS.MaterialDatabase.Form.clsAbsorptionCoefficient_FindDetail clsAbsorptionCoefficient_Find_ATDetail;
		public HONUS.MaterialDatabase.Form.clsAbsorptionCoefficient_FindDetail clsAbsorptionCoefficient_Find_TLDetail;

		public HONUS.MaterialDatabase.Form.clsParameters clsParameters1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TextBox edtProducing;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox edtVendor;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dtDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlAfterSearch;
		private System.Windows.Forms.Button btnResearch;
		private System.Windows.Forms.DateTimePicker dtDate2;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.RadioButton rdoMeasured;
		private System.Windows.Forms.RadioButton rdoPredicted;
		public HONUS.MaterialDatabase.Form.clsMultiLayer_Find clsMultiLayer_Find1;

		public ucSearchingCondition()
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

		private void cboMaterialType_Bind()
		{
//			cboMaterialType.Items.Add("Panel");
//			cboMaterialType.Items.Add("Impermeable membrane");
//			cboMaterialType.Items.Add("Permeable membrane");
//			cboMaterialType.Items.Add("Limp porous material");
//			cboMaterialType.Items.Add("Rigid porous material");
//			cboMaterialType.Items.Add("Elastic porous material");
//			cboMaterialType.Items.Add("Panel-Elastic (BU)");
//			cboMaterialType.Items.Add("Elastic-Panel (UB)");
//			cboMaterialType.Items.Add("Panel-Elastic-Panel (BB)");
//
//			cboMaterialType.SelectedIndex = 0;

			cboMaterialType.Items.Clear();

			MPE_DB MPE_DB1 = new MPE_DB();
			MaterialTypeds = MPE_DB1.GetMaterialType(0);

			//			cboMeterialType.DataSource = ds;
			//			cboMeterialType.DisplayMember = "MatType";
			//			cboMeterialType.ValueMember = "MID";

			MaterialType MaterialType1 = new MaterialType();
			MaterialType1.Name = "ALL";
			MaterialType1.ID = "0";
			cboMaterialType.Items.Add(MaterialType1.Name);

			for(int i = 0 ; i < MaterialTypeds.Tables[0].Rows.Count ; i++)
			{
				MaterialType1 = new MaterialType();
				MaterialType1.Name = MaterialTypeds.Tables[0].Rows[i]["MatType"].ToString();
				MaterialType1.ID = MaterialTypeds.Tables[0].Rows[i]["MID"].ToString();

				cboMaterialType.Items.Add(MaterialType1.Name);
			}

			cboMaterialType.SelectedIndex = 0;
		}

		private void cboSearchingOption_Bind()
		{
			cboSearchingOption.Items.Add("Select");
			cboSearchingOption.Items.Add("Absorption coefficient-rigid backing");
			cboSearchingOption.Items.Add("Absorption coefficient-anechoic termination");
			cboSearchingOption.Items.Add("Transmission Loss");
			cboSearchingOption.Items.Add("Parameters");

			cboSearchingOption.SelectedIndex = 0;
		}

		public string GetcboMeterialType_ID()
		{
			if(cboMaterialType.SelectedItem.ToString() == "ALL")
			{
				return "0";
			}
			else
			{
				return MaterialTypeds.Tables[0].Rows[cboMaterialType.SelectedIndex - 1]["MID"].ToString();
			}
		}

		public string GetCategory()
		{
			string strResult = "";
			if(rdoSingleLayer.Checked)
			{
				strResult = "Single";
			}
			else
			{
				strResult = "Multy";
			}

			return strResult;
		}
		
		public string GetIncidence()
		{
			string strResult = "";
			if(rdoNormal.Checked)
			{
				strResult = "1";
			}
			else
			{
				strResult = "2";
			}

			return strResult;
		}
		
		public string GetOption()
		{
			string strResult = "";

			strResult = cboSearchingOption.SelectedItem.ToString();

			return strResult;
		}
		
		public string GetFrequency()
		{
			string strResult = "";
			if(rdoOctave.Checked)
			{
				strResult = "2";
			}
			else
			{
				strResult = "3";
			}

			return strResult;
		}

		public string ctVendor
		{
			get
			{
				return edtVendor.Text;
			}
			set
			{
				edtVendor.Text = value;
			}
		}

		public string ctProducing
		{
			get
			{
				return edtProducing.Text;
			}
			set
			{
				edtProducing.Text = value;
			}
		}

		public string ctDate
		{
			get
			{
				return dtDate.Value.ToString("yyyy-MM-dd");
			}
			set
			{
				dtDate.Value = DateTime.Parse(value);
			}
		}

		public string ctDate2
		{
			get
			{
				return dtDate2.Value.ToString("yyyy-MM-dd");
			}
			set
			{
				dtDate2.Value = DateTime.Parse(value);
			}
		}

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoMultiLayer = new System.Windows.Forms.RadioButton();
			this.rdoSingleLayer = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdoRandom = new System.Windows.Forms.RadioButton();
			this.rdoNormal = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cboMaterialType = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cboSearchingOption = new System.Windows.Forms.ComboBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rdoOctave_3_1 = new System.Windows.Forms.RadioButton();
			this.rdoOctave = new System.Windows.Forms.RadioButton();
			this.btnSearch = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnResearch = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.edtProducing = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.edtVendor = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.dtDate2 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlAfterSearch = new System.Windows.Forms.Panel();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.rdoMeasured = new System.Windows.Forms.RadioButton();
			this.rdoPredicted = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlAfterSearch.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoMultiLayer);
			this.groupBox1.Controls.Add(this.rdoSingleLayer);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 56);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Searching Category";
			// 
			// rdoMultiLayer
			// 
			this.rdoMultiLayer.Location = new System.Drawing.Point(144, 24);
			this.rdoMultiLayer.Name = "rdoMultiLayer";
			this.rdoMultiLayer.TabIndex = 1;
			this.rdoMultiLayer.Text = "Multi Layer";
			this.rdoMultiLayer.CheckedChanged += new System.EventHandler(this.rdoMultiLayer_CheckedChanged);
			// 
			// rdoSingleLayer
			// 
			this.rdoSingleLayer.Checked = true;
			this.rdoSingleLayer.Location = new System.Drawing.Point(8, 24);
			this.rdoSingleLayer.Name = "rdoSingleLayer";
			this.rdoSingleLayer.TabIndex = 0;
			this.rdoSingleLayer.TabStop = true;
			this.rdoSingleLayer.Text = "Single layer";
			this.rdoSingleLayer.CheckedChanged += new System.EventHandler(this.rdoSingleLayer_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdoRandom);
			this.groupBox2.Controls.Add(this.rdoNormal);
			this.groupBox2.Location = new System.Drawing.Point(8, 72);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 56);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Incidence Condition";
			// 
			// rdoRandom
			// 
			this.rdoRandom.Location = new System.Drawing.Point(144, 24);
			this.rdoRandom.Name = "rdoRandom";
			this.rdoRandom.TabIndex = 1;
			this.rdoRandom.Text = "Random";
			// 
			// rdoNormal
			// 
			this.rdoNormal.Checked = true;
			this.rdoNormal.Location = new System.Drawing.Point(8, 24);
			this.rdoNormal.Name = "rdoNormal";
			this.rdoNormal.TabIndex = 0;
			this.rdoNormal.TabStop = true;
			this.rdoNormal.Text = "Normal";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cboMaterialType);
			this.groupBox3.Location = new System.Drawing.Point(8, 136);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(256, 56);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Material Type";
			// 
			// cboMaterialType
			// 
			this.cboMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaterialType.Location = new System.Drawing.Point(8, 24);
			this.cboMaterialType.Name = "cboMaterialType";
			this.cboMaterialType.Size = new System.Drawing.Size(240, 20);
			this.cboMaterialType.TabIndex = 0;
			this.cboMaterialType.SelectedIndexChanged += new System.EventHandler(this.cboMaterialType_SelectedIndexChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cboSearchingOption);
			this.groupBox4.Location = new System.Drawing.Point(8, 328);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(256, 56);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Searching Option";
			// 
			// cboSearchingOption
			// 
			this.cboSearchingOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSearchingOption.Location = new System.Drawing.Point(8, 24);
			this.cboSearchingOption.Name = "cboSearchingOption";
			this.cboSearchingOption.Size = new System.Drawing.Size(240, 20);
			this.cboSearchingOption.TabIndex = 0;
			this.cboSearchingOption.SelectedIndexChanged += new System.EventHandler(this.cboSearchingOption_SelectedIndexChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.rdoOctave_3_1);
			this.groupBox5.Controls.Add(this.rdoOctave);
			this.groupBox5.Location = new System.Drawing.Point(8, 200);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(256, 56);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Searching  Frequency";
			// 
			// rdoOctave_3_1
			// 
			this.rdoOctave_3_1.Location = new System.Drawing.Point(144, 24);
			this.rdoOctave_3_1.Name = "rdoOctave_3_1";
			this.rdoOctave_3_1.TabIndex = 1;
			this.rdoOctave_3_1.Text = "1/3 Octave";
			// 
			// rdoOctave
			// 
			this.rdoOctave.Checked = true;
			this.rdoOctave.Location = new System.Drawing.Point(8, 24);
			this.rdoOctave.Name = "rdoOctave";
			this.rdoOctave.TabIndex = 0;
			this.rdoOctave.TabStop = true;
			this.rdoOctave.Text = "Octave";
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
			this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnSearch.Location = new System.Drawing.Point(24, 0);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(74, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnResearch);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 539);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(280, 33);
			this.panel1.TabIndex = 7;
			// 
			// btnResearch
			// 
			this.btnResearch.BackColor = System.Drawing.SystemColors.Control;
			this.btnResearch.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnResearch.Location = new System.Drawing.Point(168, 0);
			this.btnResearch.Name = "btnResearch";
			this.btnResearch.Size = new System.Drawing.Size(80, 23);
			this.btnResearch.TabIndex = 7;
			this.btnResearch.Text = "Re Search";
			this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox3.Location = new System.Drawing.Point(248, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 23);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 23);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox1.Location = new System.Drawing.Point(0, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(280, 10);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// edtProducing
			// 
			this.edtProducing.Location = new System.Drawing.Point(112, 88);
			this.edtProducing.Name = "edtProducing";
			this.edtProducing.Size = new System.Drawing.Size(144, 21);
			this.edtProducing.TabIndex = 130;
			this.edtProducing.Text = "";
			this.edtProducing.Visible = false;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 88);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 23);
			this.label14.TabIndex = 129;
			this.label14.Text = "Producing :";
			this.label14.Visible = false;
			// 
			// edtVendor
			// 
			this.edtVendor.Location = new System.Drawing.Point(112, 64);
			this.edtVendor.Name = "edtVendor";
			this.edtVendor.Size = new System.Drawing.Size(144, 21);
			this.edtVendor.TabIndex = 128;
			this.edtVendor.Text = "";
			this.edtVendor.Visible = false;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 64);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 23);
			this.label13.TabIndex = 127;
			this.label13.Text = "Vendor : ";
			this.label13.Visible = false;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 23);
			this.label12.TabIndex = 126;
			this.label12.Text = "Date :";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtDate
			// 
			this.dtDate.Location = new System.Drawing.Point(8, 32);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(120, 21);
			this.dtDate.TabIndex = 125;
			// 
			// dtDate2
			// 
			this.dtDate2.Location = new System.Drawing.Point(144, 32);
			this.dtDate2.Name = "dtDate2";
			this.dtDate2.Size = new System.Drawing.Size(120, 21);
			this.dtDate2.TabIndex = 131;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(128, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 23);
			this.label1.TabIndex = 132;
			this.label1.Text = "~";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlAfterSearch
			// 
			this.pnlAfterSearch.Controls.Add(this.dtDate);
			this.pnlAfterSearch.Controls.Add(this.edtProducing);
			this.pnlAfterSearch.Controls.Add(this.label14);
			this.pnlAfterSearch.Controls.Add(this.edtVendor);
			this.pnlAfterSearch.Controls.Add(this.dtDate2);
			this.pnlAfterSearch.Controls.Add(this.label1);
			this.pnlAfterSearch.Controls.Add(this.label13);
			this.pnlAfterSearch.Controls.Add(this.label12);
			this.pnlAfterSearch.Enabled = false;
			this.pnlAfterSearch.Location = new System.Drawing.Point(0, 392);
			this.pnlAfterSearch.Name = "pnlAfterSearch";
			this.pnlAfterSearch.Size = new System.Drawing.Size(272, 112);
			this.pnlAfterSearch.TabIndex = 133;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.rdoPredicted);
			this.groupBox6.Controls.Add(this.rdoMeasured);
			this.groupBox6.Location = new System.Drawing.Point(8, 264);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(256, 56);
			this.groupBox6.TabIndex = 135;
			this.groupBox6.TabStop = false;
			// 
			// rdoMeasured
			// 
			this.rdoMeasured.Checked = true;
			this.rdoMeasured.Location = new System.Drawing.Point(8, 24);
			this.rdoMeasured.Name = "rdoMeasured";
			this.rdoMeasured.TabIndex = 0;
			this.rdoMeasured.TabStop = true;
			this.rdoMeasured.Text = "Measured";
			this.rdoMeasured.CheckedChanged += new System.EventHandler(this.rdoMeasured_CheckedChanged);
			// 
			// rdoPredicted
			// 
			this.rdoPredicted.Location = new System.Drawing.Point(144, 24);
			this.rdoPredicted.Name = "rdoPredicted";
			this.rdoPredicted.TabIndex = 1;
			this.rdoPredicted.Text = "Predicted";
			// 
			// ucSearchingCondition
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.pnlAfterSearch);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "ucSearchingCondition";
			this.Size = new System.Drawing.Size(280, 572);
			this.Load += new System.EventHandler(this.ucSearchingCondition_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.pnlAfterSearch.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ucSearchingCondition_Load(object sender, System.EventArgs e)
		{
//			cboMaterialType_Bind();
//			cboSearchingOption_Bind();
		}

		public void InitForm()
		{
			cboMaterialType_Bind();
			cboSearchingOption_Bind();
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
//			if(cboSearchingOption.SelectedItem.ToString() == "Select")
//			{
//				MessageBox.Show("SearchingOption 을 선택하여 주십시오");
//			}
//			else
//			{
			if(pnlAfterSearch.Enabled == true)
			{
				MyButtonClickedEvent("AfterSearch","");
			}
			else
			{
				pnlAfterSearch.Enabled = true;
				MyButtonClickedEvent("Search","");
			}
//			}
		}

		private void cboSearchingOption_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			HONUS.MaterialDatabase.Form.AbsorptionCoefficient_Find AbsorptionCoefficient_Find1;
			HONUS.MaterialDatabase.Form.OneThirdOctaveFind AbsorptionCoefficient_Find1Detail;

			switch(cboSearchingOption.SelectedItem.ToString())
			{
				case "Absorption coefficient-rigid backing":
					if(rdoOctave.Checked == true)
					{
						AbsorptionCoefficient_Find1 = new HONUS.MaterialDatabase.Form.AbsorptionCoefficient_Find();
						AbsorptionCoefficient_Find1.clsAbsorptionCoefficient_Find1 = clsAbsorptionCoefficient_Find_RB;
						if(AbsorptionCoefficient_Find1.ShowDialog() == DialogResult.OK)
						{
							clsAbsorptionCoefficient_Find_RB = AbsorptionCoefficient_Find1.clsAbsorptionCoefficient_Find1;
						}
					}
					else
					{
						AbsorptionCoefficient_Find1Detail = new HONUS.MaterialDatabase.Form.OneThirdOctaveFind();
						AbsorptionCoefficient_Find1Detail.clsAbsorptionCoefficient_Find1 = clsAbsorptionCoefficient_Find_RBDetail;
						if(AbsorptionCoefficient_Find1Detail.ShowDialog() == DialogResult.OK)
						{
							clsAbsorptionCoefficient_Find_RBDetail = AbsorptionCoefficient_Find1Detail.clsAbsorptionCoefficient_Find1;
						}
					}
					break;
				case "Absorption coefficient-anechoic termination":
					if(rdoOctave.Checked == true)
					{
						AbsorptionCoefficient_Find1 = new HONUS.MaterialDatabase.Form.AbsorptionCoefficient_Find();
						AbsorptionCoefficient_Find1.clsAbsorptionCoefficient_Find1 = clsAbsorptionCoefficient_Find_AT;
						if(AbsorptionCoefficient_Find1.ShowDialog() == DialogResult.OK)
						{
							clsAbsorptionCoefficient_Find_AT = AbsorptionCoefficient_Find1.clsAbsorptionCoefficient_Find1;
						}
					}
					else
					{
						AbsorptionCoefficient_Find1Detail = new HONUS.MaterialDatabase.Form.OneThirdOctaveFind();
						AbsorptionCoefficient_Find1Detail.clsAbsorptionCoefficient_Find1 = clsAbsorptionCoefficient_Find_ATDetail;
						if(AbsorptionCoefficient_Find1Detail.ShowDialog() == DialogResult.OK)
						{
							clsAbsorptionCoefficient_Find_ATDetail = AbsorptionCoefficient_Find1Detail.clsAbsorptionCoefficient_Find1;
						}
					}
					break;
				case "Transmission Loss":
					if(rdoOctave.Checked == true)
					{
						AbsorptionCoefficient_Find1 = new HONUS.MaterialDatabase.Form.AbsorptionCoefficient_Find();
						AbsorptionCoefficient_Find1.clsAbsorptionCoefficient_Find1 = clsAbsorptionCoefficient_Find_TL;
						AbsorptionCoefficient_Find1.gbAll_Enable(true);
						if(AbsorptionCoefficient_Find1.ShowDialog() == DialogResult.OK)
						{
							clsAbsorptionCoefficient_Find_TL = AbsorptionCoefficient_Find1.clsAbsorptionCoefficient_Find1;
						}
					}
					else
					{
						AbsorptionCoefficient_Find1Detail = new HONUS.MaterialDatabase.Form.OneThirdOctaveFind();
						AbsorptionCoefficient_Find1Detail.clsAbsorptionCoefficient_Find1 = clsAbsorptionCoefficient_Find_TLDetail;
						AbsorptionCoefficient_Find1Detail.gbAll_Enable(true);
						if(AbsorptionCoefficient_Find1Detail.ShowDialog() == DialogResult.OK)
						{
							clsAbsorptionCoefficient_Find_TLDetail = AbsorptionCoefficient_Find1Detail.clsAbsorptionCoefficient_Find1;
						}
					}
					break;
				case "Parameters":
					HONUS.MaterialDatabase.Form.dgParameters_Find dgParameters_Find1 = new HONUS.MaterialDatabase.Form.dgParameters_Find();
					dgParameters_Find1.clsParameters1 = clsParameters1;
					if(dgParameters_Find1.ShowDialog() == DialogResult.OK)
					{
						clsParameters1 = dgParameters_Find1.clsParameters1;
					}
					
					break;
				case "MultiLayer":
					if(rdoOctave.Checked == true)
					{
						HONUS.MaterialDatabase.Form.dgMultiLayer_Find dgMultiLayer_Find1 = new HONUS.MaterialDatabase.Form.dgMultiLayer_Find();
						dgMultiLayer_Find1.MultiLayer_Find1 = clsMultiLayer_Find1;
						if(dgMultiLayer_Find1.ShowDialog() == DialogResult.OK)
						{
							clsMultiLayer_Find1 = dgMultiLayer_Find1.MultiLayer_Find1;
						}
					}
					else
					{
						HONUS.MaterialDatabase.Form.dgMultiLayer_Find dgMultiLayer_Find1 = new HONUS.MaterialDatabase.Form.dgMultiLayer_Find();
						dgMultiLayer_Find1.MultiLayer_Find1 = clsMultiLayer_Find1;
						if(dgMultiLayer_Find1.ShowDialog() == DialogResult.OK)
						{
							clsMultiLayer_Find1 = dgMultiLayer_Find1.MultiLayer_Find1;
						}
					}
					break;
			}
		}

		private void rdoSingleLayer_CheckedChanged(object sender, System.EventArgs e)
		{
			cboSearchingOption.Items.Clear();

			if(rdoSingleLayer.Checked == true)
			{
				cboSearchingOption.Items.Add("Select");
				cboSearchingOption.Items.Add("Absorption coefficient-rigid backing");
				cboSearchingOption.Items.Add("Absorption coefficient-anechoic termination");
				cboSearchingOption.Items.Add("Transmission Loss");
				cboSearchingOption.Items.Add("Parameters");
			}
			else
			{
				cboSearchingOption.Items.Add("Select");
				cboSearchingOption.Items.Add("Absorption coefficient-rigid backing");
				cboSearchingOption.Items.Add("Absorption coefficient-anechoic termination");
				cboSearchingOption.Items.Add("Transmission Loss");
				cboSearchingOption.Items.Add("Parameters");
				cboSearchingOption.Items.Add("MultiLayer");
			}

			cboSearchingOption.SelectedIndex = 0;
		}

		private void rdoMultiLayer_CheckedChanged(object sender, System.EventArgs e)
		{
			//
		}

		private void cboMaterialType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(rdoSingleLayer.Checked == true)
			{
				MyButtonClickedEvent("MaterialTypeChange",cboMaterialType.SelectedItem.ToString());
			}
		}

		private void btnResearch_Click(object sender, System.EventArgs e)
		{
			pnlAfterSearch.Enabled = false;

			MyButtonClickedEvent("ReSearch","");
		}

		private void rdoMeasured_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rdoMeasured.Checked == true)
			{
				dMeasured = 1;
			}
			else
			{
				dMeasured = 2;
			}
		}

	}
}
