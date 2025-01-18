namespace DesignPatterns.Behavioral.Strategy
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying black and white overlay");
        }
    }
}
