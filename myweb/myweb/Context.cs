namespace myweb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;
    public class Context : DbContext
    {
        public Context()
        : base("name=Context")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
        public DbSet<Employee> Employees { get; set; }





        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //// {

        //}
    }
}
