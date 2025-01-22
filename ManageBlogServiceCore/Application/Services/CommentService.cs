using ManageBlogServiceCore.Domain.Entities;
using ManageBlogServiceCore.Domain.Interfaces;
using ManageBlogServiceCore.Application.Interfaces;

namespace ManageBlogServiceCore.Application.Services
{
    public class CommentService(ICommentRepository repository) : ICommentService
    {
        private readonly ICommentRepository commentRepository = repository;
        public void PostComment(BlogComment comment)
        {
            commentRepository.PostComment(comment);
        }
    }
}
