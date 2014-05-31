using System.Collections.Generic;
using Newtonsoft.Json;

namespace Harvest.DTO
{
    public class Project
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Id { get; set; }
        [JsonProperty("tasks")]
        public List<TaskDto> AssociatedTasks { get; set; }
        public string Client { get; set; }
        [JsonProperty("client_id")]
        public int ClientId { get; set; }
        [JsonProperty("client_currency")]
        public string ClientCurrency { get; set; }
        [JsonProperty("client_currency_symbol")]
        public string ClientCurrencySymbol { get; set; }

    }
}
    