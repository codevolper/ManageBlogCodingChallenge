using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text.Json.Serialization;

namespace ManageBlogServiceCore.Domain.Entities
{
    public class BlogComment
    {
        public BlogComment()
        {
            Post = new BlogPost { Title = string.Empty, Content = string.Empty }; 
        }

        [Key]
        public int Id { get; set; }
                
        public required string Author { get; set; }

        public required string Content { get; set; }

        [JsonIgnore]
        [ForeignKey("Id")]
        public BlogPost Post { get; set; }         
    }
}