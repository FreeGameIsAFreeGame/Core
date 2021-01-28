using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class DiscordPostedDealsApi : BasicApi<IDiscordPostedDeal, DiscordPostedDeal>
    {
#region Overrides of BasicApi<IDiscordPostedDeal,DiscordPostedDeal>
        /// <inheritdoc />
        protected override string Slug => "discord/deals";
#endregion
    }
}
