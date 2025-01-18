namespace DesignPatterns.Behavioral.State
{
    internal class PublishedState : State
    {
        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            // do nothing
        }
    }
}