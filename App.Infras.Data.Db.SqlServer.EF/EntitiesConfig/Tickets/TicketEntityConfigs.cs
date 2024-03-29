﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Code.Tickets.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infras.Data.Db.SqlServer.EF.EntitiesConfig.Tickets
{
    public class TicketEntityConfigs : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets");

            builder.HasKey(t => t.Id);
            builder.Property(t => t.UserId).IsRequired();
            builder.Property(t => t.Subject).HasMaxLength(50);
            builder.Property(t => t.Description).HasMaxLength(512);
            builder.Property(t => t.SubmitAt).HasColumnType("datetime");
            builder.HasOne(t => t.User).WithMany(u => u.Tickets).HasForeignKey(t => t.UserId);
            builder.HasOne(t => t.Category).WithMany(c => c.TicketsByCategory).HasForeignKey(t => t.CategoyId);
            builder.HasOne(t => t.Priority).WithMany(c => c.TicketsByPriority).HasForeignKey(t => t.PriorityId);

        }
    }
}
