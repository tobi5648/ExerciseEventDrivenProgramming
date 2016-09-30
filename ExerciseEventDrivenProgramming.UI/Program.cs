

namespace ExerciseEventDrivenProgramming
{

    #region Using

    using System;

    #endregion
    
    public class Program
    {

        public static void Main(string[] args)
        {
            WhatIsYourFirstName();
        }

        private static void SendName(object sender, NamedEventArgs e)
        {
            Console.Write("Your full name is {0}?", e.Name);
        }

        private static void WhatIsYourFirstName()
        {
            Console.Write("What is your firstname? ");
            Names myName = new Names(Console.ReadLine());
            myName.Named += new NamedEventHandler(SendName);
            Console.Write("Your firstname is " + myName.Namer + "?");
            Answer(myName, true);
        }

        private static void WhatIsYourLastName(Names myName)
        {
            Console.Write(Environment.NewLine + "What is your sirname " + myName.Namer +"? ");
            myName.NameOf(Console.ReadLine());
            Answer(myName, false);
        }
        private static void YourFullName(Names myName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Environment.NewLine + "Then hello " + myName.Namer + "!");
            Console.ReadKey();
        }

        private static void Answer(Names myName, bool firstname)
        {
            Console.Write(" Y/N");
            if(Console.ReadKey(true).Key == ConsoleKey.Y || Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                if (firstname)
                    WhatIsYourLastName(myName);
                else if (!firstname)
                    YourFullName(myName);
            }
            else if(Console.ReadKey(true).Key != ConsoleKey.Y || Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                if (firstname)
                {
                    Console.WriteLine();
                    WhatIsYourFirstName();
                }
                else if (!firstname)
                    WhatIsYourLastName(myName);
            }
        }       
    }
}
