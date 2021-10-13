using System;
using System.ComponentModel.DataAnnotations;


namespace Practica_2.Models
{
    public class PostModel
    {
        public int Id { set; get; }
    
        [Required]
        [Display(Name = "userId")]
        public int userId { set; get; }
    
        [Required]
        [Display(Name = "title")]
        public string title { set; get; }   

        [Display(Name = "body")]
        public string body { set; get; }
    }
}