using System;
using Design_Pattern.factory;


namespace Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region singletone
            //SingleTone instance1 = SingleTone.GetInstance();

            //SingleTone instance2 = SingleTone.GetInstance();

            //Console.WriteLine(instance1.GetHashCode());
            //Console.WriteLine(instance2.GetHashCode());
            //Console.ReadLine();
            #endregion


            #region
            Knife knife = Knife.OrederKnife("Meat");
            Console.ReadLine();
            #endregion


        }
    }
}
