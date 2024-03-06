using System;
using System.Collections.Generic;
namespace Ex04.Menus.Interfaces
{ 
    class Program
    {
        static void Main(string[] args)
        {

            MainMenu mainMenu = new MainMenu();
            mainMenu.Title = "vscode";

            MenuItem menuItem1 = new MenuItem();
            menuItem1.Title = "Show Date/Time";
            mainMenu.Items.Add(menuItem1);

               
            MenuItem subMenuItem1 = new MenuItem();
            subMenuItem1.Title = "Show Time";
            menuItem1.SubItems.Add(subMenuItem1);
    
            MenuItem subMenuItem2 = new MenuItem();
            subMenuItem2.Title = "Show Date";
            menuItem1.SubItems.Add(subMenuItem2);
    
            MenuItem menuItem2 = new MenuItem();
            menuItem2.Title = "Version and Capitals";
            mainMenu.Items.Add(menuItem2);

            menuItem2.SubItems=new List<MenuItem>();
            MenuItem subMenuItem2_1 = new MenuItem();
            subMenuItem2_1.Title = "Count Capitals";
            menuItem2.SubItems.Add(subMenuItem2_1);
    
            MenuItem subMenuItem2_2 = new MenuItem();
            subMenuItem2_2.Title = "Show Version";
            menuItem2.SubItems.Add(subMenuItem2_2);
            mainMenu.Show();

        }
    }
}
  /*  static void ShowDateAndTime()
    {
        Console.WriteLine($"Current Date/Time: {DateTime.Now}");
    }

    static void ShowDate()
    {
        Console.WriteLine($"Current Date: {DateTime.Now.Date}");
    }

    static void CountCapitals()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (char.IsUpper(sentence[i]))
            {
                count++;
            }
        }

        Console.WriteLine($"Number of Capitals: {count}");
    }

    static void ShowVersion()
    {
        Console.WriteLine($"Version: {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}");
    }
}

class MainMenu
{
    public string Title { get; set; }
    public List<MenuItem> Items { get; set; }

    public void Show()
    {
        Console.WriteLine(Title);
        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Items[i].Title}");
        }
        Console.WriteLine($"0. Exit");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 0)
        {
            return;
        }
        Items[choice - 1].Show();
    }
}

class MenuItem
{
    public string Title { get; set; }
    public List<MenuItem> SubItems { get; set; } = new List<MenuItem>();
    public IMenuItemAction Action { get; set; }

    public void Show()
    {
        if (SubItems.Count > 0)
        {
            Console.WriteLine(Title);
            for (int i = 0; i < SubItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {SubItems[i].Title}");
            }
            Console.WriteLine($"0. Back");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 0)
            {
                return;
            }
            SubItems[choice - 1].Show();
        }
        else
        {
            Action.Execute();
        }
    }
}

interface IMenuItemAction
{
    void Execute();
}

class MenuItemAction : IMenuItemAction
{
    private Action action;

    public MenuItemAction(Action action)
    {
        this.action = action;
    }

    public void Execute()
    {
        action();
*/   