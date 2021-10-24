using System;
using System.ComponentModel.DataAnnotations;

namespace Practica_2.Models
{

    public class ToDoModel
    {
        public int Id { set; get; }
        public int userId { set; get; }
        public string title { set; get; }
        public bool completed { set; get; }

    }
}