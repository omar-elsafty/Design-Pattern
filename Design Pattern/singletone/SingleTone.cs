using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{
    class SingleTone
    {
        private static SingleTone instance = null;
        private SingleTone()
        {

        }

        public static SingleTone GetInstance()
        {
            if (instance == null)
            {
                instance = new SingleTone();
            }
            return instance;
        }
    }
}
