﻿using System.ComponentModel.DataAnnotations;

namespace Fooddeliveryapp1.Models
{
    public class Item
    {

        [Key]
        public int ItemID { get; set; }
        public string? ItemName { get; set; }
        public decimal Unitprice { get; set; }
        public decimal Discount { get; set; }
        public string? Description { get; set; }
        public string?  ImageUrl { get; set; }

        public int IsActive { get; set; }

    }
}
