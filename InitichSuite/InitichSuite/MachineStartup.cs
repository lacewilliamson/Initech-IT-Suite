using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace InitichSuite
{
    public class MachineStartup //A simple class that generates the bootup and program running precursor
    {
        public static void Boot()
        {
            Pause.PauseStable(1200);

            TypeWriter.MachineType("INITECH BASIC V6.1 524288 BYTES FREE\n", 20);
            TypeWriter.MachineType("(C) INITECH - DEVELOPED BY M.Judge\n\n", 20);
            Pause.PauseStable(1800);

            Console.Write(">");
            Console.Beep(1500, 300);
            Pause.PauseStable(2200);
            TypeWriter.HumanType(("LOAD \"INNITECH-IT\",8,1"), 100, 350, true);
            Pause.PauseStable(700);
            Console.WriteLine("\n");
            TypeWriter.MachineTypeInstant("?FILE NOT FOUND\n");
            Console.Write(">");
            Pause.PauseStable(4200);

            TypeWriter.HumanType(("asd;lkasdf;ldfas';lk"), 40, 80, true);
            Pause.PauseStable(1600);
            Console.WriteLine("\n");
            TypeWriter.MachineTypeInstant("?SYNTAX ERROR\n");
            Console.Write(">");
            Pause.PauseStable(4200);

            TypeWriter.HumanType(("LOAD \"INITECH-IT\",8,1"), 200, 450, true);
            Pause.PauseStable(1600);
            Console.WriteLine("\n");
            TypeWriter.MachineTypeInstant("LOADING ");
            TypeWriter.MachineType(".",450);
            TypeWriter.MachineType(".",450);
            TypeWriter.MachineType(".",450);

            Console.Clear();
        }
    }
}
