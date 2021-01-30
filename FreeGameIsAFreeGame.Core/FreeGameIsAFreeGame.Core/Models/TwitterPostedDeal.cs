using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class TwitterPostedDeal : ITwitterPostedDeal
    {
        public int Id { get; set; }
        public int DealId { get; set; }
    }
}
