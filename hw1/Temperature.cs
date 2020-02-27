using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    public abstract class Temperature
    {
        protected string name;  //имя температуры
        protected int currentvalue;    //значение температуры в градусах цельсия
        protected int max_value;
        protected int min_value;
        protected Demension demension;  //размерность темпертуры

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Max_value
        {
            get { return max_value; }
        }

        public int Min_value
        {
            get { return min_value; }
        }

        public int Value
        {
            get { return currentvalue; }
            set { currentvalue = value; }
        }

        public Demension DementionState
        {
            get { return demension; }
        }

        protected Temperature()
        {
            demension = Demension.celsius;
            Console.WriteLine("Значение в цельсиях:");
        }

        protected Temperature(string Name, int Currentvalue, int Min_temperature, int Max_temperature) : this()  
        {
            this.name = Name;
            this.currentvalue = Currentvalue;
            this.min_value = Min_temperature;
            this.max_value = Max_temperature;
        }

        public abstract void ConvertToFahrenheit();
        public abstract void ConvertToKelvin();
    }
}
