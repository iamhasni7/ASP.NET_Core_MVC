﻿using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_MVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
