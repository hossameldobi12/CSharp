namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Channel MBC = new Channel() { Name = "MBC" };
            Subscriber Hossam = new Subscriber() { Name = "Hossam", };
            MBC.AdditionEvent = Hossam.Notify;
            MBC.AddVideo(new Videos() { Title = "News now" });


        }
    }
}
