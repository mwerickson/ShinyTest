using System.Threading.Tasks;
using Shiny.Push;

namespace ShinyTest.Notifications
{
    public class PushDelegate : IPushDelegate
    {
        public async Task OnEntry(PushNotificationResponse response)
        {
            var justABreakPoint = 12;
        }

        public async Task OnReceived(PushNotification notification)
        {
            var justABreakPoint = 12;
        }

        public async Task OnTokenChanged(string token)
        {
            var justABreakPoint = 12;
        }
    }
}