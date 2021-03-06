namespace TheGarage
{
    //Make this a baseclass, with several subclasses.
    //Interface.
    //
    //

    public abstract class Vehicle
    {
        /*[...Ska innehålla registreringsnummer, färg,
         * antal hjul och andra egenskaper ni kan komma på].
         *-----------------Note, what type should RegNr be?
         */

        // Add properties with some input logic.

        public string RegNo { get; set; }
        public string Color { get; set; }
        public int NoOfWheels { get; set; }


        public Vehicle(string regNo, string color, int noOfWheels)
        {
            RegNo = regNo;
            Color = color;
            NoOfWheels = noOfWheels;

        }
        public virtual string Stats()
        {
            return $"Type: {GetType().Name}, RegNo: {RegNo}, Color: {Color}, Number of wheels: {NoOfWheels}, ";
        }
    }
    public class Airplane : Vehicle
    {
        private int NoOfEngines { get; set; }
        public Airplane(string regNo, string color, int noOfWheels, int noOfEngines) : base(regNo, color, noOfWheels)
        {
            NoOfEngines = noOfEngines;
        }

        public override string Stats()
        {
            return base.Stats() + $"Number of engines: {NoOfEngines}."; 
        }
    }

    public class MotorCycle : Vehicle
    {
        private int NoOfSeats { get; set; }
        public MotorCycle(string regNo, string color, int noOfWheels, int noOfSeats) : base(regNo, color, noOfWheels)
        {
            NoOfSeats = noOfSeats;
        }

        public override string Stats()
        {
            return base.Stats() + $"Number of seats: {NoOfSeats}.";
        }
    }
    public class Car : Vehicle
    {
        private string FuelType { get; set; }
        public Car(string regNo, string color, int noOfWheels, string fuelType) : base(regNo, color, noOfWheels)
        {
            FuelType = fuelType;
        }

        public override string Stats()
        {
            return base.Stats() + $"Fueltype: {FuelType}.";
        }
    }
    public class Bus : Vehicle
    {
        private int CylVol { get; set; }
        public Bus(string regNo, string color, int noOfWheels, int cylVol) : base(regNo, color, noOfWheels)
        {
            CylVol = cylVol;
        }

        public override string Stats()
        {
            return base.Stats() + $"Cylinder Volume: {CylVol}.";
        }
    }
    public class Boat : Vehicle
    {
        private int Lenght { get; set; }
        public Boat(string regNo, string color, int noOfWheels, int lenght) : base(regNo, color, noOfWheels)
        {
            Lenght = lenght;
        }

        public override string Stats()
        {
            return base.Stats() + $"Length: {Lenght}.";
        }

    }
}




