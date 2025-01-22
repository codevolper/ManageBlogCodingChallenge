using ManageBlogServiceCore.Domain.Entities;

namespace ManageBlogServiceCore.Application.Interfaces
{
    public interface ICommentService
    {
        void PostComment(BlogComment comment);
    }
}
