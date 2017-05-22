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
           
        }
    }
}
