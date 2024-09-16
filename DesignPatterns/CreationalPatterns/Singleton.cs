using System;

namespace DesignPatterns.CreationalPatterns
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void ConnectToDb()
        {
            Console.WriteLine($"Подключение к базе данных из объекта {instance}");
        }
    }
}
