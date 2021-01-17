using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitis.Models
{
    public class Product
    {
        [Column("ProductId")]
        public Guid Id { get; set; }

        [Required]
        public string ProdName { get; set; }

        [Required]
        public double Price { get; set; }

        
        public string Description { get; set; }


        public string VendorName { get; set; }


        public string ImgPath { get; set; }

        [Required]
        public Category category { get; set; }

    }
}
