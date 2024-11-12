using FactoryPattern;

namespace Design_Patterns.FactoryPattern
{
    public class WhatsAppNotificationService : NotificationFactory
    {
        public override INotification Notifier() => new WhatsApp();
    }
}