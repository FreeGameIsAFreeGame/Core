using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class PlatformsApi : BasicApi<IPlatform, Platform>
    {
#region Overrides of BasicApi<IPlatform,Platform>
        /// <inheritdoc />
        protected override string Slug => "Platforms";
#endregion
    }
}
