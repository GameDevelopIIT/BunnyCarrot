using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCarrot
{
    interface ICell
    {
        /// <summary>
        /// Метод, возвращающий есть ли вход на клетку
        /// </summary>
        /// <returns></returns>
        bool HasEnter();

        /// <summary>
        /// Метод, возвращающий есть ли выход с клетки
        /// </summary>
        /// <returns></returns>
        bool HasExit();

        /// <summary>
        /// Массив с разрешенными входными направлениями
        /// </summary>
        bool[] inputDirections { get; set; }

        /// <summary>
        /// Массив с разрешенными выходными направлениями с клетки
        /// </summary>
        bool[] outputDirections { get; set; }

        /// <summary>
        /// Список с элементами которые могут быть на клетке (монета, ключ и т.д)  ??нужно ли
        /// </summary>
        List<IItem> Items { get; set; }
    }
}
