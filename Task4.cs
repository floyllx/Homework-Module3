public interface INotificationSender
{ 
    void Send(string message);
}

public class EmailSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}

public class SmsSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }
}

public class NotificationService
{
    private INotificationSender emailSender;
    private INotificationSender smsSender;

    public NotificationService(INotificationSender emailSender, INotificationSender smsSender)
    {
        this.emailSender = emailSender;
        this.smsSender = smsSender;
    }

    public void SendNotification(string message)
    {
        emailSender.Send(message);
        smsSender.Send(message);
    }
}