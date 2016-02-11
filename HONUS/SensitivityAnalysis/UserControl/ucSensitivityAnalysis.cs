using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using HONUS.Common_Class;

namespace HONUS.SensitivityAnalysis.UserControl
{
	/// <summary>
	/// ucSensitivityAnalysis에 대한 요약 설명입니다.
	/// </summary>
	public class ucSensitivityAnalysis : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.TextBox edtStep;
		private System.Windows.Forms.Button btnStepOK;
		private System.Windows.Forms.TextBox edtTo;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.TextBox edtParameter;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox edtRemark;
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SAClass SAClass1;
		public string strPerformance;
		public string strSelectedMaterialType;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbAdjustmentRange;
		private System.Windows.Forms.Panel pnlParameter;
		private System.Windows.Forms.Button btnSave;
		public string strSelectedMaterialValue;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Button btnGraphSave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Button btnEditCancel;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.Button btnGraphEdit;
		private DataPlotter.Plotter plotter1;

		DataPlotter.DataSeries pSeries_Prev;
		/// <summary>
		/// Material 을 생성할지 말지를 판정(DB에서 로드했으면 안하고 false 사용자 입력일 경우 생성 true)
		/// </summary>
		public bool IsMaterialCreate = false;

		public ucSensitivityAnalysis()
		{
			// 이 호출은 Windows.Forms Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			strPerformance = "";

			//NullGraph();
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
			this.gbAdjustmentRange = new System.Windows.Forms.GroupBox();
			this.edtStep = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnStepOK = new System.Windows.Forms.Button();
			this.edtTo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtParameter = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pnlParameter = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.edtRemark = new System.Windows.Forms.TextBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.btnGraphSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnGraphEdit = new System.Windows.Forms.Button();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.btnEditCancel = new System.Windows.Forms.Button();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.plotter1 = new DataPlotter.Plotter();
			this.gbAdjustmentRange.SuspendLayout();
			this.pnlParameter.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbAdjustmentRange
			// 
			this.gbAdjustmentRange.Controls.Add(this.edtStep);
			this.gbAdjustmentRange.Controls.Add(this.label5);
			this.gbAdjustmentRange.Controls.Add(this.btnStepOK);
			this.gbAdjustmentRange.Controls.Add(this.edtTo);
			this.gbAdjustmentRange.Controls.Add(this.label2);
			this.gbAdjustmentRange.Controls.Add(this.edtFrom);
			this.gbAdjustmentRange.Controls.Add(this.label1);
			this.gbAdjustmentRange.Controls.Add(this.pictureBox7);
			this.gbAdjustmentRange.Controls.Add(this.pictureBox8);
			this.gbAdjustmentRange.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gbAdjustmentRange.Enabled = false;
			this.gbAdjustmentRange.Location = new System.Drawing.Point(10, 433);
			this.gbAdjustmentRange.Name = "gbAdjustmentRange";
			this.gbAdjustmentRange.Size = new System.Drawing.Size(690, 63);
			this.gbAdjustmentRange.TabIndex = 6;
			this.gbAdjustmentRange.TabStop = false;
			this.gbAdjustmentRange.Text = "Adjustment range";
			// 
			// edtStep
			// 
			this.edtStep.Location = new System.Drawing.Point(496, 32);
			this.edtStep.Name = "edtStep";
			this.edtStep.Size = new System.Drawing.Size(96, 21);
			this.edtStep.TabIndex = 3;
			this.edtStep.Text = "";
			this.edtStep.TextChanged += new System.EventHandler(this.edtFrom_TextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(448, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Step";
			// 
			// btnStepOK
			// 
			this.btnStepOK.BackColor = System.Drawing.SystemColors.Control;
			this.btnStepOK.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnStepOK.Location = new System.Drawing.Point(631, 27);
			this.btnStepOK.Name = "btnStepOK";
			this.btnStepOK.Size = new System.Drawing.Size(56, 23);
			this.btnStepOK.TabIndex = 4;
			this.btnStepOK.Text = "OK";
			this.btnStepOK.Click += new System.EventHandler(this.btnStepOK_Click);
			// 
			// edtTo
			// 
			this.edtTo.Location = new System.Drawing.Point(288, 32);
			this.edtTo.Name = "edtTo";
			this.edtTo.Size = new System.Drawing.Size(136, 21);
			this.edtTo.TabIndex = 2;
			this.edtTo.Text = "";
			this.edtTo.TextChanged += new System.EventHandler(this.edtFrom_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(264, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "to";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(80, 32);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.Size = new System.Drawing.Size(168, 21);
			this.edtFrom.TabIndex = 1;
			this.edtFrom.Text = "";
			this.edtFrom.TextChanged += new System.EventHandler(this.edtFrom_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "from";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox7.Location = new System.Drawing.Point(3, 17);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(684, 10);
			this.pictureBox7.TabIndex = 7;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox8.Location = new System.Drawing.Point(3, 50);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(684, 10);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "New parameter value";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtParameter
			// 
			this.edtParameter.Location = new System.Drawing.Point(144, 13);
			this.edtParameter.Name = "edtParameter";
			this.edtParameter.Size = new System.Drawing.Size(200, 21);
			this.edtParameter.TabIndex = 8;
			this.edtParameter.Text = "";
			this.edtParameter.TextChanged += new System.EventHandler(this.edtFrom_TextChanged);
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.SystemColors.Control;
			this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnOK.Location = new System.Drawing.Point(634, 10);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(56, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(710, 10);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox2.Location = new System.Drawing.Point(0, 10);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(10, 562);
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox3.Location = new System.Drawing.Point(700, 10);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 562);
			this.pictureBox3.TabIndex = 13;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox4.Location = new System.Drawing.Point(10, 562);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(690, 10);
			this.pictureBox4.TabIndex = 14;
			this.pictureBox4.TabStop = false;
			// 
			// pnlParameter
			// 
			this.pnlParameter.Controls.Add(this.label4);
			this.pnlParameter.Controls.Add(this.edtRemark);
			this.pnlParameter.Controls.Add(this.btnOK);
			this.pnlParameter.Controls.Add(this.pictureBox6);
			this.pnlParameter.Controls.Add(this.pictureBox5);
			this.pnlParameter.Controls.Add(this.label3);
			this.pnlParameter.Controls.Add(this.edtParameter);
			this.pnlParameter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlParameter.Enabled = false;
			this.pnlParameter.Location = new System.Drawing.Point(10, 496);
			this.pnlParameter.Name = "pnlParameter";
			this.pnlParameter.Size = new System.Drawing.Size(690, 43);
			this.pnlParameter.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(368, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "ReMark";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtRemark
			// 
			this.edtRemark.Location = new System.Drawing.Point(424, 13);
			this.edtRemark.Name = "edtRemark";
			this.edtRemark.Size = new System.Drawing.Size(176, 21);
			this.edtRemark.TabIndex = 11;
			this.edtRemark.Text = "";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox6.Location = new System.Drawing.Point(0, 33);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(690, 10);
			this.pictureBox6.TabIndex = 1;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox5.Location = new System.Drawing.Point(0, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(690, 10);
			this.pictureBox5.TabIndex = 0;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox9.Location = new System.Drawing.Point(10, 423);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(690, 10);
			this.pictureBox9.TabIndex = 17;
			this.pictureBox9.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(10, 539);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(690, 23);
			this.panel1.TabIndex = 15;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.SystemColors.Control;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(570, 0);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 23);
			this.btnSave.TabIndex = 21;
			this.btnSave.Text = "DataBase Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(488, 10);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.SelectedObject = this.plotter1;
			this.propertyGrid1.Size = new System.Drawing.Size(212, 413);
			this.propertyGrid1.TabIndex = 18;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.propertyGrid1.Visible = false;
			this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
			// 
			// btnGraphSave
			// 
			this.btnGraphSave.BackColor = System.Drawing.SystemColors.Control;
			this.btnGraphSave.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnGraphSave.Location = new System.Drawing.Point(0, 0);
			this.btnGraphSave.Name = "btnGraphSave";
			this.btnGraphSave.Size = new System.Drawing.Size(144, 23);
			this.btnGraphSave.TabIndex = 20;
			this.btnGraphSave.Text = "Graph Save";
			this.btnGraphSave.Click += new System.EventHandler(this.btnGraphSave_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnGraphEdit);
			this.panel2.Controls.Add(this.pictureBox11);
			this.panel2.Controls.Add(this.btnEditCancel);
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Controls.Add(this.btnGraphSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(10, 400);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(478, 23);
			this.panel2.TabIndex = 21;
			// 
			// btnGraphEdit
			// 
			this.btnGraphEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnGraphEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnGraphEdit.Location = new System.Drawing.Point(154, 0);
			this.btnGraphEdit.Name = "btnGraphEdit";
			this.btnGraphEdit.Size = new System.Drawing.Size(186, 23);
			this.btnGraphEdit.TabIndex = 24;
			this.btnGraphEdit.Text = "Graph Edit";
			this.btnGraphEdit.Click += new System.EventHandler(this.btnGraphEdit_Click);
			// 
			// pictureBox11
			// 
			this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox11.Location = new System.Drawing.Point(340, 0);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(10, 23);
			this.pictureBox11.TabIndex = 23;
			this.pictureBox11.TabStop = false;
			// 
			// btnEditCancel
			// 
			this.btnEditCancel.BackColor = System.Drawing.SystemColors.Control;
			this.btnEditCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnEditCancel.Enabled = false;
			this.btnEditCancel.Location = new System.Drawing.Point(350, 0);
			this.btnEditCancel.Name = "btnEditCancel";
			this.btnEditCancel.Size = new System.Drawing.Size(128, 23);
			this.btnEditCancel.TabIndex = 22;
			this.btnEditCancel.Text = "Edit Cancel";
			this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
			// 
			// pictureBox10
			// 
			this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox10.Location = new System.Drawing.Point(144, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(10, 23);
			this.pictureBox10.TabIndex = 21;
			this.pictureBox10.TabStop = false;
			// 
			// plotter1
			// 
			this.plotter1.BorderBottom = 50;
			this.plotter1.BorderLeft = 50;
			this.plotter1.BorderRight = 30;
			this.plotter1.BorderTop = 30;
			this.plotter1.ColorAxis = System.Drawing.Color.Black;
			this.plotter1.ColorBg = System.Drawing.Color.White;
			this.plotter1.ColorDraw = System.Drawing.Color.DarkBlue;
			this.plotter1.ColorGrid = System.Drawing.Color.LightGray;
			this.plotter1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plotter1.DrawMode = DataPlotter.Plotter.DrawModeType.Line;
			this.plotter1.FontAxis = new System.Drawing.Font("Arial", 8F);
			this.plotter1.FontLabel = new System.Drawing.Font("굴림", 9F);
			this.plotter1.FontTitle = new System.Drawing.Font("굴림", 9F);
			this.plotter1.Interval = 0;
			this.plotter1.IsOctave = false;
			this.plotter1.Location = new System.Drawing.Point(10, 10);
			this.plotter1.MarkerSize = 4;
			this.plotter1.MarkerType = DataPlotter.Plotter.MarkerModeType.None;
			this.plotter1.Name = "plotter1";
			this.plotter1.PenWidth = 1;
			this.plotter1.ShowGrid = true;
			this.plotter1.ShowLegend = false;
			this.plotter1.Size = new System.Drawing.Size(478, 390);
			this.plotter1.TabIndex = 22;
			this.plotter1.Title = "Plotter Example";
			this.plotter1.TitleColor = System.Drawing.Color.Black;
			this.plotter1.XAxisMode = DataPlotter.Plotter.XAxisModeType.Linear;
			this.plotter1.XGrid = 10;
			this.plotter1.XLabel = "X Axis";
			this.plotter1.XLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter1.XRangeEnd = 100;
			this.plotter1.XRangeStart = 0;
			this.plotter1.YAxisMode = DataPlotter.Plotter.YAxisModeType.Linear;
			this.plotter1.YGrid = 10;
			this.plotter1.YLabel = "Y Axis";
			this.plotter1.YLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter1.YRangeEnd = 100;
			this.plotter1.YRangeStart = 0;
			this.plotter1.ZAxisMode = DataPlotter.Plotter.ZAxisModeType.Linear;
			this.plotter1.ZLabel = "Z Axis";
			this.plotter1.ZLabelColor = System.Drawing.Color.DarkBlue;
			this.plotter1.ZRangeEnd = 100;
			this.plotter1.ZRangeStart = 0;
			// 
			// ucSensitivityAnalysis
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.plotter1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.gbAdjustmentRange);
			this.Controls.Add(this.pnlParameter);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ucSensitivityAnalysis";
			this.Size = new System.Drawing.Size(710, 572);
			this.Load += new System.EventHandler(this.ucSensitivityAnalysis_Load);
			this.gbAdjustmentRange.ResumeLayout(false);
			this.pnlParameter.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ucSensitivityAnalysis_Load(object sender, System.EventArgs e)
		{
			//GraphDraw();
		}

		public void GraphDraw()
		{
			DataPlotter.DataSeries pSeries1 = new DataPlotter.DataSeries();

			///plotter1.ColorBg = Color.LightYellow;
			plotter1.ColorGrid = Color.LightGray;
			//plotter1.XLogBase = 0;
			plotter1.XRangeStart = 0;
			plotter1.XRangeEnd = 8000;
			plotter1.XGrid = 1000;
			//plotter1.YLogBase = 0;
			plotter1.YRangeStart = 0;
			plotter1.YRangeEnd = 1;
			plotter1.YGrid = 0.2;
			plotter1.Series.Clear();

			pSeries1.Name  = "Data 01";
			pSeries1.Color = Color.Blue ;

			plotter1.bIsColorMap = false;

			bool DataExist = false;

			if(SAClass1 != null)
			{
				#region 예전
//				object [] ar = new object[3];
//
//				DataTable table = new DataTable();
//
//				table.Columns.Add("GroupName",typeof(int));
//				table.Columns.Add("my_X",typeof(double));
//				table.Columns.Add("my_Y",typeof(double));
				
//				for(int i = 0 ; i < SAClass1.Frequency.GetCount() ; i++)
//				{
//					DataRow row = table.NewRow();
//					ar[0] = i.ToString();
//					ar[1] = SAClass1.Frequency.GetData(i).ToString();
//					try 
//					{
//						ar[2] = double.Parse(SAClass1.Igraph.GetData(i).ToString());
//						if (ar[2].ToString() == "NaN") ar[2]=0;
//					} 
//					catch
//					{
//						ar[2] = 0;
//					}
//					row.ItemArray = ar;
//					table.Rows.Add(row);
//
//					DataExist = true;
//				}
				#endregion

				DataExist = true;

				pSeries1.XData = SAClass1.Frequency.GetData();
				pSeries1.YData = SAClass1.Igraph.GetData();

				switch(SAClass1.GraphType)
				{
					case 1 :
						plotter1.YLabel = "Transmission Loss [dB]";
						plotter1.XLabel = "Frequency [Hz]";
						break;
					case 2 :
						plotter1.YLabel = "Absorption Coefficient for Rigid Backing";
						plotter1.XLabel = "Frequency [Hz]";
						break;
					case 3 :
						plotter1.YLabel = "Absotpyion Coefficient for Anechoic termiation";
						plotter1.XLabel = "Frequency [Hz]";
						break;
				}

				if(DataExist == true)
				{
					#region 예전
//					ultraChart1.DataSource = table;
//					ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
//					ultraChart1.ScatterChart.ConnectWithLines = true;
					#endregion

					plotter1.Series.Clear();
					plotter1.Series.Add(pSeries1);
					pSeries_Prev = pSeries1;
					//plotter1.IsOctave = true;
					plotter1.Refresh();
				}
//				else
//				{
//					NullGraph();
//				}
			}
//			else
//			{
//				NullGraph();
//			}
		}

//		private void NullGraph()
//		{
//			object [] ar = new object[3];
//		
//			DataTable table = new DataTable();
//		
//			table.Columns.Add("GroupName",typeof(int));
//			table.Columns.Add("my_X",typeof(int));
//			table.Columns.Add("my_Y",typeof(int));
//		
//			DataRow row = table.NewRow();
//			ar[0] = "1";
//			ar[1] = 0;
//			ar[2] = 0;
//			row.ItemArray = ar;
//			table.Rows.Add(row);
//
//			ultraChart1.DataSource = table;
//			ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
//			ultraChart1.ScatterChart.ConnectWithLines = true;
//		}


		public void GraphDraw_Step()
		{
			DataPlotter.DataSeries pSeries1;

			//plotter1.ColorBg = Color.LightYellow;
			plotter1.ColorGrid = Color.LightGray;
			//plotter1.XLogBase = 0;
			plotter1.XRangeStart = 0;
			plotter1.XRangeEnd = 8000;
			plotter1.XGrid = 1000;
			//plotter1.YLogBase = 0;
			plotter1.YRangeStart = 0;
			plotter1.YRangeEnd = 1;
			plotter1.YGrid = 0.2;
			plotter1.Series.Clear();

			plotter1.bIsColorMap = true;
			plotter1.IsOctave = true;

			bool DataExist = false;

			plotter1.Series.Clear();

			if(SAClass1 != null)
			{
				#region 예전
//				object [] ar = new object[3];
//
//				DataTable table = new DataTable();
//
//				table.Columns.Add("GroupName",typeof(int));
//				table.Columns.Add("my_X",typeof(double));
//				table.Columns.Add("my_Y",typeof(double));
				#endregion

				// Z 값을 구한다
				SAClass1.Cal_Z_Data();

				for(int i = 0 ; i < SAClass1.Sgraph.Count ; i++)
				{
					ClsData cls = (ClsData)SAClass1.Sgraph[i];

					pSeries1 = new DataPlotter.DataSeries();

					pSeries1.Name  = "Data 01";
					pSeries1.Color = Color.Blue ;

					#region 예전
//					for(int j = 0 ; j < cls.GetCount() ; j++)
//					{
//						DataRow row = table.NewRow();
//						ar[0] = i.ToString();
//						ar[1] = cls.GetData(j).ToString();
//						ar[2] = cls.GetData(j).ToString();
//						row.ItemArray = ar;
//						table.Rows.Add(row);
//					}
					#endregion

					pSeries1.XData = SAClass1.Frequency.GetData();
					pSeries1.YData = cls.GetData();

					// Z 값을 넣는다
					pSeries1.ZData = new double[1];
					pSeries1.ZData[0] = SAClass1.Get_Z_Data(i);

					DataExist = true;

					plotter1.Series.Add(pSeries1);
				}

				if(DataExist == true)
				{
					#region 예전
//					ultraChart1.DataSource = table;
//					ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
//					ultraChart1.ScatterChart.ConnectWithLines = true;
					#endregion

					plotter1.YLabel = "Parameter Value";
					plotter1.Interval = 2;
					plotter1.AutoRange();
					plotter1.Refresh();
				}
			}
		}

		public void GraphDraw_Result(string strPerformance)
		{
			DataPlotter.DataSeries pSeries1 = new DataPlotter.DataSeries();

			//plotter1.ColorBg = Color.LightYellow;
			plotter1.ColorGrid = Color.LightGray;
			//plotter1.XLogBase = 0;
			plotter1.XRangeStart = 0;
			plotter1.XRangeEnd = 8000;
			plotter1.XGrid = 1000;
			//plotter1.YLogBase = 0;
			plotter1.YRangeStart = 0;
			plotter1.YRangeEnd = 1;
			plotter1.YGrid = 0.2;
			plotter1.Series.Clear();

			pSeries1.Name  = "Data 01";
			pSeries1.Color = Color.Red ;

			plotter1.bIsColorMap = false;
			plotter1.IsOctave = false;

			bool DataExist = false;

			plotter1.Series.Clear();

			if(SAClass1 != null)
			{
				#region 예전
//				object [] ar = new object[3];
//
//				DataTable table = new DataTable();
//
//				table.Columns.Add("GroupName",typeof(int));
//				table.Columns.Add("my_X",typeof(double));
//				table.Columns.Add("my_Y",typeof(double));
				#endregion

				if(strPerformance == null || strPerformance == "")
				{
					strPerformance = "Transmission Loss";
				}

				if(strPerformance == "Transmission Loss")
				{
					#region 예전
//					for(int i = 0 ; i < SAClass1.Frequency.GetCount() ; i++)
//					{
//						DataRow row = table.NewRow();
//						ar[0] = i.ToString();
//						ar[1] = SAClass1.Frequency.GetData(i).ToString();
//						ar[2] = SAClass1.Rgraph_TL.GetData(i).ToString();
//						row.ItemArray = ar;
//						table.Rows.Add(row);						
//					}
					#endregion

					DataExist = true;

					pSeries1.XData = SAClass1.Frequency.GetData();
					pSeries1.YData = SAClass1.Rgraph_TL.GetData();

					plotter1.YGrid = 20;
					plotter1.YRangeEnd = 100;
				}
				else if(strPerformance == "Absorption coefficient for rigid backing")
				{
					#region 예전
//					for(int i = 0 ; i < SAClass1.Frequency.GetCount() ; i++)
//					{
//						DataRow row = table.NewRow();
//						ar[0] = i.ToString();
//						ar[1] = SAClass1.Frequency.GetData(i).ToString();
//						ar[2] = SAClass1.Rgraph_RB.GetData(i).ToString();
//						row.ItemArray = ar;
//						table.Rows.Add(row);
//					}
					#endregion

					DataExist = true;

					pSeries1.XData = SAClass1.Frequency.GetData();
					pSeries1.YData = SAClass1.Rgraph_RB.GetData();
				}
				else if(strPerformance == "Absorption coefficient for anechoic termination")
				{
					#region 예전
//					for(int i = 0 ; i < SAClass1.Frequency.GetCount() ; i++)
//					{
//						DataRow row = table.NewRow();
//						ar[0] = i.ToString();
//						ar[1] = SAClass1.Frequency.GetData(i).ToString();
//						ar[2] = SAClass1.Rgraph_AT.GetData(i).ToString();
//						row.ItemArray = ar;
//						table.Rows.Add(row);
//					}
					#endregion

					DataExist = true;

					pSeries1.XData = SAClass1.Frequency.GetData();
					pSeries1.YData = SAClass1.Rgraph_AT.GetData();
				}

				if(DataExist == true)
				{
					#region 예전
//					ultraChart1.DataSource = table;
//					ultraChart1.ScatterChart.IconSize = Infragistics.UltraChart.Shared.Styles.SymbolIconSize.Small;
//					ultraChart1.ScatterChart.ConnectWithLines = true;
					#endregion

					if(pSeries_Prev != null)
					{
						plotter1.Series.Add(pSeries_Prev);
					}
					plotter1.Series.Add(pSeries1);
					
					plotter1.Refresh();
				}
			}
		}

		private string NumberCheck(string str)
		{
			if(str == "")
			{
				return "0";
			}
			else
			{
				return str;
			}
		}

		private void btnStepOK_Click(object sender, System.EventArgs e)
		{
			double StartValue = 0;
			double EndValue = 0;
			double StepValue = 0;

			StartValue = double.Parse(NumberCheck(edtFrom.Text));
			EndValue = double.Parse(NumberCheck(edtTo.Text));
			StepValue = double.Parse(NumberCheck(edtStep.Text));

			SAClass1.StartValue = StartValue;
			SAClass1.EndValue = EndValue;
			SAClass1.StepValue = StepValue;

			frmCalc frmCalc1 = new frmCalc();
			frmCalc1.SAClass1 = SAClass1;
			frmCalc1.SAClass_Mode = 2;
			frmCalc1.ShowDialog();

			//SAClass1.SensCalc();

			GraphDraw_Step();

			btnSave_Enable(false);
			pnlParameter_Enable(true);
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			double SelectedValue = 0;

			SelectedValue = double.Parse(NumberCheck(edtParameter.Text));

			SAClass1.SelectedValue = SelectedValue;

			frmCalc frmCalc1 = new frmCalc();
			frmCalc1.SAClass1 = SAClass1;
			frmCalc1.SAClass_Mode = 3;
			frmCalc1.ShowDialog();

			//SAClass1.ResultingCalc();

			GraphDraw_Result(strPerformance);

			btnSave_Enable(true);
		}

		public void gbAdjustmentRange_Enable(bool bEnable)
		{
			gbAdjustmentRange.Enabled = bEnable;
		}

		public void pnlParameter_Enable(bool bEnable)
		{
			pnlParameter.Enabled = bEnable;
		}

		public void btnSave_Enable(bool bEnable)
		{
			btnSave.Enabled = bEnable;
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(SAClass1 != null)
			{
				SAClass1.Remark = edtRemark.Text;
				SAClass1.IsMaterialCreate = this.IsMaterialCreate;
				SAClass1.DBSave();

				MessageBox.Show("저장되었습니다.","저장");
			}
		}

		private void propertyGrid1_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			plotter1.Refresh();
		}

		private void btnGraphSave_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.Filter = "(*.Bmp)|*.Bmp|(*.Emf)|*.Emf|(*.Exif)|*.Exif|(*.Gif)|*.Gif|(*.Icon)|*.Icon|(*.Jpeg)|*.Jpeg|(*.MemoryBmp)|*.MemoryBmp|(*.Png)|*.Png|(*.Tiff)|*.Tiff|(*.Wmf)|*.Wmf";

			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string path = saveFileDialog1.FileName;
				string strExtension = System.IO.Path.GetExtension(saveFileDialog1.FileName);
				switch(strExtension)
				{
					case ".Bmp" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Bmp);
						break;
					case ".Emf" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Emf);
						break;
					case ".Exif" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Exif);
						break;
					case ".Gif" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Gif);
						break;
					case ".Icon" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Icon);
						break;
					case ".Jpeg" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Jpeg);
						break;
					case ".MemoryBmp" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.MemoryBmp);
						break;
					case ".Png" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Png);
						break;
					case ".Tiff" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Tiff);
						break;
					case ".Wmf" :
						plotter1.Save(path,System.Drawing.Imaging.ImageFormat.Wmf);
						break;
				}
			}
		}

		private void btnGraphEdit_Click(object sender, System.EventArgs e)
		{
			propertyGrid1.Visible = true;

			btnGraphEdit.Enabled = false;
			btnEditCancel.Enabled = true;
		}

		private void btnEditCancel_Click(object sender, System.EventArgs e)
		{
			propertyGrid1.Visible = false;

			btnGraphEdit.Enabled = true;
			btnEditCancel.Enabled = false;
		}

		private void edtFrom_TextChanged(object sender, System.EventArgs e)
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
	}
}
