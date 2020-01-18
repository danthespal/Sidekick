using Microsoft.Extensions.DependencyInjection;
using Sidekick.Business.Apis.Poe;
using Sidekick.Business.Http;
using Sidekick.Business.Languages;
using Sidekick.Business.Leagues;
using Sidekick.Business.Parsers;
using Sidekick.Business.Tokenizers;
using Sidekick.Business.Tokenizers.ItemName;
using Sidekick.Business.Trades;

namespace Sidekick.Business
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddSidekickBusinessServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpClientProvider, HttpClientProvider>();
            services.AddSingleton<IItemParser, ItemParser>();
            services.AddSingleton<ILanguageProvider, LanguageProvider>();
            services.AddSingleton<ILeagueService, LeagueService>();
            services.AddSingleton<IPoeApiService, PoeApiService>();
            services.AddSingleton<ITokenizer, ItemNameTokenizer>();
            services.AddSingleton<ITradeClient, TradeClient>();
            services.AddSingleton<IUILanguageProvider, UILanguageProvider>();

            return services;
        }
    }
}