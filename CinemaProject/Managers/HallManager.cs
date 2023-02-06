using CinemaProject.Data;
using CinemaProject.Models;
using CinemaProject.Utilities;
using Core.Services.Contracts;
namespace CinemaProject.Managers
{
    internal class HallManager : ICrudService<Hall>, IPrintService
    {
        public void Add(Hall hall)
        {
            DataContext.Halls.Add(hall);
        }

        public void Delete(int id)
        {
            int index = FindHelper.FindHallIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Hall not found");
                return;
            }

            DataContext.Halls.RemoveAt(index);
            Console.WriteLine("Hall deleted");
        }

        public Hall Get(int id)
        {
            int index = FindHelper.FindHallIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Hall not found");
                return null;
            }

            return DataContext.Halls[index];
        }

        public List<Hall> GetAll()
        {
            return DataContext.Halls;
        }

        public void Print()
        {
            foreach (var item in DataContext.Halls)
            {
                Console.WriteLine(item);
                Console.WriteLine("-".PadLeft(20, '-'));
            }
        }

        public void Update(int id, Hall newHall)
        {
            int index = FindHelper.FindHallIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Hall not found");
                return;
            }

            DataContext.Halls[index] = newHall;
        }
    }
}
