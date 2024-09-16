using System;
using DesignPatterns.CreationalPatterns;

namespace DesignPatterns
{
    public class DesigPatterns
    {
        public static void Main(string[] args)
        {
            SingltonWork();
            MonostateWork();

            Console.WriteLine();

            FactoryMethodWork();
        }

        public static void SingltonWork()
        {
            //Падение ошибки из-за приватного конструктора
            //Singleton singleton = new Singleton();

            Singleton singleton = Singleton.Instance;
            Singleton newSingleton = Singleton.Instance;
            Console.WriteLine(singleton == newSingleton);
        }

        public static void MonostateWork()
        {
            Monostate monostate = new Monostate();
            Monostate newMonostate = new Monostate();

            monostate.SetValue("state", "Monostate");

            Console.WriteLine(newMonostate.GetValue("state") == monostate.GetValue("state"));

        }

        public static void FactoryMethodWork()
        {
            Factory civilRobotFactory = new CivilRobotFactory();
            Robot civilRobot = civilRobotFactory.CreateRobot("Valera");

            Factory militaryRobotFactory = new MilitaryRobotFactory();
            Robot militaryRobot = militaryRobotFactory.CreateRobot("T-1000");

            civilRobot.IntroduceYourself();
            militaryRobot.IntroduceYourself();
        }

    }
}