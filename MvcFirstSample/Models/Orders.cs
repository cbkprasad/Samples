using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcFirstSample.Models
{
    public class Orders
    {
        
        public virtual List<Products> Product { get; set; }

        [Key]
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        [Display(Name="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }
    }
}