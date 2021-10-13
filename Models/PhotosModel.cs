using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Practica_2.Models
{
    public class AlbumModel
    {
        public int Id { set; get; }
        public int userId { set; get; }
        [Required]
        public string title { set; get; }
        public List<PhotoModel> PhotosList { set; get; }
    }

    public class PhotoModel
    {
        public int Id { set; get; }
        public string albumId { set; get; }
        [Required]
        public string url { set; get; }
        [Required]
        public string title { set; get; }
        [Required]
        public string thumbnailUrl { set; get; }
    }
}