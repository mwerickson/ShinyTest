using Microsoft.Extensions.DependencyInjection;
using Shiny;
using Shiny.Prism;
using ShinyTest.Notifications;

namespace ShinyTest
{
    public class MyShinyStartup : PrismStartup
    {
        private string _listenerString = "";
        private string _hubName = "";
        protected override void ConfigureServices(IServiceCollection services, IPlatform platform)
        {
            services.UsePushAzureNotificationHubs<PushDelegate>(_listenerString, _hubName);
        }
    }
}