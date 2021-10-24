using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using Practica_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Practica_2.ViewComponents{
    public class UsersFriendsViewComponent : ViewComponent{
        public List<UserModel> userFriendsList = new List<UserModel>();
        private AppDbContext _context;

        public UsersFriendsViewComponent(AppDbContext context){
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            //UserServices userServices = new UserServices();
            //userFriendsList = await userServices.getlistUsers();
            userFriendsList = await _context.Users.ToListAsync();
            return View(userFriendsList);
        }
    }
}