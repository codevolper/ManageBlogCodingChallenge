using ManageBlogServiceCore.Domain.Entities;

namespace ManageBlogServiceCore.Domain.Interfaces
{
    public interface IPostRepository
    {
        void Post(BlogPost post);

        BlogPost GetById(int id);

        IList<BlogPost> GetPosts();
    }
}
