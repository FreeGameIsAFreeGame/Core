using System.Collections.Generic;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class DiscordPostedDealsApi : BasicApi<IDiscordPostedDeal, DiscordPostedDeal>
    {
#region Overrides of BasicApi<IDiscordPostedDeal,DiscordPostedDeal>
        /// <inheritdoc />
        protected override string Slug => "discord/deals";
#endregion

        public async Task<IEnumerable<IDiscordPostedDeal>> GetForDeal(IDeal deal)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/deal/{deal.Id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<IDiscordPostedDeal>>(result.Content);
            }

            throw new ApiException(result);
        }
    }
}
