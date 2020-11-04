using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.factory
{
    class KnifeFactory
    {
        public KnifeFactory()
        {
        }
        public Knife CreateKnife(string type)
        {
            Knife knife = null;
            if (type == "Meat")
            {
                knife = new MeatKnife();
            }
            if (type == "Bread")
            {
                knife = new BreadKnife();
            }

            knife.Sharpen();
            knife.Polish();
            knife.Package();
            return knife;
        }
    }
}
