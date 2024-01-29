using App.Domain.Code.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Code.Tickets.Entities
{
    public class TicketHistory
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int UserId { get; set; }
        public User ModifiedBy { get; set; }
        public int StatusId { get; set; }
        public Constant Status { get; set; }

    }
}
