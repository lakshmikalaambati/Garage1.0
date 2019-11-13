using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage1._0
{
    public class GarageHandler 
    {
        private Garage<Vehicle> garage;


        public void CreateGarage(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            Console.WriteLine($"Created Garage with {capacity} Capacity.You can Park your Vehicles.");
            Console.WriteLine(garage.Count);
        }

       

        public void ParkVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"ISFULL VARiable:{garage.IsFull}");

            if (garage.IsFull == false)
            {
                garage.Add(vehicle);
                Console.WriteLine(garage.Count);
                foreach (var item in garage)
                {
                    Console.WriteLine(item.Toprint());

                }
            }
            else
            {
                Console.WriteLine("garage is full");
            }

        }

        internal void UnParkVehicle(string regno)
        {
            
        }
    }
}