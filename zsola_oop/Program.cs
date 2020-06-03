using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zsola_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            new Class4(new Class3().rand(0,10), new Class1().poz()).egyenlo();
            Console.ReadKey();

        }
    }
}
