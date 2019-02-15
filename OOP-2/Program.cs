using System;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Yazici yazici = new Yazici();
            yazici.Yazdir(5);
            yazici.Yazdir("Hello");
            
            Console.ReadKey();
        }
    }
}
