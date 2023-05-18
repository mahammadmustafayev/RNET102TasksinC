using MailSender;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

await new HostBuilder()
              .ConfigureServices((hostContext, services) =>
              {
                  services.AddHostedService<BackgroundWorker>();
              }).RunConsoleAsync();