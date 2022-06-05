using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef1 = new Chef();
            chef1.MakeSpecialDish();

            ItalianChef chef2 = new ItalianChef();
            chef2.MakeSpecialDish();
            

            Console.ReadLine();
        }
    }
}
