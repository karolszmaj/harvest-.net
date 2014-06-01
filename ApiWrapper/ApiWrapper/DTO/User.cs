using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Harvest.DTO
{
    public class User
    {
        public bool Admin { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        public string Email { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        public long Id { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        //FIXME: check for better documentatio: is this dynamic?
        [JsonProperty("project_manager")]
        public UserPrivileges ProjectManager { get; set; }
        [JsonProperty("timestamp_timers")]
        public bool TimestampTimers { get; set; }
        public string Timezone { get; set; }
        [JsonProperty("timezone_identifier")]
        public string TimezoneIdentifier { get; set; }
        [JsonProperty("timezone_utc_offset")]
        public int TimezoneUtcOffset { get; set; }
    }
}
