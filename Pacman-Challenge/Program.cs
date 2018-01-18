using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Challenge
{
    class Program
    {
        private static Pacman pacman = new Pacman();
        static void Main(string[] args)
        {
            // __1 pacman,
            //__starting at 5000 points, 
            //__3 lives
            //4 ghosts
            //each dot eaten +10points
            //if ghost chomps pacman -1 life
            //if all lives lost, terminate game
            //4 power pellets in each corner of room
            //power pellet temporarily disables ghost chomp function and allows pacman to chomp ghost, -1 ghost, earns 200 points times 2 with each additional ghost
            //(
            //1 = +200
            //2 = +400
            //3 = +800
            //4 = +1600
            //)
            //extra points given per fruit eaten
            //if points = 10000, +1 life for pacman
            //console.writeLine(totalPoints);

            //__read from text file
            //__iterate over data
            //switch scenarios to handle points systems

            var kataPacmanSteps = File.ReadLines("C:\\dev\\Pacman-Challenge\\KataPacman-seq.txt");
            var totalPoints = 5000;

            foreach (string line in kataPacmanSteps)
            {
                line.Split(",".ToCharArray());

                switch(line)
                {
                    case "Dot":
                        totalPoints += 10;
                        break;
                    case "InvincibleGhost":
                        //if ()
                        //{

                        //}
                        break;
                    case "Melon":
                        totalPoints += 1000;
                        break;
                    case "Galaxin":
                        totalPoints += 2000;
                        break;
                    case "VulnerableGhost":
                        //if ()
                        //{

                        //}
                        break;
                    case "Bell":
                        totalPoints += 3000;
                        break;
                    case "Cherry":
                        totalPoints += 100;
                        break;
                    case "Strawberry":
                        totalPoints += 300;
                        break;
                    case "Orange":
                        totalPoints += 500;
                        break;
                    case "Apple":
                        totalPoints += 700;
                        break;
                    case "Key":
                        totalPoints += 5000;
                        break;
                }
                Console.WriteLine(line);
                Console.WriteLine(totalPoints);
                Console.ReadLine();
            }
        }
    }
}
