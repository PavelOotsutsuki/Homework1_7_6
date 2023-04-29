using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;

namespace Homework1_7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string tanksArmament = "Танки";
            string armoredPersonnelCarrierArmament = "Бронетранспортер";
            string lieutenantRank = "Лейтенант";
            string ensignRank = "Прапорщик";
            string sergeantRank = "Сержант";

            List<Soldier> soldiers = new List<Soldier>
            {
                new Soldier("Иванов Иван Иванович", armoredPersonnelCarrierArmament, sergeantRank, 20),
                new Soldier("Сидоров Сидр Сидорович", armoredPersonnelCarrierArmament, sergeantRank, 16),
                new Soldier("Петров Петр Петрович", tanksArmament, ensignRank, 30),
                new Soldier("Павлов Павел Павлович", tanksArmament, lieutenantRank, 96),
                new Soldier("Матвеев Тимофей Матвеевич", tanksArmament, ensignRank, 42)
            };

            var newSoldiers = from Soldier soldier in soldiers
                              select new
                              {
                                  Name = soldier.Name,
                                  Rank = soldier.Rank
                              };

            foreach (var soldier in newSoldiers)
            {
                Console.WriteLine($"Имя: {soldier.Name}, звание: {soldier.Rank}");
            }
        }
    }

    class Soldier
    {
        public Soldier (string name, string armanent, string rank, int termOfServiceMonth)
        {
            Name = name;
            Armament = armanent;
            Rank = rank;
            TermOfServiceMonth = termOfServiceMonth;
        }

        public string Name { get; private set; }
        public string Armament { get; private set; }
        public string Rank { get; private set; }
        public int TermOfServiceMonth { get; private set; }
    }
}