using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame
{ 
    public class Ball : Game
    {
        private Texture2D ballTexture;
        private double _scale;
        private SpriteBatch _spriteBatch;

        Vector2 ballPosition;
        float ballSpeed;
        public float velX;
        public float velY;

        public Ball(Vector2 position, double scale, float speed, SpriteBatch batch, Texture2D texture)
        {
            ballPosition = position;
            _scale = scale;
            ballSpeed = speed;
            _spriteBatch = batch;

            ballTexture = texture;

            velX = 0;
            velY = 0;
        }

        public void Draw()
        {
            this.Update();

            _spriteBatch.Draw(
                ballTexture,
                ballPosition,
                null,
                Color.White,
                0f,
                new Vector2(ballTexture.Width / 2, ballTexture.Height / 2),
                Vector2.One,
                SpriteEffects.None,
                0f);
        }

        private void Update()
        {
            ballPosition.X += velX * ballSpeed;
            ballPosition.Y += velY * ballSpeed;
        }

        public Vector2 GetPos()
        {
            return ballPosition;
        }
        
        public void SetSpeed(float speed)
        {
            ballSpeed = speed;
        }

        public Vector2 GetSize()
        {
            return new Vector2(ballTexture.Width, ballTexture.Height);
        }
    }
}
