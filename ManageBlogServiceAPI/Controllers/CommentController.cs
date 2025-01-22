using Microsoft.AspNetCore.Mvc;
using ManageBlogServiceCore.Domain.Entities;
using ManageBlogServiceCore.Application.Interfaces;

namespace ManageBlogServiceAPI.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class CommentController(ICommentService commentService) : ControllerBase
    {
        private readonly ICommentService _commentService = commentService;

        [HttpPost("{id}/comments")]
        public void Post(int id, [FromBody] BlogComment comment)
        {
            comment.Post.Id = id;
            _commentService.PostComment(comment);
        }
    }
}
