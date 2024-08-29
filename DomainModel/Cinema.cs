namespace The_Movies.Model
{ 
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Cinema(int Id, string Name) { 
            this.Id = Id;
            this.Name = Name;
        }
    }
}
