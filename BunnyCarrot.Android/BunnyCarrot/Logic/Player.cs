using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCarrot
{
    class Player
    {
        /// <summary>
        /// Позиция игрока на поле
        /// </summary>
        public Vector2 position { get; set; }

        /// <summary>
        /// Монеты игрока
        /// </summary>
        public float money { get; set; }


        public Player()
        {
            this.money = 100f;
            this.position = new Vector2();
        }
    }
}
