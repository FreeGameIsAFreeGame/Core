using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Platform : IPlatform
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The identifier used for filtering
        /// </summary>
        public string Identifier { get; set; }
        /// <summary>
        /// The name used for displaying to the public
        /// </summary>
        public string DisplayName { get; set; }
    }
}
