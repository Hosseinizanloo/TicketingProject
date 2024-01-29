using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domin.Services.EntitiesTickets
{
    public class SearchModelTicket
    {
        public string Subject { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int PriorityId { get; set; }

    }
}
