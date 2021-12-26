namespace TheGarage
{
    //Make this a baseclass, with several subclasses.
    //Interface.
    //
    //

    public class Vehicle
    {
        /*[...Ska innehålla registreringsnummer, färg,
         * antal hjul och andra egenskaper ni kan komma på].
         *-----------------Note, what type should RegNr be?
         */

        // Add properties with some input logic.    
        public string RegNo { get; set; }
        public string Color { get; set; }
        public int NoOfWheels { get; set; }
        public string WeightCl { get; set; }

        public Vehicle(string regNo, string color, int noOfWheels, string weightCl)
        {
            RegNo = regNo;
            Color = color;
            NoOfWheels = noOfWheels;
            WeightCl = weightCl;
        }
        public virtual string Stats()
        {
            return $"This is a nice looking vehicle, let me see its licenseplate...{RegNo}";
        }
    }
    public class Airplane : Vehicle
    {
        private int NoOfEngines { get; set; }
        public Airplane(string regNo, string color, int noOfWheels, string weightCl, int noOfEngines) : base(regNo, color, noOfWheels, weightCl)
        {
            NoOfEngines = noOfEngines;
        }
    }
    public class MotorCycle : Vehicle
    {
        private int NoOfSeats { get; set; }
        public MotorCycle(string regNo, string color, int noOfWheels, string weightCl, int noOfSeats) : base(regNo, color, noOfWheels, weightCl)
        {
            NoOfSeats = noOfSeats;
        }
        public class Car : Vehicle
        {
            private int CylVol { get; set; }
            public Car(string regNo, string color, int noOfWheels, string weightCl, int cylVol) : base(regNo, color, noOfWheels, weightCl)
            {
                CylVol = cylVol;
            }
        }
        public class Bus : Vehicle
        {
            private int CylVol { get; set; }
            public Bus(string regNo, string color, int noOfWheels, string weightCl, int cylVol) : base(regNo, color, noOfWheels, weightCl)
            {
                CylVol = cylVol;
            }
        }
        public class Boat : Vehicle
        {
            private int Lenght { get; set; }
            public Boat(string regNo, string color, int noOfWheels, string weightCl, int lenght) : base(regNo, color, noOfWheels, weightCl)
            {
                Lenght = lenght;
            }
        }
    }
}




