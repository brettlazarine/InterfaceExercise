using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    interface IVehicle
    {           /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
        int Wheels { get; set; }
        int Doors { get; set; }
        int MaxSpeed { get; set; }
        string HonkNoise { get; set; }
    }
}
