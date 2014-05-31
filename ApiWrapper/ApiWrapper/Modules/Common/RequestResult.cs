using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Harvest.Modules.Common
{
    public class RequestResult
    {
        public string Content { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
