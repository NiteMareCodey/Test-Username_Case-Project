using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Console_App
{
    internal class Program
    {
        public class car
        {
            public string color;
           public void run()
            {
                Console.WriteLine("vroom");

            }
        }
        static void Main(string[] args)
        {
            Mycar();
            DoSomething();
            

        }

        static void DoSomething()
        {
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.Write("Username is:" + username);
            //Console.Readline();
            Console.ReadKey();
        }
        static void Mycar()
        {
            car Beater=new car();
            Beater.color = "Red";
            Beater.run();
        }
    }
}

