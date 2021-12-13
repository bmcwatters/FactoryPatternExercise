using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    class Car : IVehicle
    {
        public string Color { get; set; }
        public bool IsDrivable { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Sorry, I'm driving right now in my {Color} car!");


        }




    }
}
