using System;
using Newtonsoft.Json;

namespace Harvest.Models
{
    public class CreateEntryRequest
    {
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("project_id")]
        public long ProjectId { get; set; }
        [JsonProperty("task_id")]
        public long TaskId { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("hours")]
        public float? Hours { get; set; }
    }
}
