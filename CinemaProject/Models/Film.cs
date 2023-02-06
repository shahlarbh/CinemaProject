using Core.Models;
namespace CinemaProject.Models
{
    internal class Film : Entity
    {
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal string Director { get; set; }
        internal int Minute { get; set; }

        public override string ToString()
        {
            return $"{"ID:",-7} {Id}\n{"Name:",-7} {Name}\n{"Minute",-7} {Minute}";
        }
    }
}
