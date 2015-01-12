using System;
using System.Collections.Generic;
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
                var x0 = Double.Parse(args[0]);
                var precision = Int32.Parse(args[1]);

                Func<double, double, double> expression = 
                    (x, t) => 4.5*Math.Pow(x, 3) + 2*Math.Pow(x, 2) - 18.63 + Math.Exp(2*t);

                var results = new RungeKutta4(expression, precision, x0);

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
