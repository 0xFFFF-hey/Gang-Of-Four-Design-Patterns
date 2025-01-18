namespace DesignPatterns.Behavioral.Memento
{
    // Caretaker: Manages the mementos and interacts with the Originator.
    public class History
    {
        private readonly Stack<Memento> _mementos = new();

        public void Save(Memento memento)
        {
            _mementos.Push(memento);
        }

        public Memento Undo()
        {
            if (_mementos.Count == 0) throw new InvalidOperationException("No mementos to undo.");
            return _mementos.Pop();
        }
    }
}
