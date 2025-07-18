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

        private void btn_openpath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file Excel";
                ofd.Filter = "Excel Files (*.xlsx)|*.xlsx";
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
            var config = new OpenXmlConfiguration()
            {
                FillMergedCells = true
            };
            var a = MiniExcel.Query(txt_path.Text, sheetName: "Dam", configuration: config);
            var b = new XulyEx(a.ToList());
            var c = b.Dams;
            foreach (var item in c)
            {
                string[] row = new string[]
                {   "0",
                    "0",
                    item.MCA.M.ToString(),
                    item.MCA.Q.ToString(),
                    item.MCB.M.ToString(),
                    item.MCB.Q.ToString(),
                    item.MCC.M.ToString(),
                    item.MCC.Q.ToString()
                };
                dgv_frames.Rows.Add(row);
            }
        }
    }
}
