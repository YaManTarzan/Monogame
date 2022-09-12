using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Tile
{
    public class TileMap
    {
        public int rows;
        public int cols;
        public int cWidth;
        public int cHeight;

        public TileMap(int width, int height, int r, int c)
        {
            rows = r;
            cols = c;
            cWidth = width;
            cHeight = height;
        }

    }
}
