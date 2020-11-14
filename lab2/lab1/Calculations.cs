using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
      public class Calculations
     {
        public List<double> xValues;
        public double Mx;
        public double Dx;
        public double Sigma;
        public int period;
        public int aperiodLength;

        public Calculations(List<double> xValues)
        {
            this.xValues = xValues;
            this.Mx = 0;
            this.Dx = 0;
            this.Sigma = 0;
            this.period = 0;
            this.aperiodLength = 0;
        }

        public double getMx()
        {
            if (Mx == 0)
            {
                findMx();
            }
            return Mx;
        }

        public double getDx()
        {
            if (Dx == 0)
            {
                findDx();
            }
            return Dx;
        }

        public double getSigma()
        {
            if (Sigma == 0)
            {
                findSigma();
            }
            return Sigma;
        }

        public int getPeriod()
        {
            if (period == 0)
            {
                findPeriod();
            }
            return period;
        }

        public int getAperiodLength()
        {
            if (aperiodLength == 0)
            {
                findAperiodLength();
            }
            return aperiodLength;
        }



        public  void findMx()
        {
            double sum = 0;
            foreach (double x in xValues)
            {
                sum += x;
            }
            Mx = (sum / xValues.Count);
        }

        public   void findDx()
        {
            double Mx = getMx();
            double sum = 0;
            foreach (double x in xValues)
            {
                sum += (x - Mx) * (x - Mx);
            }

            Dx = sum / xValues.Count;
        }

        public  void findSigma()
        {
            Sigma = Math.Sqrt(Dx);
        }

        public  void findPeriod()
        {
            double Xv = xValues[xValues.Count - 1];
            int i1 = 0, i2 = 0;
            bool flag = false;
            Console.WriteLine("Xv = " + Xv);
               
            for (int i = 0; i < xValues.Count; i++)
            {
                if (Math.Abs(xValues[i] - Xv) < 0.000000000000001)
                {
                    if (!flag)
                    {
                        flag = true;
                        i1 = i;
                    }
                    else
                    {
                        i2 = i;
                        break;
                    }
                }
            }

            period = i2 - i1;
        }

        public  void  findAperiodLength()
        {
            int i3 = 0;
            while (xValues[i3] != xValues[i3 + period])
                i3++;
            aperiodLength =  i3 + period;
        }

        public double check()
        {
            int k = 0;

            for (int i = 0; i < xValues.Count; i += 2)
            {
                if (xValues[i] * xValues[i] + xValues[i + 1] * xValues[i + 1] < 1)
                {
                    k++;
                }
            }

            return 2 * (double)k / xValues.Count;
        }

    }
}
