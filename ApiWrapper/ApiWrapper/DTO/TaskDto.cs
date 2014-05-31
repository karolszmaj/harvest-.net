using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest.DTO
{
    /// <summary>
    /// Named with DTO. Without DTo can cause conflicts with TPL.
    /// </summary>
    public class TaskDto
    {
        public string Name { get; set; }
        public bool Billable { get; set; }
        public int Id { get; set; }
    }
}
