using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Ведите название здания");
            string nameBuilding = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ведите длину здания");
            double lengthBuilding= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите ширину здания");
            double widthBuilding= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите высоту здания");
            double heightBuilding= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите этажность здания");
            double floor = Convert.ToDouble(Console.ReadLine());
            Building building = new Building(nameBuilding, lengthBuilding, widthBuilding, heightBuilding);
            MultiBuilding multiBuilding = new MultiBuilding(nameBuilding, lengthBuilding, widthBuilding, heightBuilding, floor);
            Console.WriteLine(building.Print());
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
