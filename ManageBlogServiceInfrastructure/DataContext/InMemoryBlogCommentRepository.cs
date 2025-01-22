using ManageBlogServiceCore.Domain.Entities;
using System.Data;

namespace ManageBlogServiceInfrastructure.DataContext
{
    public class InMemoryBlogCommentRepository
    {
        private readonly DataSet dataSet;

        #region Constructor creating dataset and table
        public InMemoryBlogCommentRepository()
        {
            dataSet = new DataSet("BlogCommentDataSet");
            var blogPostTable = new DataTable("BlogPosts");
            blogPostTable.Columns.Add("Id", typeof(int));
            blogPostTable.Columns.Add("PostId", typeof(int));
            blogPostTable.Columns.Add("Author", typeof(string));
            blogPostTable.Columns.Add("Content", typeof(string));
            
            blogPostTable.PrimaryKey = new DataColumn[] { blogPostTable.Columns["Id"] };
            dataSet.Tables.Add(blogPostTable);

            var relation = new DataRelation("PostCommentRelation", dataSet.Tables["BlogPosts"].Columns["Id"], dataSet.Tables["BlogPosts"].Columns["PostId"]);
            dataSet.Relations.Add(relation);
        }
        #endregion

        #region Methods
        public void InsertComment(BlogComment comment)
        {
            var blogPostTable = dataSet.Tables["BlogPosts"];
            blogPostTable.Rows.Add(comment.Id, comment.Post.Id, comment.Author, comment.Content);
        }

        public int GetCommentCount(int postId)
        {
            var blogPostTable = dataSet.Tables["BlogPosts"];
            var post = blogPostTable.Rows.Find(postId);

            if (post == null)
                return 0;

            return post.GetChildRows("PostCommentRelation").Length;
        }

        #endregion

    }
}
