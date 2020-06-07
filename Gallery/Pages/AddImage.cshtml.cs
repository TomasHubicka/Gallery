using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallery.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gallery
{
    public class AddImageModel : PageModel
    {
        private DatabaseComms _dc;
        public AddImageModel(DatabaseComms dc)
        {
            _dc = dc;
        }
        public Guid GalleryId { get; set; }
        public void OnGet(Guid galleryId)
        {
            GalleryId = galleryId;
        }
        public void OnPost(string imageName, string source, Guid galleryId)
        {
            _dc.AddImage(imageName, source, galleryId);
        }
    }
}