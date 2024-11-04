using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskmanager.Common.Models
{
    public class ProjectModel : CommonModel
    {
        public ProjectStatus Status { get; set; }
        public int? AdminId { get; set; }
        public List<int> AllUsersIds { get; set; } 
        public List<int> AllDesksIds { get; set; } 
    }
}
