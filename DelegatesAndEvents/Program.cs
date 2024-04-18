using System;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class Program
    {
        static async Task Main(string[] args) 
        {
            Player player = new Player();
            var party = new Party();

            player.AchievementsUnlocked += OnAchievementsUnlocked;
            player.AchievementsUnlocked += party.Cheering;

            await player.AddPoints(30);
            await player.AddPoints(40);
            await player.AddPoints(35);
            Console.ReadKey();

        }

        static void OnAchievementsUnlocked(int points)
        {
            Console.WriteLine($"Congratulations! Achievement unlocked for earning {points} points");
        }
    }
}
