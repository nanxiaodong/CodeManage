using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _32LINQ
{
    class Program
    {
        #region xml文件读取
        //static void Main(string[] args)
        //{
        //    string filePath = AppDomain.CurrentDomain.BaseDirectory + "User.xml";

        //    //将XML加载到内存对象
        //    XElement xmlData = XElement.Parse(File.ReadAllText(filePath));

        //    //执行LINQ查询
        //    var users = from user in xmlData.Descendants("Users")
        //                where int.Parse(user.Element("Age").Value) < 30
        //                orderby int.Parse(user.Element("Age").Value) descending
        //                select new
        //                {
        //                    Name = user.Element("Name").Value,
        //                    Age = user.Element("Age").Value
        //                };

        //    //遍历查询结果
        //    foreach (var user in users)
        //    {
        //        Console.WriteLine(user.Name);
        //    }
        //    Console.ReadKey();
        //} 
        #endregion


        static void Main(string[] args)
        {
            var students = new List<Student> 
            {
                new Student{Name="张三",Age=25},
                new Student{Name="李四",Age=26},
                new Student{Name="王五",Age=27}

            };
            var result = students.Select(i => new Student { Name = i.Name });
            var result1 = students.Select(i => new { Name = i.Name });
            var result2 = students.Select(i => new { Age = i.Age });

            Console.ReadKey();
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
