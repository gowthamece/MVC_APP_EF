using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstMVCApp.Models
{
    public class Customer
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int CustomerID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        
    }
}