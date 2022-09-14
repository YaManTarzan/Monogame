using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monogame.src.Framework.Math
{
    static class Perlin
    {
        public static float Fade(float t)
        {
            return t * t * t * (t * (t * 6.0f - 15.0f) + 10.0f);
        }

        public static float Grad(float p)
        {
            const float texture_width = 256.0f;

            return p;
        }
    }
}
