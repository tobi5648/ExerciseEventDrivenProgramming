namespace ExerciseEventDrivenProgramming
{
    #region Using
    using System; 
    #endregion

    public class NamedEventArgs : EventArgs
    {
        public string Name { get; set; }

        public NamedEventArgs(string name)
        {
            Name = name;
        }
    }
}