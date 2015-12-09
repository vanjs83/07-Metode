using System;

namespace Vsite.CSharp
{
    // Primjer metoda s promjenjivim brojem argumenata

    class Params
    {
        static void Main(string[] args)
        {
            double zbroj = Zbroji(1, 2, 3, 4);
            Console.WriteLine(zbroj);

            Console.ReadKey();
        }

        // TODO: Napisati implementaciju metode tako da vrati zbroj svih proslijeđenih argumenata
        public static double Zbroji(params double[] pribrojnici)
        {
            double zbroj=0;
            for (int i = 0; i < pribrojnici.Length; i++) {
                zbroj += pribrojnici[i];
            }
            return zbroj;
        }
    }
}
