using System;

namespace Vsite.CSharp
{
    // Primjer korištenja modifikatora new 

    //  Prekopirati definicije klasa Bazna, Izvedena i NajIzvedena iz projekta new2. 
    //  U klasu Bazna dodati virtualnu metodu void IspišiMiČlanove() te provjeriti što javlja prevoditelj
    //  Dodati modifikator new u definiciji metode Izvedena.IspišiMiČlanove

    class Bazna
    {
        public virtual void PredstaviSe()
        {
            Console.WriteLine("Bazna klasa");
        }
        public virtual void IspišiMiČlanove() 
        {
            Console.WriteLine("IspišiMiČlanove Bazna klasa");
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

        protected  new void IspišiMiČlanove()
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
        public new void IspišiMiČlanove()
        {
            Console.WriteLine("NajIzvedena.IspišiMIČlanove");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //  Pokrenuti program, prekopirati ispis u datoteku new3.txt te dopisati obrazloženje

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
