using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Harvest.DTO
{
    public class DayTaskItem
    {
        [JsonProperty("project_id")]
        public long ProjectId { get; set; }
        public string Project { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("spent_at")]
        public DateTime? Date { get; set; }
        [JsonProperty("task_id")]
        public long TaskId { get; set; }
        public string Task { get; set; }
        public string Client { get; set; }
        public long Id { get; set; }
        public string Notes { get; set; }
        [JsonProperty("created_at")]
        public DateTime? CreateTime { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdateTime { get; set; }
        [JsonProperty("external_ref")]
        public ExternalReference ExternalInfo { get; set; }
        public double HoursWithoutTimer { get; set; }
        public double Hours { get; set; }

        [JsonProperty("timer_started_at")]
        public DateTime? TimerStartedAt { get; set; }

        [JsonIgnore]
        public bool IsTimerWorkingForTask
        {
            get { return TimerStartedAt.HasValue; }
        }
    }
}
