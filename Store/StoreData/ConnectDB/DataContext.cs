using Microsoft.EntityFrameworkCore;
using StoreData.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData.ConnectDB
{
    public class DataContext : DbContext
    {
        private GetConnectionString _getConnectionString;

        public DataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            _getConnectionString = new();
        }

        //public DataContext()
        //{
        //    _getConnectionString = new();
        //}

        public DbSet<Product> Products { get; set; } = null;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // optionsBuilder.UseSqlServer("Data Source=WIN-ARCTJA5L0P5\\SQLEXPRESS;Initial Catalog=KratecDBCore;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //    var connectionString = _getConnectionString.GetConnectionStrings("StoreAPIConnection");
        //    optionsBuilder.UseSqlServer(connectionString); ///
        //}
    }
}
