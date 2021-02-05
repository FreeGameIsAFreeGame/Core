namespace FreeGameIsAFreeGame.Core
{
    public interface ITwitterPostedReminder
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// The database entry id of the deal
        /// </summary>
        int DealId { get; set; }
    }
}
