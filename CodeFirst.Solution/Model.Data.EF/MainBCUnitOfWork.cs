using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data.EF.Mapping;

namespace Model.Data.EF
{
    public class MainBCUnitOfWork : DbContext
    {

        public MainBCUnitOfWork()
            : base("Name=ConnContext")
        {
            // 禁用延迟加载
            this.Configuration.LazyLoadingEnabled = false;
        }


        static MainBCUnitOfWork()
        {
            // Database.SetInitializer<MainBCUnitOfWork>(null);

            //CreateDatabaseIfNotExists是Database.SetInitializer指定数据库的默认方式，用于当数据库不存在时，自动创建数据库。由于该方式是默认方式，所以可以不需要任何代码进行指定，当然也可以使用代码来明确的指定。
            Database.SetInitializer(new CreateDatabaseIfNotExists<MainBCUnitOfWork>());

            //DropCreateDatabaseAlways用于每次均先删除原数据库再创建新的数据库，不管数据模型是否发生改变。
            //Database.SetInitializer(new DropCreateDatabaseAlways<MainBCUnitOfWork>());

            //DropCreateDatabaseWhenModelChanges用于当数据模型发生改变时，先删除原数据库，后创建新的数据库。
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MainBCUnitOfWork>());
        }

        #region DbSet
        public DbSet<User> Users { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Person> Peoples { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Measurement> Measurements { get; set; }

        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Destination> Destinations { get; set; }

        //public DbSet<InternetSpecial> InternetSpecials { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // 禁用一对多级联删除
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            // 禁用多对多级联删除
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            // 禁用默认表名复数形式
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new TripConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new PersonalInfoConfiguration());

            // modelBuilder.Entity<>()
        }
    }

    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(i => i.Id);

            this.Property(i => i.Name).IsRequired().HasMaxLength(255);
            //配置实体映射到的表名 --数据库中会生成这种格式：UserInfo.User
            this.ToTable("User", "UserInfo");

            this.Property(i => i.Id).HasColumnName("ID");



        }
    }
}
