using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurenjeMemorijeZbogNeodjave
{
    class Program
    {
        const int max = 100000;

        class GeneratorDogadjaja
        {
            public event EventHandler Događaj;
        }

        
        class SlušateljDogađaja
        {
            static int brojInstanci = 0;

            // prilikom stvaranja objekta ispisujemo koliko je trenutno objekata
            public SlušateljDogađaja()
            {
                Console.WriteLine("{0}", ++brojInstanci);
            }

            // prilikom uništavanja objekta ispisujemo koliko je trenutno objekata (s negativnim predznakom, da bude uočljivije)
            ~SlušateljDogađaja()
            {
                Console.WriteLine("-{0}", --brojInstanci);
            }

            // metoda kojom se predbilježujemo na događaj
            public void DogađajEventHandler(object sender, EventArgs a)
            {
            }

            // veliki član u klasi da bismo opteretili GC
            double[] niz = new double[10000];
        }


        static void Main(string[] args)
        {
            GeneratorDogadjaja gd = new GeneratorDogadjaja();

            for (int i = 0; i < 10000; ++i)
            {
                SlušateljDogađaja sd = new SlušateljDogađaja();

                gd.Događaj += sd.DogađajEventHandler;

                gd.Događaj -= sd.DogađajEventHandler;

            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
