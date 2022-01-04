using System;
using System.Collections.Generic;
using System.Linq;

namespace TheGarage
{

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
            garage.Park(new Car("CAR111", "White", 4, "Diesel"));
            garage.Park(new Airplane("AIR111", "White", 5, 1));
            garage.Park(new MotorCycle("MOT111", "Red", 2, 2));
            garage.Park(new MotorCycle("MOT222", "Black", 2, 2));
            garage.Park(new Bus("BUS111", "Red", 2, 2));
            garage.Park(new Boat("BOA111", "Red", 2, 20));
            garage.Park(new Boat("BOA222", "White", 2, 20));

            Console.WriteLine("Successfully seeded data.");
        }

        public void Park(Vehicle vehicle)
        {
            //return garage.Park();
            //if (garage.IsFull())
            //{

            //}
            //Vehicle parkVehicle = new();

            // When we park a vehicle we need to create a new
            // instance of a Vehicle, but WHAT do we
            // want to park(Car, Bus Airplane...)?

            //Console.WriteLine("Are You TRying To PARK?");
            //garage.Park(new Vehicle());

            if (garage.Park(vehicle))
            {
                Console.WriteLine($"Successfully parked vehicle: Type: {vehicle.GetType().Name}, Regnr: {vehicle.RegNo}.");
            }
            else
            {
                Console.WriteLine("Garage is full.");
            }

        }

        public void UnPark(string regnr)
        {
            if (garage.Unpark(regnr))
            {
                Console.WriteLine($"Successfully unparked vehicle with licence plate: {regnr}.");
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }

        public bool FindByRegNo(string regnr)
        {
            foreach (var vehicle in garage)
            {
                if (vehicle.RegNo == regnr)
                {
                    Console.WriteLine("Found the vehicle you were looking for:");
                    Console.WriteLine(vehicle.Stats());
                    return true;
                }
            }
            Console.WriteLine("Did not find that vehicle!");
            return false;
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

        }

        public void PrintGarageStats()
        {
            // loopa genom garage
            // använd vehicle.GetType().Name för att räkna hur många av varje sort det är
            // skriv ut på ett fint sätt (mha av string interpolation)
        }


        public enum VehicleObjects : ushort
        {
            Airplane = 1,
            Motorcycle = 2,
            Car = 3,
            Bus = 4,
            Boat = 5
        }
    }
}
