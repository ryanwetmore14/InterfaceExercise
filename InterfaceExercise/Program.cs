using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            var truck = new Truck();

            var vehicles = new List<IVehicle>() { car, truck };







            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);  //if cgears not changed truck cannot reverse
                vehicle.Reverse();
            }

        }
    }
}
