namespace ExerciseEventDrivenProgramming
{

    #region Using
    using System.ComponentModel;
    #endregion

    #region Event

    public class Names : Component
    {
        public string Namer;

        public Names(string namer)
        {
            this.Namer = namer;
        }

        public event NamedEventHandler Named;

        public void NameOf(string nameOf)
        {
            Namer += " " + nameOf;
            NamedEventArgs e = new NamedEventArgs(Namer);
            HavingBeenNamed(e);
        }

        protected virtual void HavingBeenNamed(NamedEventArgs e)
        {
            Named?.Invoke(this, e);
        }

        #region Code not working properly
        //public delegate void NameEventHandler(object sender, Name e);
        //public event NameEventHandler NameEvent;

        //public Name() { }

        //public Name(string names) { }




        //  https://www.reddit.com/r/learnprogramming/comments/30p1t0/event_driven_programming_in_c/

        //#region Field

        //private string name;

        //#endregion

        //#region Properties

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }

        //    set
        //    {
        //        name = value;
        //    }
        //}

        //#endregion


        //public NameEventArgs(string name)
        //{
        //    Name = name;
        //} 
        #endregion
    }

    #endregion
}
