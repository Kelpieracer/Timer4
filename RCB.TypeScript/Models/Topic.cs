using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCB.TypeScript.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Name { get; set; }
        public User Manager { get; set; }
    }
}
