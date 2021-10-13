using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica_2.Models;
using Services;
using Practica_2.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Practica_2.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //Get data from DataBase
            List<UserModel> userList = await _context.Users
                .Include(user => user.PostsList)
                .ToListAsync();

            //Send to the View
            return View("Index", userList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task Save(IFormCollection formCollection)
        {
            PostModel post = new PostModel();
            post.title = formCollection["title"];
            post.body = formCollection["body"];
            post.userId = 1;
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            Response.Redirect("/");
        }

        public async Task Edit(int Id)
        {
            PostModel post = await _context.Posts.FindAsync(Id);
            post.title = "Fui Editado";
            post.body = "Fui Editado tambien";
            await _context.SaveChangesAsync();
            Response.Redirect("/");
        }

        public async Task Delete(int Id)
        {
            PostModel post = await _context.Posts.FindAsync(Id);
            _context.Remove(post);
            await _context.SaveChangesAsync();
            Response.Redirect("/");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
