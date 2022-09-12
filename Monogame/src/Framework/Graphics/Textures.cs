using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Graphics
{
    public class Textures
    {

        public Texture2D GrassAtlas;
        public Rectangle GrassGround1;

        private Renderer _renderer;

        private static bool isCreated = false;
        private static Textures textures;

        private Textures(Renderer renderer)
        {
            _renderer = renderer;
        }

        public bool LoadTextures()
        {
            GrassAtlas = _renderer.LoadT2D("Textures/grass_tiles");
            GrassGround1 = GetPieceOfAtlas(18, 0, 16, 16);


            return true;
        }

        public static Textures CreateTextures(Renderer renderer)
        {
            if (isCreated)
            {
                Debug.WriteLine("TEXTURES ALREADY BEEN CREATED. ONLY CREATE ONCE: Textures.cs");
            }
            else
            {
                isCreated = true;
                textures = new Textures(renderer);
                return textures;
            }
            return new Textures(renderer);
        }

        public static Textures GetTextures()
        {
            return textures;
        }

        private Rectangle GetPieceOfAtlas(Vector2 location, Vector2 size)
        {
            return new Rectangle((int)location.X, (int)location.Y, (int)size.X, (int)size.Y);
        }
        private Rectangle GetPieceOfAtlas(int x, int y, int w, int h)
        {
            return new Rectangle(x, y, w, h);
        }

    }
}
