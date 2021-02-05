namespace FreeGameIsAFreeGame.Core
{
    public interface IGuild
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// The discord id of the guild
        /// </summary>
        ulong Snowflake { get; set; }
    }
}
