using CinemaProject.Data;
namespace CinemaProject.Utilities
{
    internal static class FindHelper
    {
        internal static int FindSessionIndex(int id)
        {
            for (int i = 0; i < DataContext.Sessions.Count; i++)
            {
                if (DataContext.Sessions[i].Id == id)
                    return i;
            }
            return -1;
        }

        internal static int FindHallIndex(int id)
        {
            for (int i = 0; i < DataContext.Halls.Count; i++)
            {
                if (DataContext.Halls[i].Id == id)
                    return i;
            }
            return -1;
        }

        internal static int FindCinemaIndex(int id)
        {
            for (int i = 0; i < DataContext.Cinemas.Count; i++)
            {
                if (DataContext.Cinemas[i].Id == id)
                    return i;
            }
            return -1;
        }

        internal static int FindFilmIndex(int id)
        {
            for (int i = 0; i < DataContext.Films.Count; i++)
            {
                if (DataContext.Films[i].Id == id)
                    return i;
            }
            return -1;
        }
    }
}
