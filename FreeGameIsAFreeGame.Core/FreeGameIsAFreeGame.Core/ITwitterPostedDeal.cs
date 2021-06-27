namespace FreeGameIsAFreeGame.Core
{
    public interface ITwitterPostedDeal : IModel
    {
        /// <summary>
        /// The database entry id of the deal
        /// </summary>
        int DealId { get; set; }
    }
}
