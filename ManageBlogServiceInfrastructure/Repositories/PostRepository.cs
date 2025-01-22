using ManageBlogServiceCore.Domain.Entities;
using ManageBlogServiceInfrastructure.DataContext;
using ManageBlogServiceCore.Domain.Interfaces;

namespace ManageBlogServiceInfrastructure.Repositories
{
    public class PostRepository(InMemoryBlogPostRepository datasetMemory) : IPostRepository
    {
        private readonly InMemoryBlogPostRepository _datasetMemory = datasetMemory;

        public void Post(BlogPost post)
        {
            _datasetMemory.InsertPost(post);
        }       

        public BlogPost GetById(int id)
        {
            return _datasetMemory.GetPostById(id);
        }

        public IList<BlogPost> GetPosts()
        {
            return _datasetMemory.GetAllPosts();
        }
    }
}
