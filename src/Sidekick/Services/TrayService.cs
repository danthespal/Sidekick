using Sidekick.Business.Leagues;
using Sidekick.Core.DependencyInjection.Services;
using Sidekick.Core.Initialization;
using Sidekick.Core.Settings;
using Sidekick.Helpers;
using System.Threading.Tasks;

namespace Sidekick.Services
{
    [SidekickService(typeof(ITrayService))]
    public class TrayService : ITrayService, IOnAfterInitialize
    {
        private readonly ILeagueService leagueService;

        public TrayService(ILeagueService leagueService)
        {
            this.leagueService = leagueService;
        }

        public Task OnAfterInitialize()
        {
            TrayIcon.Initialize();
            TrayIcon.PopulateLeagueSelectMenu(leagueService.Leagues);
            TrayIcon.SendNotification("Sidekick is ready", $"Press {KeybindSetting.PriceCheck.GetTemplate()} over an item in-game to use. Press {KeybindSetting.CloseWindow.GetTemplate()} to close overlay.");

            return Task.CompletedTask;
        }
    }
}
