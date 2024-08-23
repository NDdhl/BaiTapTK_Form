namespace BaiThucHanhBuoi1
{
	partial class Mainform
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSaoChep = new System.Windows.Forms.TextBox();
			this.btnSaoChep = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập tên của bạn:";
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(174, 48);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(242, 22);
			this.txtTen.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(174, 103);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(109, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "Xử lý";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Bạn đã nhập:";
			// 
			// txtSaoChep
			// 
			this.txtSaoChep.Location = new System.Drawing.Point(174, 168);
			this.txtSaoChep.Name = "txtSaoChep";
			this.txtSaoChep.ReadOnly = true;
			this.txtSaoChep.Size = new System.Drawing.Size(242, 22);
			this.txtSaoChep.TabIndex = 4;
			// 
			// btnSaoChep
			// 
			this.btnSaoChep.Location = new System.Drawing.Point(307, 103);
			this.btnSaoChep.Name = "btnSaoChep";
			this.btnSaoChep.Size = new System.Drawing.Size(109, 23);
			this.btnSaoChep.TabIndex = 5;
			this.btnSaoChep.Text = "Sao chép";
			this.btnSaoChep.UseVisualStyleBackColor = true;
			this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
			// 
			// Mainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSaoChep);
			this.Controls.Add(this.txtSaoChep);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.label1);
			this.Name = "Mainform";
			this.Text = "Chương trình đầu tiên";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSaoChep;
		private System.Windows.Forms.Button btnSaoChep;
	}
}

