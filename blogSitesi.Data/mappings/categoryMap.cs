using blogSitesi.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogSitesi.Data.mappings
{
    public class categoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("540C738F-2D82-4866-84C0-E497700BFC74"),
                name = "ASP.Net Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Category
            {
                Id = Guid.Parse("92B75F4A-FB11-4122-A8F6-D405CBD76045"),
                name = "Visual Studio 2023",
                CreatedBy = "Admin Test2",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            });
        }
    }
}
