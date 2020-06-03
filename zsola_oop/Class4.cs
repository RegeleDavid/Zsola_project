using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zsola_oop
{
    class Class4
    {
        private int a, b;
        public Class4(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void egyenlo()
        {
            Console.WriteLine(a+"+"+b+"="+(a + b));
        }
    }
}
