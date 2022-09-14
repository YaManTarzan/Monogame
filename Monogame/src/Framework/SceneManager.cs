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
using Monogame.src.Framework.Tiles;
using System.Transactions;

namespace Monogame.src.Framework
{

    public class SceneManager
    {
        Application _app;
        ContentManager _content;

        Renderer _renderer;
        InputManager _inputManager;
        Textures _textures;

        TileMap testing;
        BackGround bg;

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
            app.Window.AllowUserResizing = true;
            _renderer.graphicsDevice.PreferredBackBufferWidth = 1072;

            _textures = Textures.CreateTextures(_renderer);
        }

        public void Initialize()
        {
            testing = new TileMap(16, 16, 100, 100);
        }

        public void LoadContent()
        {
            _renderer.spriteBatch = new SpriteBatch(_app.GraphicsDevice);

            // Texture loading
            _textures.LoadTextures();

            bg = new BackGround(_textures.defaultbg, new Vector2(0, 0));
            WorldGeneration.AssignRandomValues(testing);
        }

        public void Update()
        {

        }

        public void Draw()
        {
            // Clear buffer color
            _app.GraphicsDevice.Clear(new Color(135, 206, 235));

            _renderer.spriteBatch.Begin();

            // Rendering here
            _renderer.DrawTilemap(testing);
            //bg.Draw(_renderer);

            _renderer.spriteBatch.End();
        }
    }
}
