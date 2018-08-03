namespace Event
{
    internal class Subscriber<T>
    {
        public IPublisher<T> Publisher { get; private set; }
        public Subscriber(IPublisher<T> publisher)
        {
            Publisher = publisher;
        }
    }
}