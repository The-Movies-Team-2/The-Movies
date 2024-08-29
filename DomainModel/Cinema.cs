using DomainModel;
using The_Movies.DomainModel;

namespace The_Movies.Model
{ 
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Theater> Theaters = new List<Theater>();
        
        public Cinema(int id, string name, List<Theater> theaters)
        {
            Id = id;
            Name = name;
            Theaters = theaters;
        }
    }
}
