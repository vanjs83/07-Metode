using System;

namespace Vsite.CSharp
{
    // Primjer korištenja modifikatora new kada u baznoj

    class Bazna
    {
        public void PredstaviSe()
        {
            Console.WriteLine("Bazna klasa");
        }
    }
    class Izvedena : Bazna
    {
        //  Dodajte modifikator new metodi
        public new void  PredstaviSe()
        {
            Console.Write("Izvedena klasa, izvedena iz: ");
            base.PredstaviSe();
        }
    }

    class new1
    {
        static void Main(string[] args)
        {
            //  Izvesti program, ispis preslikati u datoteku new1.txt te dodati obrazloženje
            Bazna[] niz = new Bazna[] { new Bazna(), new Izvedena() };

            foreach (Bazna b in niz)
                b.PredstaviSe();

            Console.WriteLine();


            Izvedena i = new Izvedena();
            i.PredstaviSe();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
