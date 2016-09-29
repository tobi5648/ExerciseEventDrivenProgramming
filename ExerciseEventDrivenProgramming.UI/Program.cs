

namespace ExerciseEventDrivenProgramming
{

    #region Using

    using System;

    #endregion


    #region Delegates

    public delegate void NameEventHandler(object sender, NameEventArgs e); 
    
    #endregion

    public class Program
    {

        public static event NameEventHandler Name;

        public static void Main(string[] args)
        {
            #region Console

            Console.Write("What is your name? ");
            OnName(new NameEventArgs(Console.ReadLine()));

            Console.WriteLine(Name);
            Console.ReadKey();

            #endregion

            public void OnName(NameEventArgs e)
            {
                Name?.Invoke(this, e);
            }
    }

        
    }
}
