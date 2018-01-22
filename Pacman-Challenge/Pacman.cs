using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Challenge
{
    public class Pacman
    {
        public int StartPoints { get; set; }
        public int Lives { get; set; }

        public Pacman()
        {
            StartPoints = 5000;
            Lives = 3;
        }
    }
}
