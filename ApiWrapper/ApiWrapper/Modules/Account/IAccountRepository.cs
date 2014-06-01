using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harvest.Models;
using Harvest.Modules.Common;

namespace Harvest.Modules.Account
{
    public interface IAccountRepository: IAuthInitalizer
    {
        Task<UserResponse> GetProfileAsync();
    }
}
