using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Core.Entities;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                ViewCount = 15,                
                CategoryId = Guid.Parse("29713C56-E93A-475F-A596-FF19FE254B1F"),
                ImageId = Guid.Parse("00A5354D-0D30-4576-A128-78EFCBED9849"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted  =false,
                DeletedBy = "Admin",
                ModifiedBy ="Adminn",
                UserId = Guid.Parse("FC40CC76-AB31-4009-8A37-0136E80C88B7")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.",
                Content = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
                ViewCount = 25,                
                CategoryId = Guid.Parse("43DF9B9A-A17F-449B-A79D-414A684E7350"),
                ImageId = Guid.Parse("BE2C73CF-C312-485E-BE69-7F7A7027829E"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                DeletedBy = "Admin",
                ModifiedBy = "Adminn",
                UserId = Guid.Parse("E3E6B42A-4C32-4044-83DF-F1ED9AE65BFE")

            });

        }
    }
}
