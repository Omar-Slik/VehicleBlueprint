using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputModel = Console.ReadLine();
            string inputEngineType = Console.ReadLine();
            string inputColor = Console.ReadLine();
            int inputSeat = Console.Read();
            

            var newCar = new Car(inputModel,inputEngineType,inputColor,inputSeat);
        }
    }
}
