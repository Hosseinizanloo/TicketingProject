using App.Domain.Code.Users.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Code.Tickets.Entities
{
    public class Ticket
    {   
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime SubmitAt { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoyId { get; set; }
        public virtual Constant Category { get; set; }
        public int PriorityId { get; set; }
        public bool IsClosed { get; set; }
        public virtual Constant Priority { get; set; }
        public List<TicketHistory> TicketHistories { get; set; }
    }
}
