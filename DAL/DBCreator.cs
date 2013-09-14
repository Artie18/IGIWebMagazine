using Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBCreator
    {
        public DBCreator()
        {
            var ConnectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(ConnectionString);
            var database = server.GetDatabase("WebJournal_development");
            var collection = database.GetCollection<User>("users");
            var user = new User { UserName = "Ben", Password = "123456", Profile = new Profile { Name = "Ben", Surname = "Benich"} };
            collection.Save(user);
            var id = user.Id;
    
        }
    }
}
