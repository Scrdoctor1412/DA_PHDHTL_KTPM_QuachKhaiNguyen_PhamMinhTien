using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tien_47_Nunit
{
    public class poly
    {
        private int n;
        private List<int> a;
        public poly(int n, List<int> a)
        {
            if (a.Count() != 1 + n)
            {
                throw new ArgumentException("Invalid Data");
            }
            this.n = n;
            this.a = a;
        }
        public double Cal(double x)
        {
            double result = 0;
            for (int i = 0; i <= this.n; i++)
            {
                result += (double)(a[i] * Math.Pow(x, i));
            }
            return result;
        }
    }
}
