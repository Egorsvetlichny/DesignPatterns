using System;

namespace DesignPatterns.CreationalPatterns
{
    public abstract class Robot
    {
        public string Name { get; set; }

        public abstract void IntroduceYourself();
    }

    public class CivilRobot : Robot
    {
        public CivilRobot(string name) => Name = name;

        public override void IntroduceYourself()
        {
            Console.WriteLine($"I am just a new civil robot - {Name}!");
        }
    }

    public class MilitaryRobot : Robot
    {
        public MilitaryRobot(string name) => Name = name;

        public override void IntroduceYourself()
        {
            Console.WriteLine($"I am a military robot - {Name}!");
        }
    }

    public abstract class Factory
    {
        public abstract Robot CreateRobot(string name);
    }

    public class CivilRobotFactory : Factory
    {
        public override Robot CreateRobot(string name)
        {
            return new CivilRobot(name);
        }
    }

    public class MilitaryRobotFactory : Factory
    {
        public override Robot CreateRobot(string name)
        {
            return new MilitaryRobot(name);
        }
    }
}
