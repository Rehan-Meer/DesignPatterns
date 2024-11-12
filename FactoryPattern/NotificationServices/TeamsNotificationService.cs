using Design_Patterns.FactoryPattern;
using FactoryPattern;
using System;

public class TeamsNotificationService : NotificationFactory
{
    public override INotification Notifier() => new Teams();

}
