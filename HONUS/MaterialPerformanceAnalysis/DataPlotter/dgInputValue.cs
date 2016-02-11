using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HONUS
{
	/// <summary>
	/// dgInputValue�� ���� ��� �����Դϴ�.
	/// </summary>
	public class dgInputValue : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox edtValue;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public dgInputValue()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

		public string ctValue
		{
			get
			{
				return edtValue.Text;
			}
			set
			{
				edtValue.Text = value;
			}
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
			this.edtValue = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// edtValue
			// 
			this.edtValue.Location = new System.Drawing.Point(8, 8);
			this.edtValue.Name = "edtValue";
			this.edtValue.Size = new System.Drawing.Size(160, 21);
			this.edtValue.TabIndex = 0;
			this.edtValue.Text = "";
			this.edtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtValue_KeyDown);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(8, 40);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "CANCEL";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(88, 40);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// dgInputValue
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(178, 74);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.edtValue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dgInputValue";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Input Value";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;

			this.Close();
		}

		private void edtValue_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(Keys.Enter == e.KeyCode)
			{
				btnOK_Click(null,null);
			}
		}

	}
}
