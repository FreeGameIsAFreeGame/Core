using System.Collections.Generic;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class TwitterPostedDealsApi : BasicApi<ITwitterPostedDeal, TwitterPostedDeal>
    {
#region Overrides of BasicApi<ITwitterPostedDeal,TwitterPostedDeal>
        /// <inheritdoc />
        protected override string Slug => "twitter/deals";
#endregion

        public async Task<IReadOnlyList<ITwitterPostedDeal>> GetForDeal(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/deal/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<TwitterPostedDeal>>(result.Content);
            }

            throw new ApiException(result);
        }
    }
}
