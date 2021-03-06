using System.Net;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class PlatformsApi : BasicApi<IPlatform, Platform>
    {
#region Overrides of BasicApi<IPlatform,Platform>
        /// <inheritdoc />
        protected override string Slug => "Platforms";
#endregion

        public async Task<IPlatform> GetByIdentifier(string identifier)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/identifier/{identifier}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<Platform>(result.Content);
            }

            if (result.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }

            throw new ApiException(result);
        }
    }
}
