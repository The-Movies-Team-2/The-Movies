namespace DomainModel
{
    internal class User
    {
        public string Name { get; set; } = "";
        public string Username = "";
        public string Password = "";
        public bool Access;
        public int Id;
        public List<int> GenreId = new List<int>();
    }
}
