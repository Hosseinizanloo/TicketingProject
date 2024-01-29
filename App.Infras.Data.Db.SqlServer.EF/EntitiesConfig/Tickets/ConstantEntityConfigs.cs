using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Code.Tickets.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infras.Data.Db.SqlServer.EF.EntitiesConfig.Tickets
{
    public class ConstantEntityConfigs : IEntityTypeConfiguration<Constant>
    {
        public void Configure(EntityTypeBuilder<Constant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Title).HasMaxLength(50);
        }
    }
}
