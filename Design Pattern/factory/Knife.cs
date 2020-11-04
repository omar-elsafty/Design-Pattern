using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.factory
{
    class Knife
    {
        public Knife()
        {
        }

        public void Polish()
        {
            Console.WriteLine( "Knife is polished");
        }
        public void Sharpen()
        {
            Console.WriteLine("Knife is sharben");
        }
        public void Package()
        {
            Console.WriteLine("Knife is packeged");
        }
    }
}
