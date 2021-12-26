using System;
using System.Collections.Generic;


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
            var vehicles = new List<Vehicle>
            {
                new Airplane("abc123", "Green", 8, "Super Heavy", 4),
                new Airplane("ddk223", "Green", 8, "Super Heavy", 4),
                new Airplane("jkl098", "Green", 8, "Super Heavy", 4),
                new Airplane("ert980", "Green", 8, "Super Heavy", 4),
                new Airplane("sdf123", "Green", 8, "Super Heavy", 4),

            };

            foreach (Vehicle fordon in vehicles)
            {
                Console.WriteLine(fordon.Stats());

            }
        }
    }
}
