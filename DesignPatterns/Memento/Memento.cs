namespace DesignPatterns.Memento
{
    // Memento: Stores the state of the Originator.
    public class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            State = state;
        }
    }
}
