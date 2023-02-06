using Core.Models;
namespace CinemaProject.Models
{
    internal class Cinema : Entity
    {
        internal string Name { get; set; }
        internal List<Hall> Halls { get; set; }

        public override string ToString()
        {
            return $"{"ID:",-7} {Id}\n{"Name:",-7} {Name}";
        }
    }
}
