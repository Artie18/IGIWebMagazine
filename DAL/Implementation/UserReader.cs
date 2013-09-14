using System;
using DAL.MongoHelper; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MongoDB.Bson;

namespace DAL.Implementation
{
    public class UserReader : IData<User>
    {

        public User Create(User entity)
        {
            return MongoHelper<User>.Add(entity);
        }

        public User Update(ObjectId id, User entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(MongoDB.Bson.ObjectId id)
        {
            throw new NotImplementedException();
        }
    }
}
