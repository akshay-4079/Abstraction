using System;
using InheritanceHard;

namespace AbstractionHard
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A Class can have only one Parent but inherit multiple interfaces");
            Console.WriteLine("Interfaces are the ultimate form of abstraction and have little to none implementation details");
            Console.WriteLine("Consider the following interface that calculates area and volume");
            Calculation calc = new Calculation();
            calc.SetLength(12);
            calc.SetWidth(14);
            calc.getArea1();
            calc.SetRadius(4);
            calc.SetHeight(1);
            calc.getArea2();
            calc.getVolume();
        }
    }
}
