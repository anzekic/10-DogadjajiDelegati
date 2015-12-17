using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        // definicija delegata
        delegate void MojDelegat();

        public static void StatičkaMetoda()
        {
            Console.WriteLine("Pozvana je statička metoda");
        }

        public void MetodaInstance()
        {
            Console.WriteLine("Pozvana je metoda instance");
        }

        static void Main(string[] args)
        {
            MojDelegat md = StatičkaMetoda;

            md();

            Program p = new Program();

            md += p.MetodaInstance;

            md();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
