﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OdataPractice.Models
{
    [Index(nameof(ItemID), Name = "IX_SalesSubs_ItemID")]
    [Index(nameof(SalesMainID), Name = "IX_SalesSubs_SalesMainID")]
    public partial class SalesSubs
    {
        [Key]
        public int SalesSubID { get; set; }
        public int SalesMainID { get; set; }
        public int ItemID { get; set; }
        public int ItemQuantity { get; set; }
        public double TotalPrice { get; set; }

        [ForeignKey(nameof(ItemID))]
        [InverseProperty(nameof(items.SalesSubs))]
        public virtual items Item { get; set; }
        [ForeignKey(nameof(SalesMainID))]
        [InverseProperty(nameof(SalesMains.SalesSubs))]
        public virtual SalesMains SalesMain { get; set; }
    }
}