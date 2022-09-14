using Microsoft.Xna.Framework;
using Monogame.src.Framework.Tiles.TilePresets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Tiles
{
    public static class WorldGeneration
    {
        public static void AssignRandomValues(TileMap map)
        {
            Random rnd = new Random();
            for (int x = 0; x < map.cols; x++)
            {
                for (int y = 0; y < map.rows; y++)
                {
                    int randomNumber = rnd.Next(0, 2);
                    if (randomNumber == 0)
                    {
                        map.TileArray[x, y] = new Tile(new Dirt(), new Vector2(x, y));
                    }
                    else
                    {
                        map.TileArray[x, y] = new Tile(new Air(), new Vector2(x, y));
                    }
                }
            }

        }
    }
}
