namespace LR4;
using InputUtils;

internal static class Program
{
    public static void Main()
    {
        var name = InputString.GetInputWith("Input station name");
        var seats = InputUint.GetInputWith("Input seats count");
        var price = InputUint.GetInputWith("Input ticket cost");

        var station = RailwayStation.Instance;
        station.SetName(name);
        station.SetTotalSeats(seats);
        station.SetTicketPrice(price);

        while (true)
        {
            Menu(name);

            var choice = InputUint.GetInputWith("Input your choice");

            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine("Cost of unsold tickets: {0}", station.UnsoldTicketsCost());
                    break;
                case 2:
                    var incrAmount = InputUint.GetInputWith("Input increase amount");
                    station.TicketIncreasePrice(incrAmount);
                    break;
                case 3:
                    var decrAmount = InputUint.GetInputWith("Input decrease amount");
                    station.TicketDecreasePrice(decrAmount);
                    break;
                case 4:
                    var soldAmount = InputUint.GetInputWith("Input sold tickets amount");
                    station.SetSoldTickets(soldAmount);
                    break;
                default:
                    Console.WriteLine("Incorrect menu item");
                    break;
            }
        }
    }

    private static void Menu(string name)
    {
        Console.WriteLine(
            $"***** Menu of Railway Station '{name}' *****\n" +
            "1. - Get cost of unsold tickets\n" +
            "2. - Increase ticket cost\n" +
            "3. - Decrease ticket cost\n" +
            "4. - Set sold tickets amount\n" +
            "0. - Exit"
        );
    }
}