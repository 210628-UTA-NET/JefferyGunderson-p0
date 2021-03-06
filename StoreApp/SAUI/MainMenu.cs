using System;

namespace SAUI
{
    public class MainMenu : IMenu
    {

        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[3] Make an Order");
            Console.WriteLine("[2] Go to StoreFront Menu");
            Console.WriteLine("[1] Go to Customer Management Menu");
            Console.WriteLine("[0] Exit");

        }


        //initially called at the begining of the switch statement to navigate the main menu
        public MenuType UserInput()
        {
            //retrieves userinput for menu navigation and places it within the string "userInput"
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    //returns "Exit" to the main program which ends the looping while statement
                    return MenuType.Exit;
                case "1":
                    //returns MenuType.Customer menu to the switch statement within main which navigates to the Customer menu
                    return MenuType.CustomerMenu;
                case "2":
                    return MenuType.FindStoreFrontMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Please press ENTER to continue");
                    Console.ReadLine();
                    //Input was incorrect, remains in the main menu for further functionality
                    return MenuType.MainMenu;
            }

        }
    }
}
