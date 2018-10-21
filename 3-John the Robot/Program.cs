using System;

namespace _3_John_the_Robot
{
    class Program
    {
        private static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined
            Console.ReadKey();

        }

    }

  public  class Humanoid: ISkills
    {
        public Humanoid()
        {

        }
        private ISkills _Iskills;
      public  Humanoid(ISkills skills)
        {
            _Iskills = skills;
        }
        public string ShowSkill()
        {
            if(_Iskills!=null)
           return _Iskills.ShowSkill();
            else
                return "no skill is defined";

        }
    }

    class Dancing: ISkills
    {
        public string ShowSkill()
        {
            return "dancing";
           
        }
    }
    class Cooking: ISkills
    {
        public string ShowSkill()
        {
            return "cooking";

        }

    }

    public interface ISkills
    {
        string ShowSkill();
    }
}
