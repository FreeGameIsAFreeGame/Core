using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class PlatformChannelsApi : BasicApi<IPlatformChannel, PlatformChannel>
    {
#region Overrides of BasicApi<IPlatformChannel,PlatformChannel>
        /// <inheritdoc />
        protected override string Slug => "PlatformChannels";
#endregion
    }
}
