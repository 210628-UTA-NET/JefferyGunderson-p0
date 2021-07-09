
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace SADL.Entities
{
    public partial class StoreFront
    {
        [Key]
        public string Id { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
    }
}