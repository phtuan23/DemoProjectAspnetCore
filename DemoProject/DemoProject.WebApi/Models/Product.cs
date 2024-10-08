﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoProject.WebApi.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public required string Id { get; set; }
        public required string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public required string Description { get; set; }
    }
}
