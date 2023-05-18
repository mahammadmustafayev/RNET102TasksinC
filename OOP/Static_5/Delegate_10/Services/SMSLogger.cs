namespace Delegates_10.Services;

public interface ILogger
{
    void SetLog(string message);
}

internal class SMSLogger:ILogger
{
    public void SetLog(string message)
    {
        Console.WriteLine("{0} -> {1}", this.GetType().Name, message);
    }
}
public class MailLogger : ILogger
{
    public void SetLog(string message)
    {
        Console.WriteLine("{0} -> {1}", this.GetType().Name, message);
    }
}
public class XmlLogger : ILogger
{
    public void SetLog(string message)
    {
        Console.WriteLine("{0} -> {1}", this.GetType().Name, message);
    }
}
public class DbLogger : ILogger
{
    public void SetLog(string message)
    {
        Console.WriteLine("{0} -> {1}", this.GetType().Name, message);
    }
}
public class PushNotification : ILogger
{
    public void SetLog(string message)
    {
        Console.WriteLine("{0} -> {1}", this.GetType().Name, message);
    }
}

