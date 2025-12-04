using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class Restaurant
    {
        public List<IMenuItem> Menu { get; private set; } = new List<IMenuItem>();
        public List<Order> Orders { get; private set; } = new List<Order>();

        public void AddMenuItem(IMenuItem item) => Menu.Add(item);

        public void ShowMenu()
        {
            Console.WriteLine("--- МЕНЮ РЕСТОРАНУ ---");
            int i = 1;
            foreach (var item in Menu)
            {
                Console.WriteLine($"{i}. {item.GetInfo()}");
                i++;
            }
            Console.WriteLine("-----------------------");
        }

        public Order CreateOrder(int id, int table)
        {
            var order = new Order(id, table);
            Orders.Add(order);
            Console.WriteLine($"\nСтворено замовлення для столика №{table}");
            return order;
        }

        public Order FindOrder(int id)
        {
            return Orders.FirstOrDefault(o => o.Id == id);
        }

        public void ShowAllOrders()
        {
            Console.WriteLine("\n--- УСІ ЗАМОВЛЕННЯ ---");
            foreach (var o in Orders)
            {
                Console.WriteLine(
                    $"ID: {o.Id} | Стіл: {o.TableNumber} | Статус: {o.Status} | Сума: {o.GetTotal()} грн");
            }
        }
    }
}
