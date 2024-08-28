using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;

namespace ApplicationLayer.Repositories
{
    public class ReservationRepository
    {
        private readonly List<Reservation> reservations = new List<Reservation>();

        public ReservationRepository() 
        {
            Add(new Reservation(4,1,"88 88 88 88","fake@email.com"));
        }
        public void Add(Reservation reservation)
        {
            int maxId = 0;
            if (reservations.Count > 0) maxId = reservations.Max(h => h.Id);
            reservation.Id = maxId + 1;
            reservations.Add(reservation);
        }

        public void Remove(Reservation reservation)
        {
            if (reservations.Contains(reservation))
                reservations.Remove(reservation);
        }

        public Reservation GetById(int id)
        {
            return reservations.FirstOrDefault(g => g.Id == id);
        }

        public List<Reservation> GetAll()
        {
            return reservations;
        }
        public List<Reservation> GetByShowingId(int id)
        {
            return reservations.Where(r => r.ShowingId == id).ToList();
        }

    }
}
