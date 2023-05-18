namespace Delegates_10;
using Delegates_10.Services;

public delegate void LowLevelLoggerDelegate(string message);
public delegate void MediumLevelLoggerDelegate(string message);
public delegate void HighLevelLoggerDelegate(string message);

internal class Program
{
    static void Main(string[] args)
    {
        //string errorMessage = "Exception sinifinden gelen hata mesaji";

        ILogger sMSLogger = new SMSLogger();

        //sMSLogger.SetLog(errorMessage);

        ILogger mailLogger = new MailLogger();
        //mailLogger.SetLog(errorMessage);

        ILogger pushNotification = new PushNotification();
        //pushNotification.SetLog(errorMessage);

        ILogger xmlLogger = new XmlLogger();
        //xmlLogger.SetLog(errorMessage);

        ILogger dbLogger = new DbLogger();
        //dbLogger.SetLog(errorMessage);

        Exception ex = new Exception("Alinan xeta bilgisi");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Low Level Delegate\n");
        LowLevelLoggerDelegate lowLevel = new LowLevelLoggerDelegate(xmlLogger.SetLog);
        lowLevel += mailLogger.SetLog;
        
        lowLevel.Invoke(ex.Message);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Medium Level Delegate\n");

        MediumLevelLoggerDelegate medium = new MediumLevelLoggerDelegate(mailLogger.SetLog);
        medium += xmlLogger.SetLog;
        medium += dbLogger.SetLog;
        medium.Invoke(ex.Message);

        Console.ResetColor();
        

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("High Level Delegate\n");

        HighLevelLoggerDelegate high = new HighLevelLoggerDelegate(mailLogger.SetLog);
        high += sMSLogger.SetLog;
        high += xmlLogger.SetLog;
        high += dbLogger.SetLog;
        high += pushNotification.SetLog;
        high.Invoke(ex.Message);

        Console.ResetColor();
    }
}
