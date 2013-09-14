using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Source : ParentEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
    }
}
