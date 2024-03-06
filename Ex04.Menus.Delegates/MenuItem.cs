using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{  
    public class MenuItem
    {
        private string m_Title;

        public List<MenuItem> m_SubItems = new List<MenuItem>();

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }   
        }

        public List<MenuItem> SubItems
        {
            get { return m_SubItems; }
        }

        public event Action OnMenuItemClick;  


    
        public void Show()
        {
            while (true)
            {
                Console.WriteLine($"{Title}");
                if (SubItems.Any())
                {
                    for (int i = 0; i < SubItems.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} -> {SubItems[i].Title}");
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
                    SubItems[choice - 1].();
                }
            }
    
        }
    } 
    
}
