using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace RCB.TypeScript.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public Customer Customer { get; set; }
        public ICollection<WorkItem> WorkItems { get; set; }
        public ICollection<Rate> Rates { get; set; }
        public User Manager { get; set; }
        public ICollection<User> Members { get; set; }
    }
}
