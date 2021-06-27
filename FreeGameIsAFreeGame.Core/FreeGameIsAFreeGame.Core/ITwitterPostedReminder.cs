namespace FreeGameIsAFreeGame.Core
{
    public interface ITwitterPostedReminder : IModel
    {
        /// <summary>
        /// The database entry id of the deal
        /// </summary>
        int DealId { get; set; }
    }
}
