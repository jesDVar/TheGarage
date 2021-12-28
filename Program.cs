/*
 * 
 * 
 * 
 * 
 */

namespace TheGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list with some "dummy" data.

            //var vehicles = new List<Vehicle>
            //{
            //    new Airplane("ADR123", "Green", 5, "Super Heavy", 4),
            //    new Airplane("DDL223", "Red", 8, "Super Heavy", 4),
            //    new Airplane("JKL098", "Blue", 8, "Super Heavy", 4),
            //    new Airplane("ERT980", "White", 8, "Super Heavy", 4),
            //    new Airplane("SDF123", "Green", 8, "Super Heavy", 4),

            //};


            //foreach (Vehicle fordon in vehicles)
            //{
            //    Console.WriteLine(fordon.Stats());
            //}            

            Meny meny = new Meny();
            meny.Run();

            //var gh = new GarageHandler(3);
            //gh.SeedData();
            //gh.PrintAllVehicles();
        }

        //private static void Meny()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
