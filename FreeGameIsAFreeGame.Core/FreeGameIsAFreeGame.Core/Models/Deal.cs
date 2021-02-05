using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Deal : IDeal
    {
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public int PlatformId { get; set; }
        /// <inheritdoc />
        public string Title { get; set; }
        /// <inheritdoc />
        public string Link { get; set; }
        /// <inheritdoc />
        public string Image { get; set; }
        /// <inheritdoc />
        public int Discount { get; set; }
        /// <inheritdoc />
        public DateTime? Start { get; set; }
        /// <inheritdoc />
        public DateTime? End { get; set; }
    }
}
