using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harvest.Modules.Common
{
    public interface IAuthInitalizer
    {
        /// <summary>
        /// Initalizes repository with credentials used for HTTP Basic Authentication
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        void SetCredentials(string login, string password);

        /// <summary>
        /// Initalizes repository with credentials used for HTTP OAuth 2.0 Authentication
        /// </summary>
        /// <param name="token"></param>
        void SetCredentials(string token);

    }
}
