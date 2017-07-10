using MediatorPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            User robert = new User("Robert");
            User laura = new User("Laura");

            robert.SendMessage("Hello");
            laura.SendMessage("world !");

            Console.ReadLine();
        }
    }
}
