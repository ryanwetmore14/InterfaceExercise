using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public bool HasTrunk { get; set; } = true;

        public int NumberOfSeats { get; set; } = 4;
        public string logo { get; set; } = "Ford";
        public string color { get; set; } = "Red";
        public int NumberOfWheels { get; set; } = 4;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F-250";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;


        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward...");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward");
            }

        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant reverse until we change gears");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant park until we change gears");
            }
        }

        public void ChangeGears(bool IsChanged)
        {
            HasChangedGears = IsChanged;
        }
    }
}
