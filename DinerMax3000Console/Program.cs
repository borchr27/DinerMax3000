using System;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu summerMenu = new Menu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with butter.", 25.50);
            summerMenu.AddMenuItem("Tacos", "All Norwegians eat tacos on Fridays", 10);
            
        }
    }
}
