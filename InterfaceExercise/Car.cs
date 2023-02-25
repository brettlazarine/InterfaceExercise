using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : Vehicle, IVehicle, ICompany
    {
        public  bool RearTrunk { get; set; } = true;
        public  bool Sedan { get; set; }
        public override int Wheels { get; set; }
        public override int Doors { get; set; }
        public override int MaxSpeed { get; set; }
        public override string HonkNoise { get; set; }
        public override string Logo { get; set; }
        public override bool HasMultipleModels { get; set; } = true;
        public override void PrintDetails()
        {
            Console.WriteLine($"This {(Sedan ? "sedan" : "coupe")} has a {(RearTrunk ? "rear" : "front")} trunk.");
        }
    }
}
