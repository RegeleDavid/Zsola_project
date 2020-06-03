using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zsola_oop
{
    class Class3:Interface1
    {

        public void pl()
        {
            Console.WriteLine("bla bla bla");
            Console.WriteLine("bla bla bla");
            Console.WriteLine("bla bla bla");
            Console.WriteLine("bla bla bla");
            Console.WriteLine("bla bla bla");
            Console.WriteLine("bla bla bla");
            Console.WriteLine("bla bla bla");
            Console.WriteLine("bla bla bla");
            Console.WriteLine("bla bla bla");
        }
        public int rand(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
