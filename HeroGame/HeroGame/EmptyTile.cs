using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    internal class EmptyTile : Tile
    {
        int xPosition;
        int yPosition;

        public EmptyTile(int xPosition, int yPosition) // constructor
        {

            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }
    }
}
