using Microsoft.Xna.Framework;
using Monogame.src.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Tiles.TilePresets
{
    public class Dirt : TileData
    {
        public Dirt()
        {
            atlas = Textures.GetTextures().DirtAtlas;

            type = "dirt";
            Rectangle[] defaultShapes = {
            Textures.GetTextures().DirtBlock1,
            Textures.GetTextures().DirtBlock2,
            Textures.GetTextures().DirtBlock3,
            };

            Random rnd = new Random();
            int index = rnd.Next(defaultShapes.Length);
            startingShape = defaultShapes[index];

            toughness = 1;
            health = 1;
        }
    }
}
