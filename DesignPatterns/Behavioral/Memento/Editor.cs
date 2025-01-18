namespace DesignPatterns.Behavioral.Memento
{
    // Originator: The editor whose state we want to save/restore.
    public class Editor
    {
        public string Content { get; private set; }

        public void Write(string text)
        {
            Content += text;
        }

        public Memento Save()
        {
            Console.WriteLine("Saving state: " + Content);
            return new Memento(Content);
        }

        public void Restore(Memento memento)
        {
            if (memento == null) throw new ArgumentNullException(nameof(memento));
            Content = memento.State;
            Console.WriteLine("Restored state: " + Content);
        }
    }
}
