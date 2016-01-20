using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data;
using Model.Data.EF;

namespace ConsoleApplication.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new MainBCUnitOfWork())
            {
                var user = new User();

                //db.Database.CreateIfNotExists();

                user.Name = "南晓东";
                user.Age = 26;

                db.Users.Add(user);

                //var loding = new Lodging();
                //loding.Name = "123";
                //db.Lodgings.Add(loding);


                db.SaveChanges();

                Console.WriteLine("成功创建数据库和表");
                Console.ReadKey();
            }

        }
    }
}
