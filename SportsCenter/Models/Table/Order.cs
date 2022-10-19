﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsCenter.Models.Table
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }
        [Required]
        public int Location_Id { get; set; }
        [Required]
        public int Member_Id { get; set; }
        [Required]
        public int Order_Price { get; set; }
        [Required]
        public string? Order_Duration { get; set; }
        [Required]
        public string? Order_Date { get; set; }
        [Required]
        public string? Location_Branch { get; set; }
        [Required]
        [DefaultValue(0)]
        public int Order_ValidFlag { get; set; }

    }
}
