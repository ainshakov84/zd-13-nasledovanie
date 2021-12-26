using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class MultiBuilding : Building
    {
        double floor;

        public MultiBuilding(string nameBuilding, double lengthBuilding, double widthBuilding, double heightBuilding, double floor)
                : base(nameBuilding, lengthBuilding, widthBuilding, heightBuilding)
        {
            this.floor = floor;
        }
        public string Print()
        {
             string result = base.Print();
            return result+= $"\n этажи здания {floor}";
        }
    }

}
