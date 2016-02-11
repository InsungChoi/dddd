using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// dgPassWord�� ���� ��� �����Դϴ�.
	/// </summary>
	public class dgPassWord : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox edtPass;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public dgPassWord()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

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
			this.edtPass = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// edtPass
			// 
			this.edtPass.Location = new System.Drawing.Point(8, 8);
			this.edtPass.Name = "edtPass";
			this.edtPass.PasswordChar = '*';
			this.edtPass.Size = new System.Drawing.Size(176, 21);
			this.edtPass.TabIndex = 0;
			this.edtPass.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(8, 40);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(72, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(112, 40);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(72, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "CANCEL";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// dgPassWord
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(194, 74);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.edtPass);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dgPassWord";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pass Word";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			HONUS.MaterialDatabase.Component.MD_DB MD_DB1 = new HONUS.MaterialDatabase.Component.MD_DB();

			if(MD_DB1.PassWordCheck(edtPass.Text) > 0)
			{
				this.DialogResult = DialogResult.OK;

				this.Close();
			}
			else
			{
				MessageBox.Show("��� ��ȣ�� �߸� �Ǿ����ϴ�","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
		}
	}
}
