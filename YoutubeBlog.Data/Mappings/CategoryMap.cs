using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("29713C56-E93A-475F-A596-FF19FE254B1F"),
                Name = "Asp.Net Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                DeletedBy = "Admin",
                ModifiedBy = "Adminn"
            },
            new Category
            {
                Id = Guid.Parse("43DF9B9A-A17F-449B-A79D-414A684E7350"),
                Name = "Asp.Net Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                DeletedBy = "Admin",
                ModifiedBy = "Adminn"
            });                    
        }
    }
}
