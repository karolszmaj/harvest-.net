using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harvest.DTO;
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

        public Task<DayTaskItem> GetSingleEntryAsync(long entryId)
        {
            return GetAsync<DayTaskItem>(string.Format("daily/show/{0}", entryId));
        }

        public Task<DayTaskItem> ToogleTimerForEntryAsync(long entryId)
        {
            return GetAsync<DayTaskItem>(string.Format("daily/timer/{0}", entryId));
        }

        public Task<DayTaskItem> CreateNewEntryAsync(CreateEntryRequest entry)
        {
            return PostAsync<DayTaskItem>("daily/add", entry);
        }
    }
}
