using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE

            //DONE - Create a seperate class file called Car
            //DONE - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE - The methods should take one string parameter: the respective noise property


            //DONE - Now that the Car class is created we can instanciate 3 new cars
            //DONE - Set the properties for each of the cars
            //DONE - Call each of the methods for each car

            var lot = new CarLot();

            var elantra = new Car();
            elantra.Year = 2015;
            elantra.Make = "Hyundai";
            elantra.Model = "Elantra";
            elantra.IsDriveable = true;
            elantra.EngineNoise = "vroom";
            elantra.HonkNoise = "beeeep";

            elantra.MakeEngineNoise();
            elantra.MakeHonkNoise();
            Console.WriteLine();

            lot.Cars.Add(elantra);


            var modelT = new Car()
            {
                Year = 1933,
                Make = "Ford",
                Model = "Model T",
                IsDriveable = false,
                EngineNoise = "glug",
                HonkNoise = "honk honk",
            };
            

            modelT.MakeEngineNoise();
            modelT.MakeHonkNoise();
            Console.WriteLine();

            lot.Cars.Add(modelT);


            var dbs = new Car(2022, "Aston Martin", "DBS", "prrrr", "beep beep", true);
            
            dbs.MakeEngineNoise();
            dbs.MakeHonkNoise();
            Console.WriteLine();

            lot.Cars.Add(dbs);

            //*************BONUS*************//

            //DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE - Create a CarLot class
            //DONE - It should have at least one property: a List of cars
            //DONE - Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //DONE - At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine("The lot contains: ");
            foreach (var vehicle in lot.Cars)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }
        }
    }
}
