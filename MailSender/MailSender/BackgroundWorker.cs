using MailKit.Net.Smtp;
using Microsoft.Extensions.Hosting;
using MimeKit;
using System.Net;

namespace MailSender;

internal class BackgroundWorker:BackgroundService
{
    Timer timer;
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        timer = new Timer(SendMail
                        ,new MailData("mahammadvm@code.edu.az","Title testing sender","Is working")
                        ,TimeSpan.Zero
                        ,TimeSpan.FromSeconds(10));
        
    }
    private void SendMail(object data)
    {
        Console.WriteLine("Email sending");
        var email = new MimeMessage();
        MailData mailData = (MailData)data;
        email.Sender = MailboxAddress.Parse("mahammadvm@hotmail.com");
        email.To.Add(MailboxAddress.Parse(mailData.To));
        email.Subject = mailData.Subject;
        var builder = new BodyBuilder();
        builder.HtmlBody = mailData.Body;
        email.Body=builder.ToMessageBody();
        var smtp = new SmtpClient("smtp.office365.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("mahammadvm@hotmail.com", "Mmustafayev2001"),
            EnableSsl = true,
        };
        smtp.Send(email);
        //var smtpClient = new SmtpClient("smtp.office365.com")
        //{
        //    Port = 587,
        //    Credentials = new NetworkCredential("mahammadvm@hotmail.com", "Mmustafayev2001"),
        //    EnableSsl = true,
        //};

        //smtpClient.Send("mahammadvm@hotmail.com", "mahammadvm@code.edu.az", "subject", "body");
    }
}

record MailData(string To,string Subject,string Body);