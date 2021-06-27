using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Platform : IPlatform
    {
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public string Identifier { get; set; }
        /// <inheritdoc />
        public string DisplayName { get; set; }
        /// <inheritdoc />
        public string IconUrl { get; set; }
    }
}
