using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Comment : ParentEntity
    {
        public string Body { get; set; }
        public User Author { get; set; } 
    }
}
