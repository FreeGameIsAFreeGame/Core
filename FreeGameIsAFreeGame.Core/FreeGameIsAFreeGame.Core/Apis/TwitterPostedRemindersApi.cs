using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class TwitterPostedRemindersApi : BasicApi<ITwitterPostedReminder, TwitterPostedReminder>
    {
#region Overrides of BasicApi<ITwitterPostedReminder,TwitterPostedReminder>
        /// <inheritdoc />
        protected override string Slug => "twitter/reminders";
#endregion
    }
}
