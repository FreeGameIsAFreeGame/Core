using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Deal : IDeal
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The database entry id of the platform
        /// </summary>
        public int PlatformId { get; set; }
        /// <summary>
        /// The title of the deal
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The link of of the deal where the end-user can download the game
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// The link to an image to show for the deal
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// The amount in percentage of the discount
        /// </summary>
        public int Discount { get; set; }
        /// <summary>
        /// The start datetime stamp of the deal
        /// </summary>
        public DateTime? Start { get; set; }
        /// <summary>
        /// The end datetime stamp of the deal
        /// </summary>
        public DateTime? End { get; set; }
    }
}
