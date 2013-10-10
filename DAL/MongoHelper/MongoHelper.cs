using MongoDB.Bson;
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
        public static T Add(T entity) {
            var database = MongoDataBaseHelper.GetDatabase();
            var collection = database.GetCollection<T>(typeof(T).Name.ToLower());
            collection.Save(entity);
            return entity;
        }

        public static T Update(T entity) {
            var database = MongoDataBaseHelper.GetDatabase();
            var collection = database.GetCollection<T>(typeof(T).Name.ToLower());
            collection.Save(entity);
            return entity;
        }

        public static bool Remove(string id) {
            var database = MongoDataBaseHelper.GetDatabase();
            var collection = database.GetCollection<T>(typeof(T).Name.ToLower());
            var query = new QueryDocument {{ "id", id }};
            collection.Remove(query);
            return true;
        }

        
    }
}
