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

        private static bool ExitProgram = false;
        public static void Run()
        {

            while (!ExitProgram)
            {
                Console.WriteLine("Please Insert through the menu by inputting the number \n(1, 2, 3 ,4,5,6,7, 0) of your choice"
                     + "\n1. Create garage"
                     + "\n2. park the Vehicles"
                     + "\n3. Unpark the Vehicle"
                     + "\n4. List all vehicles parked"
                     + "\n5. Setting maximum capacity of garage"
                     + "\n6. Find Vehicles based on Properties "
                     + "\n7. Search based on regno"
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
                        CreateGarage();
                        break;

                    case '2':
                        ParkVehicleToGarage();
                        break;

                    case '3':
                        UnParkVehicleToGarage();
                        break;

                    case '4':
                        ListAllVehiclesParked();
                        break;

                    case '5':
                        SettingGarageMaxCapacity();
                        break;

                    case '6':
                        FindVehiclesbasedonProperties();
                        break;

                    case '7':
                        FindVehiclebasedonregno();

                        break;
                    case '0':
                        ExitProgram = true;
                        break;
                    default:
                        break;
                }

            }


        }
    }
}
