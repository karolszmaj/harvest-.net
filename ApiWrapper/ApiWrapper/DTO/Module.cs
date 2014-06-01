using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest.DTO
{
    public class Module
    {
        public bool Approval { get; set; }
        public bool Estimates { get; set; }
        public bool Expenses { get; set; }
        public bool Invoices { get; set; }
    }
}
