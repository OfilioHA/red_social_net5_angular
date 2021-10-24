using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using Practica_2.Models;
using Microsoft.EntityFrameworkCore;


namespace Practica_2.Controllers
{
    public class UserController : Controller
    {

        private AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> details(int Id){
            
            UserModel user = await _context.Users
                .Include(user => user.PostsList)
                //.Include(user => user.AlbumList.Select(photos => photos.PhotosList))
                .Include(user => user.ToDoList)
                .Where(user => user.Id == Id)
                .FirstOrDefaultAsync();
            /*
            UserServices userServices = new UserServices();
            PostsServices postServices = new PostsServices();
            PhotosServices photosServices = new PhotosServices();
            ToDoServices toDoServices  = new ToDoServices();
            UserModel user = await userServices.getAUser(Id);
            List<PostModel> posts = await postServices.getPostsFromUser(Id);
            int albumId = await photosServices.getUserAlbum(user.Id);
            List<PhotoModel> photosList = await photosServices.getUserPhotos(albumId);
            List<ToDoModel> toDoList = await toDoServices.getUserToDos(user.Id);
            */
            ViewBag.toDos = user.ToDoList;
            ViewBag.user = user;
            //ViewBag.photos = user.AlbumList[0].PhotosList; 
            ViewBag.posts = user.PostsList;
            ViewBag.title = "User";
            return View("Index");
        }

        public async Task<IActionResult> find(string username){
            UserServices userServices = new UserServices();
            List<UserModel> userlistComplete = await userServices.getlistUsers();
            List<UserModel> userlistFilter = new List<UserModel>();
            foreach(var user in userlistComplete){
                if(user.username.ToLower().Contains(username.ToLower())){ 
                    userlistFilter.Add(user);
                }
            }
            
            return PartialView("~/Views/Shared/Partials/BuscadorItem.cshtml", userlistFilter);
        }
    }
}