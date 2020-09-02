using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public Platform Platform { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public int Discount { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
