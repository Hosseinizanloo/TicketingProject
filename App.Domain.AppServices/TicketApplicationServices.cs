using App.Domain.Code.Tickets.Entities;
using App.Domain.Code.Tickets.Repositories;
using App.Domin.Services.EntitiesTickets;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices
{
    public class TicketApplicationServices : ITicketApplicationServices
    {
        //در این قسمت ریپازیتوری یک متغیر خصوصی تعریف شده است
        //ور در آیتیکت ریپازیتوری از آن به عنوان کانستراکتور استفاده شده است 
        //م این متغیر برای کراد بر روی دیتابیس و انجام عملیات وابسته تیکت ها به کلاس آیتیکت ریپازیتوریاست
        private readonly ITicketRepository _ticketRepository;

        public TicketApplicationServices(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task CloseAsync(int id)
        {
            var ticket = await _ticketRepository.GetByIdAsync(id);
            if (ticket == null)
            {
                throw new NotFoundException($"Ticket with ID {ticket.Id} not found.");
              
            }

            ticket.IsClosed = true;
            _ticketRepository.CloseAsync(ticket);
        }

        public async Task CreatAsync(CreatTicket creatTicketticket)
        {
            var ticket = new Ticket
            {
                Subject=creatTicketticket.Subject,
                Description = creatTicketticket.Description,
                SubmitAt = DateTime.Now,
                UserId = creatTicketticket.UserId
            };
           await _ticketRepository.CreatAsync(ticket);
           _ticketRepository.SavechangeAsync();
        }

   

        //نمایش تمام تیکت ها
        public async Task<List<TicketViewModel>> GetAllTicketAsync()
        {
           return await _ticketRepository.GetAllTicketAsync();
        }

        /*
        این متد تمامی تیکت ها را با استفاده ای گت آل ایسینک از 
        ITicketRepository
        برمی گرداند 
         */
        //public async Task<List<TicketViewModel>> GetAllTicketAsync(int id)
        //{
        //    return await _ticketRepository.GetByIdAsync(id);
        //}

        /*
         این متد جستو جوت تیکت ها را با استفاده از 
        searchmodel
        از ITicketRepository 
        فراخانی می کند
         */
        public Task<List<TicketViewModel>> SearchAsync(SearchModelTicket searchmodel)
        {
            return _ticketRepository.searchmodel(searchmodel);
        }

        public async Task UpdateAsync(UpdateTicket updateTicket)
        {
            var ticket = await _ticketRepository.GetByIdAsync(updateTicket.Id);
            if (ticket != null)
            {
                ticket.Subject = updateTicket.Subject;
                ticket.Description = updateTicket.Description;
                ticket.SubmitAt = DateTime.Now;
                await _ticketRepository.UpdateAsync(ticket);
            }
            else
            {
                throw new NotFoundException($"Ticket with ID {updateTicket.Id} not found.");
            }
        }
    }
}
//
