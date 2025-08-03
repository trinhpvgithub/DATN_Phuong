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
	public partial class ChiTiet : Form
	{
		public ChiTiet()
		{
			InitializeComponent();
		}

		private void ChiTiet_Load(object sender, EventArgs e)
		{
			cbb_chitet.Items.Clear();
			cbb_chitet.Items.AddRange(TinhToan.Ketqua.Select(x => (object)x.Id).ToArray());
			cbb_chitet.SelectedIndex = 0;
		}

		private void cbb_chitet_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tt = TinhToan.Ketqua.Where(x => x.Id == Convert.ToInt32(cbb_chitet.SelectedItem)).FirstOrDefault();
			lb_Rb.Text = tt.Rb.ToString() ;
			lb_Rs.Text = tt.Rs.ToString();
			lb_a.Text = tt.a.ToString();
			lb_h0.Text = (tt.h -tt.a).ToString();
			lb_am.Text = tt.Am[0].ToString() ;
			lb_zeta.Text = tt.zeta[0].ToString();
			lb_As1.Text = tt.AsA.ToString();
			lb_am2.Text = tt.Am[1].ToString();
			lb_zeta2.Text = tt.zeta[1].ToString();
			lb_As2.Text = tt.AsB.ToString();
			lb_am3.Text = tt.Am[2].ToString();
			lb_zeta3.Text = tt.zeta[2].ToString();
			lb_As3.Text = tt.AsC.ToString();
			lb_ma.Text = tt.Ma.ToString();
			lb_mb.Text = tt.Mb.ToString();
			lb_mc.Text = tt.Mc.ToString();
		}
	}
}
