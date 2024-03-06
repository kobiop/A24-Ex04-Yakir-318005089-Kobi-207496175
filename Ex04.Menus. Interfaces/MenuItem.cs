using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public string Title { get; set; }
        public List<MenuItem> SubItems { get; set; } = new List<MenuItem>();
        private List<IListener<string> >  m_IListners { get; set; }

        public void AddListener(IListener<string> i_listener)
        {
            m_IListners.Add(i_listener);
        }
        public void RemoveListener(IListener<string> i_listener)
        {
            m_IListners.Remove(i_listener);
        }
        private void notifyAllSickListeners(string i_ID)
        {
            foreach (IListener<string> listener in m_IListners) 
            {
                listener.Execute(i_ID);
            }
        }
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
