using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Swagger.API.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        /// <summary>
        /// Name of the product
        /// </summary>
        [Required]
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Date { get; set; }
        public string? Category { get; set; }
    }
}
