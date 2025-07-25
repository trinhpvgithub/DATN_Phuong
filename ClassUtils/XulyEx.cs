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
			var groupname = data.GroupBy(x => x.A);// group theo giá trị của cột A
			foreach (var group in groupname)
			{
				string name = Convert.ToString(group.Key);
				if (!string.IsNullOrEmpty(name) && name.StartsWith("N"))
				{
					var beam = new Dam(group);
					Dams.Add(beam);
				}
			}
		}
	}
}
