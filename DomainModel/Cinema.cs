namespace The_Movies.Model
{
    internal class Cinema
    {

        public string Name = "";
        public int Id;

        public enum Cinemas
        {
            Hjerm,
            Videbaek,
            Thorsminde,
            Raehr,

        }

        public enum HjermSale

        {
            H1,
            H2,
            H3,
        }

        public enum VidebaekSale

        {
            V1,
            V2,
            V3,
            V4,
        }

        public enum ThorsmindeSale

        {
            T1,
            T2,
        }

        public enum RaehrSale

        {
            R1,
            R2,
            R3,
        }
    }
}
