using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.factory
{
    class KnifeStore
    {
        private KnifeFactory knifeFactory;

        public KnifeStore()
        {
            knifeFactory = new KnifeFactory();
        }
        public KnifeStore(KnifeFactory knifeFactory)
        {
            this.knifeFactory = knifeFactory;
        }

        public Knife OrderKnife(string type)
        {
            return knifeFactory.CreateKnife(type);
        }
    }
}
