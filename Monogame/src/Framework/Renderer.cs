using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Monogame.src.Framework.Tile;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework
{ 

    public class Renderer
    {
        public Application app;
        public GraphicsDeviceManager graphicsDevice;
        public SpriteBatch spriteBatch;
        public ContentManager content;

        public Texture2D LoadT2D(string path)
        {
            return content.Load<Texture2D>(path);
        }

        public void DrawTilemap(TileMap map)
        {
            
        }

        public void DrawT2D(Texture2D texture, Vector2 pos, Color color)
        {
            spriteBatch.Draw(texture, pos, color);
        }

    }
}
