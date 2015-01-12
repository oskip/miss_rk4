using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MiSS_RK4
{
    public class Equation
    {
        private readonly Dictionary<float, float> xPowersCoefficients;
        private readonly Dictionary<float, float> ePowersCoefficients;

        public Equation(Dictionary<float, float> xPowersCoefficients, Dictionary<float, float> ePowersCoefficients)
        {
            this.xPowersCoefficients = xPowersCoefficients;
            this.ePowersCoefficients = ePowersCoefficients;
        }

        public double Calculate(double x, double t)
        {
            return xPowersCoefficients.Sum(coefficient => Math.Pow(x, coefficient.Key)*coefficient.Value) 
                + ePowersCoefficients.Sum(coefficient => Math.Exp(coefficient.Key*t)*coefficient.Value);
        }
    }
}