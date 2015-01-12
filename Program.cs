using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiSS_RK4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2) throw new Exception("Nie podano wszystkich parametrów");
                var x0 = Double.Parse(args[0], CultureInfo.InvariantCulture);
                var step = Double.Parse(args[1], CultureInfo.InvariantCulture);

                //Równanie do RK4
                Func<double, double, double> expression =
                    //(t, x) => 4.5*Math.Pow(x, 3) + 2*Math.Pow(x, 2) - 18.63 + Math.Exp(2*t);
                    (t, x) => -0.5 * x + 4 * Math.Exp(0.8 * t);

                var results = new RungeKutta4(expression, step, x0).Go();
                foreach (var d in results)
                {
                    Console.WriteLine(d);
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is ArgumentNullException)
                    Console.WriteLine("Podano nieprawidłowe dane wejściowe");
                else Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Wciśnij dowolny klawisz...");
            Console.ReadKey(true);
        }
    }
}
