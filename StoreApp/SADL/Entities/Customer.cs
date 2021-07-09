using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace SADL.Entities
{
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
    }
}