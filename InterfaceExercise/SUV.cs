using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : Vehicle, IVehicle, ICompany
    {
        public  bool AWD { get; set; }
        public  double CargoHoldSize { get; set; }
        public override int Wheels { get; set; }
        public override int Doors { get; set; }
        public override int MaxSpeed { get; set; }
        public override string HonkNoise { get; set; }
        public override string Logo { get; set; }
        public override bool HasMultipleModels { get; set; } = true;
        public override void PrintDetails()
        {
            Console.WriteLine($"This {(AWD ? "AWD" : "RWD")} SUV has a {CargoHoldSize} square foot cargo hold.");
        }
    }
}
