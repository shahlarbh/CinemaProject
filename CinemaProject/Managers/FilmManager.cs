using CinemaProject.Data;
using CinemaProject.Models;
using CinemaProject.Utilities;
using Core.Services.Contracts;
namespace CinemaProject.Managers
{
    internal class FilmManager : ICrudService<Film>, IPrintService
    {
        public void Add(Film film)
        {
            DataContext.Films.Add(film);
        }

        public void Delete(int id)
        {
            int index = FindHelper.FindFilmIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Film not found");
                return;
            }

            DataContext.Films.RemoveAt(index);
            Console.WriteLine("Film deleted");
        }

        public Film Get(int id)
        {
            int index = FindHelper.FindFilmIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Film not found");
                return null;
            }

            return DataContext.Films[index];
        }

        public List<Film> GetAll()
        {
            return DataContext.Films;
        }

        public void Print()
        {
            foreach (var item in DataContext.Films)
            {
                Console.WriteLine(item);
                Console.WriteLine("-".PadLeft(20, '-'));
            }
        }

        public void Update(int id, Film newFilm)
        {
            int index = FindHelper.FindFilmIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Film not found");
                return;
            }

            DataContext.Films[index] = newFilm;
        }
    }
}
