namespace Garage1._0
{
    public class Vehicle : IVehicle
    {
        
            public string Regno { get; set; }
            public string Color { get; set; }
            public int NoOfWheels { get; set; }

            public Vehicle(string regno, string color, int noofwheels)
            {
                this.Regno = regno;
                this.Color = color;
                this.NoOfWheels = noofwheels;
            }

            public void ParkVehicle(string regno, string color, int noofwheels)
            { 
                 
        
        
            }
            
            public void UnparkVehicle(string regno)
            { 


            }

        
    }
}