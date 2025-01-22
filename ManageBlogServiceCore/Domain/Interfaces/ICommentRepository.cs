using ManageBlogServiceCore.Domain.Entities;

namespace ManageBlogServiceCore.Domain.Interfaces
{
    public interface ICommentRepository
    {
        void PostComment(BlogComment comment);       
    }
}
