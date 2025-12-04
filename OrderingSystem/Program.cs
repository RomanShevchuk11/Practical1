namespace OrderingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                Restaurant rest = new Restaurant();

                // MENU (оновлене)
                rest.AddMenuItem(new Dish("Піцца 4 М'", 185, "Main", "Італійська"));
                rest.AddMenuItem(new Dish("Салат Цезар", 160, "Salad", "Холодна"));
                rest.AddMenuItem(new Drink("Капучино", 75, 250, false));
                rest.AddMenuItem(new Drink("Лимонад домашній", 90, 300, false));
                rest.AddMenuItem(new Drink("Пиво світле", 65, 500, true));

                rest.ShowMenu();

                // NEW ORDER (оновлений)
                Order order = rest.CreateOrder(202, 12);
                // ID = 202, Стіл = 12

                order.AddItem(rest.Menu[0]); // Піцца
                order.AddItem(rest.Menu[2]); // Капучино
                order.AddItem(rest.Menu[3]); // Лимонад

                Console.WriteLine($"Поточна сума: {order.GetTotal()} грн");

                // STATUS CHANGE (ті самі кроки)
                Console.WriteLine($"\nСтатус замовлення: {order.Status}");
                order.ChangeStatus(OrderStatus.InProgress);
                order.ChangeStatus(OrderStatus.Ready);
                order.ChangeStatus(OrderStatus.Paid);

                // DOWNCAST demo
                IMenuItem itemForCast = rest.Menu[4];
                if (itemForCast is Drink drink)
                    Console.WriteLine($"\nDowncast! Напій: {drink.Name}, об’єм: {drink.Volume} мл");

                // ALL ORDERS
                rest.ShowAllOrders();
            }
        }
    }

    

