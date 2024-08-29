using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Booking
    {
        public int BookingId;
        public DateOnly BookingDate;
        public string Email = "";
        public int PhoneNumber = 0;
        public int NumberOfTickets;


        Booking(int BookingId,DateOnly BookingDate, string Email,
            int PhoneNumber, int NumberOfTickets, Showing showing) {

            this.BookingId = BookingId;
            this.BookingDate = BookingDate;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.NumberOfTickets = NumberOfTickets;
        }
    }
}
