using System;

namespace OOP_1
{
    class Program
    {
        enum CanliTip
        {
            insan,hayvan
        }
        enum Hareket
        {
            Havla,KuyrukSalla,PatiUzat
        }
        static void Main(string[] args)
        {
            Konus(CanliTip.insan, "Ben bir insanım..");
            Konus(CanliTip.hayvan, Hareket.PatiUzat);
            Konus("Hav");
            Console.ReadKey();
        }
        static void Konus(CanliTip e,string ifade)
        {
            Console.WriteLine("{0} der ki : '{1}'", e, ifade);
        }
        static void Konus(string ifade)
        {
            Console.WriteLine(ifade);
        }
        static void Konus(CanliTip e,Hareket f)
        {
            Console.WriteLine("{0} şunu yaptı : '{1}'", e, f);
        }
    }
}
