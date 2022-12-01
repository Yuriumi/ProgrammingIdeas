using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 合成复用原则_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Animal
    {
        public string Gender { get; set; }

        public void Eat()
        {

        }

        public void Sleep()
        {

        }
    }

    public interface IClime
    {
        void Clime();
    }

    public class Tigger : Animal, IClime
    {
        private string name;

        private Leg leg;

        private Food food;

        public Tigger(Leg leg)
        {
            this.leg = leg;
        }

        public void Clime()
        {
            Console.WriteLine("爬");
        }

        public void Drank(Water water)
        {
            Console.WriteLine("老虎喝了" + water.weight + "水");
        }
    }

    public class Leg
    {
        public int Count { get; set; }
    }

    public class TiggerGroup
    {
        private Tigger[] tiggers;
    }

    public class Food
    {
        public string FoofName;
        public string FoofColor;
    }

    public class Water
    {
        public float weight;
    }
}
