using System.ComponentModel.DataAnnotations;

namespace ManageBlogServiceCore.Domain.Entities
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }                
       
        public required string Title { get; set; }

        public required string Content { get; set; }

        public int TotalComments { get; set; }
    }
}
