using DesignPattern.Decorator;
using DesignPattern.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
#if DECORATOR
            Person ms = new Person("MarsonShine");
            Console.WriteLine("\n 第一种妆扮：");
            TShirts dtx = new TShirts();
            BigTrouser bt = new BigTrouser();
            dtx.Decorate(ms);
            bt.Decorate(dtx);
            bt.Show(); 
#endif
            SchoolGirl zhuqin = new SchoolGirl();
            zhuqin.Name = "祝琴";
            Proxy.Proxy ms = new Proxy.Proxy(zhuqin);
            ms.GiveChocolate();
            ms.GiveDolls();
            ms.GiveFlowers();
            Console.ReadLine();
        }
    }
}
