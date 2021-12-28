using System;
using System.Collections.Generic;
using System.Linq;

namespace TheGarage
{
    // The GarageHandler class which is
    // where we handle our garage
    // by adding/removing cars and
    // so on.
    //
    public class GarageHandler
    {
        //1. Add vehicle
        //2. Remove vehicle
        //3. List vehcles
        //4. Instantiate a new garage
        //5. Opt. to init. the garage with a collect. of vehicles
        //6. Find a spec. vehicle by licensplate
        //7. Find a spec. vehicle by looking at properties
        //8. Give the user feed-back from the flow

        private Garage<Vehicle> garage;
        private List<int> tempList = new();

        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            //var garage1 = new Garage<Airplane>(capacity);
            //var garage3 = new Garage<Bus>(capacity);
            //var garage4 = new Garage<string>(capacity);
        }

        public void PrintAllVehicles()
        {
            foreach (var vehicle in garage)
            {
                Console.WriteLine(vehicle.Stats());
            }
        }

        public void SeedData()
        {
            garage.Park(new Car("CAR111", "White", 4, "Light", 1));
            garage.Park(new Airplane("AIR111", "White", 5, "Light", 2));
            garage.Park(new MotorCycle("MOT111", "Red", 2, "Light", 1));
        }

        public void Park()
        { 

        }

        public void UnPark()
        {

        }

        public void FindByRegNo()
        {

        }

        internal IEnumerable<Vehicle> GetVehicles()
        {
            return garage.ToList();
        }

        internal IEnumerable<Vehicle> FindByColor(string color)
        {
            var redVehicles = garage.Where(v => v.Color == color);
            return redVehicles;
            //var found = garage.FirstOrDefault(v => v.RegNo == "ABC123");

            //foreach (var item in garage)
            //{

            //}
        }
    }
}
