using System;

namespace TheGarage
{
    // User interface where we handle all the input/output.
    class UIFace
    {
        public string GetUserInput()
        {
            String userInput = Console.ReadLine();
            return userInput.ToUpper();

        }

        public void PrintString(string message)
        {
            Console.WriteLine(message);
        }

        public Vehicle GetInputParking()
        {

            Console.WriteLine("\nLicence plate?");
            var regnr = Console.ReadLine();

            Console.WriteLine("\nColor?");
            var color = Console.ReadLine();

            Console.WriteLine("\nNumber of wheels?");
            var nrOfWheels = int.Parse(Console.ReadLine());

            Console.WriteLine(
                "\nType of vehicle?\n" +
                "1. Car\n" +
                "2. Airplane\n" +
                "3. Boat\n" +
                "4. Bus\n" +
                "5. Motorcycle\n");

            var type = Console.ReadKey().KeyChar;

            do
            {
                switch (type)
                {
                    case '1':
                        Console.WriteLine("\nFueltype?");
                        var fuelType = Console.ReadLine();
                        return new Car(regnr, color, nrOfWheels, fuelType);
                    case '2':
                        Console.WriteLine("\nNumber of engines?");
                        var nrOfEngines = int.Parse(Console.ReadLine());
                        return new Airplane(regnr, color, nrOfWheels, nrOfEngines);
                    case '3':
                        Console.WriteLine("\nLength?");
                        var length = int.Parse(Console.ReadLine());
                        return new Boat(regnr, color, nrOfWheels, length);
                    case '4':
                        Console.WriteLine("\nCylinder Volume?");
                        var cylVol = int.Parse(Console.ReadLine());
                        return new Bus(regnr, color, nrOfWheels, cylVol);
                    case '5':
                        Console.WriteLine("\nNumber of seats?");
                        var nrOfSeats = int.Parse(Console.ReadLine());
                        return new MotorCycle(regnr, color, nrOfWheels, nrOfSeats);
                    default:
                        Console.WriteLine("\nPlease press 1-5 and nothing else!");
                        break;
                }

            } while (true);

            


        }

        public string GetInputRegNr()
        {
            Console.WriteLine("Enter registration number:\n");
            return Console.ReadLine();
        }
    }
}
