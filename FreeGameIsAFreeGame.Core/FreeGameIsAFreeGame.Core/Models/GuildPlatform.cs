using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class GuildPlatform : IGuildPlatform
    {
        /// <inheritdoc />
        public int Id { get; set; }
        /// <inheritdoc />
        public int GuildId { get; set; }
        /// <inheritdoc />
        public int PlatformId { get; set; }
        /// <inheritdoc />
        public bool EnabledInitial { get; set; }
        /// <inheritdoc />
        public bool EnabledReminder { get; set; }
    }
}
