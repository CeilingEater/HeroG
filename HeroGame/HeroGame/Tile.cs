﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{

    //hello test 3
    internal abstract class Tile
    {
        private int xPosition;
        private int yPosition;
        private char Display;

        public int XPosition
        {
            get { return xPosition; }
        }

        public int YPosition
        {
            get { return yPosition; }
        }

        public Tile(int xPosition, int yPosition) // constructor
        {

            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }
        public char display
        {
            get { return Display; }
        }
    }
}
