using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harvest.Models;
using Harvest.Modules.Common;

namespace Harvest.Modules.Time
{
    public class TimeTrackingRepository : RestCore, ITimeTrackingRepository
    {

        public Task<TimeResponse> GetEntriesAsync(DateTime date)
        {
            return GetAsync<TimeResponse>(string.Format("daily/{0}/{1}", date.DayOfYear, date.Year));
        }

        public System.Threading.Tasks.Task<object> GetSingleEntryAsync(int entryId)
        {
            throw new NotImplementedException();
        }
    }
}
