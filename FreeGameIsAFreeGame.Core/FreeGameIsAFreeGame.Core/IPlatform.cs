namespace FreeGameIsAFreeGame.Core
{
    public interface IPlatform
    {
        /// <summary>
        /// The database entry id
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// The identifier used for filtering
        /// </summary>
        string Identifier { get; set; }
        /// <summary>
        /// The name used for displaying to the public
        /// </summary>
        string DisplayName { get; set; }
    }
}
