using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harvest.Modules.Account;
using Harvest.Modules.Time;

namespace Harvest
{
    public class HarvestRepository : IHarvestRepository
    {
        public ITimeTrackingRepository Time { get; protected set; }
        public IAccountRepository Account { get; protected set; }

        public HarvestRepository(ITimeTrackingRepository timeRepository, AccountRepository accountRepository)
        {
            Time = timeRepository;
            Account = accountRepository;
        }

        public void SetCredentials(string login, string password)
        {
            Time.SetCredentials(login,password);
            Account.SetCredentials(login,password);
        }

        public void SetCredentials(string token)
        {
            Time.SetCredentials(token);
            Account.SetCredentials(token);
        }


        
    }
}
