using System;
// Link to tutorial below:
// https://app.pluralsight.com/library/courses/becoming-dotnet-developer/table-of-contents
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
