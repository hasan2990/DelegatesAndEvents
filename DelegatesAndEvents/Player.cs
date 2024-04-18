using System.Threading.Tasks;
using System;

internal class Player
{
    public int Points { get; set; }
    public delegate void AchievementsUnlockedHandler(int points);
    public event AchievementsUnlockedHandler AchievementsUnlocked;
    public async Task AddPoints(int points)
    {
        Points += points;
        Console.WriteLine($"Player earned {points}. Total Points: {Points}");
        await Task.Delay(1000);

        if (Points >= 100)
        {
            AchievementsUnlocked?.Invoke(Points);
        }
    }
}