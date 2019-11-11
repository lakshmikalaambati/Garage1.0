namespace Garage1._0
{
    internal class Airplane : Vehicle
    {
        
        public int NoOfEngines { get; set; }
        
        public Airplane(string regno, string color, int noofwheels,int noOfEngines) : base(regno, color, noofwheels)  
        {

            this.NoOfEngines = noOfEngines;
        }
    }
}