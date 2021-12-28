using System.Collections;
using System.Collections.Generic;

namespace TheGarage
{
    // A collection of vehicles.   
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private int capacity;
        private int count;
        private T[] vehicles;

        public int Count => count;
        public bool IsFull => count >= capacity;
        public Garage(int capacity)
        {
            //Validate capacity
            this.capacity = capacity;
            vehicles = new T[capacity];

        }

        public bool Park(T vehicle)
        {
            //Finns plats
            if (IsFull) return false;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    count++;
                    return true;
                }
            }

            return false;
        }

        public bool Unpark(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {

                if (vehicles[i] == vehicle)
                {
                    vehicles[i] = null;
                    count--;
                    return true;

                }
            }

            return false;
        }

        // Här definierar vi vad som händer när man gör en foreach på en Garage-variabel
        public IEnumerator<T> GetEnumerator()
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
