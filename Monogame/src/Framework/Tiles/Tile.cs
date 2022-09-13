using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Monogame.src.Framework.Tiles;
using Monogame.src.Framework.Tiles.TilePresets;

namespace Monogame.src.Framework.Tiles
{
    public class Tile
    {
        public TileData data;
        public Rectangle shape;
        public Vector2 position;

        public Tile(TileData data, Vector2 position)
        {
            this.data = data;
            this.shape = data.startingShape;
            this.position = position;
        }

        public Tile GetTileAbove(TileMap map)
        {
            return TileMap.GetTileFromVec2(map, new Vector2(position.X, position.Y - 1));
        }

    }
}
