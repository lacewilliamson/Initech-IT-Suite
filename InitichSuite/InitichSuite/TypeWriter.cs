using System;
using System.Collections.Generic;
using System.Text;

namespace InitichSuite
{
    public class TypeWriter //This class simulates the printed of characters to the console to make them appear as if they are "typed".
    {
        public static void MachineType(string input, int stablePauseLength) //MachineType : Steady, controlled method for typing by some sort of computer or mechanism.
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (char character in input)
            {
                Console.Write(character);
                Pause.PauseStable(stablePauseLength);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.CursorVisible = true;

        }

        public static void MachineTypeInstant(string input) //MachineType : Instant typing, but removed cursor as needed.
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (char character in input)
            {
                Console.Write(character);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = true;

        }


        public static void HumanType(string input, int baseSpeed) // HumanType : Like MachineType, but with randomized pauses between characters.
        {
            foreach (char character in input)
            {
                Console.Write(character);
                Pause.PauseSlightlyRandom(baseSpeed);
            }
            Console.Write("\n");
        }

        public static void HumanType(string input, int baseSpeed, int maxSpeed, bool pauseBetweenWords) // HumanType Overload : Allows for a pause between words, delimited by a space. Looks more natural.
        {
            if (pauseBetweenWords)
            {
                {
                    string[] inputArray = input.Split(" ");

                    foreach (string word in inputArray)
                    {
                        foreach (char character in word)
                        {
                            Console.Write(character);
                            Pause.PauseSlightlyRandom(baseSpeed, maxSpeed);
                        }
                        Console.Write(" "); //Puts the space back in
                        Pause.PauseStable(920);
                    }

                }
                return;
            }
            foreach (char character in input)
            {
                Console.Write(character);
                Pause.PauseSlightlyRandom(baseSpeed, maxSpeed);
            }
            Console.Write("\n");
        }
    }
}
