using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Persons
    {
        static void Main(string[] args)
        {
           Person george = new Person("George", 35);
           Person pesho = new Person("Pesho", 25, "@");
           Person alex = new Person("Alex", 25, "$");
           Person ani = new Person("Ani", 20, "design.angelova@gmail.com");

           Console.WriteLine("{0} {1} {2} {3}", george, pesho,alex, ani);
        }
    }
}