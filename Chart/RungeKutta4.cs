using System;
using System.Collections.Generic;

namespace MiSS_RK4
{
    public class RungeKutta4
    {
        private readonly Func<double, double, double> f;
        private double y_t, k1, k2, k3, k4, h, t_i;

        public RungeKutta4(Func<double, double, double> f, double step, double x0)
        {
            k1 = k2 = k3 = k4 = h = t_i = 0;
            this.f = f;
            this.h = step;
            this.y_t = x0;
        }

        public IEnumerable<Tuple<double, double>> Go()
        {
            while (t_i < 1)
            {
                if (t_i + h > 1) h = 1 - t_i;
                t_i += h;
                k1 = f(t_i, y_t);
                k2 = f(t_i + 0.5 * h, y_t + 0.5 * k1 * h);
                k3 = f(t_i + 0.5 * h, y_t + 0.5 * k2 * h);
                k4 = f(t_i + h, y_t + k3 * h);

                y_t += (1 / 6d) * (k1 + 2 * k2 + 2 * k3 + k4) * h;
                yield return new Tuple<double, double>(t_i, y_t);
            }
        }
    }
}