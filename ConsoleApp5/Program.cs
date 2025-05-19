using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Drill drill = new Drill("drill",3.7);
            drill.Describe();
            drill.Use();
            Console.WriteLine("");
            Hammer hammer = new Hammer("hammer",1.7);
            hammer.Describe();
            hammer.Use();
            Console.WriteLine("");
            Wrench wrench = new Wrench("wrench", 1.1);
            wrench.Describe();
            wrench.Use();
            Console.WriteLine("");
            Saw saw = new Saw("saw", 0.9);
            saw.Describe();
            saw.Use();
            Console.WriteLine("");
            Screwdriver screwdriver = new Screwdriver("screwdriver", 0.15);
            screwdriver.Describe();
            screwdriver.Use();
            Console.WriteLine("");
            Pipecutter pipecutter = new Pipecutter("pipecutter", 1.3);
            pipecutter.Describe();
            pipecutter.Use();


            Console.WriteLine();
            Drill drill2 = new Drill("drill2",3.2);
            drill2.Describe();
            drill2.Use();
            Console.WriteLine();
            Pipecutter pipecutter2 = new Pipecutter("pipecutter02", 1.1);
            pipecutter2.Describe();
            pipecutter2.Use();



            List<Tool> tools = new List<Tool>();
            tools.Add(drill);
            tools.Add(hammer);
            tools.Add(wrench);
            tools.Add(saw);
            tools.Add(screwdriver);
            tools.Add(pipecutter);

            foreach (Tool item in tools)
            {
                item.Describe();
                item.Use();
            }
        }
    }
}
