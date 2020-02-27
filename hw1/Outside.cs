using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    public class Outside : Temperature
    {
        public Outside() { }
        public Outside(string name, int currentvalue, int min_value, int max_value)
            : base(name, currentvalue, min_value, max_value)
        {

        }

        public override void ConvertToFahrenheit()
        {
            if (demension == Demension.fahrenheit)
            {
                Console.WriteLine("Зачем ты пытаешься перевести с фаренгейтов в фаренгейты ?");
                return;
            }
            if (demension == Demension.celsius)
            {
                demension = Demension.fahrenheit;
                currentvalue = 32 + (currentvalue * 9 / 5);
                min_value = 32 + (min_value * 9 / 5);
                max_value = 32 + (max_value * 9 / 5);
                Console.WriteLine("Значение наружной темпеарутры переведены из цельсий в фаренгейты");
            }
            if (demension == Demension.kelvin)
            {
                demension = Demension.fahrenheit;
                currentvalue = 32 + (currentvalue - 273) * 9 / 5;
                min_value = 32 + (min_value - 273) * 9 / 5;
                max_value = 32 + (max_value - 273) * 9 / 5;
                Console.WriteLine("Значение наружной темпеарутры переведены из кельвин в фаренгейты");
            }
        }

        public override void ConvertToKelvin()
        {
            if (demension == Demension.celsius)
            {
                demension = Demension.kelvin;
                currentvalue = currentvalue + 273;
                min_value = min_value + 273;
                max_value = max_value + 273;
                Console.WriteLine("Значение наружной темпеарутры переведены из цельсий в кельвины");
            }
            if (demension == Demension.fahrenheit)
            {
                demension = Demension.kelvin;
                currentvalue = (currentvalue - 32) * 5 / 9 + 273;
                min_value = (min_value - 32) * 5 / 9 + 273;
                max_value = (max_value - 32) * 5 / 9 + 273;
                Console.WriteLine("Значение наружной темпеарутры переведены из фаренгейтов в кельвины");
            }
            else
            {
                Console.WriteLine("Зачем ты пытаешься перевести с кельвинов в кельвины ?");
            }
        }
    }
}
