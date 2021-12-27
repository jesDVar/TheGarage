using System.Collections;
using System.Collections.Generic;

namespace TheGarage
{

    // A collection of vehicles.
    //
    //
    public class Garage<T> : IEnumerable<Vehicle> where T : Vehicle
    {

        private Vehicle[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new Vehicle[capacity];
           
        }

        public bool Park(Vehicle vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }

            return false;
        }

        public bool Unpark(string regno)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].RegNo == regno)
                {
                    vehicles[i] = null;
                    return true;
                }
            }

            return false;
        }

        // Här definierar vi vad som händer när man gör en foreach på en Garage-variabel
        public IEnumerator<Vehicle> GetEnumerator()
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    yield return vehicles[i];
                }
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
