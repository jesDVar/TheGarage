namespace TheGarage
{
    //Make this a baseclass, with several subclasses.
    //Interface.
    //
    //

    class Vehicle
    {
        /*[...Ska innehålla registreringsnummer, färg,
         * antal hjul och andra egenskaper ni kan komma på].
         *-----------------Note, what type should RegNr be?
         */

        // Add properties with some input logic.    
        public string Regnr { get; set; }
        public string Color { get; set; }
        public int NrOfWheels { get; set; }
        public string WeightCl { get; set; }


        

    }
}
