using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
   public class AnimalConfiguration:EntityTypeConfiguration<Animal>
   {
       public AnimalConfiguration()
       {
           //Map(m =>
           //{
           //    m.ToTable("AnimalTable");
           //    m.Requires("AnimalType").HasValue("AnimalDefault");
           //}).Map<Dog>(m => m.Requires("AnimalType").HasValue("DogDefault"))
           //.Map<Cat>(m=>m.Requires("AnimalType").HasValue("CatDefault"));


           //Map(m =>
           //{
           //    m.ToTable("AnimalTable");
           //    m.Requires("IsResort").HasValue(false);
           //}).Map<Dog>(m => m.Requires("IsResort").HasValue(true));
           //.Map<Cat>(m=>m.Requires("AnimalType").HasValue(true));
       }
    }
}
