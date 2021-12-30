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
    }
}
