using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCarrot
{
    interface IGame
    {
        /// <summary>
        /// Поле для игры
        /// </summary>
        Area field { get; set; }

        /// <summary>
        /// Игрок
        /// </summary>
        Player player { get; set; }
    }
}
