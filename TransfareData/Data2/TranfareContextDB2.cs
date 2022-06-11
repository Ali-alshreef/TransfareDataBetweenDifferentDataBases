using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace TransfareData.Data2
{
    public partial class TranfareContextDB2 : DbContext
    {
        public TranfareContextDB2()
            //: base("name=ModelDB2")
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = "localhost";
            csb.InitialCatalog = "ScrapData";
            csb.UserID = "your user name";
            csb.Password = "your password";
            Database.Connection.ConnectionString = csb.ToString();
        }

        public virtual DbSet<Merchants> Merchants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
