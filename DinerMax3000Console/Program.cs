using System;
using DinerMax3000.Business;
// Link to tutorial below:
// https://app.pluralsight.com/library/courses/becoming-dotnet-developer/table-of-contents
namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> menusFromDatabase = Menu.GetAllMenus();

            Order HungryGuestOrder = new Order();

            foreach(Menu currentMenu in menusFromDatabase)
            {
                foreach (MenuItem currentitem in currentMenu.items)
                {
                    HungryGuestOrder.items.Add(currentitem);
                }
            }
            Console.WriteLine("The total is: " + "$" + HungryGuestOrder.Total);
        }
    }
}
