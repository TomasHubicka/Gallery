using Gallery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Services
{
    public class DatabaseComms
    {
        readonly ApplicationDbContext _db;
        readonly HttpContextAccessor _hca;

        public DatabaseComms(ApplicationDbContext db, HttpContextAccessor hca)
        {
            _db = db;
            _hca = hca;
        }
        
        public void AddGallery(string name)
        {
            
            _db.Galleries.Add(new Models.Gallery {Name = name, OwnerId = Guid.Parse(_hca.HttpContext.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value)});
            _db.SaveChanges();
        }
        public void AddImage(string name, string source, Guid galleryId)
        {
            _db.Images.Add(new Image {Name = name, OwnerId = Guid.Parse(_hca.HttpContext.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value), Source = source, GalleryId = galleryId});
            _db.SaveChanges();
        }
        public List<Image> LoadGallery(Guid galleryId)
        {
            return _db.Images.Include(i => i.galleryImages).Where(gi => gi.GalleryId == galleryId).ToList();
        }
        public List<Image> LoadAllImages()
        {
            return _db.Images.ToList();
        }
        public List<Models.Gallery> LoadGalleryList()
        {
            return _db.Galleries.ToList();
        }
    }
}
