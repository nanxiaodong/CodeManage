using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Null_Object模式
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager manager = new UserManager();
            manager.User = null;

            manager.User.Login();
            if (manager.User.IsNull)
            {
                Console.WriteLine("用户不存在，前检查。。。");
            }

            Console.ReadKey();
        }
    }
    class UserManager
    {
        private IUser user = new User();
        public IUser User
        {
            get { return user; }
            set
            {
                user=value??new NullUser();
            }
        }
    }
    public interface IUser
    {
        void Login();
        void GetInfo();
        bool IsNull { get; }
    }
    public class User : IUser
    {
        public void Login()
        {
            Console.WriteLine("user login now...");
        }
        public void GetInfo()
        {
            Console.WriteLine("user logout now...");
        }
        public bool IsNull
        {
            get { return false; }
        }
    }
    public class NullUser : IUser
    {

        public void Login()
        {
            Console.WriteLine("Login不做任何处理。。。");
        }

        public void GetInfo()
        {
            Console.WriteLine("GetInfo不做任何处理。。。");
        }
        public bool IsNull
        {
            get { return true; }
        }
    }
}
