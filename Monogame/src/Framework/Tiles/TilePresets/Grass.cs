using Microsoft.Xna.Framework.Graphics;
using Monogame.src.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Tiles.TilePresets
{
    public class Grass : TileData
    { 
        public Grass()
        {
            atlas = Textures.GetTextures().GrassAtlas;

            type = "grass";
            startingShape = Textures.GetTextures().GrassGround1;

            toughness = 1;
            health = 1;
        }

    }

}
