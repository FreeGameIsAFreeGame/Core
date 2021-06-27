using System.Collections.Generic;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class PlatformMentionsApi : BasicApi<IPlatformMention, PlatformMention>
    {
#region Overrides of BasicApi<IPlatformMention,PlatformMention>
        /// <inheritdoc />
        protected override string Slug => "PlatformMentions";
#endregion

        public async Task<IReadOnlyList<IPlatformMention>> GetForGuild(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/guild/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<PlatformMention>>(result.Content);
            }

            throw new ApiException(result);
        }

        public async Task<IReadOnlyList<IPlatformMention>> GetForPlatform(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/platform/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<PlatformMention>>(result.Content);
            }

            throw new ApiException(result);
        }
    }
}
