using System;
using DesignPatterns.CreationalPatterns;

namespace DesignPatterns
{
    public class DesigPatterns
    {
        public static void Main(string[] args)
        {
            SingltonWork();
        }

        public static void SingltonWork()
        {
            //Ошибка из-за приватного конструктора
            //Singleton singleton = new Singleton();
            
            Singleton singleton = Singleton.Instance;
            Singleton newSingleton = Singleton.Instance;
            Console.WriteLine(singleton == newSingleton);
        }

    }
}