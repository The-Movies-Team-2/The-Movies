using ApplicationLayer.Repositories;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;

namespace ApplicationLayer.DataHandlers.DomainDataHandlers
{
    internal class ReservationDataHandler : AbstractDataHandler<ReservationRepository>
    {
            private static string _filePath = @"C:\\TheMovies\\Reservations.txt";
            private readonly ReservationRepository _repository = new ReservationRepository();

        internal ReservationRepository Read(ShowingRepository showingRepository)
        {
            CheckIfFileExists(_filePath);
            List<string> lines = File.ReadLines(_filePath).ToList();
            ;
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                int id = int.Parse(values[0]);
                int showingId = int.Parse(values[1]);
                string email = values[2];
                string phone = values[3];
                int numberofticket = int.Parse(values[4]);

                Reservation reservation = new Reservation(id, showingId, email, phone, numberofticket);
                _repository.Add(reservation);
            }
            return _repository;
        }

        internal void Write(ReservationRepository repository)
        {
            CheckIfFileExists(_filePath);

            List<Reservation> lines = repository.GetAll().ToList();
            foreach (Reservation Reservation in lines)
            {
                var createText = $"{Reservation.Id};{Reservation.ShowingId};{Reservation.CustomerMail};{Reservation.CustomerPhone};{Reservation.NumberOfTickets}";
                File.AppendAllText(_filePath, createText + Environment.NewLine);
            }
        }
       
    }
}
