using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_Phuong.ClassUtils
{
    public class MatCat
    {
        public double M { get; set; }
        public double Q { get; set; }
        public MatCat(List<dynamic> s, bool c = true)
        {
            var m = s.FirstOrDefault(x =>
            {
                var mm = Convert.ToString(x.D);
                if (mm == null) return false;
                return mm.StartsWith("M");
            });
            var q = s.FirstOrDefault(x =>
            {
                var mm = Convert.ToString(x.D);
                if (mm == null) return false;
                return mm.StartsWith("Q");
            });
            if (m == null) return;
            if (q == null) return;
			List<double> mmax = GetValue(m);
            if (mmax.Count > 0)
            {
                if (c)
                {
                    M = -mmax.Max(x => Math.Abs(x));
                }
                else M = mmax.Max(x => Math.Abs(x));
            }
            List<double> qmax = GetValue(q);
            if (qmax.Count > 0)
                Q = qmax.Max(x => Math.Abs(x));
        }
        public List<double> GetValue(dynamic dy)// lấy giá trị của mặt cắt
        {
            var result = new List<double>();
            if (Convert.ToString(dy.K) != "-" && dy.K != null)
                result.Add(dy.K);
            if (Convert.ToString(dy.L) != "-" && dy.L != null)
                result.Add(dy.L);
            if (Convert.ToString(dy.M) != "-" && dy.M != null)
                result.Add(dy.M);
            if (Convert.ToString(dy.N) != "-" && dy.N != null)
                result.Add(dy.N);
            if (Convert.ToString(dy.O) != "-" && dy.O != null)
                result.Add(dy.O);
            if (Convert.ToString(dy.P) != "-" && dy.P != null)
                result.Add(dy.P);
            return result;
        }
    }
}
