using CinemaProject.Data;
using CinemaProject.Models;
using CinemaProject.Utilities;
using Core.Services.Contracts;
namespace CinemaProject.Managers
{
    internal class CinemaManager : ICrudService<Cinema>, IPrintService
    {
        public void Add(Cinema cinema)
        {
            DataContext.Cinemas.Add(cinema);
        }

        public void Delete(int id)
        {
            int index = FindHelper.FindCinemaIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Cinema not found");
                return;
            }

            DataContext.Cinemas.RemoveAt(index);
            Console.WriteLine("Cinema deleted");
        }

        public Cinema Get(int id)
        {
            int index = FindHelper.FindCinemaIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Cinema not found");
                return null;
            }

            return DataContext.Cinemas[index];
        }

        public List<Cinema> GetAll()
        {
            return DataContext.Cinemas;
        }

        public void Print()
        {
            foreach (var item in DataContext.Cinemas)
            {
                Console.WriteLine(item);
                Console.WriteLine("-".PadLeft(20, '-'));
            }
        }

        public void Update(int id, Cinema newCinema)
        {
            int index = FindHelper.FindCinemaIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Cinema not found");
                return;
            }

            DataContext.Cinemas[index] = newCinema;
        }
    }
}
