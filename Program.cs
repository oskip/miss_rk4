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

                Equation parameters = new Equation(new Dictionary<float, float>()
                                                    {
                                                        //Współczynniki przy potęgach x
                                                        //np. {0, 3.5f}, {2, -5f} to: 3.5 + -5x^2
                                                        {0f, 3.5f}, {1f, 2.5f}, {2f, -5f}
                                                    },
                                                    new Dictionary<float, float>()
                                                    {
                                                        //Współczynniki przy potęgach e
                                                        //np. {1, 2}, {3, -4f} to: 2e^t - 4e^3t
                                                        {1f, 2f}
                                                    }
                );
                var results = new RungeKutta4(parameters, precision, x0);

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
