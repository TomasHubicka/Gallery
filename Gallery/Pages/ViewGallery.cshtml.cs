﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallery.Models;
using Gallery.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gallery
{
    public class ViewGalleryModel : PageModel
    {
        private DatabaseComms _dc;
        public string GalleryName { get; set; }
        public Guid GalleryId { get; set; }
        public List<Image> images { get; set; }
        public ViewGalleryModel(DatabaseComms dc)
        {
            _dc = dc;
        }
        public void OnGet(Guid galleryId)
        {
            images = _dc.LoadGallery(galleryId);
            GalleryName = _dc.GetGalleryName(galleryId);
            GalleryId = galleryId;
        }
    }
}