using System.Collections.Generic;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class TwitterPostedRemindersApi : BasicApi<ITwitterPostedReminder, TwitterPostedReminder>
    {
#region Overrides of BasicApi<ITwitterPostedReminder,TwitterPostedReminder>
        /// <inheritdoc />
        protected override string Slug => "twitter/reminders";
#endregion

        public async Task<IReadOnlyList<ITwitterPostedReminder>> GetForDeal(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/deal/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<TwitterPostedReminder>>(result.Content);
            }

            throw new ApiException(result);
        }
    }
}
