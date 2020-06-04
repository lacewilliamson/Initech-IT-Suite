using System;

namespace InitichSuite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Initech IT Suite";

            MachineStartup.Boot();
            
            Login.Start();
        }
    }
}
