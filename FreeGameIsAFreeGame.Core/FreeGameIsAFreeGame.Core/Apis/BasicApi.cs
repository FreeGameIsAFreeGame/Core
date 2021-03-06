using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public abstract class BasicApi<TInterface, TClass> where TClass : TInterface
    {
        internal BasicApi()
        {
        }

        protected abstract string Slug { get; }

        public async Task<IReadOnlyList<TInterface>> Get()
        {
            IRestRequest request = new RestRequest($"api/{Slug}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<TClass>>(result.Content)
                    .Cast<TInterface>()
                    .ToList();
            }

            throw new ApiException(result);
        }

        public async Task<TInterface> GetById(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<TClass>(result.Content);
            }

            if (result.StatusCode == HttpStatusCode.NotFound)
            {
                return default;
            }

            throw new ApiException(result);
        }

        public async Task<TInterface> Patch(TInterface value)
        {
            RestRequest request = new RestRequest($"api/{Slug}", Method.PATCH);
            request.AddJsonBody(value);

            IRestResponse response = await Api.Client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<TClass>(response.Content);
            }

            throw new ApiException(response);
        }

        public async Task<TInterface> Post(TInterface value)
        {
            IRestRequest request = new RestRequest($"api/{Slug}", Method.POST);
            request.AddJsonBody(value);

            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<TClass>(result.Content);
            }

            throw new ApiException(result);
        }
    }
}
