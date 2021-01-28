using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class GuildsApi : BasicApi<IGuild, Guild>
    {
#region Overrides of BasicApi<IGuild,Guild>
        /// <inheritdoc />
        protected override string Slug => "guilds";
#endregion
    }
}
