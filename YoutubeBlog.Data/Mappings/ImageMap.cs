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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("00A5354D-0D30-4576-A128-78EFCBED9849"),
                FileName = "images/testimage",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                DeletedBy = "Admin",
                ModifiedBy = "Adminn",
                FileType ="abc"
            }
            ,
            new Image
            {
                Id = Guid.Parse("BE2C73CF-C312-485E-BE69-7F7A7027829E"),
                FileName = "images/testimage",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                DeletedBy = "Admin",
                ModifiedBy = "Adminn",
                FileType = "abc"
            });
        }
    }
}
