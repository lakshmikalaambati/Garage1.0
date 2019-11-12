using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Garage1._0
{
    public class UI
    {


        
        internal static void Run()
        {
            
            Console.WriteLine("Please Enter Capacity of Garage to be created");
            int capacity = int.Parse(Console.ReadLine());

            var garagehandler = new GarageHandler();
            garagehandler.CreateGarage(capacity);

               

            bool ExitProgram = false;
            while (!ExitProgram)
            {
                Console.WriteLine("Please Insert through the menu by inputting the number \n(1, 2, 3 ,4,5,6,7, 0) of your choice"
                     + "\n1. park the Vehicles"
                     + "\n2. Unpark the Vehicle"
                     + "\n3. List all vehicles parked"
                     + "\n4. Setting maximum capacity of garage"
                     + "\n5. Find Vehicles based on Properties "
                     + "\n6. Search based on regno"
                     + "\n0. Exit the application");

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {


                    case '1':
                        ParkVehicleToGarage(garagehandler);
                        break;

                    //    case '2':
                    //        UnParkVehicleToGarage();
                    //        break;

                    //    case '3':
                    //        ListAllVehiclesParked();
                    //        break;

                    //    case '4':
                    //        SettingGarageMaxCapacity();
                    //        break;

                    //    case '5':
                    //        FindVehiclesbasedonProperties();
                    //        break;

                    //    case '6':
                    //        FindVehiclebasedonregno();

                    //        break;
                    case '0':
                        ExitProgram = true;
                        break;
                    default:
                        break;
                }

            }


        }

        private static void ParkVehicleToGarage(GarageHandler garagehandler)
        {
            Console.WriteLine("Please Specify which Vehicle to be Parked" +
                "\nAirplane" +
                "\nMotorCycle" +
                "\nCar" +
                "\nBus" +
                "\nBoat");
            string Vehicletype = Console.ReadLine();
            Console.WriteLine("Please specify Reg No of the Vehicle");
            string regNo = Console.ReadLine();

            Console.WriteLine("Please specify Color of the Vehicle");
            string color = Console.ReadLine();

            Console.WriteLine("Please specify number of wheels");
            string noofwheels = Console.ReadLine();

            switch (Vehicletype.ToLower())
            {
                case "airplane":
                    Console.WriteLine("Please specify number of Engines");
                    string noofengines = Console.ReadLine();
                    garagehandler.ParkVehicle(Vehicletype,regNo,color,noofwheels, noofengines);
                    break;

                case "motorcycle":
                    Console.WriteLine("Please specify CylinderVolume");
                    string cylindervolume = Console.ReadLine();

                    break;

                case "car":
                    Console.WriteLine("Please specify FuelType");
                    string fueltype = Console.ReadLine();

                    break;

                case "bus":
                    Console.WriteLine("Please specify No of Seats");
                    string noofseats = Console.ReadLine();

                    break;

                case "boat":
                    Console.WriteLine("Please specify Length");
                    string length = Console.ReadLine();
                    break;

                
                default:
                    break;
            }
        }
    }
}
