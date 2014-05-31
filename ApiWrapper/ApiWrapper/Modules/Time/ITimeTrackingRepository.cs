using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harvest.Models;
using Harvest.Modules.Common;

namespace Harvest.Modules.Time
{
    public interface ITimeTrackingRepository: IAuthInitalizer
    {
        Task<TimeResponse> GetEntriesAsync(DateTime date);
        Task<object> GetSingleEntryAsync(int entryId);

    }
}
