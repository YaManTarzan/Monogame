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

namespace Monogame.src.Framework
{

    public class SceneManager
    {
        Application _app;
        ContentManager _content;
        Renderer _renderer;
        InputManager _inputManager;

        Texture2D _texture;

        public SceneManager(Application app)
        {
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

        }

        public void Initialize()
        {

        }

        public void LoadContent()
        {
            _renderer.spriteBatch = new SpriteBatch(_app.GraphicsDevice);
            _texture = _renderer.LoadT2D("ball");
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

            _renderer.spriteBatch.End();
        }
    }
}
