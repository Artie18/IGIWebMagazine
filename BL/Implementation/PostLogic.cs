using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBL;
using Entity;
using DAL.Implementation;

namespace BL.Implementation
{
    public class PostLogic<T> : IPost<T> where T : Post 
    {

        public Post Add(string title, string preview, string body, string sourceId)
        {
            if (preview.Length > Post.maxLengthOfAPreview)
                throw new System.InvalidOperationException("Preview is to long");
            /* TODO: Implement source BL */
            var post = new Post
            {
                Body = body,
                Title = title,
                /* TODO: Add Source here */
                Preview = preview
            };
            try
            {
                new PostReader().Create(post);
                return post;
            }
            catch (Exception e)
            {
                return null;
            }
         }

        public Post Update(string id, string title, string preview, string body, string sourceId)
        {
            throw new NotImplementedException();
        }

        public Post Remove(string id, string title, string preview, string body, string sourceId)
        {
            throw new NotImplementedException();
        }
    }
}
