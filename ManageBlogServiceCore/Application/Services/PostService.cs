using ManageBlogServiceCore.Domain.Entities;
using ManageBlogServiceCore.Application.Interfaces;
using ManageBlogServiceCore.Domain.Interfaces;

namespace ManageBlogServiceCore.Application.Services
{
    public class PostService(IPostRepository repository) : IPostService        
    {
        private readonly IPostRepository postRepository = repository;

        public void Post(BlogPost post)
        {
            postRepository.Post(post);
        }

        public BlogPost GetById(int id)
        {
            return postRepository.GetById(id);
        }

        public IList<BlogPost> GetPosts()
        {
            return postRepository.GetPosts();          
        }       
    }
}
