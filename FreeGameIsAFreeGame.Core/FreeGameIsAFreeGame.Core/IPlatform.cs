namespace FreeGameIsAFreeGame.Core
{
    public interface IPlatform : IModel
    {
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
