using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20 kg", "1.5", "Kitty");
            cat.PrintInfo();
        }
    }
}
