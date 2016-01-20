using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class DropCreateBreakAwayWithSeedData : DropCreateDatabaseAlways<MyDomainContext>
    {
        protected override void Seed(MyDomainContext context)
        {
            context.Database.ExecuteSqlCommand("CREATE INDEX IX_Lodgings_Name ON Animals (Name)");
            context.Animals.Add(new Cat() { Name = "毛", Eat = "吃吃吃" });
            context.Animals.Add(new Dog() { Name = "狗", Run = "看家去" });
        }
    }
}
