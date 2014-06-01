using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harvest.Models;
using Harvest.Modules.Common;

namespace Harvest.Modules.Account
{
    public class AccountRepository: RestCore, IAccountRepository
    {
        public Task<UserResponse> GetProfileAsync()
        {
            return this.GetAsync<UserResponse>("account/who_am_i");
        }
    }
}
