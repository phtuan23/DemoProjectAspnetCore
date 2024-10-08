﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoProject.WebApi.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }

    }
}
