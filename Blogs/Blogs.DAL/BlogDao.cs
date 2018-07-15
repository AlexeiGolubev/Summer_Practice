using Blogs.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogs.Entities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Blogs.DAL
{
    public class BlogDao : IBlogDao
    {
        private readonly string _connectionString;

        #region Constructor
        public BlogDao()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }
        #endregion

        #region Methods
        public int AddBlog(Blog blog)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "";

                    var name = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = blog.Name };
                    command.Parameters.Add(name);
                    var description = new SqlParameter("@Description", SqlDbType.NVarChar) { Value = blog.Description };
                    command.Parameters.Add(description);

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

        public void DeleteBlog(int BlogId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "";

                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        public void DeleteBlog(string Name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "";

                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        public Blog GetBlog(int BlogId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetBlogById";

                var blogId = new SqlParameter("@BlogId", SqlDbType.Int) { Value = BlogId };
                command.Parameters.Add(blogId);

                connection.Open();
                var reader = command.ExecuteReader();
                reader.Read();
                return new Blog
                {
                    BlogId = (int)reader["BlogId"],
                    Name = (string)reader["Name"],
                    CreationDate = ((DateTime)reader["CreationDate"]).ToString(),
                    Description = (string)reader["Description"],
                };
            }
        }

        public IEnumerable<Blog> GetBlog(string Name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "";

                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Blog
                        {
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

        public IEnumerable<Blog> GetBlog()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "";

                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Blog
                        {
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

        public IEnumerable<Blog> SortBlogs()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "";

                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Blog
                        {
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

        public void UpdateBlog(int BlogId, Blog blog)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "";

                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);
                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);
                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        public void UpdateBlog(string Name, Blog blog)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "";

                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);
                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);
                    var text = new SqlParameter("@Text", SqlDbType.NVarChar) { Value = 1 };
                    command.Parameters.Add(text);

                    connection.Open();
                    command.ExecuteNonQuery();
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
