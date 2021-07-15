using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    [Obsolete]
    public class PlatformChannelsApi : BasicApi<IPlatformChannel, PlatformChannel>
    {
#region Overrides of BasicApi<IPlatformChannel,PlatformChannel>
        /// <inheritdoc />
        protected override string Slug => "PlatformChannels";
#endregion

        public async Task<IReadOnlyList<IPlatformChannel>> GetForGuild(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/guild/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<PlatformChannel>>(result.Content);
            }

            throw new ApiException(result);
        }

        public async Task<IReadOnlyList<IPlatformChannel>> GetForPlatform(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/platform/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<PlatformChannel>>(result.Content);
            }

            throw new ApiException(result);
        }
    }
}
