using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Monogame.src.Framework
{
    public class InputManager
    {
        KeyboardState state;

        public InputManager()
        {
            state = Keyboard.GetState();
        }

        public Boolean IsKeyDown(Keys key)
        {
            state = Keyboard.GetState();
            return state.IsKeyDown(key);
        }

        public void BindCallBack(Keys key, Action callback)
        {
            if (IsKeyDown(key))
                callback();
              
        }

    }
}
