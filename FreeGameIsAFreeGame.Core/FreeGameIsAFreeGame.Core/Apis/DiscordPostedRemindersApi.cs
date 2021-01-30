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

        public async Task<IEnumerable<IDiscordPostedReminder>> GetForDeal(IDeal deal)
        {
            IRestRequest request = new RestRequest($"api/{Slug}/deal/{deal.Id}", Method.GET);
            IRestResponse result = await Api.Client.ExecuteAsync(request);
            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<IDiscordPostedReminder>>(result.Content);
            }

            throw new ApiException(result);
        }
    }
}
