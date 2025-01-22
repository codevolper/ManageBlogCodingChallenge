using ManageBlogServiceCore.Domain.Entities;

namespace ManageBlogServiceCore.Application.Interfaces
{
    public interface IPostService
    {
        void Post(BlogPost post);

        BlogPost GetById(int id);

        IList<BlogPost> GetPosts();
    }
}
