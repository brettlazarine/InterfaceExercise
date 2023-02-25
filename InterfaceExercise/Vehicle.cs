using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal abstract class Vehicle : IVehicle, ICompany
    {
        public abstract int Wheels { get; set; }
        public abstract int Doors { get; set; }
        public abstract int MaxSpeed { get; set; }
        public abstract string HonkNoise { get; set; }
        public abstract string Logo { get; set; }
        public abstract bool HasMultipleModels { get; set; }

        public abstract void PrintDetails();
    }
}
