using System.Data;
using ManageBlogServiceCore.Domain.Entities;

namespace ManageBlogServiceInfrastructure.DataContext
{
    /// <summary>
    /// This class simulates a database table in memory to store blog posts.
    /// </summary>
    public class InMemoryBlogPostRepository
    {
        private readonly DataSet dataSet;

        private readonly InMemoryBlogCommentRepository _commentRepository;

        #region Constructor creating dataset and table
        public InMemoryBlogPostRepository(InMemoryBlogCommentRepository commentRepository)
        {
            _commentRepository = commentRepository;

            // Dataset to simulate a database table in memory to store blog posts.
            // It was used to gain time and not to implement a real database.
            dataSet = new DataSet("BlogPostDataSet");            
            var blogPostTable = new DataTable("BlogPosts");
            blogPostTable.Columns.Add("Id", typeof(int));
            blogPostTable.Columns.Add("Title", typeof(string));
            blogPostTable.Columns.Add("Content", typeof(string));

            blogPostTable.PrimaryKey = new DataColumn[] { blogPostTable.Columns["Id"] };
            dataSet.Tables.Add(blogPostTable);
        }
        #endregion

        #region Methods
        public void InsertPost(BlogPost post)
        {
            var blogPostTable = dataSet.Tables["BlogPosts"];
            blogPostTable.Rows.Add(post.Id, post.Title, post.Content);            
        }

        public List<BlogPost> GetAllPosts() 
        {
            var blogPostTable = dataSet.Tables["BlogPosts"];
            var posts = new List<BlogPost>();
            foreach (DataRow row in blogPostTable.Rows)
            {
                var post = new BlogPost
                {
                    Id = (int)row["Id"],
                    Title = (string)row["Title"],
                    Content = (string)row["Content"],
                    TotalComments = _commentRepository.GetCommentCount((int)row["Id"])
                };
                posts.Add(post);
            }            
            return posts;
        }

        public BlogPost GetPostById(int id)
        {
            var blogPostTable = dataSet.Tables["BlogPosts"];
            var row = blogPostTable.Rows.Find(id);

            if (row == null)
                return new BlogPost { Title = string.Empty, Content = string.Empty };

            return new BlogPost
            {
                Id = (int)row["Id"],
                Title = (string)row["Title"],
                Content = (string)row["Content"],
                TotalComments = _commentRepository.GetCommentCount((int)row["Id"])
            };
        }
        #endregion 
    }
}
