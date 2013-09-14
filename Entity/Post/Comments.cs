using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Entity
{
    public class Comments : ParentEntity
    {
        public List<Comment> InnerComments { get; set; }
    }
}
