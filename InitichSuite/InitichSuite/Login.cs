using System;
using System.Collections.Generic;
using System.Text;

namespace InitichSuite
{
    public class Login
    {
        private string UserName { get; } = "M.Judge";
        private string Password { get; } = "setecastronomy";
        public static void Start()
        {
            TypeWriter.MachineTypeInstant("LOGIN: ");
            Console.ReadLine();
            TypeWriter.HumanType($"\n\nThanks for visiting, the rest has yet to be implemented!",40,180,true);

        }
    }
}
