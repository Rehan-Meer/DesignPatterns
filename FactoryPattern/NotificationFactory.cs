using Design_Patterns.FactoryPattern;

namespace FactoryPattern
{
    public abstract class NotificationFactory
    {
        public abstract INotification Notifier();

        public void SendNotification(string _msg)
        {
        INotification notifier = Notifier();
        notifier.SendNotification(_msg);
        }      
    }

    public class Program
    {
        public static void Main()
        {
            var whatsAppNotifier = new WhatsAppNotificationService();
            whatsAppNotifier.SendNotification("WhatsApp");

            var emailNotifier = new EmailNotificationService();
            emailNotifier.SendNotification("EMail");

            var teamsNotifier = new TeamsNotificationService();
            teamsNotifier.SendNotification("Teams");
        }
    }
}