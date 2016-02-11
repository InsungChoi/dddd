using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// dgSelected�� ���� ��� �����Դϴ�.
	/// </summary>
	public class dgSelected : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnGO;
		private System.Windows.Forms.RadioButton rdoAddition;
		private System.Windows.Forms.RadioButton rdoSearch;

		public string strSelected;

		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public dgSelected()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();
			strSelected = "";

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
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
			this.rdoAddition = new System.Windows.Forms.RadioButton();
			this.rdoSearch = new System.Windows.Forms.RadioButton();
			this.btnGO = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rdoAddition
			// 
			this.rdoAddition.Checked = true;
			this.rdoAddition.Location = new System.Drawing.Point(8, 16);
			this.rdoAddition.Name = "rdoAddition";
			this.rdoAddition.Size = new System.Drawing.Size(208, 24);
			this.rdoAddition.TabIndex = 0;
			this.rdoAddition.TabStop = true;
			this.rdoAddition.Text = "Addition Material to database";
			// 
			// rdoSearch
			// 
			this.rdoSearch.Location = new System.Drawing.Point(8, 40);
			this.rdoSearch.Name = "rdoSearch";
			this.rdoSearch.Size = new System.Drawing.Size(192, 24);
			this.rdoSearch.TabIndex = 1;
			this.rdoSearch.Text = "Search material database";
			// 
			// btnGO
			// 
			this.btnGO.BackColor = System.Drawing.SystemColors.Control;
			this.btnGO.Location = new System.Drawing.Point(8, 72);
			this.btnGO.Name = "btnGO";
			this.btnGO.Size = new System.Drawing.Size(192, 23);
			this.btnGO.TabIndex = 2;
			this.btnGO.Text = "GO";
			this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
			// 
			// dgSelected
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(224, 109);
			this.Controls.Add(this.btnGO);
			this.Controls.Add(this.rdoSearch);
			this.Controls.Add(this.rdoAddition);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dgSelected";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "dgSelected";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnGO_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			strSelected = GetSelected();

			this.Close();
		}

		private string GetSelected()
		{
			string strResult = "";

			if(rdoAddition.Checked == true)
			{
				strResult = "Addition";
			}
			else
			{
				strResult = "Search";
			}

			return strResult;
		}
	}
}
