﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SalesApi.Models
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(30)] public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(9,2)")] public decimal Price { get; set; }
    }
}
