using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            //p.Name = "zhangsan";
            //p.Age = 21;
            string strname = p.Name;
            int strage = p.Age;

            Person p2 = new Person("zhangsan", 21);
           //静态变量在任何地方都可以使用,没有限制,直接可以拿过来用
           //静态变量相当于全局变量
           //当在静态方法中访问实例成员(实例变量,实例方法)的时候,,需要先创建一个对象
        }
    }
}
