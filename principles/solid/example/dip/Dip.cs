using System;

namespace Company.ClassLibrary1;

// Violates DIP
public class EmailNotifier
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class NotificationService
{
    private EmailNotifier _emailNotifier = new EmailNotifier();

    public void Notify(string message)
    {
        _emailNotifier.SendEmail(message);
    }
}

// Follow DIP
public interface INotifier
{
    void SendNotification(string message);
}

public class EmailNotifier : INotifier
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class SmsNotifier : INotifier
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

public class NotificationService
{
    public INotifier _notifier;

    public NotificationService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Notify(string message)
    {
        _notifier.SendNotification(message);
    }
}