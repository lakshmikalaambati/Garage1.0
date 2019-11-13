using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage1._0
{
    public class GarageHandler 
    {
        private Garage<Vehicle> garage;
        public int indexnum = 0;


        public void CreateGarage(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            Console.WriteLine($"Created Garage with {capacity} Capacity.You can Park your Vehicles.");
            //Console.WriteLine(garage.Count);
        }

       

        public void ParkVehicle(Vehicle vehicle)
        {
            garage.Add(vehicle);


            //int newindex= garage.Add(vehicle,indexnum);
            //indexnum = newindex;

        }

        internal void UnParkVehicle(string regno)
        {
            
        }
    }
}
