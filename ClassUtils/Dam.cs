using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace DATN_Phuong.ClassUtils
{
    public class Dam
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Story { get; set; }
        public string Name { get; set; }

        public MatCat MCA { get; set; }
        public MatCat MCB { get; set; }
        public MatCat MCC { get; set; }

        public Dam( IGrouping<dynamic,dynamic> b)
        {
            Story = Convert.ToString(b.Select(x => x?.E).First());
            Name = Convert.ToString(b.Select(x => x?.F).First());
            var sectionA = b.Where(x =>
            {
                string s = Convert.ToString(x.B);
                return s.Equals("0");
            });
            var sectionB = b.Where(x =>
            {
                string s = Convert.ToString(x.B);
                return s.Equals("0.5L");
            });
            var sectionC = b.Where(x =>
            {
                string s = Convert.ToString(x.B);
                return s.Equals("1L");
            });
            MCA = new MatCat(sectionA.ToList());
            MCB = new MatCat(sectionB.ToList(), false);
            MCC = new MatCat(sectionC.ToList());
        }
    }
}
