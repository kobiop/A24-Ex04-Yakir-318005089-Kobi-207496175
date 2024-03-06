using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    internal class MainMenu
    {
        public string m_Title;

        public List<MenuItem> m_Items = new List<MenuItem>();

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public List<MenuItem> Items
        {
            get { return m_Items; }
        }

        public void Show()
        {
            while (true)
            {

                Console.WriteLine($"{Title}");
                for (int i = 0; i < Items.Count; i++)
                {
                    Console.WriteLine($"{i + 1} -> {Items[i].Title}");
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
    }
}
