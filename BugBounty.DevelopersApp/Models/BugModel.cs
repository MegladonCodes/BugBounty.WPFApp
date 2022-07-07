using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBounty.DevelopersApp.Models
{
    public class BugModel
    {
        public int BugId { get; set; }
        public string? ShortDesc { get; set; }
        public string? Location { get; set; }
        public string? Assignee { get; set; }
        public bool IsResolved { get; set; }
    }
}
