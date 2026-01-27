using LR2.Tasks;

namespace  LR2;
using Menus;

internal static class Program
{ 
    public static void Main() {
        var exit = false;

        while (!exit)
        {   
            Menu.ShowMainMenu();
            var choice = Menu.Choice;

            switch (choice)
            {
                case 0:
                    exit = true;
                    break;
                case 1:
                    Task1.ExecuteTask();
                    break;
            }
        }
    }
}