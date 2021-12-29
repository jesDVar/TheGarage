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
    }
}
