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
		private int _selectedIndex = -1; // Biến để lưu chỉ mục được chọn
		private void ChiTiet_Load(object sender, EventArgs e)
		{
			cbb_chitet.Items.Clear();
			cbb_chitet.Items.AddRange(TinhToan.Ketqua.Select(x => (object)x.Id).ToArray());
			if (cbb_chitet.Items.Count > 0)
			{
				cbb_chitet.SelectedIndex = 0; // chọn mục đầu tiên
			}
			else
			{
				MessageBox.Show("Không có kết quả tính toán nào để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void cbb_chitet_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedIndex = cbb_chitet.SelectedIndex; // lưu chỉ mục được chọn
			// sử dụng kết quả tính toán đã lưu để đưa lên màn hình
			if (cbb_chitet.SelectedItem == null)
			{
				return; // không có mục nào được chọn
			}
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
			var thepA = ClassUtils.RebarCombo.GetMixedRebarOptions_WithMin2Phi12(tt.AsA, maxResults: Convert.ToInt32(cbb_soluachonA.Text));
			if (thepA.Count > 0)
			{
				lst_chonA.Items.Clear(); // xóa các mục cũ trước khi thêm mới
				foreach (var item in thepA)
				{
					lst_chonA.Items.Add(item.ToString());
				}
			}
			else
			{
				lst_chonA.Items.Add("Không có lựa chọn nào phù hợp, vui lòng chọn lại Vật liệu!");
			}
			var thepB = ClassUtils.RebarCombo.GetMixedRebarOptions_WithMin2Phi12(tt.AsB);
			if (thepB.Count > 0)
			{
				lst_chonB.Items.Clear(); // xóa các mục cũ trước khi thêm mới
				foreach (var item in thepB)
				{
					lst_chonB.Items.Add(item.ToString());
				}
			}
			else
			{
				lst_chonB.Items.Add("Không có lựa chọn nào phù hợp, vui lòng chọn lại Vật liệu!");
			}
			var thepC = ClassUtils.RebarCombo.GetMixedRebarOptions_WithMin2Phi12(tt.AsC);
			if (thepC.Count > 0)
			{
				lst_chonC.Items.Clear();
				foreach (var item in thepC)
				{
					lst_chonC.Items.Add(item.ToString());
				}
			}
			else
			{
				lst_chonC.Items.Add("Không có lựa chọn nào phù hợp, vui lòng chọn lại Vật liệu!");
			}
		}

		private void cbb_soluachonA_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tt = TinhToan.Ketqua.FirstOrDefault(x => x.Id == _selectedIndex);
			var thepA = ClassUtils.RebarCombo.GetMixedRebarOptions_WithMin2Phi12(tt.AsA, maxResults: Convert.ToInt32(cbb_soluachonA.Text));
			if (thepA.Count > 0)
			{
				lst_chonA.Items.Clear(); // xóa các mục cũ trước khi thêm mới
				foreach (var item in thepA)
				{
					lst_chonA.Items.Add(item.ToString());
				}
			}
			else
			{
				lst_chonA.Items.Add("Không có lựa chọn nào phù hợp, vui lòng chọn lại Vật liệu!");
			}
		}

		private void cbb_soluachonB_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tt = TinhToan.Ketqua.FirstOrDefault(x => x.Id == _selectedIndex);
			var thepB = ClassUtils.RebarCombo.GetMixedRebarOptions_WithMin2Phi12(tt.AsB, maxResults: Convert.ToInt32(cbb_soluachonB.Text));
			if (thepB.Count > 0)
			{
				lst_chonB.Items.Clear(); // xóa các mục cũ trước khi thêm mới
				foreach (var item in thepB)
				{
					lst_chonB.Items.Add(item.ToString());
				}
			}
			else
			{
				lst_chonB.Items.Add("Không có lựa chọn nào phù hợp, vui lòng chọn lại Vật liệu!");
			}
		}

		private void cbb_soluachonC_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tt = TinhToan.Ketqua.FirstOrDefault(x => x.Id == _selectedIndex);
			var thepC = ClassUtils.RebarCombo.GetMixedRebarOptions_WithMin2Phi12(tt.AsC, maxResults: Convert.ToInt32(cbb_soluachonC.Text));
			if (thepC.Count > 0)
			{
				lst_chonC.Items.Clear();
				foreach (var item in thepC)
				{
					lst_chonC.Items.Add(item.ToString());
				}
			}
			else
			{
				lst_chonC.Items.Add("Không có lựa chọn nào phù hợp, vui lòng chọn lại Vật liệu!");
			}
		}
	}
}
