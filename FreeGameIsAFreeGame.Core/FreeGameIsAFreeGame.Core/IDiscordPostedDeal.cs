namespace FreeGameIsAFreeGame.Core
{
    public interface IDiscordPostedDeal : IModel
    {
        /// <summary>
        /// The database entry id of the deal
        /// </summary>
        int DealId { get; set; }
        /// <summary>
        /// The database entry id of the guild
        /// </summary>
        int GuildId { get; set; }
        /// <summary>
        /// The status of the posted deal
        /// </summary>
        PostStatus Status { get; set; }
    }
}
