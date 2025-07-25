using DATN_Phuong.ClassUtils;
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
	public partial class TinhToan : Form
	{
		public TinhToan()
		{
			InitializeComponent();
		}
        public static List<string[]> Dams { get; set; } = new List<string[]>();
        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(txt_a.Text);
            var hf = Convert.ToDouble(txt_hf.Text);
            var beams = TTDam.Dams;
            var BT = CCVatLieu.MACBT;
            var THEP = CCVatLieu.MACTHEPCHINH;
            foreach (var beam in beams)
            {
                var Result = new Tinh(beam.Height, a, hf, beam.Width, 8, BT.Rb, THEP.Rs, beam.MCA.M, beam.MCB.M, beam.MCC.M);
                string[] beamresult = new string[]
                {
                    beam.Story,
                    beam.Name,
                    Math.Round( Result.AsA,4).ToString(),
                    Math.Round( Result.AsB,4).ToString(),
                    Math.Round( Result.AsC,4).ToString(),
                };
                dgv_result.Rows.Add(beamresult);
                Dams.Add(beamresult);
            }
        }
    }
}
