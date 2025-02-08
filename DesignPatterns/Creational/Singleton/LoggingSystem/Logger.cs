namespace DesignPatterns.Creational.Singleton.LoggingSystem
{
    public class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
        private readonly string _filePath = "log.txt";
        private Logger() { Console.WriteLine("[Logger] Logger initialized."); }
        public Logger Instance => _instance.Value;
        public void Log(string message)
        {
            try
            {
                lock (_filePath)
                {
                    using (StreamWriter writer = new StreamWriter(_filePath, true))
                    {
                        writer.WriteLine($"{DateTime.Now}: {message}");
                    }
                    Console.WriteLine($"[Logger] {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Logger] Error: {ex.Message}");
            }
        }
    }
}
