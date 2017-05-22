using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        private int age;//字段
        private string name;
        public int Age
        {
            get { return age; }// 取值
            set { age = value; }// 赋值
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person()  //构造方法,初始化变量
        {
            Console.WriteLine("人类的构造函数");
        }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
}
