using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 依赖倒置原则_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetCar(new Benz());
            student.Driver();

            Console.ReadKey();
        }
    }

    public interface ICar
    {
        void Run();
    }

    public interface IDriver
    {
        void SetCar(ICar car);

        // 接口注入
        // void Driver(ICar car);

        // 构造函数传递
        void Driver();
    }

    public class Benz : ICar
    {
        public void Run()
        {
            Console.WriteLine("奔驰在奔跑");
        }
    }

    public class Student : IDriver
    {
        private ICar _car;
        //public Student(ICar car)
        //{
        //    _car = car;
        //}

        //public void Driver()
        //{
        //    this._car.Run();
        //}

        public void SetCar(ICar car)
        {
            this._car = car;
        }
        public void Driver()
        {
            _car.Run();
        }
    }
}
