using DAL.MongoHelper;
using MongoDB.Driver;
using Entity;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
        public class PostReader : IPost<Post>
        {

            public Post Create(Post entity)
            {
                return MongoHelper<Post>.Add(entity);
            }

            public Post Update(Post entity)
            {
                return MongoHelper<Post>.Update(entity);
            }

            public bool Delete(String id)
            {
                return MongoHelper<Post>.Remove(id);
            }

            public bool AddComment(string comment, string postId)
            {
              /* 
                var database = MongoDataBaseHelper.GetDatabase();
                var collection = database.GetCollection<Post>(typeof(Post).Name.ToLower());
                var post = collection.Find(new QueryDocument {{"id", postId}};
              */
                /* Not implemented yet */

                return false;
            }

            public bool RemoveComment(string comment, string postId)
            {
                /* Not implemented yet */
                return false;
            }
        }
}
