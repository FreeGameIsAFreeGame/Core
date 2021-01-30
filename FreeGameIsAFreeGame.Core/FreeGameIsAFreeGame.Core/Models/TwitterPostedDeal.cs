using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class TwitterPostedDeal : ITwitterPostedDeal
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The database entry id of the deal
        /// </summary>
        public int DealId { get; set; }
    }
}
