
using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class InventoryPage
    {
        [Key]

        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        public double Price { get; set; }


    }
}

