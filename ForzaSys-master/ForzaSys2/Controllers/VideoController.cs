// VideoController.cs
using Microsoft.AspNetCore.Mvc;
using ForzaSys2.Models;
using System.Collections.Generic;

namespace ForzaSys2.Controllers
{
    public class VideoController : Controller
    {
        private readonly List<Video> _videos; // Simulated video data

        public VideoController()
        {
            // Initialize with some sample data
            _videos = new List<Video>
            {
                new Video { Id = 1, Title = "Video 1", Category = "Goals" },
                new Video { Id = 2, Title = "Video 2", Category = "Assists" },
                // Add more videos as needed
            };
        }

        // Action method to retrieve all videos
        public IActionResult Index()
        {
            return View(_videos);
        }

        // Action method to retrieve a specific video by ID
        public IActionResult Details(int id)
        {
            var video = _videos.Find(v => v.Id == id);
            if (video == null)
            {
                return NotFound();
            }
            return View(video);
        }

        // Add more action methods as needed
    }
}
