using System.Collections.Generic;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    public class DiscordPostedRemindersApi : BasicApi<IDiscordPostedReminder, DiscordPostedReminder>
    {
#region Overrides of BasicApi<IDiscordPostedReminder,DiscordPostedReminder>
        /// <inheritdoc />
        protected override string Slug => "discord/reminders";
#endregion

        public async Task<IReadOnlyList<IDiscordPostedReminder>> GetForDeal(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/deal/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<DiscordPostedReminder>>(result.Content);
            }

            throw new ApiException(result);
        }

        public async Task<IReadOnlyList<IDiscordPostedReminder>> GetForGuild(int id)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/guild/{id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<DiscordPostedReminder>>(result.Content);
            }

            throw new ApiException(result);
        }
    }
}
