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
        public BlogDao()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        public int AddBlog(Blogs.Entities.Blog blog)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "";
                return 1;

            }
        }

        public void DeleteBlog(int BlogId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteBlogById";
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteBlog(string Name)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "";


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

        public IEnumerable<Blogs.Entities.Blog> GetBlog(string Name)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "";

                yield return new Blog
                {
                }; ;
            }
        }

        public IEnumerable<Blogs.Entities.Blog> GetBlog()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "";

                yield return new Blog
                {
                }; ;
            }
        }

        public IEnumerable<Blogs.Entities.Blog> SortBlogs()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "";

                yield return new Blog
                {
                }; ;
            }
        }

        public void UpdateBlog(int BlogId, Blogs.Entities.Blog blog)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "";


            }
        }

        public void UpdateBlog(string Name, Blogs.Entities.Blog blog)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "";


            }
        }
    }
}
