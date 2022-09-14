using Monogame.src.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Tiles.TilePresets
{
    public class Air : TileData
    {
        public Air()
        {
            atlas = Textures.GetTextures().GrassAtlas;

            type = "air";
            startingShape = Textures.GetTextures().GrassGround1;


            toughness = 1;
            health = 1;
        }
    }
}
