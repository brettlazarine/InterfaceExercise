using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE  Create 2 Interfaces called IVehicle & ICompany

            //DONE  Create 3 classes called Car , Truck , & SUV

            //DONE  In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //DONE  In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //DONE  In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //DONE  Now, create objects of your 3 classes and give their members values;
            //DONE  Creatively display and organize their values
            var vehicles = new List<Vehicle>();
            var car = new Car()
            {
                RearTrunk = true,
                Sedan= false,
                Wheels = 4,
                Doors = 2, 
                MaxSpeed = 160,
                HonkNoise = "MeepMeep",
                Logo = "Bowtie",
                HasMultipleModels= true
            };
            vehicles.Add(car);
            var truck = new Truck()
            {
                FourWheelDrive= true,
                BedLength = 6.5,
                Wheels = 4,
                Doors = 4,
                MaxSpeed = 100,
                HonkNoise = "HOOOONK",
                Logo = "Oval",
                HasMultipleModels = true
            };
            vehicles.Add(truck);
            var suv = new SUV()
            {
                AWD = false,
                CargoHoldSize = 23.4,
                Wheels = 4,
                Doors = 4,
                MaxSpeed = 120,
                HonkNoise = "BeepBeep",
                Logo = "Sheep",
                HasMultipleModels = true
            }; 
            vehicles.Add(suv);
            foreach (var vehicle in vehicles)
            {
                vehicle.PrintDetails();
                Console.WriteLine($"This vehicle has {vehicle.Wheels} wheels, {vehicle.Doors} doors, a max speed of {vehicle.MaxSpeed} mph, and honks {vehicle.HonkNoise}.");
                Console.WriteLine($"This company's logo is {vehicle.Logo} shaped, and makes {(vehicle.HasMultipleModels ? "multiple models." : "one model.")}");
                Console.WriteLine("----------");
            }
        }
    }
}
