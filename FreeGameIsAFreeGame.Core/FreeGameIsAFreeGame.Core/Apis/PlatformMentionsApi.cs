using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class PlatformMentionsApi : BasicApi<IPlatformMention, PlatformMention>
    {
#region Overrides of BasicApi<IPlatformMention,PlatformMention>
        /// <inheritdoc />
        protected override string Slug => "PlatformMentions";
#endregion
    }
}
