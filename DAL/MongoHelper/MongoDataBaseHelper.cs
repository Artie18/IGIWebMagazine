using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoHelper
{
    class MongoDataBaseHelper
    {
        public static MongoDatabase GetDatabase()
        {
            var server =
             MongoServer.Create(ConfigurationManager.ConnectionStrings["MongoDB_Local"].ConnectionString);
            return server.GetDatabase("WebJournal_development");
        }

    }
}
