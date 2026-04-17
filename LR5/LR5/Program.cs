namespace LR5;

using Railway;
using InputUtils;

internal static class Program
{
    public static void Main()
    {
        var station = new RailwayStation();
        
        while (true)
        {
            Menu();
            var choice = InputUint.GetInputWith("Введите пункт меню");
            
            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    var count = InputUint.GetInputWith("Введи количество тарифов для ввода");

                    for (var i = 0; i < count; ++i)
                    {
                        var price = InputUint.GetInputWith("Введите цену");
                        var type = InputTicketType;
                        var destination = InputString.GetInputWith("Введите пункт назначения").Trim();
                        
                        station.AddTariff(new Ticket(price, type, destination));
                    }

                    break;
                case 2:
                    var fullname = InputString.GetInputWith("Введите полное имя пассажира").Trim();
                    var passportId = InputString.GetInputWith("Введите паспортные данные пассажира").Trim();
                    
                    station.AddCustomer(new Customer(fullname, passportId));
                    break;
                case 3:
                    var id = InputString.GetInputWith("Введите паспортные данные покупателя").Trim();
                    var dest = InputString.GetInputWith("Введите направление").Trim();

                    try
                    {
                        station.Buy(id, dest);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: {0}", e);
                    }
                    
                    break;
                case 4:
                    var targetId = InputString.GetInputWith("Введите паспортные данные покупателя").Trim();

                    try
                    {
                        var cost = station.CustomerCart(targetId);
                        Console.WriteLine("Стоимость купленных пассажиром билетов: {0}", cost);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: {0}", e);
                    }
                    
                    break;
                case 5:
                    station.PrintTariffs();
                    break;
                case 6:
                    var direction = InputString.GetInputWith("Введите направление");
                    station.PrintCustomersListOnDirection(direction);
                    break;
                case 7:
                    station.PrintCustomers();
                    break;
                default:
                    Console.WriteLine("Неправильный пункт меню");
                    break;
            }
        }
    }

    private static void Menu()
    {
        Console.WriteLine(
            "***** Menu of Railway Station *****\n" +
            "1 -> Вести тарифы\n" +
            "2 -> Ввести данные пассажира\n" +
            "3 -> Купить билет\n" +
            "4 -> Рассчитать стоимость купленных пасажиром билетов\n" +
            "5 -> Вывести тарифы\n" +
            "6 -> Список пассажиров, купивших билет на направление\n" +
            "7 -> Список пассажиров\n" +
            "0 -> Exit"
        );
    }

    private static TicketType InputTicketType
    {
        get
        {
            Console.WriteLine("Выбери тип тикета \n 1. Default\n 2. Premium \n 3. Business");
            var choice = InputUint.GetInput;

            while (true)
            {
                switch (choice)
                {
                    case 1:
                        return TicketType.Default;
                    case 2:
                        return TicketType.Premium;
                    case 3:
                        return TicketType.Business;
                    default:
                        Console.WriteLine("Неверный тип тикета");
                        break;
                }
            }
        }
    }
}