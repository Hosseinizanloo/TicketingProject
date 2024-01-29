using App.Domain.AppServices;
using App.Domain.Code.Tickets.Entities;
using App.Domain.Code.Tickets.Repositories;
using App.Domin.Services.EntitiesTickets;
using App.Infras.Data.Db.SqlServer.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _dbContext;

        public TicketRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreatAsync(Ticket ticket)
        {
            _dbContext.Tickets.Add(ticket);
             _dbContext.SaveChanges();
        }

        public async Task CloseAsync(Ticket ticket)
        {
             _dbContext.Tickets.Update(ticket);
        }

        public async Task<Ticket> GetByIdAsync(int id)
        {
            //حتما باید جدول مورد نظر نوشته شود
            return await _dbContext.Tickets.FindAsync(id);
        }

        public void SavechangeAsync()
        {
            _dbContext.SaveChanges();
        }

        public async Task<List<TicketViewModel>> searchmodel(SearchModelTicket searchModelTicket)
        {
            //ابتدا یک کوئری می سازیم که از طریق پروداکت سلکت می کنیم و پرداکت ویو مدل را می گیریم 
            // و داخل آن انتتی های تعریف شده در آن کلاس را دریافت میکنیم 
            var query = _dbContext.Tickets.Include(x => x.Category).Select(x => new TicketViewModel
            {
                Id = x.Id,
                Subject = x.Subject,
                CategoyId = x.CategoyId,
                Description = x.Description,
                PriorityId = x.PriorityId,
                SubmitAt = x.SubmitAt,
                UserId = x.UserId

            });
            // عملیات فیلترینگ

            //اگر که نام نبود عملیات زیر آن را ایجاد کن     
            if (!string.IsNullOrWhiteSpace(searchModelTicket.Subject))
                query = query.Where(x => x.Subject.Contains(searchModelTicket.Subject));
            if (searchModelTicket.UserId != 0)
                query = query.Where(x => x.UserId == searchModelTicket.UserId);
            if (searchModelTicket.CategoryId != 0)
                query = query.Where(x => x.CategoyId == searchModelTicket.CategoryId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
        public async Task UpdateAsync(Ticket ticket)
        {
            //ذخیره تغیرات انجام شده در دیتا بیس
            await _dbContext.SaveChangesAsync();
        }

        public Task<List<TicketViewModel>> GetAllTicketAsync()
        {
            throw new NotImplementedException();
        }
    }
}
