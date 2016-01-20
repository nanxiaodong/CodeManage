using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class MyDomainContext : DbContext
    {
        static MyDomainContext()
        {
           // Database.SetInitializer<MyDomainContext>(new DropCreateDatabaseIfModelChanges<MyDomainContext>());
        }

        //public MyDomainContext(DbConnection connection)
        //    : base(connection, contextOwnsConnection:false)
        //{
            
        //}

        public MyDomainContext()
            : base("Name=ConnContext")
        {
            // 禁用延迟加载
            this.Configuration.LazyLoadingEnabled = false;
        }

        #region DbSet
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Video> Videos { get; set; }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Animal> Animals { get; set; }

        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Father> Fathers { get; set; }
        public DbSet<Son> Sons { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            // modelBuilder.Ignore<Phone>();//忽略Phone类的映射
            //modelBuilder.Entity<Teacher>().ToTable("Teacher");//派生类映射到一个新的表中
        }

    }
}
