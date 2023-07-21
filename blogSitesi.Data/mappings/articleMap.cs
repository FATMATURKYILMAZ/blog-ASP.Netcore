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
    public class articleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id=Guid.NewGuid(),
                Title= "ASP.Net Core EF Article Essay",
                Content= "ASP.NET Core MVC is a powerful framework for building web applications, but it is also important to ensure that your application is secure. Security is a critical aspect of any web application, and there are several best practices that you can follow to make sure that your ASP.NET Core MVC application is secure. In this article, we will explore some of the best practices for securing your ASP.NET Core MVC application.",
                ViewCount=15,
                CategoryId=Guid.Parse("540C738F-2D82-4866-84C0-E497700BFC74"),
                ImageId = Guid.Parse("D9678411-71F1-41D5-8238-B9531B1083B1"),
                CreatedBy="Admin Test",
                CreatedDate=DateTime.Now,
                IsDeleted=false

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Essay Article 1",
                Content = "Visual Studio ASP.NET Core MVC is a powerful framework for building web applications, but it is also important to ensure that your application is secure. Security is a critical aspect of any web application, and there are several best practices that you can follow to make sure that your ASP.NET Core MVC application is secure. In this article, we will explore some of the best practices for securing your ASP.NET Core MVC application.",
                ViewCount = 15,
                CategoryId = Guid.Parse("92B75F4A-FB11-4122-A8F6-D405CBD76045"),
                ImageId = Guid.Parse("2C2BD7A1-DEA5-45A9-86F3-4204F9C0CC2C"),
                CreatedBy = "Admin Test2",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }) ;
        }
    }
}
