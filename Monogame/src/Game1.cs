using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame
{
    public class Game1 : Game
    {
        Texture2D ballTexture;
        public Ball ball;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public int WIDTH;
        public int HEIGHT;

        public Game1(int width = 1080, int height = 720)
        {
            WIDTH = width;
            HEIGHT = height;

            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferHeight = HEIGHT;
            _graphics.PreferredBackBufferWidth = WIDTH;
            
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Vector2 ballPosition = new Vector2(_graphics.PreferredBackBufferWidth / 2, _graphics.PreferredBackBufferHeight / 2);
            ballTexture = Content.Load<Texture2D>("ball");
            ball = new Ball(ballPosition, 1, 100f, _spriteBatch, ballTexture);
            ball.velX = 1f;
            ball.velY = 1f;
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            var kstate = Keyboard.GetState();

            if (ball.GetPos().X < 0 + ball.GetSize().X / 2)
                ball.velX *= -1f;
            if (ball.GetPos().X > WIDTH - ball.GetSize().X / 2)
                ball.velX *= -1f;
            if (ball.GetPos().Y < 0 + ball.GetSize().Y / 2)
                ball.velY *= -1;
            if (ball.GetPos().Y > HEIGHT - ball.GetSize().Y / 2)
                ball.velY *= -1;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            ball.Draw();
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}