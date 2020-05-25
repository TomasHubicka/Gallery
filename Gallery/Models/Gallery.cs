using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Models
{
    public class Gallery
    {
        [Key]
        public Guid GalleryId { get; set; }
        public Guid OwnerId { get; set; }
        public String Name { get; set; }
        public ICollection<GalleryImage> galleryImages { get; set; }
    }
}
