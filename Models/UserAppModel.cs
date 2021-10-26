using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practica_2.Models
{
    public class UserModel
    {
        public int Id { set; get; }
        [Required]
        [Display(Name = "name")]
        public string name { set; get; }
        [Required]
        [Display(Name = "username")]
        public string username { set; get; }

        [Required]
        [Display(Name = "password")]
        public string password { set; get; }


        public List<PostModel> PostsList { set; get; }
        public List<ToDoModel> ToDoList { set; get; }
        public List<AlbumModel> AlbumList { set; get; }

        [Display(Name = "address")]
        public Address address { set; get; }
    }

    public class Address
    {
        public string Id { set; get; }

        [Display(Name = "street")]
        public string street { set; get; }

        [Display(Name = "suite")]
        public string suite { set; get; }

        [Required]
        [Display(Name = "city")]
        public string city { set; get; }

        [Display(Name = "zipcode")]
        public string zipcode { set; get; }

        [Display(Name = "geo")]
        public Geo geo { set; get; }
    }

    public class Geo
    {
        public int Id { set; get; }
          
        [Display(Name = "lat")]
        public string lat { set; get; }
          
        [Display(Name = "lng")]
        public string lng { set; get; }
    }
}