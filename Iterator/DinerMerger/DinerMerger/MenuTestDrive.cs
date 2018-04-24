using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class MenuTestDrive
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            CafeMenu cafeMenu = new CafeMenu();

            Waitress waitress = new Waitress(new List<IMenu>
                                                { pancakeHouseMenu, dinerMenu, cafeMenu });
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
