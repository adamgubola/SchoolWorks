﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffaloHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(12, 5);
            game.run();

        }
    }
}
