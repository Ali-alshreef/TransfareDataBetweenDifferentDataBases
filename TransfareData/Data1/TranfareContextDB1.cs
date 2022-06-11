using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace TransfareData.Data1
{
    public partial class TranfareContextDB1 : DbContext
    {
        public TranfareContextDB1()
            //: base("name=ModelDB1")
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = "localhost";
            csb.InitialCatalog = "Scrap";
            csb.UserID = "your user name";
            csb.Password = "your password";
            Database.Connection.ConnectionString = csb.ToString();
        }

        public virtual DbSet<DraiverNames> DraiverNames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }


    }
}
