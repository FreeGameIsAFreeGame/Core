using System.Net;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class GuildsApi : BasicApi<IGuild, Guild>
    {
#region Overrides of BasicApi<IGuild,Guild>
        /// <inheritdoc />
        protected override string Slug => "guilds";
#endregion

        public async Task<IGuild> GetBySnowflake(ulong snowflake)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/snowflake/{snowflake}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<Guild>(result.Content);
            }

            if (result.StatusCode == HttpStatusCode.NotFound)
            {
                return default;
            }

            throw new ApiException(result);
        }

        public async Task<bool> Delete(IGuild guild)
        {
            IRestRequest request = new RestRequest($"api/{Slug}", Method.DELETE);
            request.AddJsonBody(guild);

            IRestResponse result = await Api.Client.ExecuteAsync(request);
            return result.IsSuccessful;
        }
    }
}
