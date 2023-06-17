using System;
using System.ComponentModel.DataAnnotations;

namespace Store.Application.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Category { get; set; }

        [Required]
        [MaxLength(10)]
        public decimal Price { get; set; }
    }
}

