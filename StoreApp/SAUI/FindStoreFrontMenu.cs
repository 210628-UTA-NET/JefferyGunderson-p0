using System;
using SAModels;



namespace SAUI
{
    public class FindStoreFrontMenu : IMenu
    {
        StoreFrontMenu location = new StoreFrontMenu();
        public object[] storeFronts = { 3 };
        StoreFront store1 = new StoreFront("Furniture Outlet", "Macon, Georgia");
        StoreFront store2 = new StoreFront("Brady's Clothing Outlet", "Chattanooga , Tennesee");
        StoreFront store3 = new StoreFront("Louisville Distrbution", "Louisville, Kentucky");
        //Create StoreFront Object with Location Parameters based on what the user chooses
        public void Menu()
        {
            object[] storeFronts = { store1, store2, store3 };
            Console.WriteLine("Welcome to the Store Front Menu!");
            Console.WriteLine("Choose from the following or type the city of your shop!");
            Console.WriteLine(string.Format("[3] {0}\n[2] {1}\n[1] {2}", store1, store2, store3));
            Console.WriteLine("[0] Go Back");
        }

        public MenuType UserInput()
        {
            StoreFrontMenu location = new StoreFrontMenu();
            string userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "0":
                    return MenuType.MainMenu;
                case "3":
                    location.storeLocation(store1);
                    location._location = store1.Name;
                    return MenuType.StoreFrontMenu;
                case "2":
                    location.storeLocation(store2);
                    location._location = store2.Name;
                    return MenuType.StoreFrontMenu;
                case "1":
                    location.storeLocation(store3);
                    location._location = store3.Name;
                    return MenuType.StoreFrontMenu;
                default:
                    return MenuType.FindStoreFrontMenu;
            }
        }
    }
}