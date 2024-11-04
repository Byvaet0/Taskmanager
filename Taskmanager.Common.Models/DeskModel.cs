using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskmanager.Common.Models
{
    public class DeskModel : CommonModel
    {
        public bool IsPrivate { get; set; }
        public string[] Columns { get; set; }
        public int ProjectId { get; set; }
        public int AdminId { get; set; }
        public List<int> TasksIds { get; set; } 
    }
}

