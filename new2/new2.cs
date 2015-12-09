using System;

namespace CSharp.Metode
{
    // Primjer korištenja modifikatora new 

    class Bazna
    {
        public virtual void PredstaviSe()
        {
            Console.WriteLine("Bazna klasa");
        }
    }

    class Izvedena : Bazna
    {
        public override void PredstaviSe()
        {
            Console.Write("Izvedena klasa, izvedena iz: ");
            base.PredstaviSe();
            IspišiMiČlanove();
        }

        protected virtual void IspišiMiČlanove()
        {
            Console.WriteLine("Izvedena.IspišiMiČlanove");
        }
    }

    class NajIzvedena : Izvedena
    {
        public override void PredstaviSe()
        {
            Console.Write("Još izvedenija klasa, izvedena iz: ");
            base.PredstaviSe();
        }

        //  Dodati metodu IspišiMiČlanove koja će ispisati "NajIzvedena.IspišiMiČlanove"
        public new void IspišiMiČlanove() {
            Console.WriteLine("NajIzvedena.IspišiMIČlanove");
        }
    }

    class new2
    {
        static void Main(string[] args)
        {
            //  Izvesti program, prekopirati ispis u datoteku new2.txt te dopisati obrazloženje rezultata
            Bazna[] niz = new Bazna[] { new Bazna(), new Izvedena(), new NajIzvedena() };

            foreach (Bazna b in niz)
            {
                b.PredstaviSe();
                Console.WriteLine();
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
