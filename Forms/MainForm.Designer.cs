
namespace DATN_Phuong.Forms
{
	partial class MainForm
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
			this.pl_Main = new System.Windows.Forms.Panel();
			this.pl_Title = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pl_Name = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pl_Tab = new System.Windows.Forms.Panel();
			this.btn_Tinh = new System.Windows.Forms.Button();
			this.btn_VatLieu = new System.Windows.Forms.Button();
			this.btn_ThongTin = new System.Windows.Forms.Button();
			this.pl_Title.SuspendLayout();
			this.pl_Name.SuspendLayout();
			this.pl_Tab.SuspendLayout();
			this.SuspendLayout();
			// 
			// pl_Main
			// 
			this.pl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pl_Main.Location = new System.Drawing.Point(296, 141);
			this.pl_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pl_Main.Name = "pl_Main";
			this.pl_Main.Size = new System.Drawing.Size(889, 467);
			this.pl_Main.TabIndex = 0;
			// 
			// pl_Title
			// 
			this.pl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pl_Title.BackColor = System.Drawing.Color.DarkCyan;
			this.pl_Title.Controls.Add(this.label3);
			this.pl_Title.Controls.Add(this.label2);
			this.pl_Title.Location = new System.Drawing.Point(296, 7);
			this.pl_Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pl_Title.Name = "pl_Title";
			this.pl_Title.Size = new System.Drawing.Size(889, 134);
			this.pl_Title.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(47, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(812, 47);
			this.label3.TabIndex = 0;
			this.label3.Text = "TÍNH TOÁN DẦM THEO TIÊU CHUẨN VIỆT NAM(1995-2023)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(268, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(321, 37);
			this.label2.TabIndex = 0;
			this.label2.Text = "ĐỒ ÁN TỐT NGHIỆP";
			// 
			// pl_Name
			// 
			this.pl_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pl_Name.BackColor = System.Drawing.Color.Teal;
			this.pl_Name.Controls.Add(this.label1);
			this.pl_Name.Location = new System.Drawing.Point(2, 7);
			this.pl_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pl_Name.Name = "pl_Name";
			this.pl_Name.Size = new System.Drawing.Size(294, 134);
			this.pl_Name.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(43, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Minh Phương";
			// 
			// pl_Tab
			// 
			this.pl_Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pl_Tab.BackColor = System.Drawing.Color.DarkSlateGray;
			this.pl_Tab.Controls.Add(this.btn_Tinh);
			this.pl_Tab.Controls.Add(this.btn_VatLieu);
			this.pl_Tab.Controls.Add(this.btn_ThongTin);
			this.pl_Tab.Location = new System.Drawing.Point(2, 141);
			this.pl_Tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pl_Tab.Name = "pl_Tab";
			this.pl_Tab.Size = new System.Drawing.Size(294, 467);
			this.pl_Tab.TabIndex = 3;
			// 
			// btn_Tinh
			// 
			this.btn_Tinh.BackColor = System.Drawing.Color.Orange;
			this.btn_Tinh.Location = new System.Drawing.Point(11, 159);
			this.btn_Tinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_Tinh.Name = "btn_Tinh";
			this.btn_Tinh.Size = new System.Drawing.Size(277, 68);
			this.btn_Tinh.TabIndex = 0;
			this.btn_Tinh.Text = "Tính Toán";
			this.btn_Tinh.UseVisualStyleBackColor = false;
			this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
			// 
			// btn_VatLieu
			// 
			this.btn_VatLieu.BackColor = System.Drawing.Color.Orange;
			this.btn_VatLieu.Location = new System.Drawing.Point(10, 83);
			this.btn_VatLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_VatLieu.Name = "btn_VatLieu";
			this.btn_VatLieu.Size = new System.Drawing.Size(277, 68);
			this.btn_VatLieu.TabIndex = 0;
			this.btn_VatLieu.Text = "Cài đặt Vật Liệu";
			this.btn_VatLieu.UseVisualStyleBackColor = false;
			this.btn_VatLieu.Click += new System.EventHandler(this.btn_VatLieu_Click);
			// 
			// btn_ThongTin
			// 
			this.btn_ThongTin.BackColor = System.Drawing.Color.Orange;
			this.btn_ThongTin.Location = new System.Drawing.Point(11, 7);
			this.btn_ThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_ThongTin.Name = "btn_ThongTin";
			this.btn_ThongTin.Size = new System.Drawing.Size(277, 68);
			this.btn_ThongTin.TabIndex = 0;
			this.btn_ThongTin.Text = "Thông tin dầm";
			this.btn_ThongTin.UseVisualStyleBackColor = false;
			this.btn_ThongTin.Click += new System.EventHandler(this.btn_ThongTin_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1198, 622);
			this.Controls.Add(this.pl_Tab);
			this.Controls.Add(this.pl_Name);
			this.Controls.Add(this.pl_Title);
			this.Controls.Add(this.pl_Main);
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.pl_Title.ResumeLayout(false);
			this.pl_Title.PerformLayout();
			this.pl_Name.ResumeLayout(false);
			this.pl_Name.PerformLayout();
			this.pl_Tab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pl_Main;
		private System.Windows.Forms.Panel pl_Title;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pl_Name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pl_Tab;
		private System.Windows.Forms.Button btn_Tinh;
		private System.Windows.Forms.Button btn_VatLieu;
		private System.Windows.Forms.Button btn_ThongTin;
	}
}