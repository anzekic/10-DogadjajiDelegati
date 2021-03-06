﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class SlušateljAlarma
    {
        // ovo je callback metoda koju će pozvati odašiljatelj
        public void AlarmNotifikacija(object posiljatelj, GeneratorAlarma.AlarmEventArgs e)
        {
            Console.WriteLine(
              "Slušatelj je dobio alarm!\nKada: {0}\nGdje: {1}\nOzbiljnost: {2}, Opis: {3}\n",
              e.Vrijeme, e.Mjesto, e.Razina, e.Opis
            );
        }
    }
}
