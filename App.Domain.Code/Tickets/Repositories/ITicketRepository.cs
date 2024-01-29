using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Code.Tickets.Entities;
using App.Domin.Services.EntitiesTickets;

namespace App.Domain.Code.Tickets.Repositories
{


    /*
    مسئول عملیات مرتیط تیکت ها بر روی موجودیت
    CRUD
    با دیتا بیس است و این شامل دریافت اضافه کردن به روز رسانی و حذف تیکت ها میشود
    */
    public interface ITicketRepository
    {

        Task<List<TicketViewModel>> GetAllTicketAsync();
        //استفاده از یک شناسه برای دریافت یک تیکت متد
        Task<Ticket> GetByIdAsync(int id);
        //متد برای دریافت همه ی تیکت ها 
        //Task<List<Ticket>> GetAllAsync(int id);
        //متد برای افذودن یک تیکن جدید
        Task CreatAsync(Ticket ticket);
        //متد برای آپدیت یک تیکت
        Task UpdateAsync(Ticket ticket);
        //متد برای حذف یک تیکت
        Task CloseAsync(Ticket ticket);

        //برای سرچ می باشد در محیط ادمین 
        Task<List<TicketViewModel>> searchmodel(SearchModelTicket searchModelTicket);

        void SavechangeAsync();

    }
}
