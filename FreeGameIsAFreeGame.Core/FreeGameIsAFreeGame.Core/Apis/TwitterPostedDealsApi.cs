using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class TwitterPostedDealsApi : BasicApi<ITwitterPostedDeal, TwitterPostedDeal>
    {
#region Overrides of BasicApi<ITwitterPostedDeal,TwitterPostedDeal>
        /// <inheritdoc />
        protected override string Slug => "twitter/deals";
#endregion
    }
}
