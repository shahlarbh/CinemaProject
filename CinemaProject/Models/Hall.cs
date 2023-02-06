using Core.Models;
namespace CinemaProject.Models
{
    internal class Hall : Entity
    {
        internal string Name { get; set; }
        internal int RowCount { get; set; }
        internal int ColumnCount { get; set; }

        public override string ToString()
        {
            return $"{"ID:",-7} {Id}\n{"Name:",-7} {Name}\n{"Capacity",-7} {RowCount}x{ColumnCount}";
        }
    }
}
