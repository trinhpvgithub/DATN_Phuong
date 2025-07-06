using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN_Phuong.Forms
{
	public partial class MainForm : Form
	{
		private Form activeForm;
		public static TinhToan formTT { get; set; }
		public static CCVatLieu fromVL { get; set; }
		public static TTDam fromTTDam { get; set; }
		public MainForm()
		{
			InitializeComponent();
		}
		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Hide();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.pl_Main.Controls.Add(childForm);
			this.pl_Main.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void btn_ThongTin_Click(object sender, EventArgs e)
		{
			if (fromTTDam == null)
			{
				fromTTDam = new TTDam();
			}
			OpenChildForm(fromTTDam, sender);
		}

		private void btn_VatLieu_Click(object sender, EventArgs e)
		{
			if (fromVL == null)
			{
				fromVL = new CCVatLieu();
			}
			OpenChildForm(fromVL, sender);
		}

		private void btn_Tinh_Click(object sender, EventArgs e)
		{
			if (formTT == null)
			{
				formTT = new TinhToan();
			}
			OpenChildForm(formTT, sender);
		}
	}
}
