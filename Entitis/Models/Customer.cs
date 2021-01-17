using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitis.Models
{
    public class Customer
    {
        [Column("CustomerId")]
        public Guid Id { get; set; }

        [Required]
        public string Fullname { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }


        [Required]
        public string Password { get; set; }


        public string Email { get; set; }

    }
}
