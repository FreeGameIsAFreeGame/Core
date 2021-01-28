using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class DiscordPostedRemindersApi : BasicApi<IDiscordPostedReminder, DiscordPostedReminder>
    {
#region Overrides of BasicApi<IDiscordPostedReminder,DiscordPostedReminder>
        /// <inheritdoc />
        protected override string Slug => "discord/reminders";
#endregion
    }
}
