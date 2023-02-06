using CinemaProject.Data;
using CinemaProject.Models;
using CinemaProject.Models.Enums;
using Core.Services.Contracts;

namespace CinemaProject.Managers
{
    internal class TicketManager : IPrintService
    {
        private readonly SessionManager _sessionManager;
        private readonly CinemaManager _cinemaManager;

        public TicketManager(SessionManager sessionManager, CinemaManager cinemaManager)
        {
            _sessionManager = sessionManager;
            _cinemaManager = cinemaManager;
        }

        public void BuyTicket()
        {
            Console.WriteLine("Cinemas:");

            _cinemaManager.Print();

            Console.Write("Enter the Cinema ID:");
            var cinemaId = int.Parse(Console.ReadLine());

            var cinema = _cinemaManager.Get(cinemaId);

            if (cinema == null)
            {
                Console.WriteLine("Cinema not found");
                return;
            }

            Console.WriteLine(cinema);

            Console.WriteLine("Session:");

            _sessionManager.PrintSessionByCinema(cinema.Id);

            Console.Write("Enter the Session ID:");
            var sessionId = int.Parse(Console.ReadLine());

            var session = _sessionManager.Get(sessionId);

            if (session == null || session.CinemaId != cinema.Id)
            {
                Console.WriteLine("Session not found");
                return;
            }

            Console.WriteLine(session);

            _sessionManager.PrintSessionSeats(session);

            row:

            Console.Write("Enter the Row:");
            var row = int.Parse(Console.ReadLine());

            if (!(row >= 1 && row <= session.Seats.GetLength(0)))
            {
                Console.WriteLine("Row range is not correct");

                goto row;
            }

            column:

            Console.Write("Enter the Column:");
            var column = int.Parse(Console.ReadLine());

            if (!(column >= 1 && column <= session.Seats.GetLength(1)))
            {
                Console.WriteLine("Column range is not correct");

                goto column;
            }

            if (session.Seats[row - 1, column - 1] == State.Full) 
            {
                Console.WriteLine("This seat is not empty");

                goto row;
            }

            session.Seats[row - 1, column - 1] = State.Full;

            var ticket = new Ticket
            {
                Session = session,
                Row = row,
                Column = column
            };

            DataContext.Tickets.Add(ticket);

            Console.WriteLine("Ticket bought");
        }

        public void Print()
        {
            foreach (var item in DataContext.Tickets)
            {
                Console.WriteLine(item);
                Console.WriteLine("-".PadLeft(20, '-'));
            }
        }
    }
}
