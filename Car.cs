namespace Garage1._0
{
    public class Car : Vehicle
    {
        public int Fueltype { get; set; }

        public Car(string regno, string color, int noofwheels, int fueltype) : base(regno, color, noofwheels)
        {

            this.Fueltype = fueltype;
        }
    }
}