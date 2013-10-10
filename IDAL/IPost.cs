using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IPost<T> : IData<T> where T : Post  
    {
        public bool AddComment(string comment, string postId);
        public bool RemoveComment(string comment, string postId);
    }
}
