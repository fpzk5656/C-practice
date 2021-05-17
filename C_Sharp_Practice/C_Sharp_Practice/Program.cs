using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    // 접근한정자 예제

    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            // this.temperature는 protected로 선언했지만
            // 해당 함수는 public 이라서 외부에서 이 함수를 통해 접근 가능하다.
            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine("Turn on water : {0} ", temperature);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
