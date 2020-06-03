using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zsola_oop
{
    class Class1:Class2
    {
        public void kiir()
        {
            Console.WriteLine("szia zsola");
        }

        public int poz()
        {
            Console.Write("a:");
            int a = this.billenyuzetrol();
            while (a%2!= 0 || a<0)
            {
                Console.Write("a:");

                a = this.billenyuzetrol();
            }
            return a;
        }
    }
}
