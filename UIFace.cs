using System;

namespace TheGarage
{
    // User interface where we handle all the input/output.
    class UIFace
    {
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public void PrintString(string message)
        {
            Console.WriteLine(message);
        }
    }
}
