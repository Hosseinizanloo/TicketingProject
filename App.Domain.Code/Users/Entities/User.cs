using App.Domain.Code.Tickets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Code.Users.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public virtual List<Ticket>? Tickets { get; set; }
        public virtual List<TicketHistory>? TicketHistories { get; set; }
    }
}
