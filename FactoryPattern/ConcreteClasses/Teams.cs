namespace Design_Patterns.FactoryPattern
{
    public class Teams : INotification
    {
        public void SendNotification(string _msg) => Console.WriteLine("Sending Teams Notification: " + _msg);
    }
}