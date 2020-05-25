using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Models
{
    public class Image
    {
        [Key]
        public Guid ImageId { get; set; }
        public Guid OwnerId { get; set; }
        public String Name { get; set; }
        public String Source { get; set; }
        public Guid GalleryId { get; set; }
        public ICollection<GalleryImage> galleryImages { get; set; }
    }
}
