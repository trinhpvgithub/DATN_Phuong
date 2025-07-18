using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_Phuong.ClassUtils
{
    public class XulyEx
    {
        public List<Dam> Dams { get; set; } = new List<Dam>();
        public XulyEx(List<dynamic> data)
        {
            var groupname = data.GroupBy(x => x.A);// group theo giá trị của cột E
            foreach (var group in groupname)
            {
                var name = group.Where(x =>
                {
                    var d = $"{x.B}";
                    return d.StartsWith("B") && !d.Equals("BẢNG TỔ HỢP NỘI LỰC DẦM KHUNG KHÔNG GIAN - TCVN 2737:2023");
                })
                .GroupBy(x => x.B).ToList();
                if (name.Count > 0)
                {
                    foreach (var item in name)
                    {
                        var beam = new Dam(item);
                        Dams.Add(beam);
                    }
                }
            }
        }
    }
}
