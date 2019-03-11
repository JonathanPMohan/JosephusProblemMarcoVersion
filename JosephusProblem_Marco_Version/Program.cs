using System;
using System.Collections.Generic;

namespace JosephusProblem_Marco_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of people");
            var numberOfPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter killing interval");
            var killingInterval = Convert.ToInt32(Console.ReadLine());

            List<int> People = new List<int>(CreatePeople(numberOfPeople));

            //LastPersonStanding(People, killingInterval);
            var whoAmiI = FindJosephusPosition(numberOfPeople, killingInterval);

            Console.WriteLine($"I am the Winner {whoAmiI}");
            Console.ReadLine();
        }

        static int FindJosephusPosition(int numberOfPeople, int killingInterval)
        {
            if (numberOfPeople == 1)
                return 1;
            else
                return (FindJosephusPosition(numberOfPeople - 1, killingInterval) + killingInterval - 1) % numberOfPeople + 1;
        }

        public static List<int> CreatePeople(int numberOfPeople)
        {
            List<int> tempList = new List<int>();
            for (int i = 1; i <= numberOfPeople; i++)
            {
                tempList.Add(i);
            }
            return tempList;
        }
    }
}