using System;

namespace Module3Demo
{
    public class Panda
    {
        public string Name { get; }
        public int Age { get; }

        public Panda(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");
        }

        public class PandaStats
        {
            public int BambooPerDay { get; }
            public double HoursOfSleep { get; }

            public PandaStats(int bambooPerDay, double hoursOfSleep)
            {
                BambooPerDay = bambooPerDay;
                HoursOfSleep = hoursOfSleep;
            }

            public void PrintStats(Panda panda)
            {
                Console.WriteLine(
                    $"{panda.Name} eats about {BambooPerDay} bamboo shoots per day " +
                    $"and sleeps around {HoursOfSleep} hours.");
            }
        }
    }

    
    public class Program
    {
        public static void Main()
        {
            
            Panda po = new Panda("Po", 5);

            
            po.Eat("bamboo");

            
            Panda.PandaStats stats = new Panda.PandaStats(bambooPerDay: 30, hoursOfSleep: 12.5);

            
            stats.PrintStats(po);

            Console.WriteLine("Demo complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}