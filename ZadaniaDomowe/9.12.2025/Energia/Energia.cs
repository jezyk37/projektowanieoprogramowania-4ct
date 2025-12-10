using System;

namespace Energia
{
    public class Energia
    {
        public double Ep(double m, double g, double h)
        {
            return m * g * h;
        }

        public double Ek(double m, double v)
        {
            return 0.5 * m * v * v;
        }

        public double Em(double ep, double ek)
        {
            return ep + ek;
        }
    }
}
