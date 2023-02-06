using CinemaProject.Models.Enums;
using Core.Models;
namespace CinemaProject.Models
{
    internal class Session : Entity
    {
        internal Film Film { get; set; }
        internal Hall Hall { get; set; }
        internal State[,] Seats { get; set; }
        internal int CinemaId { get; set; }
        internal double Price { get; set; }

        public override string ToString()
        {
            return $"{"ID:",-7} {Id}\nFilm:\n{Film}\nHall:\n{Hall}\n{"Price:",-7} {Price}AZN";
        }
    }
}
