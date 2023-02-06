using Core.Models;
namespace CinemaProject.Models
{
    internal class Ticket : Entity
    {
        internal Session Session { get; set; }
        internal int Row { get; set; }
        internal int Column { get; set; }

        public override string ToString()
        {
            return $"{Session}\n{Row}x{Column}";
        }
    }
}
