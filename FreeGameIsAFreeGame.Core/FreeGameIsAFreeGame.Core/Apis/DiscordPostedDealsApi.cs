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

        public async Task<IReadOnlyList<IDiscordPostedDeal>> GetForDeal(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/deal/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<DiscordPostedDeal>>(result.Content);
            }

            throw new ApiException(result);
        }

        public async Task<IReadOnlyList<IDiscordPostedDeal>> GetForGuild(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/guild/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<DiscordPostedDeal>>(result.Content);
            }

            throw new ApiException(result);
        }
    }
}
