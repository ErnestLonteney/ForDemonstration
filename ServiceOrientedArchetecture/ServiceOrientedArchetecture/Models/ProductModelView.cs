﻿using DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace ServiceOrientedArchetecture.Models
{
    public class ProductModelView
    {
        [Required]
        [Display(Name = "Name of Product")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; } = 0.00m;

        public virtual Brand Brand { get; set; } = new();
    }
}
