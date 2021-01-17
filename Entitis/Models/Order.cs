using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitis.Models
{
    public class Order
    {
        [Column("OrderId")]
        public Guid Id { get; set; }

       
        public double totalPrice { get; set; }

        public Customer customer { get; set; }


        public OrderStatus orderStatus { get; set; }


        public ICollection<OrderItem> orderItems { get; set; }


    }
}
