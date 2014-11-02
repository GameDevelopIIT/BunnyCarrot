using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCarrot.Logic
{
    class GrassCell : ICell
    {
        /// <summary>
        /// Метод, возвращающий есть ли вход на клетку
        /// </summary>
        /// <returns></returns>
        public bool HasEnter()
        {
            return true;
        }

        /// <summary>
        /// Метод, возвращающий есть ли выход с клетки
        /// </summary>
        /// <returns></returns>
        public bool HasExit()
        {
            return true;
        }

        /// <summary>
        /// Массив с разрешенными входными направлениями
        /// </summary>
        public bool[] inputDirections { get; set; }

        /// <summary>
        /// Массив с разрешенными выходными направлениями с клетки
        /// </summary>
        public bool[] outputDirections { get; set; }

        /// <summary>
        /// Список с элементами которые могут быть на клетке (монета, ключ и т.д)  ??нужно ли
        /// </summary>
        public List<IItem> Items { get; set; }
    }
}
