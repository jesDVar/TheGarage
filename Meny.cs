using System;
using System.Collections.Generic;

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
        private GarageHandler garageHandler;
        private UIFace ui;

        public Meny()
        {
            ui = new UIFace();
        }

        internal void Run()
        {
            CreateGarage();

            do
            {
                MainAppRun();

            } while (true);
        }

        private void MainAppRun()
        {
            ShowMainMeny();
            //GetUserInput();
            var input = Console.ReadLine();


            switch (input.ToUpper())
            {
                case "1":

                    // Give feedback to screen.
                    Console.Clear();
                    // Declaire vehicles to park
                    ShowParkingMeny();
                    
                    // We'll check this input.
                    
                    
                    switch (ui.GetUserInput()) 
                    {
                        case "1":
                            //Console.WriteLine("HELLLO CASE 1");
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        default:
                            break;
                    }

                    //Trying to reach GarageHandler to "park a vehicle".

                    // GarageHandler(Console.WriteLine());
                    //ar input = GarageHandler.Park();
                    //var input = UIFace.GetUserInput();
                    break;
                case "2":
                    
                    break;
                case "3":
                    garageHandler.SeedData();
                    break;
                case "4":
                    var vehicles = garageHandler.GetVehicles();
                    PrintVehicles(vehicles);
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        private void ShowParkingMeny()
        {

            Console.WriteLine("************************************");
            Console.WriteLine("          PARK A VEHICLE            ");
            Console.WriteLine("************************************");
            Console.WriteLine("What kind of vehicle do" +
                              " you want to park?");
            Console.WriteLine("1: Airplane");
            Console.WriteLine("2: Motorcycle");
            Console.WriteLine("3: Car");
            Console.WriteLine("4: Bus");
            Console.WriteLine("5: Boat");
            Console.WriteLine("Q: Quit.");




        }

        private void PrintVehicles(IEnumerable<Vehicle> vehicles)
        {
            foreach (var v in vehicles)
            {
                ui.PrintString(v.ToString());
            }
        }

        private void CreateGarage()
        {
          
                ShowCreateGarageMeny();
                var input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "1":
                        //Set garage size 
                        //Intansiate handler with size
                        ui.PrintString("Size of garage?");
                        int capacity = 0;
                        while (!int.TryParse(Console.ReadLine(), out capacity))
                        {
                            Console.WriteLine("Only numeric values!");
                        }
                        garageHandler = new GarageHandler(capacity);
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }    
        }
        private static void ShowCreateGarageMeny()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("          CRATE GARAGE MENU         ");
            Console.WriteLine("************************************");
            Console.WriteLine("1: Create a new Garage.");
            Console.WriteLine("Q: Quit.");
        }

        private void ShowMainMeny()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("            MENU                    ");
            Console.WriteLine("************************************");
            Console.WriteLine("1: Park a vehicle.");
            Console.WriteLine("2: Remove a vehicle.");
            Console.WriteLine("3: Add 3 dummy vehicles.");
            Console.WriteLine("4: Show all vehicles.");
            Console.WriteLine("Q: Quit.");

        }
    }
}

