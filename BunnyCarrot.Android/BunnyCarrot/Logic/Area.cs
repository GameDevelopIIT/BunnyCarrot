using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCarrot
{
    class Area
    {
        /// <summary>
        /// Клетки для поля
        /// </summary>
        public List<List<ICell>> cells { get; set; }


        public Area()
        {
            this.cells = new List<List<ICell>>();
        }
    }
}
