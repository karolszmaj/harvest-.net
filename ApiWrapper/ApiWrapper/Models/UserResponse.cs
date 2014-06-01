using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harvest.DTO;

namespace Harvest.Models
{
    public class UserResponse
    {
        public Company Company { get; set; }
        public User User { get; set; }
    }
}
