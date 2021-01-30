using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class GuildsApi : BasicApi<IGuild, Guild>
    {
#region Overrides of BasicApi<IGuild,Guild>
        /// <inheritdoc />
        protected override string Slug => "guilds";
#endregion

        public async Task<bool> Delete(IGuild guild)
        {
            IRestRequest request = new RestRequest($"api/{Slug}", Method.DELETE);
            request.AddJsonBody(guild);

            IRestResponse result = await Api.Client.ExecuteAsync(request);
            return result.IsSuccessful;
        }
    }
}
