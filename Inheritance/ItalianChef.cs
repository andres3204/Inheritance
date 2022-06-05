using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine(" The Chef makes a special Italian dish.");
        }
        public void MakeItalianDish()
        {
            Console.WriteLine(" The Italian Chef makes Pizza.");

        }
    }
}
