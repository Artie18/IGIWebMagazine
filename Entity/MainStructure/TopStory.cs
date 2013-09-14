using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TopStory : ParentEntity
    {
        public Post Posts { get; set; }
        public bool isActive { get; set; }
    }
}
