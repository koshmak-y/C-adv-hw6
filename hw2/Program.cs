using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw1;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Outside t1 = new Outside("Снаржи", 4, 0, 10);
            Console.WriteLine("Текущая температура: {0}\nМинимальная температура: {1}\nМаксимальная температура: {2}\n", t1.Value, t1.Min_value, t1.Max_value);
            Console.WriteLine(new string ('-', 15));
            t1.ConvertToFahrenheit();
            Console.WriteLine("Текущая температура: {0}\nМинимальная температура: {1}\nМаксимальная температура: {2}\n", t1.Value, t1.Min_value, t1.Max_value);
            Console.WriteLine(new string('-', 15));
            t1.ConvertToFahrenheit();
            Console.WriteLine("Текущая температура: {0}\nМинимальная температура: {1}\nМаксимальная температура: {2}\n", t1.Value, t1.Min_value, t1.Max_value);
            Console.WriteLine(new string('-', 15));
            t1.ConvertToKelvin();
            Console.WriteLine("Текущая температура: {0}\nМинимальная температура: {1}\nМаксимальная температура: {2}\n", t1.Value, t1.Min_value, t1.Max_value);
            Console.ReadKey();
        }
    }
}
