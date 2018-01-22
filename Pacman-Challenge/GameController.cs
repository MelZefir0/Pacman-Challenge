using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Pacman_Challenge
{
    //Represents the game board and steps taken

    public class GameController
    {
        private static Pacman pacman = new Pacman();
        private static Consumable consumable = new Consumable();

        public static void Start()
        {
            var kataPacmanSteps = File.ReadAllText("C:\\dev\\Pacman-Challenge\\KataPacman-seq.txt");
            var entities = new List<string>(kataPacmanSteps.Split(',').ToList());
            int points = 0;
            int ghostCount = 0;
            int newLives = 0;

            foreach (string entity in entities)
            {
                switch (entity)
                {
                    case "Dot":
                        points += consumable.Dot;
                        break;
                    case "Melon":
                        points += consumable.Melon;
                        break;
                    case "Galaxin":
                        points += consumable.Galaxian;
                        break;
                    case "Bell":
                        points += consumable.Bell;
                        break;
                    case "Cherry":
                        points += consumable.Cherry;
                        break;
                    case "Strawberry":
                        points += consumable.Strawberry;
                        break;
                    case "Orange":
                        points += consumable.Orange;
                        break;
                    case "Apple":
                        points += consumable.Apple;
                        break;
                    case "Key":
                        points += consumable.Key;
                        break;
                    case "InvincibleGhost":
                        pacman.Lives -= 1;
                        break;
                    case "VulnerableGhost":
                        ghostCount++;
                        if (ghostCount > 1)
                        {
                            AddGhostPoints();
                        }
                        points += consumable.VulnerableGhost;
                        break;
                }

            }

            int totalPoints = pacman.StartPoints += points;

            if (totalPoints >= 10000)
            {
                newLives = totalPoints/10000;
                pacman.Lives += newLives;
            }

            if (pacman.Lives <= 0)
            {
                Console.WriteLine($"Game ended with Pacman having {totalPoints} points but {pacman.Lives} lives. Game Over");
                Thread.Sleep(30000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"Game ended with Pacman having {totalPoints} points and {pacman.Lives} lives");
                Thread.Sleep(30000);
                Environment.Exit(0);
            }
        }

        private static void AddGhostPoints()
        {
            consumable.VulnerableGhost *= 2;
        }
    }
}
