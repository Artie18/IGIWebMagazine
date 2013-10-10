using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBL
{
    public interface IPost<T> : ILogic<T> where T : Post 
    {
        public T Add(string title, 
            string preview, string body, string sourceId);
        public T Update(string id, string title,
            string preview, string body, string sourceId);
        public T Remove(string id, string title,
            string preview, string body, string sourceId);
    }
}
