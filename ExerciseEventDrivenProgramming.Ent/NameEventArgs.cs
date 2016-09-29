namespace ExerciseEventDrivenProgramming
{

    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    #region Event

    public class NameEventArgs : EventArgs
    {
        //  https://www.reddit.com/r/learnprogramming/comments/30p1t0/event_driven_programming_in_c/

        #region Field

        private string name;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        #endregion


        public NameEventArgs(string name)
        {
            Name = name;
        }

       
    } 

    #endregion
}
