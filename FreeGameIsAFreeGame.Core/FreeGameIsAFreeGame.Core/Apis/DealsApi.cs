using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class DealsApi : BasicApi<IDeal, Deal>
    {
#region Overrides of BasicApi<IDeal,Deal>
        /// <inheritdoc />
        protected override string Slug => "deals";
#endregion
    }
}
