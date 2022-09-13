using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework.Graphics
{
    public class BackGround
    {
        Texture2D bgTexture;
        Vector2 pos;

        public BackGround(Texture2D background, Vector2 pos)
        {
            bgTexture = background;
            this.pos = pos;
        }

        public void Draw(Renderer renderer)
        {
            renderer.DrawT2D(bgTexture, pos, Color.White);
        }

    }
}
