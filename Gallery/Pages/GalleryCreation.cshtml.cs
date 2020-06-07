using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gallery.Services;


namespace Gallery
{
    public class GalleryCreationModel : PageModel
    {
        private DatabaseComms _dc;
        public GalleryCreationModel(DatabaseComms dc)
        {
            _dc = dc;
        }
        public void OnGet()
        {

        }
        public void OnPost(string GalleryName)
        {
            _dc.AddGallery(GalleryName);
        }
    }
}