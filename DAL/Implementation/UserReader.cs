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

        public User Update(User entity)
        {
            return MongoHelper<User>.Update(entity);
        }

        public bool Delete(String id)
        {
            return MongoHelper<User>.Remove(id);
        }
    }
}
