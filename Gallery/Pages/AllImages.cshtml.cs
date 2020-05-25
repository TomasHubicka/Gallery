using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallery.Models;
using Gallery.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gallery
{
    public class AllImagesModel : PageModel
    {
        private DatabaseComms _dc;
        public List<Image> images { get; set; }
        public AllImagesModel(DatabaseComms dc)
        {
            _dc = dc;
        }
        public void OnGet(Guid galleryId)
        {
            images = _dc.LoadAllImages();
        }
    }
}