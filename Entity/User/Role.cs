using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Entity
{
    public class Role : ParentNoIdEntity
    {
        public bool isAdmin { get; set; }
        public bool isJournalist { get; set; }
        public bool isMarketing { get; set; }
        public bool isEditor { get; set; }
        public bool isPhotographer { get; set; }

    }
}
