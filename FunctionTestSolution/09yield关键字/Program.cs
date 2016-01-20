using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09yield关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo userList = new UserInfo();
            foreach (var str in userList)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
    class UserInfo
    {
        string[] users = { "张三", "李四", "王五" };
        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < users.Length; i++)
            {
                yield return users[i];
            }
            yield break;
            yield return "BREAK";//代码不可访问
        }
    }
}
