using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IData<T>
    {
        T Create(T entity);
        T Update(ObjectId id, T entity);
        bool Delete(ObjectId id);
        // read
    }
}
