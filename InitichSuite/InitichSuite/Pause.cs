using System;
using System.Collections.Generic;
using System.Text;


namespace InitichSuite
{
    public class Pause
    {
        static Random randomPause = new Random();
        public static void PauseStable(int length)
        {
            System.Threading.Thread.Sleep(length);
        }

        public static void PauseSlightlyRandom(int baseSpeed)
        {
            int length = randomPause.Next(baseSpeed,425);
            System.Threading.Thread.Sleep(length);
        }

        public static void PauseSlightlyRandom(int baseSpeed, int maxSpeed)
        {
            int length = randomPause.Next(baseSpeed, maxSpeed);
            System.Threading.Thread.Sleep(length);
        }
    }
}
