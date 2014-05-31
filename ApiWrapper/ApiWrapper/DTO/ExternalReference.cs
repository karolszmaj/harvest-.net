using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Harvest.DTO
{
    public class ExternalReference
    {
        public long Id { get; set; }
        public string Namespace { get; set; }
        public string Service { get; set; }
        [JsonProperty("service_icon")]
        public object ServiceIcon { get; set; }
        [JsonProperty("account_id")]
        public object AccountId { get; set; }
        [JsonProperty("group_id")]
        public object GroupId { get; set; }
        [JsonProperty("day_entry_id")]
        public int DayEntryId { get; set; }
        public string Shorthand { get; set; } // ?
    }
}
