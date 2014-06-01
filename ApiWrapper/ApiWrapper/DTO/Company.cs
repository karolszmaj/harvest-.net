using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Harvest.DTO
{
    public class Company
    {
        public bool Active { get; set; }
        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }
        public string Clock { get; set; }
        [JsonProperty("color_scheme")]
        public string ColorScheme { get; set; }
        [JsonProperty("decimal_symbol")]
        public string DecimalSymbol { get; set; }
        [JsonProperty("full_domain")]
        public string FullDomain { get; set; }
        public Module Modules { get; set; }
        public string Name { get; set; }
        [JsonProperty("plan_type")]
        public string PlanType { get; set; }
        [JsonProperty("thousands_separator")]
        public string ThousandsSeparator { get; set; }
        //FIXME add last two properties
    }
}
