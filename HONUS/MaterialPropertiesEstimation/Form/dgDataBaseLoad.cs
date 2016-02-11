using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using HONUS.MaterialPropertiesEstimation.Component;

namespace HONUS.MaterialPropertiesEstimation.Form
{
	/// <summary>
	/// dgDataBaseLoad에 대한 요약 설명입니다.
	/// </summary>
	public class dgDataBaseLoad : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView lstDBList;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string strSelectedDataBase_ID;
		public string strSelectedDataBase_Name;

		DataSet dsDataBaseLoad;

		public dgDataBaseLoad()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
			strSelectedDataBase_ID = "";
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
			this.lstDBList = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// lstDBList
			// 
			this.lstDBList.GridLines = true;
			this.lstDBList.Location = new System.Drawing.Point(8, 8);
			this.lstDBList.Name = "lstDBList";
			this.lstDBList.Size = new System.Drawing.Size(256, 176);
			this.lstDBList.TabIndex = 10;
			this.lstDBList.View = System.Windows.Forms.View.Details;
			this.lstDBList.DoubleClick += new System.EventHandler(this.lstDBList_DoubleClick);
			// 
			// dgDataBaseLoad
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(272, 189);
			this.Controls.Add(this.lstDBList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dgDataBaseLoad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DataBase Load";
			this.Load += new System.EventHandler(this.dgDataBaseLoad_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void dgDataBaseLoad_Load(object sender, System.EventArgs e)
		{
			DataBaseListInit();
			lstDBList_Load();
		}

		private void DataBaseListInit()
		{
			ColumnHeader col = new ColumnHeader();
			col.Text = "Name";
			col.Width = 245;
			col.TextAlign = HorizontalAlignment.Center;

			lstDBList.Columns.Add(col);

			col = new ColumnHeader();
			col.Text = "";
			col.Width = 5;
			col.TextAlign = HorizontalAlignment.Center;

			lstDBList.Columns.Add(col);
		}

		/// <summary>
		/// DB 에서 기본적인 것들을 가져온다
		/// </summary>
		private void lstDBList_Load()
		{
			ListViewItem list;

			MPE_DB MPE_DB1 = new MPE_DB();
			dsDataBaseLoad = MPE_DB1.GetDBDefault_Load();
			for(int i = 0 ; i < dsDataBaseLoad.Tables[0].Rows.Count ; i++)
			{
				list = new ListViewItem();
				list.Text = dsDataBaseLoad.Tables[0].Rows[i]["Name"].ToString();
				lstDBList.Items.Add(list);
			}
		}

		private void lstDBList_DoubleClick(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			strSelectedDataBase_Name = lstDBList.SelectedItems[0].Text;
			strSelectedDataBase_ID = dsDataBaseLoad.Tables[0].Rows[lstDBList.SelectedIndices[0]]["SGID"].ToString();
			this.Close();
		}
	}
}
