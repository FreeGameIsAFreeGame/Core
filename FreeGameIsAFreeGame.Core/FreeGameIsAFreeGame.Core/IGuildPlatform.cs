namespace FreeGameIsAFreeGame.Core
{
    public interface IGuildPlatform : IModel
    {
        /// <summary>
        /// The database entry id of the guild
        /// </summary>
        int GuildId { get; set; }
        /// <summary>
        /// The database entry id of the platform
        /// </summary>
        int PlatformId { get; set; }
        /// <summary>
        /// Should the initial message be posted for this platform & guild combination
        /// </summary>
        bool EnabledInitial { get; set; }
        /// <summary>
        /// Should the reminder message be posted for this platform & guild combination
        /// </summary>
        bool EnabledReminder { get; set; }
    }
}
