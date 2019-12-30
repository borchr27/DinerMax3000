using System;
// Link to tutorial below:
// https://app.pluralsight.com/library/courses/becoming-dotnet-developer/table-of-contents
namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with butter.", 25);
            summerMenu.AddMenuItem("Tacos", "All Norwegians eat tacos on Fridays", 10);
            summerMenu.HospitalDirections = "Go right on 5th street and its just down a ways, ask for Dr. Gein";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Outside drinks are absolutely allowed, please remeber to code responsibly";
            outsideDrinks.AddMenuItem("Screwdriver", "Gets you turnt up real quick", 15);
            outsideDrinks.AddMenuItem("Cuban Virgin Libre","Always a good time, makes sure the boys have fun but not to much fun",10);

            Order HungryGuestOrder = new Order();

            for (int x = 0; x <= summerMenu.items.Count - 1; x++) 
            {
                MenuItem currentItem = summerMenu.items[x];
                HungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentitem in outsideDrinks.items) 
            {
                HungryGuestOrder.items.Add(currentitem);
            }
            try
            {
                outsideDrinks.AddMenuItem("Extra V", "Always a good time, makes sure the boys have fun but not to much fun", 0);
            }
            catch (Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }

            Console.WriteLine("The total is: " + "$" + HungryGuestOrder.Total);
        }
    }
}
