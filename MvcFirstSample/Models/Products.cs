using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcFirstSample.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

     }
}