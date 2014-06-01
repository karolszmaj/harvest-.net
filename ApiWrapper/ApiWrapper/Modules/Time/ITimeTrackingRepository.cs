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
    public interface ITimeTrackingRepository: IAuthInitalizer
    {
        Task<TimeResponse> GetEntriesAsync(DateTime date);
        Task<DayTaskItem> GetSingleEntryAsync(long entryId);
        Task<DayTaskItem> ToogleTimerForEntryAsync(long entryId);

    }
}
