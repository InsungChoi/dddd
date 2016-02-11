using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// MultiMaterial_View에 대한 요약 설명입니다.
	/// </summary>
	public class MultiMaterial_View : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView lstSearchResultList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTotalThick;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lbl_MID;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string strName;
		public string strTotalThick;
		public string strMID;

		public MultiMaterial_View()
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

		private void SearchResultList_Init()
		{
			lstSearchResultList.Columns.Clear();

			ColumnHeader col;

			col = new ColumnHeader();
			col.Text = "ID";
			col.Width = 10;
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Name";
			lstSearchResultList.Columns.Add(col);

			//			col = new ColumnHeader();
			//			col.Text = "Type";
			//			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Thickness";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "FlowResistivity";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "LossFactor";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "BulkDensity";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "YoungsModulus";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "PoissionsRatio";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "ThermalCharLength";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "ViscousCharLength";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Prosity";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "StructureFactor";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Emp1";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Pratiop1";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "hp1";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "densityp1";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "hp2";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "densityp2";
			lstSearchResultList.Columns.Add(col);			

			col = new ColumnHeader();
			col.Text = "Emp2";
			lstSearchResultList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "Pratiop2";
			lstSearchResultList.Columns.Add(col);

			//			col = new ColumnHeader();
			//			col.Text = "MultiLayerID";
			//			lstSearchResultList.Columns.Add(col);
		}

		private void MaterialListBind()
		{
			HONUS.MaterialDatabase.Component.MD_DB MD_DB1 = new HONUS.MaterialDatabase.Component.MD_DB();

			DataSet dsSearchResult = MD_DB1.GetMultiMaterial(int.Parse(lbl_MID.Text));

			for(int i = 0 ; i < dsSearchResult.Tables[0].Rows.Count ; i++)
			{
				ListViewItem item = new ListViewItem();

				item.SubItems[0].Text = dsSearchResult.Tables[0].Rows[i]["SID"].ToString();
				
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Name"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Thick"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["FlowRes"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["LossFactor"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["BulkDens"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Ymodulus"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["PoissionR"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["ThermalCL"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["ViscousCL"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Prosity"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["Sfactor"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["EmP1"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["PRatioP1"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["DensityP1"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["EmP2"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["HP2"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["HP2"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["HP1"].ToString());
				item.SubItems.Add(dsSearchResult.Tables[0].Rows[i]["PRatioP2"].ToString());


				lstSearchResultList.Items.Add(item);
			}
		}


		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstSearchResultList = new System.Windows.Forms.ListView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_MID = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTotalThick = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstSearchResultList
			// 
			this.lstSearchResultList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstSearchResultList.FullRowSelect = true;
			this.lstSearchResultList.GridLines = true;
			this.lstSearchResultList.Location = new System.Drawing.Point(0, 32);
			this.lstSearchResultList.Name = "lstSearchResultList";
			this.lstSearchResultList.Size = new System.Drawing.Size(840, 240);
			this.lstSearchResultList.TabIndex = 2;
			this.lstSearchResultList.View = System.Windows.Forms.View.Details;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbl_MID);
			this.panel1.Controls.Add(this.lblName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lblTotalThick);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 32);
			this.panel1.TabIndex = 3;
			// 
			// lbl_MID
			// 
			this.lbl_MID.Location = new System.Drawing.Point(800, 16);
			this.lbl_MID.Name = "lbl_MID";
			this.lbl_MID.TabIndex = 4;
			this.lbl_MID.Visible = false;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(64, 6);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(56, 18);
			this.lblName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label3.Location = new System.Drawing.Point(248, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "TotalThick : ";
			// 
			// lblTotalThick
			// 
			this.lblTotalThick.Location = new System.Drawing.Point(320, 5);
			this.lblTotalThick.Name = "lblTotalThick";
			this.lblTotalThick.Size = new System.Drawing.Size(56, 18);
			this.lblTotalThick.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Location = new System.Drawing.Point(8, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name : ";
			// 
			// btnDelete
			// 
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnDelete.Location = new System.Drawing.Point(765, 7);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 242);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(840, 30);
			this.panel2.TabIndex = 6;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(840, 7);
			this.panel3.TabIndex = 0;
			// 
			// MultiMaterial_View
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(840, 272);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.lstSearchResultList);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "MultiMaterial_View";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MultiMaterial View";
			this.Load += new System.EventHandler(this.MultiMaterial_View_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void MultiMaterial_View_Load(object sender, System.EventArgs e)
		{
			lblName.Text = strName;
			lblTotalThick.Text = strTotalThick;
			lbl_MID.Text = strMID;

			SearchResultList_Init();

			MaterialListBind();
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("정말로 삭제 하시겠습니까?","삭제",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				HONUS.MaterialDatabase.Component.MD_DB MD_DB1 = new HONUS.MaterialDatabase.Component.MD_DB();

				MD_DB1.DeleteMultiMaterial(lbl_MID.Text);
			}
		}
	}
}
