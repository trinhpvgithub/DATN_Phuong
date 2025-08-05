using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_Phuong.ClassUtils
{
	public class RebarCombo
	{
		public int Quantity1 { get; set; }
		public int Diameter1 { get; set; }
		public int Quantity2 { get; set; } // = 0 nếu chỉ dùng 1 loại
		public int Diameter2 { get; set; }
		public double TotalArea { get; set; }
		public double Excess { get; set; }

		public override string ToString()
		{
			if (Quantity2 > 0)
			{
				return $"{Quantity1}Ø{Diameter1} + {Quantity2}Ø{Diameter2} = {TotalArea:F1} mm²";
			}
			else
			{
				return $"{Quantity1}Ø{Diameter1} = {TotalArea:F1} mm²";
			}
		}
		public static List<RebarCombo> GetMixedRebarOptions_WithMin2Phi12(double AsMin, int maxTotalBars = 6, int maxResults = 3)
		{
			Dictionary<int, double> areaTable = new Dictionary<int, double>
			{
				{10, 78.5}, {12, 113.1}, {14, 153.9}, {16, 201.1}, {18, 254.5},
				{20, 314.2}, {22, 380.1}, {25, 490.9}, {28, 615.8}, {32, 804.2}
			};

			List<RebarCombo> combos = new List<RebarCombo>();
			var diameters = areaTable.Keys.ToList();

			// Tổ hợp 1 loại
			foreach (int d in diameters)
			{
				double area = areaTable[d] / 100;
				for (int q = 2; q <= maxTotalBars; q++)
				{
					double total = q * area;
					if (total >= AsMin && d >= 12 && q >= 2)
					{
						combos.Add(new RebarCombo
						{
							Quantity1 = q,
							Diameter1 = d,
							Quantity2 = 0,
							Diameter2 = 0,
							TotalArea = total,
							Excess = total - AsMin
						});
					}
				}
			}

			// Tổ hợp 2 loại
			for (int i = 0; i < diameters.Count; i++)
			{
				int d1 = diameters[i];
				double a1 = areaTable[d1];

				for (int j = i + 1; j < diameters.Count; j++)
				{
					int d2 = diameters[j];
					double a2 = areaTable[d2];

					for (int q1 = 1; q1 <= maxTotalBars - 1; q1++)
					{
						for (int q2 = 1; q2 <= maxTotalBars - q1; q2++)
						{
							int totalBars = q1 + q2;
							if (totalBars > maxTotalBars)
								continue;

							double total = q1 * a1 + q2 * a2;
							if (total >= AsMin)
							{
								// Ít nhất 2 thanh có phi ≥ 12
								int countPhi12OrMore = 0;
								if (d1 >= 12) countPhi12OrMore += q1;
								if (d2 >= 12) countPhi12OrMore += q2;

								if (countPhi12OrMore >= 2)
								{
									combos.Add(new RebarCombo
									{
										Quantity1 = q1,
										Diameter1 = d1,
										Quantity2 = q2,
										Diameter2 = d2,
										TotalArea = total,
										Excess = total - AsMin
									});
								}
							}
						}
					}
				}
			}

			return combos
				.OrderBy(c => c.Excess)
				.ThenBy(c => c.TotalArea)
				.Take(maxResults)
				.ToList();
		}
	}
}
