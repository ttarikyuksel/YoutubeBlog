using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Core.Entities;
using YoutubeBlog.Entity.Enums;

namespace YoutubeBlog.Entity.Entities
{
    public class Images:EntityBase
    {
        public Images()
        {
            
        }
        public Images(string fileName,string fileType,string createdBy)
        {
            FileName = fileName;
            FileType = fileType;
            CreatedBy = createdBy;
        }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ImageType ImageType { get; set; }

        public ICollection<Article> Articles { get; set; }

        public ICollection<AppUser> Users { get; set; }

    }
}
