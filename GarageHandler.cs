using System;
using System.Collections.Generic;

namespace Garage1._0
{
    public class GarageHandler : IGarageHandler
    {
        private Garage<Vehicle> vehicles;


        internal void CreateGarage(int capacity)
        {
            vehicles = new Garage<Vehicle>(capacity);
            Console.WriteLine($"Created Garage with Capacity: {capacity}.Length You can Park your Vehicles.");
        }

       

        internal void ParkVehicle(string vehicletype,string regno,string color,int noofwheels,int noofengines)
        {
            vehicles.Add(new Airplane(regno, color, noofwheels, noofengines));
        }
    }
}