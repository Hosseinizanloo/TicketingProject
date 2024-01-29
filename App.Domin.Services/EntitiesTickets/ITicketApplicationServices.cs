using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domin.Services.EntitiesTickets
{



    /*
     
    مسئول اجرای منطق کسب کار و همچین مدیریت تبادل اطلاعات بین لایه ها 
    این ممکنه عملیاتی انجام بده 
     
     */

    public interface ITicketApplicationServices
    {

        Task<List<TicketViewModel>> SearchAsync(SearchModelTicket searchmodel);

        //متد برای نمایش همه ی تیکت ها 
        Task<List<TicketViewModel>> GetAllTicketAsync();
       //متد برای اضافه کردن یک تیکت جدید
        Task CreatAsync(CreatTicket creatTicketticket);
        //متد برای به روز رسانی یک تیکت موجود
        Task UpdateAsync(UpdateTicket updateTicket);
        //متد برای حذف یک تیکت بر اساس شناسه
        Task CloseAsync(int id);


    }
}
