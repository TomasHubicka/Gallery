using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallery.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gallery
{
    public class GalleryListModel : PageModel
    {
        private DatabaseComms _dc;
        public List<Models.Gallery> galleries { get; set; }
        public GalleryListModel(DatabaseComms dc)
        {
            _dc = dc;
        }

        public void OnGet()
        {           
            galleries = _dc.LoadGalleryList();
        }
    }
}