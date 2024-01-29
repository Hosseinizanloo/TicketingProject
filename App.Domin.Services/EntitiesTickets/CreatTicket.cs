using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domin.Services.EntitiesTickets
{
    public class CreatTicket
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime SubmitAt { get; set; }
        public int UserId { get; set; }
        public int CategoyId { get; set; }
        public int PriorityId { get; set; }
    }
}
