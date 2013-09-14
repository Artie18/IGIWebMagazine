using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Profile : ParentNoIdEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Role> Roles { get; set; }
        public string Position { get; set; } 
        // GridFS and ProfilePhotos will be supported in future not so far away

    }
}
