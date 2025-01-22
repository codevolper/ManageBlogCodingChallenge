using Microsoft.AspNetCore.Mvc;
using ManageBlogServiceCore.Domain.Entities;
using ManageBlogServiceCore.Application.Interfaces;

namespace ManageBlogServiceAPI.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;               
        }

        #region Methods
        [HttpGet]
        public IEnumerable<BlogPost> Get()
        {
            return _postService.GetPosts();
        }

        [HttpGet("{id}")]
        public BlogPost GetById(int id)
        {
            return _postService.GetById(id);
        }

        [HttpPost]
        public void Post(BlogPost post)
        {
            _postService.Post(post);
        }
        #endregion
    }
}