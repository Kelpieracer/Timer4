using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCB.TypeScript.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Rate> Rates { get; set; }
        public User Manager { get; set; }
    }
}
