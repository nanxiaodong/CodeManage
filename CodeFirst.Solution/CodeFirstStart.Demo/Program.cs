using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Order-OrderDetail
            //using (var db = new MyDomainContext())
            //{
            //    var order = new Order
            //    {
            //        OrderTitle = "C#",
            //        CustomerName = "zhangsan",
            //        TransactionDate = DateTime.Now,
            //        //OrderDetails = new List<OrderDetail>()
            //        //{
            //        //    new OrderDetail()
            //        //    {
            //        //        Cost = 50,
            //        //        ItemName = "反射"
            //        //    }
            //        //}
            //    };

            //    var detail = new OrderDetail { Cost = 50, ItemName = "反射" };
            //    detail.FK_Order = order.OrderID;

            //    db.Orders.Add(order);
            //    db.OrderDetails.Add(detail);

            //    db.SaveChanges();
            //}

            ////using (var delDb=new MyDomainContext())
            ////{
            ////    var orders = delDb.Orders.Include("OrderDetails").FirstOrDefault();
            ////    delDb.Orders.Remove(orders);
            ////    delDb.SaveChanges();
            ////} 
            #endregion

            #region User-Role

            //using (var db=new MyDomainContext())
            //{
            //    var user = new UserInfo()
            //    {
            //        UserName = "nxd",
            //        Roles = new List<Role>()
            //        {
            //            new Role()
            //            {
            //                RoleName = "管理员"
            //            }
            //        }
            //    };
            //    db.UserInfos.Add(user);
            //    db.SaveChanges();
            //}

            //using (var dbQuery = new MyDomainContext())
            //{
            //    var user = dbQuery.UserInfos.Include("Roles").FirstOrDefault();
            //    //Console.WriteLine("ID:{2}-UseName:{0}-RoleName:{1}", user.UserName, user.Roles.FirstOrDefault().RoleName, user.Id);
            //}
            #endregion

            #region Animal

            //using (var db = new MyDomainContext())
            //{
            //    var animal = new Animal()
            //    {
            //        Name = "动物"

            //    };
            //    db.Animals.Add(animal);
            //    db.SaveChanges();
            //}

            //using (var db=new MyDomainContext())
            //{
            //    var dog = new Dog()
            //    {
            //        Name = "藏獒",
            //        Run = "别叫"
            //    };
            //    db.Animals.Add(dog);
            //    db.SaveChanges();
            //}
            #endregion

            #region School

            //using (var db = new MyDomainContext())
            //{
            //    //var school = new School()
            //    //{
            //    //    SchoolName = "镇中",
            //    //    SchoolAddress = "马夹河畔",

            //    //};
            //    //db.Schools.Add(school);


            //    var teacher = new Teacher();
            //    teacher.TeacherId = 110;
            //    teacher.TeacherName = "nxd";
            //    teacher.SchoolName = "二中";
            //    teacher.SchoolAddress = "city";


            //    db.Teachers.Add(teacher);
            //    db.SaveChanges();
            //}

            //using (var db = new MyDomainContext())
            //{
            //    var school = db.Schools.FirstOrDefault();
            //    db.Schools.Remove(school);
            //    db.SaveChanges();
            //}

            //using (var db=new MyDomainContext())
            //{
            //    var teacher = db.Teachers.FirstOrDefault();
            //    db.Teachers.Remove(teacher);
            //    db.SaveChanges();
            //}
            #endregion

            #region Father

            //using (var db = new MyDomainContext())
            //{
            //    var father = new Father();
            //    father.FatherName = "zhangsan";
            //    father.FatherAdress = "北京";




            //    db.Fathers.Add(father);



            //    db.SaveChanges();
            //}

            //using (var db=new MyDomainContext())
            //{
            //    var son = new Son();
            //    son.SonName = "lili";
            //    son.Age = 20;
            //    son.FatherAdress = "洛杉矶";
            //    son.FatherName = "仓格拉";

            //    db.Sons.Add(son);
            //    db.SaveChanges();
            //}
            #endregion

            #region 抽象类

            //using (var db = new MyDomainContext())
            //{
            //    //var animal = new Animal();
            //    //animal.Name = "你猜";
            //    //db.Animals.Add(animal);
            //    //db.SaveChanges();

            //    var cat = new Cat();
            //    cat.Name = "鸡肋名称";
            //    cat.CatId = 110;
            //    cat.Eat = "老毛";
            //    //cat.Run由于Run是Dog的属性，所以使用cat对象是点不出来的
            //    db.Animals.Add(cat);
            //    db.SaveChanges();

            //    var animals = db.Animals.ToList();
            //    foreach (var animal in animals)
            //    {
            //        Console.WriteLine("animal.Name" + animal.Name);
            //    }
            //}
            #endregion

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDomainContext>());
            //using (var db = new MyDomainContext())
            //{
            //    try
            //    {
            //        db.Database.Initialize(force: false);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            Database.SetInitializer(new DropCreateBreakAwayWithSeedData());
            using (var db = new MyDomainContext())
            {
                var exitCat = from cat in db.Animals
                              where cat.Name == "毛"
                              select cat;
                if (exitCat.Any())
                {
                    Console.WriteLine(exitCat.FirstOrDefault().Name);
                }
            }

            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
