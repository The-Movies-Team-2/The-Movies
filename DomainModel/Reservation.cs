using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Reservation
    {
        public int Id { get; set; }
        public int NumberOfTickets { get; set; }
        public int ShowingId { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerMail { get; set; }
        

        public Reservation(int numberOfTickets, Showing showing, string phone,string mail)
        {
            NumberOfTickets = numberOfTickets;
            ShowingId = showing.Id;
            CustomerPhone = phone;
            CustomerMail = mail;
        }
        public Reservation(int numberOfTickets, int showId, string phone, string mail) 
        {
            NumberOfTickets = numberOfTickets;
            ShowingId = showId;
            CustomerPhone = phone;
            CustomerMail = mail;
        }
    }
}
