using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 合成复用原则
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car dCar = new DCar();
            dCar.Run(new RedColor());

            Car qyCar = new QYCar();
            qyCar.Run(new GreenColor());

            Console.ReadKey();
        }
    }

    public interface IColor
    {
        string Color();
    }

    public class RedColor : IColor
    {
        public string Color()
        {
            return "Red";
        }
    }

    public class BlueColor : IColor
    {
        public string Color()
        {
            return "Blue";
        }
    }

    public class GreenColor : IColor
    {
        public string Color()
        {
            return "Green";
        }
    }

    public abstract class Car
    {
        public abstract void Run(IColor color);
    }

    public class QYCar : Car
    {
        public override void Run(IColor color)
        {
            Console.WriteLine(color + "颜色的汽油汽车在跑");
        }
    }

    public class DCar : Car
    {
        public override void Run(IColor color)
        {
            Console.WriteLine(color + "颜色的电动汽车在跑");
        }
    }
}
