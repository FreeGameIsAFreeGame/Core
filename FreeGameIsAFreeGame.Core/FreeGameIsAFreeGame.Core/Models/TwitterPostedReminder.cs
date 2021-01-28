using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class TwitterPostedReminder : ITwitterPostedReminder
    {
        public int Id { get; set; }
        public int DealId { get; set; }
    }
}