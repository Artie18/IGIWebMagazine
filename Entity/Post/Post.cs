using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Post : ParentEntity
    {

        public string Title { get; set; }
        public string Preview { get; set; }
        // no  implamontation yet   //public List<Photo> Photos { get; set; }
        public string Body { get; set; }
        public List<Tag> Tags { get; set; }
        public Comments Comments { get; set; }
        public Source Source { get; set; }
        public List<Source> Via { get; set; }
        
    }
}
