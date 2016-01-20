using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12class和struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //不使用new来生成结构，其内部成员将初始化为
            Family newFamily;
            newFamily.name = "nanxiaodong";
            newFamily.sex = true;
            Console.WriteLine(newFamily.name);

            //以new来生成结构，调用带参数的构造器
            Family myFamily = new Family("nxd Family",25,true,"China",new Person("nxd",26));
            Person person = new Person();
            person.Name = "Nxd";

            //按值传递参数
            ShowFamily(myFamily);
            //按引用传递参数
            ShowPerson(person);

            Console.WriteLine("***************************");
            Console.WriteLine("I'm {0}",myFamily.name);
            Console.WriteLine("I'm {0}", person.Name);
            myFamily.GetSex();
            myFamily.ShowPerson();
            Console.WriteLine("***************************");
            Console.WriteLine(myFamily.ToString());

            Console.ReadKey();
        }

        public static void ShowPerson(Person person)
        {
            person.Name = "南小东";
            Console.WriteLine("This is {0}",person.Name);
        }
        public static void ShowFamily(Family family)
        {
            family.name = "nxd";
            Console.WriteLine("This is {0}",family.name);
        }
    }
    //定义接口
    interface IPerson
    {
        void GetSex();
    }
    //定义类
    public class Person
    {
        private string _name;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Person()
        {
        }
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }
    //定义结构(可以继承自接口，不可继承类或结构)
    struct Family : IPerson
    {
        public string name;
        public int age;
        public bool sex;
        public string country;
        public Person person;

        //不可以包含显示的无参构造函数和析构函数
        public Family(string name, int age, bool sex, string country, Person person)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.country = country;
            this.person = person;
        }
        //不可以实现protected、virtual、sealed和override成员
        public void GetSex()
        {
            if (sex)
            {
                Console.WriteLine(person.Name + " is a boy.");
            }
            else
            {
                Console.WriteLine(person.Name + " is a girl.");
            }
        }

        public void ShowPerson()
        {
            Console.WriteLine("This is {0} from {1}", new Person(name, 22).Name, country);
        }

        //可以重载ToString()虚方法
        public override string ToString()
        {
            return string.Format("{0} is {1},{2} from {3}",person.Name,age,sex?"Boy":"Girl",country);
        }
    }
}
