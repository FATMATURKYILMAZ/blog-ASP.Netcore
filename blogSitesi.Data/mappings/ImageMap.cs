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
    internal class ImageMap : IEntityTypeConfiguration<Image>
    {
        void IEntityTypeConfiguration<Image>.Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("D9678411-71F1-41D5-8238-B9531B1083B1"),
                fileName = "images/testimages",
                fileType = "jpg",
                CreatedBy = "Admin Test3",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },new Image
            {
                Id = Guid.Parse("2C2BD7A1-DEA5-45A9-86F3-4204F9C0CC2C"),
                fileName = "images/vstest",
                fileType = "png",
                CreatedBy = "Admin Test4",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
