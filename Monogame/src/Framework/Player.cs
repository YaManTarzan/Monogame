using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame.src.Framework
{
    public enum MovementStatus
    {
        RUNNING,
        STOPPED,
        WALKING,
        JUMPING,
        SWIMMING,
        UNDERWATER,
        FALLING,
        FLYING,
    }

    public class Player
    {

        private float _health;
        private float _speed;
        private float _armor;

        public Vector2 _position;

        public Player(Vector2 position, float armor = 0, float speed = 20, float health = 100)
        {
            _health = health;
            _armor = armor;
            _speed = speed;
            _position = position;
        }

        public void Jump()
        {

        }
           
        // Returns false if the player died from the damage
        public bool TakeDamage(int amount)
        {


            return false;
        }
    }
}
