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

        public async Task<IEnumerable<IDeal>> GetByPlatform(int id)
        {
            RestRequest request = new RestRequest($"api/{Slug}/platform/{id}", Method.GET);
            IRestResponse response = await Api.Client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<Deal>>(response.Content);
            }

            throw new ApiException(response);
        }

        public async Task<IDeal> Patch(IDeal deal)
        {
            RestRequest request = new RestRequest($"api/{Slug}", Method.PATCH);
            request.AddJsonBody(deal);

            IRestResponse response = await Api.Client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<Deal>(response.Content);
            }

            throw new ApiException(response);
        }
    }
}
