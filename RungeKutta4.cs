using System;

namespace MiSS_RK4
{
    public class RungeKutta4
    {
        private Equation parameters;
        private int iteration = 0;
        private double y_t, y_tn, k1, k2, k3, k4, h, precision;
        
        public RungeKutta4(Equation parameters, int precision, double x0)
        {
            y_tn = k1 = k2 = k3 = k4 = h = 0;
            this.parameters = parameters;
            this.precision = precision;
            this.y_t = x0;
        }

        public double Go()
        {
            throw new NotImplementedException();
        }
    }
}