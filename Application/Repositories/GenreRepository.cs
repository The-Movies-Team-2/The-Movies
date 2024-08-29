using The_Movies.DomainModel;

namespace The_Movies.ApplicationLayer.Repositories
{
    public class GenreRepository
    {
        private readonly List<Genre> _genres = new List<Genre>();

        public GenreRepository()
        {
            Add(new Genre(1, "Drama"));
            Add(new Genre(2, "Gys"));
            Add(new Genre(3, "Action"));
            Add(new Genre(4, "Komedie"));
            Add(new Genre(5, "Science Fiction"));
            Add(new Genre(6, "Romantik"));
            Add(new Genre(7, "Eventyr"));
            Add(new Genre(8, "Krimi"));
            Add(new Genre(9, "Animation"));
            Add(new Genre(10, "Thriller"));
        }

        public void Add(Genre genre)
        {
            if(!_genres.Contains(genre))
            _genres.Add(genre);
        }

        public void Remove(Genre genre)
        {
            if (_genres.Contains(genre))
                _genres.Remove(genre);
        }


        public Genre GetById(int id)
        {
            return _genres.FirstOrDefault(g => g.Id == id);
        }

        public List<Genre> GetGenres()
        {
            return _genres.OrderBy(g => g.Name).ToList();
        }
    }
}
