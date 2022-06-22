﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITE.Areas.Admin.Models
{
    public class ProductModelView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public string CategoryName { get; set; }
        public string UrlImage { get; set; }
        public string SubDecription { get; set; }
        public decimal? Price { get; set; }
        public decimal? ReducedPrice { get; set; }
        public int? Total { get; set; }
        public int? CategoryId { get; set; }
        public bool Status { get; set; }
        public int? TotalPoint { get; set; }
        public bool IsDeleted { get; set; }
        public string DateExpired { get; set; }
        public int? PricePercent { get; set; }
        public decimal? IntoPrice { get; set; }
    }
}
