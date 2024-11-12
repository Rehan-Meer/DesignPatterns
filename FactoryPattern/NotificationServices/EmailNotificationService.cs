using FactoryPattern;
using System;

namespace Design_Patterns.FactoryPattern
{
    public class EmailNotificationService : NotificationFactory
    {
        public override INotification Notifier() => new EMail();
    }
}