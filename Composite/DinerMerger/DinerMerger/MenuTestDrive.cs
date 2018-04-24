using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class MenuTestDrive
    {
        //public static void TestCompositeIterator(MenuComponent menuComponent)
        //{
        //    CompositeEnumerator enumerator = new CompositeEnumerator(menuComponent.CreateEnumerator());
        //    while (enumerator.MoveNext())
        //    {
        //        MenuComponent component = enumerator.Current;
        //        component.Print();
        //    }
        //}

        static void Main(string[] args)
        {
            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            MenuComponent pancakeHouseMenu =
                new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu =
                new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu =
                new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu =
                new Menu("DESSERT MENU", "Dessert of course!");

            //PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            //DinerMenu dinerMenu = new DinerMenu();
            //CafeMenu cafeMenu = new CafeMenu();

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            

            pancakeHouseMenu.Add(new MenuItem("K&B Pancake breakfast", "pancakes with scrambled eggs, and toast", true, 2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake breakfast", "pancakes with fried eggs, sausage", false, 2.99));

            dinerMenu.Add(new MenuItem("Veggie burguer and air fries", "Veggie burguer on a whole wheat bun, lettuce, tomato and fries", true, 3.99));
            dinerMenu.Add(new MenuItem("Soup of the day", "Soup of the day with a side salad", false, 3.69));
            
            dessertMenu.Add(new MenuItem("Apple pie", "Apple pie with a flakey crust, topped with vanilla ice cream", true, 1.59));
            dinerMenu.Add(dessertMenu);

            cafeMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));
            cafeMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
            waitress.PrintVegetarianMenu();

            Console.ReadKey();
        }
    }
}
