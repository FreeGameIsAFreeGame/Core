namespace FreeGameIsAFreeGame.Core
{
    public interface IGuild : IModel
    {
        /// <summary>
        /// The discord id of the guild
        /// </summary>
        ulong Snowflake { get; set; }
        /// <summary>
        /// Is posting enabled for this guild
        /// </summary>
        bool Enabled { get; set; }
        /// <summary>
        /// The discord id of the channel the commands will be allowed in
        /// Null means every channel
        /// </summary>
        ulong? CommandChannel { get; set; }
        /// <summary>
        /// The discord id of the role the commands requires to execute
        /// Null means everyone
        /// </summary>
        ulong? CommandRole { get; set; }
    }
}
