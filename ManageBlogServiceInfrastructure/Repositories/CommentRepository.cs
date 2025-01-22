using ManageBlogServiceCore.Domain.Entities;
using ManageBlogServiceCore.Domain.Interfaces;
using ManageBlogServiceInfrastructure.DataContext;

namespace ManageBlogServiceInfrastructure.Repositories
{
    public class CommentRepository(InMemoryBlogCommentRepository repository) : ICommentRepository
    {
        private readonly InMemoryBlogCommentRepository _repository = repository;

        public void PostComment(BlogComment comment)
        {
           _repository.InsertComment(comment);
        }
    }
}
