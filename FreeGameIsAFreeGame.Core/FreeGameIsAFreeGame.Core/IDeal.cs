using System;

namespace FreeGameIsAFreeGame.Core
{
    public interface IDeal
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// The database entry id of the platform
        /// </summary>
        int PlatformId { get; set; }
        /// <summary>
        /// The title of the deal
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// The link of of the deal where the end-user can download the game
        /// </summary>
        string Link { get; set; }
        /// <summary>
        /// The link to an image to show for the deal
        /// </summary>
        string Image { get; set; }
        /// <summary>
        /// The amount in percentage of the discount
        /// </summary>
        int Discount { get; set; }
        /// <summary>
        /// The start datetime stamp of the deal
        /// </summary>
        DateTime? Start { get; set; }
        /// <summary>
        /// The end datetime stamp of the deal
        /// </summary>
        DateTime? End { get; set; }
    }
}
