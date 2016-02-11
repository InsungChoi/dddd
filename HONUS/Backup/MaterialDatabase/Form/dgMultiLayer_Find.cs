using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS.MaterialDatabase.Form
{
	/// <summary>
	/// dgMultiLayer_Find�� ���� ��� �����Դϴ�.
	/// </summary>
	public class dgMultiLayer_Find : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox edtTotalThick;

		public clsMultiLayer_Find MultiLayer_Find1;

		public dgMultiLayer_Find()
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
			this.label1 = new System.Windows.Forms.Label();
			this.edtName = new System.Windows.Forms.TextBox();
			this.edtTotalThick = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name : ";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(88, 5);
			this.edtName.Name = "edtName";
			this.edtName.TabIndex = 1;
			this.edtName.Text = "";
			// 
			// edtTotalThick
			// 
			this.edtTotalThick.Location = new System.Drawing.Point(88, 32);
			this.edtTotalThick.Name = "edtTotalThick";
			this.edtTotalThick.TabIndex = 3;
			this.edtTotalThick.Text = "";
			this.edtTotalThick.TextChanged += new System.EventHandler(this.edtTotalThick_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "TotalThick : ";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(24, 64);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(112, 64);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "Ok";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// dgMultiLayer_Find
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(192, 93);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.edtTotalThick);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dgMultiLayer_Find";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MultiLayer �˻�";
			this.Load += new System.EventHandler(this.dgMultiLayer_Find_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void dgMultiLayer_Find_Load(object sender, System.EventArgs e)
		{
			if(MultiLayer_Find1 != null)
			{
				edtName.Text = MultiLayer_Find1.strName;
				edtTotalThick.Text = MultiLayer_Find1.strTotalThick;
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;

			MultiLayer_Find1 = new clsMultiLayer_Find();

			MultiLayer_Find1.strName = edtName.Text;
			MultiLayer_Find1.strTotalThick = edtTotalThick.Text;

			this.Close();
		}

		private void edtTotalThick_TextChanged(object sender, System.EventArgs e)
		{
			string str = ((TextBox)sender).Text;
			// �������� �ƴϸ�
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

	public class clsMultiLayer_Find
	{
		public string strName;
		public string strTotalThick;

		public clsMultiLayer_Find()
		{
			strName = "";
			strTotalThick = "";
		}
	}
}
