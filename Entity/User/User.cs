using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User : ParentEntity
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public Profile Profile { get; set; }
        public bool isDeleted { get; set; }
    }
}
