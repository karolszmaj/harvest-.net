using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harvest.Modules.Account;
using Harvest.Modules.Common;
using Harvest.Modules.Time;

namespace Harvest
{
    public interface IHarvestRepository: IAuthInitalizer
    {
        ITimeTrackingRepository Time { get; }
        IAccountRepository Account { get; }
    }
}
