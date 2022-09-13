using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame.src.Framework;

namespace Monogame
{
    public class Application : Game
    {
        SceneManager sceneManager;

        public Application(int width = 1072, int height = 720)
        {
            sceneManager = new SceneManager(this);

            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            sceneManager.Initialize();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            sceneManager.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            sceneManager.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            sceneManager.Draw();

            base.Draw(gameTime);
        }
    }
}