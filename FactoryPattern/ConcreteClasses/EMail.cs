namespace Design_Patterns.FactoryPattern
{
    public class EMail : INotification
    {
        public void SendNotification(string _msg) => Console.WriteLine("Sending EMail Notification: " + _msg);
    }
}