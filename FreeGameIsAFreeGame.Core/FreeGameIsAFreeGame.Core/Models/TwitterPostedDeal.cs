using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class TwitterPostedDeal : ITwitterPostedDeal
    {
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public int DealId { get; set; }
    }
}
