using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Monogame.src.Framework.Tiles;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Graphics
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
            for (int c = 0; c < map.cols; c++)
            {
                for (int r = 0; r < map.rows; r++)
                {
                    Tile tile = map.TileArray[c, r];
                    if (tile.data.type != "air")
                    {
                        DrawT2D(
                            tile.data.atlas,
                            new Rectangle(c * map.cWidth, r * map.cHeight, map.cWidth, map.cHeight),
                            tile.shape,
                            Color.White,
                            0f,
                            new Vector2(map.cWidth / 2, map.cHeight / 2),
                            SpriteEffects.None,
                            0f
                             );
                    }
                }
            }

        }

        public void DrawT2D(Texture2D texture, Vector2 pos, Color color)
        {
            spriteBatch.Draw(texture, pos, color);
        }
        public void DrawT2D(
            Texture2D texture,
            Rectangle pos,
            Rectangle? atlasPos,
            Color color,
            float rotation,
            Vector2 origin,
            SpriteEffects effects,
            float layerDepth)
        {
            spriteBatch.Draw(texture, pos, atlasPos, color, rotation, origin, effects, layerDepth);
        }

    }
}
