using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogs.DAL.Interface;
using Blogs.Entities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Blogs.DAL
{
    public class CommentDao : ICommentDao
    {
        private readonly string _connectionString;

        #region Constructor
        public CommentDao()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }
        #endregion

        #region Methods
        public int AddComment(Comment comment)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddComment";

                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = comment.Text };
                    command.Parameters.Add(text);
                    var blogId = new SqlParameter("@BlogId", SqlDbType.Int) { Value = comment.BlogId };
                    command.Parameters.Add(blogId);
                    var userName = new SqlParameter("@UserName", SqlDbType.NVarChar) { Value = comment.UserName };
                    command.Parameters.Add(userName);

                    connection.Open();
                    return (int)(decimal)command.ExecuteScalar();
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        public IEnumerable<Comment> GetAllCommentsByBlogId(int BlogId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetAllCommentsByBlogId";

                    var blogId = new SqlParameter("@BlogId", SqlDbType.Int) { Value = BlogId };
                    command.Parameters.Add(blogId);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Comment
                        {
                            CommentId = (int)reader["CommentID"],
                            Text = (string)reader["Text"],
                            CreationDate = ((DateTime)reader["CreationDate"]).ToString(),
                            BlogId = (int)reader["BlogID"],
                            UserName = (string)reader["Name"],
                        };
                    }
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
        #endregion
    }
}
