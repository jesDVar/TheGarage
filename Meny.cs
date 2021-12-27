using System;

namespace TheGarage
{
    // The main meny, Where user gets instructions.
    // Availability only for user input/output.
    //
    // User should be able to do different
    // options with the vehicles, like;
    // park, take them out or to to check
    // what there is available in the garage atm.
    //
    // Make use of Interface
    //ToDo: Look up Interface... and ToDo...
    //
    //This is where all the communication
    // will be between the user and the program. 
    public class Meny
    {
        public Meny()
        {
            do
            {
                ShowMainMeny();
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        GarageHandler.Park();
                    default:
                        break;
                }

            } while (true);
        }

        private void ShowMainMeny()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("            MENU                    ");
            Console.WriteLine("************************************");
            Console.WriteLine("1: Park a vehicle.");
            Console.WriteLine("2: Remove a vehicle.");
            Console.WriteLine("3: Create a new Garage.");
            //Console.WriteLine("4: Add 5 dummy vehicles to the garage.");            
            //Console.WriteLine(": Add 5 dummy vehicles to the garage.");
            //Console.WriteLine(": Add 10 dummy vehicles to the garage.");
        }
    }
}

