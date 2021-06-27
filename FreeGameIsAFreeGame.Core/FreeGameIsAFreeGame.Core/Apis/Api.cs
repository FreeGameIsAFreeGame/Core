using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public static class Api
    {
        internal static IRestClient Client { get; private set; }

        public static DealsApi Deals { get; } = new DealsApi();
        public static DiscordPostedDealsApi DiscordPostedDeals { get; } = new DiscordPostedDealsApi();
        public static DiscordPostedRemindersApi DiscordPostedReminders { get; } = new DiscordPostedRemindersApi();
        public static GuildsApi Guilds { get; } = new GuildsApi();
        public static PlatformChannelsApi PlatformChannels { get; } = new PlatformChannelsApi();
        public static PlatformMentionsApi PlatformMentions { get; } = new PlatformMentionsApi();
        public static PlatformsApi Platforms { get; } = new PlatformsApi();
        public static TwitterPostedDealsApi TwitterPostedDeals { get; } = new TwitterPostedDealsApi();
        public static TwitterPostedRemindersApi TwitterPostedReminders { get; } = new TwitterPostedRemindersApi();

        public static void Initialize(string url)
        {
            Client = new RestClient(url).UseNewtonsoftJson();
        }
    }
}
