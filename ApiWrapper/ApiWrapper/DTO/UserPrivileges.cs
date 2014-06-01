using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Harvest.DTO
{
    public class UserPrivileges
    {
        [JsonProperty("can_create_invoices")]
        public bool CanCreateInvoices { get; set; }
        [JsonProperty("can_create_projects")]
        public bool CanCreateProjects { get; set; }
        [JsonProperty("can_see_rates")]
        public bool CanSeeRates { get; set; }
        [JsonProperty("is_project_manager")]
        public bool IsProjectManager { get; set; }
    }
}
