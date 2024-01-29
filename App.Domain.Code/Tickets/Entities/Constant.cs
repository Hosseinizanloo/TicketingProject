using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Code.Tickets.Entities;

namespace App.Domain.Code.Tickets.Entities
{
    public class Constant
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<TicketHistory>? TicketsByStatus { get; set; }
        public List<Ticket>? TicketsByCategory { get; set; }
        public List<Ticket>? TicketsByPriority { get; set; }

    }
}
