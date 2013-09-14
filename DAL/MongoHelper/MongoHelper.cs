using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MongoHelper
{
    public static class MongoHelper<T>
    {
        public static T Add(T entity)
        {
            
            var server = 
                MongoServer.Create(ConfigurationManager.ConnectionStrings["MongoDB_Local"].ConnectionString);
            var database = server.GetDatabase("WebJournal_development");
            var collection = database.GetCollection<T>(typeof(T).Name.ToLower());
            collection.Save(entity);
            return entity;
        }
    }
}
