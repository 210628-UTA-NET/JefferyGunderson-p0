using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SADL.Entities;
namespace SAUI
{
    //This class abstracts what would be in the main and exports functionality to a "Factory".cs
    public class MenuFactory : IFactory
    {
        //Method is called within every case of the main switch, directing the user to the different interfaces
        public IMenu GetMenu(MenuType p_menu)
        {
            //get the configuration from our appsetting.json file
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DatabaseReference");

            DbContextOptions<GundContext> options = new DbContextOptionsBuilder<GundContext>()
                .UseSqlServer(connectionString)
                .Options;

            switch (p_menu)
            {
                case MenuType.MainMenu:
                    //brings users to the main menu -- instantiates that object
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    //brings users to the customer menu -- instantiates that object
                    return new CustomerMenu();
              
                case MenuType.StoreFrontInventoryMenu:
                    return new StoreFrontInventoryMenu();
                case MenuType.FindStoreFrontMenu:
                    return new FindStoreFrontMenu();
                
                default:
                    return null;
            }
        }
    }
}