using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.MainStructure
{
    public class Featured : ParentEntity
    {
        public Post Post;
        public bool isActive { get; set; }
    }
}
