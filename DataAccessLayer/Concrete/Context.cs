using EntityLayer.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        private static string ConnectionString { get; set; }

        public static void SetConnectionString(string connectionString)
        {
            if (ConnectionString == null)

            {
                ConnectionString = connectionString;
            }
            else
            {
                throw new Exception();
            }
        }
        // this part will help you to open the connection
        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }


        //add the connectionString to options

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //optionsBuilder.UseSqlServer("server=DESKTOP-BDTMNI9\\SQLEXPRESS;database=CoreBlogDb; integrated security=true;");
        //} 


        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

		public DbSet<Comment> Comment { get; set; }

		public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Writer> Writers { get; set; }
    }
     
}
