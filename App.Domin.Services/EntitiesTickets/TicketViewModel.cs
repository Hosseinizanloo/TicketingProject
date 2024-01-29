using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domin.Services.EntitiesTickets
{
    //من میخوام این ها را به من نمایش بدهد 
    public class TicketViewModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime SubmitAt { get; set; }
        public int UserId { get; set; }
        public int CategoyId { get; set; }
        public int PriorityId { get; set; }
    }
}
