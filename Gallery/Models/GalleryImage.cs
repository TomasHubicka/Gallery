using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Gallery.Models
{
    public class GalleryImage
    {
        public Guid GalleryId { get; set; }
        [ForeignKey("GalleryId")]
        public Gallery Gallery { get; set; }
        public Guid ImageId { get; set; }
        [ForeignKey("ImageId")]
        public Image Image { get; set; }
    }
}
