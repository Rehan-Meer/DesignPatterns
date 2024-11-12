namespace Design_Patterns.FactoryPattern
{
    public class WhatsApp : INotification
    {
        public void SendNotification(string _msg) => Console.WriteLine("Sending WhatsApp Notification: " + _msg);
    }
}