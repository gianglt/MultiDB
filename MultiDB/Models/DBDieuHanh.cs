namespace MultiDB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBDieuHanh : DbContext
    {
        public DBDieuHanh()
            : base("name=DBDieuHanh")
        {
        }



        public DBDieuHanh(string mydbname = "dhvp_1")
            
        {
            string strConnection = "data source=(local)\\SQLExpress;initial catalog=" + mydbname + ";integrated security=True;MultipleActiveResultSets=True";
            this.Database.Connection.ConnectionString = strConnection;
        }

        public virtual DbSet<DMNhanVien> DMNhanVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
