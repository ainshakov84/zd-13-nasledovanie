using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Building
    {
        string nameBuilding;
        double lengthBuilding;
        double widthBuilding;
        double heightBuilding;

        public Building(string nameBuilding, double lengthBuilding, double widthBuilding, double heightBuilding)
        {
            this.nameBuilding = nameBuilding;
            this.lengthBuilding = lengthBuilding;
            this.widthBuilding = widthBuilding;
            this.heightBuilding = heightBuilding;

        }
        public string Print()
        {
            return $" название здания {nameBuilding} \n длина здания {lengthBuilding} \n высота здания {widthBuilding} \n ширина здания {heightBuilding}";
        }
    }
}
