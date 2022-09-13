using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Monogame.src.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Tiles.TilePresets
{
    public class TileData
    {
        public string type;
        public Rectangle startingShape;

        public Texture2D atlas;

        public int toughness;
        public int health;
    }
}
