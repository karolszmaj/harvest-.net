using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harvest.DTO;
using Newtonsoft.Json;

namespace Harvest.Models
{
    public class TimeResponse
    {
        [JsonProperty("day_entries")]
        public IEnumerable<DayTaskItem> DayItems { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        [JsonProperty("for_day")]
        public DateTime Date { get; set; }
    }
}
