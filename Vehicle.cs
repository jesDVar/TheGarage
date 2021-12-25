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
        public string RegNr { get; set; }
        public string Color { get; set; }
        public int NrOfWheels { get; set; }
        public string WeightCl { get; set; }

        public Vehicle(string regNr, string color, int nrOfWheels, string weightCl)
        {
            RegNr = regNr;
            Color = color;
            NrOfWheels = nrOfWheels;
            WeightCl = weightCl;
        }
        public virtual string Stats()
        {
            return $"This is a nice looking vehicle, let me see its licenseplate...{RegNr}";
        }
    }
    public class Airplane : Vehicle
    {
        private int NoOfEngines { get; set; }
        public Airplane(string regNr, string color, int nrOfWheels, string weightCl, int noOfEngines) : base(regNr, color, nrOfWheels, weightCl)
        {
            NoOfEngines = noOfEngines;
        }

    }

}
