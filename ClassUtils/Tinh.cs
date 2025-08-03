using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_Phuong.ClassUtils
{
	public class Tinh
	{
		public int Id { get; set; }
		public double h { get; set; }
		public double a { get; set; }
		public double hf { get; set; }
		public double b { get; set; }
		public double bf { get; set; }
		public double L { get; set; }
		public double Rb { get; set; }
		public double Rs { get; set; }
		public double Ma { get; set; }
		public double Mb { get; set; }
		public double Mc { get; set; }
		public double AsA { get; set; }
		public double AsB { get; set; }
		public double AsC { get; set; }
		public List<double> Am { get; set; } = new List<double>();
		public List<double> zeta { get; set; } = new List<double>();
		public Tinh(double height, double cover, double hs, double width, double length, double Rbb, double Rss, double Maa, double Mbb, double Mcc)
		{
			h = height;
			a = cover;
			hf = hs;
			b = width;
			L = length;
			Rb = Rbb;
			Rs = Rss;
			Ma = Maa * 1000000;
			Mb = Mbb * 1000000;
			Mc = Mcc * 1000000;
			Run();
		}
		private void Run()
		{
			double h0 = h - a;
			var Mmax = new List<double>() { Ma, Mb, Mc };
			List<double> Ass = new List<double>();
			foreach (var M in Mmax)
			{
				double As = 0;
				if (M < 0)
				{
					As = DienTichThepTietDienChuNhat(M, out var am, out var z);
					Am.Add(am);
					zeta.Add(z);
				}
				else
				{
					bf = b + 2 * DoVuonCanh();

					if (M < TinhHeSo.Mf(Rb, bf, hf, h0))
					{
						As = DienTichThepTietDienChuNhat(M, out var am, out var z);
						Am.Add(am);
						zeta.Add(z);
					}
					else
					{
						As = DienTichThepTietDienChuT(M, out var am, out var z);
						Am.Add(am);
						zeta.Add(z);
					}
				}
				Ass.Add(As);
			}
			AsA = Math.Round(Ass[0] / 100, 4);
			AsB = Math.Round(Ass[1] / 100, 4);
			AsC = Math.Round(Ass[2] / 100, 4);
		}
		private double DoVuonCanh()
		{
			if (hf >= 0.1 * h)
			{
				double res = L / 6;
				if (Math.Floor(res / 10) == 0)
				{
					return res;
				}
				else
				{

					return Math.Floor(res / 10) * 10;
				}
			}
			else
			{
				double res = Math.Min(L / 6, 6 * hf);

				if (Math.Floor(res / 10) == 0)
				{
					return res;
				}
				else
				{

					return Math.Floor(res / 10) * 10;
				}
			}
		}

		private double DienTichThepTietDienChuNhat(double M, out double am, out double zeta)
		{
			double h0 = h - a;

			am = Math.Abs(M) / (Rb * b * h0 * h0);

			zeta = (1 + Math.Sqrt(1 - 2 * am)) / 2;

			return Math.Abs(M) / (Rs * zeta * h0);
		}
		private double DienTichThepTietDienChuT(double M, out double am, out double zeta)
		{
			double h0 = h - a;

			am = (Math.Abs(M) - Rb * (bf - b) * hf * (h0 - 0.5 * hf)) / (Rb * b * h0 * h0);

			zeta = 0;

			double E = TinhHeSo.Esp(am);

			return Rb / Rs * (E * b * h0 + (bf - b) * hf);
		}
	}
	public class TinhHeSo
	{
		public static double Esp(double am)
		{
			return (1 - Math.Sqrt(1 - 2 * am));
		}

		public static double Mf(double Rb, double bf, double hf, double h0)
		{
			return Rb * bf * hf * (h0 - 0.5 * hf);
		}
	}
}
