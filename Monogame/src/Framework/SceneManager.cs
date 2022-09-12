using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogame;
using Monogame.src.Framework.Graphics;
using Monogame.src.Framework.Input;

namespace Monogame.src.Framework
{

    public class SceneManager
    {
        Application _app;
        ContentManager _content;

        Renderer _renderer;
        InputManager _inputManager;
        Textures _textures;

        public SceneManager(Application app)
        {
            // Initializing members
            _app = app;
            _inputManager = new InputManager();

            _content = _app.Content;
            _content.RootDirectory = "Content";

            _renderer = new Renderer
            {
                app = _app,
                graphicsDevice = new GraphicsDeviceManager(_app),
                content = _content,
            };
            _textures = Textures.CreateTextures(_renderer);
        }

        public void Initialize()
        {
        
        }

        public void LoadContent()
        {
            _renderer.spriteBatch = new SpriteBatch(_app.GraphicsDevice);

            // Texture loading
            _textures.LoadTextures();
        }

        public void Update()
        {

        }

        public void Draw()
        {
            // Clear buffer color
            _app.GraphicsDevice.Clear(new Color(77, 137, 99));

            _renderer.spriteBatch.Begin();

            // Rendering here
            for (int i = 0; i < _renderer.graphicsDevice.PreferredBackBufferWidth; i += 16)
            {
                _renderer.DrawT2D(_textures.GrassAtlas, new Rectangle(i, 400, 16, 16), _textures.GrassGround1, Color.White, i, new Vector2(_textures.GrassGround1.Width / 2, _textures.GrassGround1.Height / 2), SpriteEffects.None, 0f);

            }
            
            _renderer.spriteBatch.End();
        }
    }
}
