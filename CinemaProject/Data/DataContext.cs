using CinemaProject.Models;
namespace CinemaProject.Data
{
    internal class DataContext
    {
        internal static List<Film> Films { get; set; } = new List<Film>();
        internal static List<Session> Sessions { get; set; } = new List<Session>();
        internal static List<Cinema> Cinemas { get; set; } = new List<Cinema>();
        internal static List<Hall> Halls { get; set; } = new List<Hall>();
        internal static List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
