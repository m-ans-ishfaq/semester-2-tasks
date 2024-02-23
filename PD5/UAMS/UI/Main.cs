using System;
using System.Collections.Generic;

namespace PD5.UAMS
{
    public class MainMenu
    {
        public static void Run()
        {
            List<string> menu = [
                "******************************",
                "            UAMS              ",
                "******************************",
                "1. Add Student",
                "2. Add Degree Program",
                "3. Generate Merit",
                "4. View Registered Students",
                "5. View Students of a Specific Program",
                "6. Register Subjects for a Specific Student",
                "7. Calculate Fees for all Registered Students",
                "8. Exit",
                "Enter Option:"
            ];
            foreach (string line in menu)
            {
                Console.WriteLine(line);
            }
            
        }
    }
}