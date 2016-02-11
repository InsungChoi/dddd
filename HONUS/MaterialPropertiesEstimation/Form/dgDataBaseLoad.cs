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
	/// dgDataBaseLoad�� ���� ��� �����Դϴ�.
	/// </summary>
	public class dgDataBaseLoad : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView lstDBList;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string strSelectedDataBase_ID;
		public string strSelectedDataBase_Name;

		DataSet dsDataBaseLoad;

		public dgDataBaseLoad()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
			strSelectedDataBase_ID = "";
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
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
		/// DB ���� �⺻���� �͵��� �����´�
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
