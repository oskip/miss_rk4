using System;

namespace MiSS_RK4
{
    public class RungeKutta4
    {
        private Func<double, double, double> expression;
        private int iteration = 0;
        private double y_t, y_tn, k1, k2, k3, k4, h, precision;
        
        public RungeKutta4(Func<double, double, double> expression, int precision, double x0)
        {
            y_tn = k1 = k2 = k3 = k4 = h = 0;
            this.expression = expression;
            this.precision = precision;
            this.y_t = x0;
        }

        public double Go()
        {
            throw new NotImplementedException();
        }
    }
}