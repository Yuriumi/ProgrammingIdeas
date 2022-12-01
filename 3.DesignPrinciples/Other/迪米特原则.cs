using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迪米特原则
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Person person = new Person();
            person.CloseComputer(computer);

            Console.ReadKey();
        }
    }

    public class Computer
    {
        private void SaveCurrentTask()
        {
            Console.WriteLine("保存当前进程");
        }

        private void CloseScreen()
        {
            Console.WriteLine("关闭屏幕");
        }

        private void PowerOff()
        {
            Console.WriteLine("关闭电源");
        }

        public void CloseComputer()
        {
            this.SaveCurrentTask();
            this.CloseScreen();
            this.PowerOff();

            Console.WriteLine("电脑已关闭");
        }
    }

    public class Person
    {
        public void CloseComputer(Computer computer)
        {
            computer.CloseComputer();
        }
    }
}
