using System;
using System.Collections.Generic;
using Practica_2.Models;

namespace Practica_2.ViewModels
{
    public class UserPostModel
    {
        public UserModel user{ set; get; }
        public List<PostModel> postList{ set; get; }
    }

}