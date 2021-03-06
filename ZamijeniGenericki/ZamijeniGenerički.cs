﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        // Primjer kako prevoditelj automatski generira različite metode za različite tipove parametara
        static void ZamijeniGenerički<T>(T o1, T o2)
        {
            T temp = o2;
            o2 = o1;
            o1 = temp;
        }

        static void Main(string[] args)
        {
            // TODO: prevesti program i otvoriti i pogledati generirani kod s ILDASM alatom te međukod metode Main prekopirati u ZamijeniGenerički.txt
            // TODO: u datoteku odgovoriti: koliko se metoda iz metode Main poziva?

            int i1 = 5;
            int i2 = 10;
            ZamijeniGenerički(i1, i2);

            double d1 = 3.14;
            double d2 = 2.76;
            ZamijeniGenerički(d1, d2);

            ZamijeniGenerički("mirko", "slavko");

        }
    }
}
