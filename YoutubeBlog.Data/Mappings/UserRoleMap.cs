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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("FC40CC76-AB31-4009-8A37-0136E80C88B7"),
                RoleId = Guid.Parse("BB002044-FBD8-4FBC-9EE9-E532B9BDB7BE")
            }, new AppUserRole 
            {
                UserId = Guid.Parse("E3E6B42A-4C32-4044-83DF-F1ED9AE65BFE"),
                RoleId = Guid.Parse("309720CA-5C91-47D7-88F7-061F4B74669B")
            }
            );
        }
    }
}
