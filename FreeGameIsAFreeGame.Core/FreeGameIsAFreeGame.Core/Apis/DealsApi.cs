using System.Collections.Generic;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class DealsApi : BasicApi<IDeal, Deal>
    {
#region Overrides of BasicApi<IDeal,Deal>
        /// <inheritdoc />
        protected override string Slug => "deals";
#endregion

        public async Task<IReadOnlyList<IDeal>> GetActive()
        {
            RestRequest request = new RestRequest($"api/{Slug}/active", Method.GET);
            IRestResponse response = await Api.Client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<Deal>>(response.Content);
            }

            throw new ApiException(response);
        }

        public async Task<IReadOnlyList<IDeal>> GetByPlatform(int id)
        {
            RestRequest request = new RestRequest($"api/{Slug}/platform/{id}", Method.GET);
            IRestResponse response = await Api.Client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<Deal>>(response.Content);
            }

            throw new ApiException(response);
        }

        public async Task<IReadOnlyList<IDeal>> GetActiveByPlatform(int id)
        {
            RestRequest request = new RestRequest($"api/{Slug}/platform/{id}/active", Method.GET);
            IRestResponse response = await Api.Client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<Deal>>(response.Content);
            }

            throw new ApiException(response);
        }
    }
}
