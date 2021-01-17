using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitis.Models
{
    public class OrderItem
    {
        [Column("OrderItemId")]
        public Guid Id { get; set; }

     
        public Product product { get; set; }


        public double qty { get; set; } = 0;
    }

}
