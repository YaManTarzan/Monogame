using Microsoft.Xna.Framework;
using Monogame.src.Framework.Tiles.TilePresets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Tiles
{
    public class TileMap
    {
        public int rows;
        public int cols;
        public int cWidth;
        public int cHeight;

        public Tile[,] TileArray;

        public TileMap(int width, int height, int c, int r)
        {
            rows = r;
            cols = c;
            cWidth = width;
            cHeight = height;
        }

        public void FillMap(TileMap map)
        {

        }

        public static Tile GetTileFromVec2(TileMap map, Vector2 pos)
        {
            return map.TileArray[(int)pos.X, (int)pos.Y];
        }
    }
}
