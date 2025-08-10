using DATN_Phuong.ClassUtils;
using MiniExcelLibs;
using MiniExcelLibs.OpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN_Phuong.Forms
{
	public partial class TTDam : Form
	{
		public TTDam()
		{
			InitializeComponent();
		}
		public static List<Dam> Dams { get; set; } = new List<Dam>();
		private void btn_openpath_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Title = "Chọn file Excel";
				ofd.Multiselect = false;

				if (ofd.ShowDialog() == DialogResult.OK)
				{
					string filePath = ofd.FileName;
					txt_path.Text = filePath;
				}
			}
		}

		private void btn_loaddata_Click(object sender, EventArgs e)
		{
			var tt = MiniExcel.Query<TietDien>(txt_pathTD.Text);
			var data = tt.Where(x => x.Label.StartsWith("B")).GroupBy(x => x.Label).ToList();
			var config = new OpenXmlConfiguration()
			{
				FillMergedCells = true
			};
			var a = MiniExcel.Query(txt_path.Text, sheetName: "Dam", configuration: config);//đọc file ex
			var b = new XulyEx(a.ToList());
			var c = b.Dams;
			int i = 1;
			foreach (var item in c)
			{
				string[] row = new string[]
				{   i.ToString(),
					item.Name,	
					item.MCA.M.ToString(),
					item.MCA.Q.ToString(),
					item.MCB.M.ToString(),
					item.MCB.Q.ToString(),
					item.MCC.M.ToString(),
					item.MCC.Q.ToString()
				};
				dgv_frames.Rows.Add(row);
				item.Width = 300;
				item.Height = i % 3 == 2 ? 400 : 700;
				Dams.Add(item);
				i++;
			}

		}

		private void btn_pathTD_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Title = "Chọn file Excel";
				ofd.Multiselect = false;

				if (ofd.ShowDialog() == DialogResult.OK)
				{
					string filePath = ofd.FileName;
					txt_pathTD.Text = filePath;
				}
			}
		}
	}
}
